namespace LoginPage
{
    partial class SignInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 884);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 117);
            this.label2.TabIndex = 0;
            this.label2.Text = "We make\r\npicking movies\r\neasier.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginPage.Properties.Resources.Dawlab_justified_left_with_background;
            this.pictureBox1.Location = new System.Drawing.Point(96, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.lblConfirmPassword);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(562, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 884);
            this.panel2.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(35, 480);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(516, 61);
            this.txtConfirmPassword.TabIndex = 18;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(28, 415);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(305, 39);
            this.lblConfirmPassword.TabIndex = 17;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(319, 780);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(232, 69);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Sign Up!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(35, 649);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(516, 61);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblEmail.Location = new System.Drawing.Point(28, 584);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 39);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(35, 317);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(516, 61);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPassword.Location = new System.Drawing.Point(28, 252);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(172, 39);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(35, 171);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(516, 61);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblUsername.Location = new System.Drawing.Point(28, 109);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(183, 39);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign Up";
            // 
            // SignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 884);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignInPage";
            this.Text = "SignInPage";
            this.Load += new System.EventHandler(this.SignInPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
    }
}