namespace FriendServer
{
    partial class FriendServer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnecterWorker = new System.ComponentModel.BackgroundWorker();
            this.ChatAbfang = new System.Windows.Forms.TextBox();
            this.Überschrift = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnecterWorker
            // 
            this.ConnecterWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConnecterWorker_DoWork);
            // 
            // ChatAbfang
            // 
            this.ChatAbfang.Location = new System.Drawing.Point(12, 66);
            this.ChatAbfang.Multiline = true;
            this.ChatAbfang.Name = "ChatAbfang";
            this.ChatAbfang.Size = new System.Drawing.Size(390, 242);
            this.ChatAbfang.TabIndex = 0;
            // 
            // Überschrift
            // 
            this.Überschrift.AutoSize = true;
            this.Überschrift.Location = new System.Drawing.Point(54, 9);
            this.Überschrift.Name = "Überschrift";
            this.Überschrift.Size = new System.Drawing.Size(305, 13);
            this.Überschrift.TabIndex = 1;
            this.Überschrift.Text = "!!!Dieses Fenster ist nur zur Überwachung des Chats gedacht!!!";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(89, 35);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(35, 13);
            this.Adresse.TabIndex = 2;
            this.Adresse.Text = "label1";
            // 
            // FriendServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 320);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Überschrift);
            this.Controls.Add(this.ChatAbfang);
            this.Name = "FriendServer";
            this.Text = "Jener Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker ConnecterWorker;
        private System.Windows.Forms.TextBox ChatAbfang;
        private System.Windows.Forms.Label Überschrift;
        private System.Windows.Forms.Label Adresse;
    }
}

