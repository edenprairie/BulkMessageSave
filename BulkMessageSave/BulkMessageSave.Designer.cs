namespace BulkMessageSave
{
   partial class BulkMessageSave
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnSave = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.textOutputFolder = new System.Windows.Forms.TextBox();
         this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.listBoxTrace = new System.Windows.Forms.ListBox();
         this.textMgmtDbServer = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.textMgmtDbName = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.folderBrowserDialog = new System.Windows.Forms.OpenFileDialog();
         this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.textStartDate = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.textEndDate = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // btnSave
         // 
         this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSave.Location = new System.Drawing.Point(421, 137);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(142, 23);
         this.btnSave.TabIndex = 12;
         this.btnSave.Text = "&Save Msg / Terminate";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 61);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Output folder:";
         // 
         // textOutputFolder
         // 
         this.textOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textOutputFolder.Location = new System.Drawing.Point(175, 61);
         this.textOutputFolder.Name = "textOutputFolder";
         this.textOutputFolder.Size = new System.Drawing.Size(358, 20);
         this.textOutputFolder.TabIndex = 4;
         // 
         // listBoxTrace
         // 
         this.listBoxTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.listBoxTrace.FormattingEnabled = true;
         this.listBoxTrace.Location = new System.Drawing.Point(15, 168);
         this.listBoxTrace.Name = "listBoxTrace";
         this.listBoxTrace.Size = new System.Drawing.Size(547, 225);
         this.listBoxTrace.TabIndex = 13;
         // 
         // textMgmtDbServer
         // 
         this.textMgmtDbServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textMgmtDbServer.Location = new System.Drawing.Point(175, 87);
         this.textMgmtDbServer.Name = "textMgmtDbServer";
         this.textMgmtDbServer.Size = new System.Drawing.Size(358, 20);
         this.textMgmtDbServer.TabIndex = 7;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 87);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(125, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "BizTalk Mgmt Db Server:";
         // 
         // textMgmtDbName
         // 
         this.textMgmtDbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textMgmtDbName.Location = new System.Drawing.Point(175, 113);
         this.textMgmtDbName.Name = "textMgmtDbName";
         this.textMgmtDbName.Size = new System.Drawing.Size(358, 20);
         this.textMgmtDbName.TabIndex = 9;
         this.textMgmtDbName.Text = "BizTalkMgmtDb";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 113);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(122, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "BizTalk Mgmt Db Name:";
         // 
         // btnBrowseOutputFolder
         // 
         this.btnBrowseOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnBrowseOutputFolder.Location = new System.Drawing.Point(539, 61);
         this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
         this.btnBrowseOutputFolder.Size = new System.Drawing.Size(24, 20);
         this.btnBrowseOutputFolder.TabIndex = 5;
         this.btnBrowseOutputFolder.Text = "...";
         this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
         this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(58, 13);
         this.label1.TabIndex = 14;
         this.label1.Text = "Start Date:";
         // 
         // textStartDate
         // 
         this.textStartDate.Location = new System.Drawing.Point(90, 13);
         this.textStartDate.Name = "textStartDate";
         this.textStartDate.Size = new System.Drawing.Size(175, 20);
         this.textStartDate.TabIndex = 15;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(285, 13);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(55, 13);
         this.label5.TabIndex = 14;
         this.label5.Text = "End Date:";
         // 
         // textEndDate
         // 
         this.textEndDate.Location = new System.Drawing.Point(360, 13);
         this.textEndDate.Name = "textEndDate";
         this.textEndDate.Size = new System.Drawing.Size(183, 20);
         this.textEndDate.TabIndex = 15;
         // 
         // BulkMessageSave
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(574, 411);
         this.Controls.Add(this.textEndDate);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.textStartDate);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnBrowseOutputFolder);
         this.Controls.Add(this.textMgmtDbName);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.textMgmtDbServer);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.listBoxTrace);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.textOutputFolder);
         this.Controls.Add(this.label2);
         this.Name = "BulkMessageSave";
         this.Text = "Bulk Message Save & Terminate Instance Tool";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkMessageSave_FormClosing);
         this.Load += new System.EventHandler(this.BulkMessageSave_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textOutputFolder;
      private System.Windows.Forms.OpenFileDialog openFileDialog;
      private System.Windows.Forms.ListBox listBoxTrace;
      private System.Windows.Forms.TextBox textMgmtDbServer;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox textMgmtDbName;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.OpenFileDialog folderBrowserDialog;
      private System.Windows.Forms.Button btnBrowseOutputFolder;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textStartDate;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox textEndDate;
   }
}

