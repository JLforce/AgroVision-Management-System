using MaterialSkin.Controls;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    partial class LoginForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 

        protected new void Dispose(bool disposing)  // Use 'new' instead of 'override'
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            ptbLogo = new PictureBox();
            pictureBox2 = new PictureBox();
            lblUsername = new Label();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            cbxShowPassword = new CheckBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            btnSignUp = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ptbLogo
            // 
            ptbLogo.BackColor = Color.Transparent;
            ptbLogo.BackgroundImage = (Image)resources.GetObject("ptbLogo.BackgroundImage");
            ptbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            ptbLogo.Location = new Point(69, 67);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(425, 220);
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(210, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 100);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.WhiteSmoke;
            lblUsername.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Red;
            lblUsername.Location = new Point(69, 302);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(152, 29);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Username:";
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = SystemColors.ControlLight;
            tbxUsername.ForeColor = SystemColors.ActiveCaptionText;
            tbxUsername.Location = new Point(242, 302);
            tbxUsername.Multiline = true;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(252, 29);
            tbxUsername.TabIndex = 17;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = SystemColors.ControlLight;
            tbxPassword.Location = new Point(242, 346);
            tbxPassword.Multiline = true;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(252, 31);
            tbxPassword.TabIndex = 18;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.BackColor = SystemColors.ActiveCaption;
            cbxShowPassword.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxShowPassword.Location = new Point(242, 387);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(134, 21);
            cbxShowPassword.TabIndex = 19;
            cbxShowPassword.Text = "Show Password";
            cbxShowPassword.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.WhiteSmoke;
            lblPassword.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.HotTrack;
            lblPassword.Location = new Point(69, 348);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(144, 29);
            lblPassword.TabIndex = 20;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogin.BackColor = SystemColors.MenuHighlight;
            btnLogin.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(289, 436);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 36);
            btnLogin.TabIndex = 21;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.BackColor = Color.LightCoral;
            btnExit.Font = new Font("ROG Fonts", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(210, 491);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 36);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Yellow;
            btnSignUp.Font = new Font("ROG Fonts", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(135, 436);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(148, 36);
            btnSignUp.TabIndex = 23;
            btnSignUp.Text = "SIGNUP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignup_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(563, 568);
            Controls.Add(btnSignUp);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(cbxShowPassword);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox2);
            Controls.Add(ptbLogo);
            ForeColor = Color.Black;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbLogo;
        private PictureBox pictureBox2;
        private Label lblUsername;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private CheckBox cbxShowPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnExit;
        private Button btnSignUp;
    }
}