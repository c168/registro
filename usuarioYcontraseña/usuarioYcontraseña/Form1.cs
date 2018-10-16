using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usuarioYcontraseña
{
    public partial class Form1 : Form
    {
        private Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "cesar a")
            {
                if (this.textBox2.Text == "1234")
                {
                    
                    f2 = new Form2();
                    f2.Show();
                    
                }
                if (this.textBox2.Text != "1234")
                {
                    if (this.textBox2.Text == "")
                    {
                        MessageBox.Show("ingrese  contraseña");
                    }
                    else
                    {
                        MessageBox.Show("contraseña incorrecta");
                    }
                }
            }

            else
            {
                MessageBox.Show("Usuario y  Contraseña Incorrecta");
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
