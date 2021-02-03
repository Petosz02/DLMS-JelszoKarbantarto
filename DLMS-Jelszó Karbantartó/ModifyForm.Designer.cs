
namespace DLMS_Jelszó_Karbantartó
{
    partial class ModifyForm
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
            this.EntriListBox = new System.Windows.Forms.ListBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntriListBox
            // 
            this.EntriListBox.DisplayMember = "asd";
            this.EntriListBox.FormattingEnabled = true;
            this.EntriListBox.Location = new System.Drawing.Point(12, 12);
            this.EntriListBox.Name = "EntriListBox";
            this.EntriListBox.Size = new System.Drawing.Size(200, 56);
            this.EntriListBox.TabIndex = 17;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.LogInBtn.Location = new System.Drawing.Point(12, 151);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(200, 47);
            this.LogInBtn.TabIndex = 16;
            this.LogInBtn.Text = "Módosítás";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Location = new System.Drawing.Point(112, 99);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.PasswordChar = '*';
            this.OldPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.OldPasswordTextBox.TabIndex = 15;
            this.OldPasswordTextBox.TextChanged += new System.EventHandler(this.OldPasswordTextBox_TextChanged);
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OldPasswordLabel.Location = new System.Drawing.Point(12, 100);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(70, 16);
            this.OldPasswordLabel.TabIndex = 14;
            this.OldPasswordLabel.Text = "Régi jelszó: ";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(112, 74);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTextBox.TabIndex = 13;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserNameLabel.Location = new System.Drawing.Point(12, 75);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(94, 16);
            this.UserNameLabel.TabIndex = 12;
            this.UserNameLabel.Text = "Felhasználó név:";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(112, 125);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewPasswordTextBox.TabIndex = 19;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(12, 126);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(59, 16);
            this.NewPasswordLabel.TabIndex = 18;
            this.NewPasswordLabel.Text = "Új jelszó: ";
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 205);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.EntriListBox);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "ModifyForm";
            this.ShowIcon = false;
            this.Text = "Módosítás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EntriListBox;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
    }
}