
namespace GUIDEMO
{
    partial class Form1
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
            this.button_close_window = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label_gender = new System.Windows.Forms.Label();
            this.checkBox_terms = new System.Windows.Forms.CheckBox();
            this.label_payment_meth = new System.Windows.Forms.Label();
            this.radioButton_credit = new System.Windows.Forms.RadioButton();
            this.radioButton_debit = new System.Windows.Forms.RadioButton();
            this.radioButton_pix = new System.Windows.Forms.RadioButton();
            this.radioButton_cash = new System.Windows.Forms.RadioButton();
            this.groupBox_gender = new System.Windows.Forms.GroupBox();
            this.groupBox_payment_meth = new System.Windows.Forms.GroupBox();
            this.groupBox_gender.SuspendLayout();
            this.groupBox_payment_meth.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close_window
            // 
            this.button_close_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close_window.Location = new System.Drawing.Point(529, 435);
            this.button_close_window.Name = "button_close_window";
            this.button_close_window.Size = new System.Drawing.Size(100, 33);
            this.button_close_window.TabIndex = 0;
            this.button_close_window.Text = "Close";
            this.button_close_window.UseVisualStyleBackColor = true;
            this.button_close_window.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(266, 158);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(77, 18);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(266, 213);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(75, 18);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(377, 152);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(252, 24);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(377, 207);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(252, 24);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_signup
            // 
            this.button_signup.Enabled = false;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.Location = new System.Drawing.Point(377, 435);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(95, 33);
            this.button_signup.TabIndex = 5;
            this.button_signup.Text = "Sign Up";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(152, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 22);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(284, 278);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(57, 18);
            this.label_gender.TabIndex = 8;
            this.label_gender.Text = "Gender";
            this.label_gender.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox_terms
            // 
            this.checkBox_terms.AutoSize = true;
            this.checkBox_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_terms.Location = new System.Drawing.Point(377, 389);
            this.checkBox_terms.Name = "checkBox_terms";
            this.checkBox_terms.Size = new System.Drawing.Size(144, 22);
            this.checkBox_terms.TabIndex = 9;
            this.checkBox_terms.Text = "I accept the terms";
            this.checkBox_terms.UseVisualStyleBackColor = true;
            this.checkBox_terms.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_payment_meth
            // 
            this.label_payment_meth.AutoSize = true;
            this.label_payment_meth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment_meth.Location = new System.Drawing.Point(223, 339);
            this.label_payment_meth.Name = "label_payment_meth";
            this.label_payment_meth.Size = new System.Drawing.Size(120, 18);
            this.label_payment_meth.TabIndex = 10;
            this.label_payment_meth.Text = "Payment Method";
            this.label_payment_meth.Click += new System.EventHandler(this.label4_Click);
            // 
            // radioButton_credit
            // 
            this.radioButton_credit.AutoSize = true;
            this.radioButton_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_credit.Location = new System.Drawing.Point(6, 19);
            this.radioButton_credit.Name = "radioButton_credit";
            this.radioButton_credit.Size = new System.Drawing.Size(65, 22);
            this.radioButton_credit.TabIndex = 11;
            this.radioButton_credit.TabStop = true;
            this.radioButton_credit.Text = "Credit";
            this.radioButton_credit.UseVisualStyleBackColor = true;
            this.radioButton_credit.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton_debit
            // 
            this.radioButton_debit.AutoSize = true;
            this.radioButton_debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_debit.Location = new System.Drawing.Point(77, 19);
            this.radioButton_debit.Name = "radioButton_debit";
            this.radioButton_debit.Size = new System.Drawing.Size(60, 22);
            this.radioButton_debit.TabIndex = 12;
            this.radioButton_debit.TabStop = true;
            this.radioButton_debit.Text = "Debit";
            this.radioButton_debit.UseVisualStyleBackColor = true;
            this.radioButton_debit.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton_pix
            // 
            this.radioButton_pix.AutoSize = true;
            this.radioButton_pix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_pix.Location = new System.Drawing.Point(143, 19);
            this.radioButton_pix.Name = "radioButton_pix";
            this.radioButton_pix.Size = new System.Drawing.Size(46, 22);
            this.radioButton_pix.TabIndex = 13;
            this.radioButton_pix.TabStop = true;
            this.radioButton_pix.Text = "Pix";
            this.radioButton_pix.UseVisualStyleBackColor = true;
            // 
            // radioButton_cash
            // 
            this.radioButton_cash.AutoSize = true;
            this.radioButton_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_cash.Location = new System.Drawing.Point(195, 19);
            this.radioButton_cash.Name = "radioButton_cash";
            this.radioButton_cash.Size = new System.Drawing.Size(61, 22);
            this.radioButton_cash.TabIndex = 14;
            this.radioButton_cash.TabStop = true;
            this.radioButton_cash.Text = "Cash";
            this.radioButton_cash.UseVisualStyleBackColor = true;
            this.radioButton_cash.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox_gender
            // 
            this.groupBox_gender.Controls.Add(this.radioButton1);
            this.groupBox_gender.Controls.Add(this.radioButton2);
            this.groupBox_gender.Location = new System.Drawing.Point(377, 268);
            this.groupBox_gender.Name = "groupBox_gender";
            this.groupBox_gender.Size = new System.Drawing.Size(252, 36);
            this.groupBox_gender.TabIndex = 15;
            this.groupBox_gender.TabStop = false;
            this.groupBox_gender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox_payment_meth
            // 
            this.groupBox_payment_meth.Controls.Add(this.radioButton_credit);
            this.groupBox_payment_meth.Controls.Add(this.radioButton_debit);
            this.groupBox_payment_meth.Controls.Add(this.radioButton_cash);
            this.groupBox_payment_meth.Controls.Add(this.radioButton_pix);
            this.groupBox_payment_meth.Location = new System.Drawing.Point(377, 319);
            this.groupBox_payment_meth.Name = "groupBox_payment_meth";
            this.groupBox_payment_meth.Size = new System.Drawing.Size(252, 53);
            this.groupBox_payment_meth.TabIndex = 16;
            this.groupBox_payment_meth.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 561);
            this.Controls.Add(this.groupBox_payment_meth);
            this.Controls.Add(this.groupBox_gender);
            this.Controls.Add(this.label_payment_meth);
            this.Controls.Add(this.checkBox_terms);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_close_window);
            this.Name = "Form1";
            this.Text = "GUI DEMO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_gender.ResumeLayout(false);
            this.groupBox_gender.PerformLayout();
            this.groupBox_payment_meth.ResumeLayout(false);
            this.groupBox_payment_meth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close_window;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.CheckBox checkBox_terms;
        private System.Windows.Forms.Label label_payment_meth;
        private System.Windows.Forms.RadioButton radioButton_credit;
        private System.Windows.Forms.RadioButton radioButton_debit;
        private System.Windows.Forms.RadioButton radioButton_pix;
        private System.Windows.Forms.RadioButton radioButton_cash;
        private System.Windows.Forms.GroupBox groupBox_gender;
        private System.Windows.Forms.GroupBox groupBox_payment_meth;
    }
}

