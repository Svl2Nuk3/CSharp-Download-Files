namespace DownloadFile
{
    partial class frmMain
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.rbtSync = new System.Windows.Forms.RadioButton();
            this.rbtAsync = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(197, 39);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(12, 39);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(179, 23);
            this.pbDownload.TabIndex = 1;
            // 
            // txtUri
            // 
            this.txtUri.Location = new System.Drawing.Point(13, 13);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(259, 20);
            this.txtUri.TabIndex = 2;
            // 
            // rbtSync
            // 
            this.rbtSync.AutoSize = true;
            this.rbtSync.Checked = true;
            this.rbtSync.Location = new System.Drawing.Point(12, 73);
            this.rbtSync.Name = "rbtSync";
            this.rbtSync.Size = new System.Drawing.Size(81, 17);
            this.rbtSync.TabIndex = 3;
            this.rbtSync.TabStop = true;
            this.rbtSync.Text = "Synchronus";
            this.rbtSync.UseVisualStyleBackColor = true;
            // 
            // rbtAsync
            // 
            this.rbtAsync.AutoSize = true;
            this.rbtAsync.Location = new System.Drawing.Point(105, 73);
            this.rbtAsync.Name = "rbtAsync";
            this.rbtAsync.Size = new System.Drawing.Size(86, 17);
            this.rbtAsync.TabIndex = 4;
            this.rbtAsync.TabStop = true;
            this.rbtAsync.Text = "Asynchronus";
            this.rbtAsync.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.rbtAsync);
            this.Controls.Add(this.rbtSync);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.btnDownload);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download File";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.RadioButton rbtSync;
        private System.Windows.Forms.RadioButton rbtAsync;
    }
}

