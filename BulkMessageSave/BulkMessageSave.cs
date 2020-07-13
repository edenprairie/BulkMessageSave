using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Genghis;

using Microsoft.BizTalk.Operations;
using Microsoft.BizTalk.Message.Interop;

namespace BulkMessageSave
{
   public partial class BulkMessageSave : Form
   {
      public BulkMessageSave()
      {
         InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         SaveMessages(textMgmtDbServer.Text, textMgmtDbName.Text, textOutputFolder.Text);
      }

      private void SaveMessages(
         string mgmtDbServer,
         string mgmtDbName,
         string outputFolder)
      {
         
         AppSettingsReader appSet = new System.Configuration.AppSettingsReader();
         InstanceStatus statusToFind = (InstanceStatus)Enum.Parse(typeof(InstanceStatus),(string)appSet.GetValue("State", typeof(string)));

         BizTalkOperations biztalkOps = new BizTalkOperations(mgmtDbServer, mgmtDbName);
         
         int retryCount = 0;
         bool retryLoop = true;

         while(retryLoop)
         {
            try
            {
               SaveHelper(outputFolder, biztalkOps, statusToFind);
               retryLoop = false;
            }
            catch (System.Exception ex)
            {
               // For large numbers of messages, the connection occasionally breaks off...
               if (ex.Message.IndexOf("Failed to connect") > -1)
               {
                  bool connectSuccess = false;
                  while (!connectSuccess)
                  {
                     try
                     {
                        retryCount++;
                        Trace(string.Format("Connection failure {0} - trying again.", retryCount));
                        this.Refresh();
                        System.Threading.Thread.Sleep(500);
                        biztalkOps = new BizTalkOperations(mgmtDbServer, mgmtDbName);
                        connectSuccess = true;
                     }
                     catch
                     {

                     }
                  }
               }

            }

         }


         Trace("Done.");
      }

      private void SaveHelper(string outputFolder, BizTalkOperations biztalkOps, InstanceStatus statusToFind)
      {
         int i = 0;
         foreach (Instance instance in biztalkOps.GetServiceInstances())
         {
            if (instance is OrchestrationInstance)
            {
               OrchestrationInstance orchInstance = instance as OrchestrationInstance;
               if (orchInstance.InstanceStatus == statusToFind)
               {
                  i = i + 1;
                  if (orchInstance.CreationTime >= DateTime.Parse(textStartDate.Text) &&
                     orchInstance.CreationTime <= DateTime.Parse(textEndDate.Text))
                  {
                     Trace(string.Format(
                        "Found orch ({0}) in date range. Creation date:{1}", i, orchInstance.CreationTime));

                     bool msgFound = false;
                     foreach (IBaseMessage msg in orchInstance.Messages)
                     {
                        IBaseMessagePart part = msg.BodyPart;
                        if (part == null)
                        {
                           Trace("Found null message attached to service instance.");
                        }
                        else
                        {
                           using (StreamWriter sw = new StreamWriter(Path.Combine(outputFolder, msg.MessageID.ToString())))
                           {
                              Trace("Saving message attached to service instance with msgid:" + msg.MessageID.ToString());
                              using (StreamReader partReader = new StreamReader(part.Data))
                              {
                                 sw.Write(partReader.ReadToEnd());
                              }
                              sw.Close();
                              msgFound = true;
                           }
                        }
                     }
                     if (!msgFound)
                        Trace(string.Format("No messages found for instance: " + instance.ID.ToString()));

                     CompletionStatus status = biztalkOps.TerminateInstance(instance.ID);
                     Trace(string.Format("Terminating instance: {0} yielded {1}", instance.ID.ToString(), status));

                  }
               }
            }

         }

      }

      private void btnBrowse_Click(object sender, EventArgs e)
      {
         //if (openFileDialog.ShowDialog() == DialogResult.OK)
         //{
         //   textCSVPath.Text = openFileDialog.FileName;
         //}
      }

      private void Trace(string trace)
      {
         int item = this.listBoxTrace.Items.Add(trace);
         listBoxTrace.SelectedIndex = item;
         listBoxTrace.Refresh();

         using (StreamWriter sw = File.AppendText("BulkMessageLog.txt"))
         {
            sw.WriteLine(DateTime.Now.ToString() + " " + trace);
         }
      }

      private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
      {
         folderBrowserDialog.Title = "Please choose a folder";
         folderBrowserDialog.CheckFileExists = false;
         folderBrowserDialog.FileName = "[Choose Folder...]";
         folderBrowserDialog.Filter = "Folders|no.files";

         if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
         {
            textOutputFolder.Text = Path.GetDirectoryName(folderBrowserDialog.FileName);
         }
      }

      private void radioMsgBox_CheckedChanged(object sender, EventArgs e)
      {
         //if (radioMsgBox.Checked)
         //   labelPathToCSV.Text = "Path to CSV file (Msg Id,Inst Id):";
         //else
         //   labelPathToCSV.Text = "Path to CSV file (Msg Id):";
      }

      private void BulkMessageSave_FormClosing(object sender, FormClosingEventArgs e)
      {
         Preferences writer = Preferences.GetUserNode("BulkMessageSave");
         //writer.SetProperty("CSVPath", this.textCSVPath.Text);
         writer.SetProperty("StartDate", this.textStartDate.Text);
         writer.SetProperty("EndDate", this.textEndDate.Text);

         writer.SetProperty("OutputFolder", this.textOutputFolder.Text);
         writer.SetProperty("MgmtDb", this.textMgmtDbName.Text);
         writer.SetProperty("DbName", this.textMgmtDbServer.Text);
      }

      private void BulkMessageSave_Load(object sender, EventArgs e)
      {
         Preferences reader = Preferences.GetUserNode("BulkMessageSave");
         //this.textCSVPath.Text = reader.GetString("CSVPath", string.Empty);
         this.textOutputFolder.Text = reader.GetString("OutputFolder", string.Empty);
         this.textMgmtDbName.Text = reader.GetString("MgmtDb", "BizTalkMgmtDb");
         this.textMgmtDbServer.Text = reader.GetString("DbName", string.Empty);

         this.textStartDate.Text = reader.GetString("StartDate", string.Empty);
         this.textEndDate.Text = reader.GetString("EndDate", string.Empty);
      }
   }
}