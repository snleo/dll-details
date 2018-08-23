namespace dotnet_fileinfo
{
    partial class FileInfoForm
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
			this.btnAnalyse = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tbFile = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAnalyse
			// 
			this.btnAnalyse.Location = new System.Drawing.Point(295, 12);
			this.btnAnalyse.Name = "btnAnalyse";
			this.btnAnalyse.Size = new System.Drawing.Size(77, 20);
			this.btnAnalyse.TabIndex = 0;
			this.btnAnalyse.Text = "Analyse";
			this.btnAnalyse.UseVisualStyleBackColor = true;
			this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tbFile
			// 
			this.tbFile.Location = new System.Drawing.Point(12, 12);
			this.tbFile.Name = "tbFile";
			this.tbFile.Size = new System.Drawing.Size(246, 20);
			this.tbFile.TabIndex = 1;
			// 
			// tbResult
			// 
			this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbResult.Location = new System.Drawing.Point(12, 39);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbResult.Size = new System.Drawing.Size(366, 210);
			this.tbResult.TabIndex = 2;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(264, 12);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(25, 20);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "...";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// FileInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.tbFile);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnAnalyse);
			this.Name = "FileInfoForm";
			this.Text = "File Info";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnSelect;
    }
}