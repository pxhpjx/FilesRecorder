namespace FilesRecorder
{
    partial class FilesRecorder
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesRecorder));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectInput = new System.Windows.Forms.Button();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.chkRecordSub = new System.Windows.Forms.CheckBox();
            this.chkFullPath = new System.Windows.Forms.CheckBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.chkRecordDir = new System.Windows.Forms.CheckBox();
            this.txtFileNameLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileTypeLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标路径:";
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(79, 13);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.Size = new System.Drawing.Size(254, 21);
            this.txtInputPath.TabIndex = 1;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(79, 41);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(254, 21);
            this.txtOutputPath.TabIndex = 2;
            this.txtOutputPath.Text = "C:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出路径:";
            // 
            // btnSelectInput
            // 
            this.btnSelectInput.Location = new System.Drawing.Point(340, 10);
            this.btnSelectInput.Name = "btnSelectInput";
            this.btnSelectInput.Size = new System.Drawing.Size(65, 23);
            this.btnSelectInput.TabIndex = 4;
            this.btnSelectInput.Text = "选择路径";
            this.btnSelectInput.UseVisualStyleBackColor = true;
            this.btnSelectInput.Click += new System.EventHandler(this.btnSelectInput_Click);
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Location = new System.Drawing.Point(340, 40);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(65, 23);
            this.btnSelectOutput.TabIndex = 5;
            this.btnSelectOutput.Text = "选择路径";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // chkRecordSub
            // 
            this.chkRecordSub.AutoSize = true;
            this.chkRecordSub.Location = new System.Drawing.Point(41, 100);
            this.chkRecordSub.Name = "chkRecordSub";
            this.chkRecordSub.Size = new System.Drawing.Size(132, 16);
            this.chkRecordSub.TabIndex = 6;
            this.chkRecordSub.Text = "包括子文件夹内文件";
            this.chkRecordSub.UseVisualStyleBackColor = true;
            // 
            // chkFullPath
            // 
            this.chkFullPath.AutoSize = true;
            this.chkFullPath.Location = new System.Drawing.Point(41, 122);
            this.chkFullPath.Name = "chkFullPath";
            this.chkFullPath.Size = new System.Drawing.Size(96, 16);
            this.chkFullPath.TabIndex = 7;
            this.chkFullPath.Text = "记录完整路径";
            this.chkFullPath.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(41, 149);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(98, 23);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "获取文件记录";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // chkRecordDir
            // 
            this.chkRecordDir.AutoSize = true;
            this.chkRecordDir.Enabled = false;
            this.chkRecordDir.Location = new System.Drawing.Point(203, 100);
            this.chkRecordDir.Name = "chkRecordDir";
            this.chkRecordDir.Size = new System.Drawing.Size(84, 16);
            this.chkRecordDir.TabIndex = 10;
            this.chkRecordDir.Text = "记录文件夹";
            this.chkRecordDir.UseVisualStyleBackColor = true;
            // 
            // txtFileNameLimit
            // 
            this.txtFileNameLimit.Location = new System.Drawing.Point(92, 68);
            this.txtFileNameLimit.Name = "txtFileNameLimit";
            this.txtFileNameLimit.Size = new System.Drawing.Size(100, 21);
            this.txtFileNameLimit.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "文件名包含:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "扩展名限定:";
            // 
            // txtFileTypeLimit
            // 
            this.txtFileTypeLimit.Location = new System.Drawing.Point(280, 68);
            this.txtFileTypeLimit.Name = "txtFileTypeLimit";
            this.txtFileTypeLimit.Size = new System.Drawing.Size(125, 21);
            this.txtFileTypeLimit.TabIndex = 14;
            // 
            // FilesRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 185);
            this.Controls.Add(this.txtFileTypeLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileNameLimit);
            this.Controls.Add(this.chkRecordDir);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.chkFullPath);
            this.Controls.Add(this.chkRecordSub);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.btnSelectInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtInputPath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilesRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PP\'s FilesRecorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectInput;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.CheckBox chkRecordSub;
        private System.Windows.Forms.CheckBox chkFullPath;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.CheckBox chkRecordDir;
        private System.Windows.Forms.TextBox txtFileNameLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileTypeLimit;
    }
}

