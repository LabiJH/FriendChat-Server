namespace FriendChat
{
    partial class FriendChat
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
            this.ChatFenster = new System.Windows.Forms.TextBox();
            this.SendeButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.Label();
            this.Chat = new System.Windows.Forms.TextBox();
            this.ServerAdresse = new System.Windows.Forms.TextBox();
            this.ServerAdresseText = new System.Windows.Forms.Label();
            this.EmpfangenSenden = new System.ComponentModel.BackgroundWorker();
            this.ChatlogText = new System.Windows.Forms.Label();
            this.ChatFensterText = new System.Windows.Forms.Label();
            this.VerbindungsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatFenster
            // 
            this.ChatFenster.Location = new System.Drawing.Point(12, 350);
            this.ChatFenster.Multiline = true;
            this.ChatFenster.Name = "ChatFenster";
            this.ChatFenster.Size = new System.Drawing.Size(667, 48);
            this.ChatFenster.TabIndex = 0;
            // 
            // SendeButton
            // 
            this.SendeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SendeButton.Location = new System.Drawing.Point(747, 309);
            this.SendeButton.Name = "SendeButton";
            this.SendeButton.Size = new System.Drawing.Size(86, 89);
            this.SendeButton.TabIndex = 1;
            this.SendeButton.Text = "Senden";
            this.SendeButton.UseVisualStyleBackColor = false;
            this.SendeButton.Click += new System.EventHandler(this.SendeButton_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(747, 404);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 2;
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Location = new System.Drawing.Point(683, 411);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(58, 13);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.Text = "Username:";
            // 
            // Chat
            // 
            this.Chat.Location = new System.Drawing.Point(13, 26);
            this.Chat.Multiline = true;
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(666, 304);
            this.Chat.TabIndex = 4;
            // 
            // ServerAdresse
            // 
            this.ServerAdresse.Location = new System.Drawing.Point(763, 26);
            this.ServerAdresse.Name = "ServerAdresse";
            this.ServerAdresse.Size = new System.Drawing.Size(100, 20);
            this.ServerAdresse.TabIndex = 5;
            // 
            // ServerAdresseText
            // 
            this.ServerAdresseText.AutoSize = true;
            this.ServerAdresseText.Location = new System.Drawing.Point(702, 32);
            this.ServerAdresseText.Name = "ServerAdresseText";
            this.ServerAdresseText.Size = new System.Drawing.Size(54, 13);
            this.ServerAdresseText.TabIndex = 6;
            this.ServerAdresseText.Text = "Server IP:";
            // 
            // EmpfangenSenden
            // 
            this.EmpfangenSenden.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EmpfangenSenden_DoWork);
            // 
            // ChatlogText
            // 
            this.ChatlogText.AutoSize = true;
            this.ChatlogText.Location = new System.Drawing.Point(9, 10);
            this.ChatlogText.Name = "ChatlogText";
            this.ChatlogText.Size = new System.Drawing.Size(43, 13);
            this.ChatlogText.TabIndex = 8;
            this.ChatlogText.Text = "Chatlog";
            // 
            // ChatFensterText
            // 
            this.ChatFensterText.AutoSize = true;
            this.ChatFensterText.Location = new System.Drawing.Point(9, 334);
            this.ChatFensterText.Name = "ChatFensterText";
            this.ChatFensterText.Size = new System.Drawing.Size(84, 13);
            this.ChatFensterText.TabIndex = 9;
            this.ChatFensterText.Text = "Eingabe Fenster";
            // 
            // VerbindungsButton
            // 
            this.VerbindungsButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerbindungsButton.Location = new System.Drawing.Point(763, 65);
            this.VerbindungsButton.Name = "VerbindungsButton";
            this.VerbindungsButton.Size = new System.Drawing.Size(100, 23);
            this.VerbindungsButton.TabIndex = 10;
            this.VerbindungsButton.Text = "Verbinden";
            this.VerbindungsButton.UseVisualStyleBackColor = false;
            this.VerbindungsButton.Click += new System.EventHandler(this.VerbindungsButton_Click);
            // 
            // FriendChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(906, 433);
            this.Controls.Add(this.VerbindungsButton);
            this.Controls.Add(this.ChatFensterText);
            this.Controls.Add(this.ChatlogText);
            this.Controls.Add(this.ServerAdresseText);
            this.Controls.Add(this.ServerAdresse);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.SendeButton);
            this.Controls.Add(this.ChatFenster);
            this.Name = "FriendChat";
            this.Text = "FriendChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatFenster;
        private System.Windows.Forms.Button SendeButton;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.TextBox Chat;
        private System.Windows.Forms.TextBox ServerAdresse;
        private System.Windows.Forms.Label ServerAdresseText;
        private System.ComponentModel.BackgroundWorker EmpfangenSenden;
        private System.Windows.Forms.Label ChatlogText;
        private System.Windows.Forms.Label ChatFensterText;
        private System.Windows.Forms.Button VerbindungsButton;
    }
}

