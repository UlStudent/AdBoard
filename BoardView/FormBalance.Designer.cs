
namespace BoardView
{
    partial class FormBalance
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMoneySpent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCardNumb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCardFIO = new System.Windows.Forms.TextBox();
            this.textBoxCardDate = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(146, 12);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(167, 21);
            this.comboBoxUsers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Денег:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Денег потрачено:";
            // 
            // textBoxMoneySpent
            // 
            this.textBoxMoneySpent.Location = new System.Drawing.Point(146, 76);
            this.textBoxMoneySpent.Name = "textBoxMoneySpent";
            this.textBoxMoneySpent.Size = new System.Drawing.Size(167, 20);
            this.textBoxMoneySpent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер карты:";
            // 
            // textBoxCardNumb
            // 
            this.textBoxCardNumb.Location = new System.Drawing.Point(146, 113);
            this.textBoxCardNumb.Name = "textBoxCardNumb";
            this.textBoxCardNumb.Size = new System.Drawing.Size(167, 20);
            this.textBoxCardNumb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ФИО держаетля карты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Окончание действия";
            // 
            // textBoxCardFIO
            // 
            this.textBoxCardFIO.Location = new System.Drawing.Point(146, 143);
            this.textBoxCardFIO.Name = "textBoxCardFIO";
            this.textBoxCardFIO.Size = new System.Drawing.Size(167, 20);
            this.textBoxCardFIO.TabIndex = 12;
            // 
            // textBoxCardDate
            // 
            this.textBoxCardDate.Location = new System.Drawing.Point(146, 174);
            this.textBoxCardDate.Name = "textBoxCardDate";
            this.textBoxCardDate.Size = new System.Drawing.Size(167, 20);
            this.textBoxCardDate.TabIndex = 13;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(146, 48);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(167, 20);
            this.textBoxMoney.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пользователь";
            // 
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 256);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxCardDate);
            this.Controls.Add(this.textBoxCardFIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCardNumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMoneySpent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUsers);
            this.Name = "FormBalance";
            this.Text = "Добавить баланс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMoneySpent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCardNumb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCardFIO;
        private System.Windows.Forms.TextBox textBoxCardDate;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label6;
    }
}