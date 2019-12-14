namespace AdbockHost
{
    partial class Blocker
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.setHosts = new System.Windows.Forms.Button();
            this.hostsList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressWrite = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // setHosts
            // 
            this.setHosts.Location = new System.Drawing.Point(444, 12);
            this.setHosts.Name = "setHosts";
            this.setHosts.Size = new System.Drawing.Size(75, 23);
            this.setHosts.TabIndex = 0;
            this.setHosts.Text = "Set";
            this.setHosts.UseVisualStyleBackColor = true;
            this.setHosts.Click += new System.EventHandler(this.setHosts_Click);
            // 
            // hostsList
            // 
            this.hostsList.FormattingEnabled = true;
            this.hostsList.Location = new System.Drawing.Point(12, 12);
            this.hostsList.Name = "hostsList";
            this.hostsList.Size = new System.Drawing.Size(412, 108);
            this.hostsList.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Host file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressWrite
            // 
            this.progressWrite.Location = new System.Drawing.Point(12, 133);
            this.progressWrite.Name = "progressWrite";
            this.progressWrite.Size = new System.Drawing.Size(412, 23);
            this.progressWrite.TabIndex = 4;
            // 
            // Blocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 168);
            this.Controls.Add(this.progressWrite);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hostsList);
            this.Controls.Add(this.setHosts);
            this.Name = "Blocker";
            this.Text = "Block ads";
            this.Load += new System.EventHandler(this.Blocker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setHosts;
        private System.Windows.Forms.ListBox hostsList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressWrite;
    }
}

