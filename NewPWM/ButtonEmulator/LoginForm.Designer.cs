namespace ButtonEmulator
{
    public partial class LoginForm
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
            AuthorizationText = new System.Windows.Forms.Label();
            LoginField = new System.Windows.Forms.TextBox();
            PassField = new System.Windows.Forms.TextBox();
            SignInButton = new System.Windows.Forms.Button();
            message = new System.Windows.Forms.Label();
            PassPicture = new System.Windows.Forms.PictureBox();
            UserPicture = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)PassPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AuthorizationText
            // 
            AuthorizationText.Anchor = System.Windows.Forms.AnchorStyles.None;
            AuthorizationText.BackColor = System.Drawing.SystemColors.MenuBar;
            AuthorizationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            AuthorizationText.ForeColor = System.Drawing.SystemColors.ControlText;
            AuthorizationText.Location = new System.Drawing.Point(0, 48);
            AuthorizationText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AuthorizationText.Name = "AuthorizationText";
            AuthorizationText.Size = new System.Drawing.Size(336, 30);
            AuthorizationText.TabIndex = 0;
            AuthorizationText.Text = "Авторизация";
            AuthorizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginField
            // 
            LoginField.Location = new System.Drawing.Point(90, 113);
            LoginField.Margin = new System.Windows.Forms.Padding(4);
            LoginField.Name = "LoginField";
            LoginField.Size = new System.Drawing.Size(155, 31);
            LoginField.TabIndex = 0;
            // 
            // PassField
            // 
            PassField.Location = new System.Drawing.Point(90, 158);
            PassField.Margin = new System.Windows.Forms.Padding(4);
            PassField.Name = "PassField";
            PassField.PasswordChar = '*';
            PassField.Size = new System.Drawing.Size(155, 31);
            PassField.TabIndex = 1;
            // 
            // SignInButton
            // 
            SignInButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            SignInButton.AutoSize = true;
            SignInButton.BackColor = System.Drawing.SystemColors.Control;
            SignInButton.ForeColor = System.Drawing.SystemColors.ControlText;
            SignInButton.Location = new System.Drawing.Point(90, 202);
            SignInButton.Margin = new System.Windows.Forms.Padding(4);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new System.Drawing.Size(156, 35);
            SignInButton.TabIndex = 2;
            SignInButton.Text = "Войти";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            SignInButton.MouseEnter += SignInButton_MouseEnter;
            SignInButton.MouseLeave += SignInButton_MouseLeave;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new System.Drawing.Point(86, 240);
            message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            message.Name = "message";
            message.Size = new System.Drawing.Size(0, 25);
            message.TabIndex = 4;
            // 
            // PassPicture
            // 
            PassPicture.Image = Properties.Resources._lock;
            PassPicture.Location = new System.Drawing.Point(64, 158);
            PassPicture.Margin = new System.Windows.Forms.Padding(4);
            PassPicture.Name = "PassPicture";
            PassPicture.Size = new System.Drawing.Size(24, 24);
            PassPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PassPicture.TabIndex = 5;
            PassPicture.TabStop = false;
            // 
            // UserPicture
            // 
            UserPicture.Image = Properties.Resources.FatUser;
            UserPicture.Location = new System.Drawing.Point(62, 113);
            UserPicture.Margin = new System.Windows.Forms.Padding(4);
            UserPicture.Name = "UserPicture";
            UserPicture.Size = new System.Drawing.Size(24, 24);
            UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            UserPicture.TabIndex = 5;
            UserPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = Properties.Resources.NotOk;
            pictureBox1.Location = new System.Drawing.Point(307, 1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(30, 30);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(338, 304);
            ControlBox = false;
            Controls.Add(PassPicture);
            Controls.Add(UserPicture);
            Controls.Add(message);
            Controls.Add(SignInButton);
            Controls.Add(PassField);
            Controls.Add(LoginField);
            Controls.Add(pictureBox1);
            Controls.Add(AuthorizationText);
            ForeColor = System.Drawing.SystemColors.ControlDark;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "LoginForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)PassPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label AuthorizationText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.PictureBox PassPicture;
    }
}