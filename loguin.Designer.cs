
using System;

namespace GUIDEMO
{
    partial class login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_close_window = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.checkBox_terms = new System.Windows.Forms.CheckBox();
            this.textBox_password_repeat = new System.Windows.Forms.TextBox();
            this.label_password_repeat = new System.Windows.Forms.Label();
            this.button_show_hide = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox_monkey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_monkey)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close_window
            // 
            this.button_close_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close_window.Location = new System.Drawing.Point(338, 273);
            this.button_close_window.Name = "button_close_window";
            this.button_close_window.Size = new System.Drawing.Size(100, 33);
            this.button_close_window.TabIndex = 0;
            this.button_close_window.Text = "Close";
            this.button_close_window.UseVisualStyleBackColor = true;
            this.button_close_window.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(75, 67);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(77, 18);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(75, 122);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(75, 18);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.Label_password_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(186, 61);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(252, 24);
            this.textBox_username.TabIndex = 3;
            this.textBox_username.TextChanged += new System.EventHandler(this.TextBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(186, 116);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(252, 24);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // button_signup
            // 
            this.button_signup.Enabled = false;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.Location = new System.Drawing.Point(186, 273);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(95, 33);
            this.button_signup.TabIndex = 5;
            this.button_signup.Text = "Sign Up";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.Button2_Click);
            // 
            // checkBox_terms
            // 
            this.checkBox_terms.AutoSize = true;
            this.checkBox_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_terms.Location = new System.Drawing.Point(186, 230);
            this.checkBox_terms.Name = "checkBox_terms";
            this.checkBox_terms.Size = new System.Drawing.Size(144, 22);
            this.checkBox_terms.TabIndex = 9;
            this.checkBox_terms.Text = "I accept the terms";
            this.checkBox_terms.UseVisualStyleBackColor = true;
            this.checkBox_terms.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // textBox_password_repeat
            // 
            this.textBox_password_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password_repeat.Location = new System.Drawing.Point(186, 163);
            this.textBox_password_repeat.Name = "textBox_password_repeat";
            this.textBox_password_repeat.Size = new System.Drawing.Size(252, 24);
            this.textBox_password_repeat.TabIndex = 11;
            this.textBox_password_repeat.UseSystemPasswordChar = true;
            this.textBox_password_repeat.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label_password_repeat
            // 
            this.label_password_repeat.AutoSize = true;
            this.label_password_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password_repeat.Location = new System.Drawing.Point(28, 166);
            this.label_password_repeat.Name = "label_password_repeat";
            this.label_password_repeat.Size = new System.Drawing.Size(124, 18);
            this.label_password_repeat.TabIndex = 10;
            this.label_password_repeat.Text = "Repeat password";
            this.label_password_repeat.Click += new System.EventHandler(this.Label_password_repeat_Click);
            // 
            // button_show_hide
            // 
            this.button_show_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show_hide.Location = new System.Drawing.Point(444, 118);
            this.button_show_hide.Name = "button_show_hide";
            this.button_show_hide.Size = new System.Drawing.Size(25, 22);
            this.button_show_hide.TabIndex = 12;
            this.button_show_hide.Text = "🙊";
            this.button_show_hide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_show_hide.UseVisualStyleBackColor = true;
            this.button_show_hide.Click += new System.EventHandler(this.Button_show_hide_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "👁️";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox_monkey
            // 
            this.pictureBox_monkey.ErrorImage = null;
            this.pictureBox_monkey.Image = global::GUIDEMO.Properties.Resources.monkey_2_;
            this.pictureBox_monkey.InitialImage = global::GUIDEMO.Properties.Resources.monkey_2_;
            this.pictureBox_monkey.Location = new System.Drawing.Point(50, 285);
            this.pictureBox_monkey.Name = "pictureBox_monkey";
            this.pictureBox_monkey.Size = new System.Drawing.Size(100, 92);
            this.pictureBox_monkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_monkey.TabIndex = 13;
            this.pictureBox_monkey.TabStop = false;
            this.pictureBox_monkey.UseWaitCursor = true;
            this.pictureBox_monkey.WaitOnLoad = true;
            this.pictureBox_monkey.Click += new System.EventHandler(this.pictureBox_monkey_Click_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(511, 442);
            this.Controls.Add(this.pictureBox_monkey);
            this.Controls.Add(this.button_show_hide);
            this.Controls.Add(this.textBox_password_repeat);
            this.Controls.Add(this.label_password_repeat);
            this.Controls.Add(this.checkBox_terms);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_close_window);
            this.Name = "login";
            this.Text = "GUI DEMO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_monkey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label_password_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button_close_window;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.CheckBox checkBox_terms;
        private System.Windows.Forms.TextBox textBox_password_repeat;
        private System.Windows.Forms.Label label_password_repeat;
        private System.Windows.Forms.Button button_show_hide;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox_monkey;
    }
}

