namespace AdbockHost
{
    partial class HostFile
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
            this.hostFileContent = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostFileContent
            // 
            this.hostFileContent.Location = new System.Drawing.Point(12, 4);
            this.hostFileContent.Multiline = true;
            this.hostFileContent.Name = "hostFileContent";
            this.hostFileContent.Size = new System.Drawing.Size(618, 555);
            this.hostFileContent.TabIndex = 0;
            this.hostFileContent.TextChanged += new System.EventHandler(this.hostFileContent_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(143, 565);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // HostFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 600);
            this.Controls.Add(this.save);
            this.Controls.Add(this.hostFileContent);
            this.Name = "HostFile";
            this.Text = "HostFile";
            this.Load += new System.EventHandler(this.HostFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostFileContent;
        private System.Windows.Forms.Button save;
    }
}