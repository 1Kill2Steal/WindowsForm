
namespace Test
{
    partial class Form1
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblCnfPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCnfPassword = new System.Windows.Forms.TextBox();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIme.Location = new System.Drawing.Point(98, 18);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(554, 38);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Регистрационна форма за Травъл ЕООД";
            // 
            // lblCnfPassword
            // 
            this.lblCnfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCnfPassword.Location = new System.Drawing.Point(234, 220);
            this.lblCnfPassword.Name = "lblCnfPassword";
            this.lblCnfPassword.Size = new System.Drawing.Size(246, 38);
            this.lblCnfPassword.TabIndex = 1;
            this.lblCnfPassword.Text = "Потвърдете паролата";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(234, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(246, 38);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Парола";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(234, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(246, 38);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Потребителско име";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(238, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(241, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtCnfPassword
            // 
            this.txtCnfPassword.Location = new System.Drawing.Point(238, 249);
            this.txtCnfPassword.Name = "txtCnfPassword";
            this.txtCnfPassword.PasswordChar = '*';
            this.txtCnfPassword.Size = new System.Drawing.Size(241, 20);
            this.txtCnfPassword.TabIndex = 6;
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.AutoSize = true;
            this.chbShowPassword.Location = new System.Drawing.Point(370, 291);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(105, 17);
            this.chbShowPassword.TabIndex = 7;
            this.chbShowPassword.Text = "Покажи парола";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(260, 354);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(189, 28);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chbShowPassword);
            this.Controls.Add(this.txtCnfPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCnfPassword);
            this.Controls.Add(this.lblIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblCnfPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCnfPassword;
        private System.Windows.Forms.CheckBox chbShowPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}

