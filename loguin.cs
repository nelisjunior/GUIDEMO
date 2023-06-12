using System;
using System.Windows.Forms;

namespace GUIDEMO
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            button_signup.Enabled = checkBox_terms.Checked;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //TextBoxes armazena o conteúdo das textbox
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string password_repeat = textBox_password_repeat.Text;
            //Verificar se a senha são iguais
            if (password == password_repeat)
            {
                //Salva os dados do usuário no DataSources do GUIDEMO

            

        }

        private void Label_password_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Verificar se a senha são iguais
            //O conteúdo da textbox muda de cor
            if (textBox_password.Text == textBox_password_repeat.Text)
            {
                textBox_password.BackColor = System.Drawing.Color.LightGreen;
                textBox_password_repeat.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                textBox_password.BackColor = System.Drawing.Color.LightPink;
                textBox_password_repeat.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void Label_password_repeat_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button_show_hide_Click(object sender, EventArgs e)
        {
            //Botao que altera o usersystemchar para true ou false do campo password
            if (textBox_password.UseSystemPasswordChar == true)
            {
                textBox_password.UseSystemPasswordChar = false;
                textBox_password_repeat.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
                textBox_password_repeat.UseSystemPasswordChar = true;
            }
            //Sempre que Button_show_hide é clicado, altera a GUIDEMO.Properties.Resources.monkey_2_
            if (button_show_hide.Text == "🙊")
            {
                button_show_hide.Text = "🙈";
                pictureBox_monkey.Image = GUIDEMO.Properties.Resources.monkey_1_;
            }
            else
            {
                button_show_hide.Text = "🙊";
                pictureBox_monkey.Image = GUIDEMO.Properties.Resources.monkey_2_;
            }
        }

        private void pictureBox_monkey_Click(object sender, EventArgs e)
        {

        }

        private void picture_monkey_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_monkey_Click_1(object sender, EventArgs e)
        {

        }
    }
}
