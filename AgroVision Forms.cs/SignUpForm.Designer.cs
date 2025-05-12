namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            lblUsernameSignup = new Label();
            tbxUsernameSignup = new TextBox();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            lblPasswordSignup = new Label();
            tbxPasswordSignup = new TextBox();
            lblConfirmPassword = new Label();
            tbxConfirmPassword = new TextBox();
            btnSubmit = new Button();
            ptbLogo = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUsernameSignup
            // 
            lblUsernameSignup.AutoSize = true;
            lblUsernameSignup.BackColor = Color.WhiteSmoke;
            lblUsernameSignup.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameSignup.ForeColor = SystemColors.ActiveCaptionText;
            lblUsernameSignup.Location = new Point(43, 267);
            lblUsernameSignup.Name = "lblUsernameSignup";
            lblUsernameSignup.Size = new Size(152, 29);
            lblUsernameSignup.TabIndex = 16;
            lblUsernameSignup.Text = "Username:";
            // 
            // tbxUsernameSignup
            // 
            tbxUsernameSignup.BackColor = SystemColors.ControlLight;
            tbxUsernameSignup.ForeColor = SystemColors.ActiveCaptionText;
            tbxUsernameSignup.Location = new Point(252, 270);
            tbxUsernameSignup.Multiline = true;
            tbxUsernameSignup.Name = "tbxUsernameSignup";
            tbxUsernameSignup.Size = new Size(258, 29);
            tbxUsernameSignup.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.WhiteSmoke;
            lblEmail.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ActiveCaptionText;
            lblEmail.Location = new Point(43, 315);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(98, 29);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = SystemColors.ControlLight;
            tbxEmail.ForeColor = SystemColors.ActiveCaptionText;
            tbxEmail.Location = new Point(252, 318);
            tbxEmail.Multiline = true;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(258, 29);
            tbxEmail.TabIndex = 20;
            // 
            // lblPasswordSignup
            // 
            lblPasswordSignup.AutoSize = true;
            lblPasswordSignup.BackColor = Color.WhiteSmoke;
            lblPasswordSignup.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordSignup.ForeColor = SystemColors.ControlText;
            lblPasswordSignup.Location = new Point(43, 365);
            lblPasswordSignup.Name = "lblPasswordSignup";
            lblPasswordSignup.Size = new Size(144, 29);
            lblPasswordSignup.TabIndex = 21;
            lblPasswordSignup.Text = "Password:";
            // 
            // tbxPasswordSignup
            // 
            tbxPasswordSignup.BackColor = SystemColors.ControlLight;
            tbxPasswordSignup.ForeColor = SystemColors.ActiveCaptionText;
            tbxPasswordSignup.Location = new Point(252, 368);
            tbxPasswordSignup.Multiline = true;
            tbxPasswordSignup.Name = "tbxPasswordSignup";
            tbxPasswordSignup.Size = new Size(258, 29);
            tbxPasswordSignup.TabIndex = 22;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.WhiteSmoke;
            lblConfirmPassword.Font = new Font("Heebo", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = SystemColors.ControlText;
            lblConfirmPassword.Location = new Point(43, 417);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(180, 25);
            lblConfirmPassword.TabIndex = 23;
            lblConfirmPassword.Text = "Confirm Password: ";
            // 
            // tbxConfirmPassword
            // 
            tbxConfirmPassword.BackColor = SystemColors.ControlLight;
            tbxConfirmPassword.ForeColor = SystemColors.ActiveCaptionText;
            tbxConfirmPassword.Location = new Point(252, 417);
            tbxConfirmPassword.Multiline = true;
            tbxConfirmPassword.Name = "tbxConfirmPassword";
            tbxConfirmPassword.Size = new Size(258, 29);
            tbxConfirmPassword.TabIndex = 24;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = SystemColors.MenuHighlight;
            btnSubmit.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(362, 489);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(148, 36);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ptbLogo
            // 
            ptbLogo.BackColor = Color.Transparent;
            ptbLogo.BackgroundImage = (Image)resources.GetObject("ptbLogo.BackgroundImage");
            ptbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            ptbLogo.Location = new Point(70, 22);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(425, 220);
            ptbLogo.TabIndex = 26;
            ptbLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(211, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 100);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(563, 568);
            Controls.Add(pictureBox2);
            Controls.Add(ptbLogo);
            Controls.Add(btnSubmit);
            Controls.Add(tbxConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(tbxPasswordSignup);
            Controls.Add(lblPasswordSignup);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbxUsernameSignup);
            Controls.Add(lblUsernameSignup);
            Name = "SignUpForm";
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsernameSignup;
        private TextBox tbxUsernameSignup;
        private Label lblEmail;
        private TextBox tbxEmail;
        private Label lblPasswordSignup;
        private TextBox tbxPasswordSignup;
        private Label lblConfirmPassword;
        private TextBox tbxConfirmPassword;
        private Button btnSubmit;
        private PictureBox ptbLogo;
        private PictureBox pictureBox2;
    }
}