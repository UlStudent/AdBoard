
namespace BoardView
{
    partial class FormMain
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonAds = new System.Windows.Forms.Button();
            this.buttonMessages = new System.Windows.Forms.Button();
            this.buttonFavorites = new System.Windows.Forms.Button();
            this.buttonBalances = new System.Windows.Forms.Button();
            this.buttonReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(43, 23);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(114, 50);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonAds
            // 
            this.buttonAds.Location = new System.Drawing.Point(191, 23);
            this.buttonAds.Name = "buttonAds";
            this.buttonAds.Size = new System.Drawing.Size(114, 50);
            this.buttonAds.TabIndex = 1;
            this.buttonAds.Text = "Объявления";
            this.buttonAds.UseVisualStyleBackColor = true;
            this.buttonAds.Click += new System.EventHandler(this.buttonAds_Click);
            // 
            // buttonMessages
            // 
            this.buttonMessages.Location = new System.Drawing.Point(340, 23);
            this.buttonMessages.Name = "buttonMessages";
            this.buttonMessages.Size = new System.Drawing.Size(114, 50);
            this.buttonMessages.TabIndex = 2;
            this.buttonMessages.Text = "Сообщения";
            this.buttonMessages.UseVisualStyleBackColor = true;
            this.buttonMessages.Click += new System.EventHandler(this.buttonMessages_Click);
            // 
            // buttonFavorites
            // 
            this.buttonFavorites.Location = new System.Drawing.Point(488, 23);
            this.buttonFavorites.Name = "buttonFavorites";
            this.buttonFavorites.Size = new System.Drawing.Size(114, 50);
            this.buttonFavorites.TabIndex = 3;
            this.buttonFavorites.Text = "Избранное";
            this.buttonFavorites.UseVisualStyleBackColor = true;
            this.buttonFavorites.Click += new System.EventHandler(this.buttonFavorites_Click);
            // 
            // buttonBalances
            // 
            this.buttonBalances.Location = new System.Drawing.Point(630, 23);
            this.buttonBalances.Name = "buttonBalances";
            this.buttonBalances.Size = new System.Drawing.Size(114, 50);
            this.buttonBalances.TabIndex = 4;
            this.buttonBalances.Text = "Балансы";
            this.buttonBalances.UseVisualStyleBackColor = true;
            this.buttonBalances.Click += new System.EventHandler(this.buttonBalances_Click);
            // 
            // buttonReq
            // 
            this.buttonReq.Location = new System.Drawing.Point(340, 96);
            this.buttonReq.Name = "buttonReq";
            this.buttonReq.Size = new System.Drawing.Size(114, 50);
            this.buttonReq.TabIndex = 5;
            this.buttonReq.Text = "Запросы";
            this.buttonReq.UseVisualStyleBackColor = true;
            this.buttonReq.Click += new System.EventHandler(this.buttonReq_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReq);
            this.Controls.Add(this.buttonBalances);
            this.Controls.Add(this.buttonFavorites);
            this.Controls.Add(this.buttonMessages);
            this.Controls.Add(this.buttonAds);
            this.Controls.Add(this.buttonUsers);
            this.Name = "FormMain";
            this.Text = "Доска объявлений";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonAds;
        private System.Windows.Forms.Button buttonMessages;
        private System.Windows.Forms.Button buttonFavorites;
        private System.Windows.Forms.Button buttonBalances;
        private System.Windows.Forms.Button buttonReq;
    }
}