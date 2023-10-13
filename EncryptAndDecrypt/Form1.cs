using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptAndDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text;
        string otv = "";
        Random random = new Random();
        private void button_encrypt_Click(object sender, EventArgs e)
        {
            text = textBox_txt.Text;
            string keyNormal = textBox_key.Text;
            int key=Convert.ToInt32(textBox_key.Text);
            for (int i = 0; i < Text.Length; i++)
            {
                char ch1= Text[i];
                ch1 = (char)(ch1 ^ key);

                otv= otv+ch1.ToString();

            }
            textBox_result.Text = otv;
            otv = "";
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            text = textBox_txt.Text;
            int keyNormal = Convert.ToInt32(textBox_key.Text);
            int key = Convert.ToInt32(textBox_key.Text);
            for (int i = 0; i < Text.Length; i++)
            {
                char ch1 = Text[i];
                ch1 = (char)(ch1 ^ key);

                otv = otv + ch1.ToString();

            }
            textBox_result.Text = otv;
            otv = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = textBox_txt.Text;
            int key = Convert.ToInt32(textBox_key.Text);
            if (!checkBox_NoGenerate.Checked)
            {
                key = key + random.Next(1, 9999999);
            }
            else
            {
                key = key * Convert.ToInt32(textBox_qwe.Text)-(Convert.ToInt32(textBox_qwe.Text)+key)-16*17;
                textBox_qwe.Text = "";
            }
            for (int i = 0; i < Text.Length; i++)
            {
                char ch1 = Text[i];
                ch1 = (char)(ch1 ^ key);

                otv = otv + ch1.ToString();

            }
            textBox_result.Text = otv;
            otv = "";
            if (!checkBox_NoMassage.Checked)
            {
                    MessageBox.Show("Ключ для расшифрования:"+key,"ВНИМАНИЕ!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] alfabet=new string[36];
            text = textBox_txt.Text;
            int key = Convert.ToInt32(textBox_key.Text);
            if (!checkBox_NoGenerate.Checked)
            {
                key = key + random.Next(1, 999999999);
            }
            else
            {
                key = key +987;
                textBox_qwe.Text = "";
            }
            for (int i = 0; i < Text.Length; i++)
            {
                
                char ch1 = Text[i];
                
                ch1 = (char)(ch1 ^ key);

                otv = otv + ch1.ToString();

            }
            textBox_result.Text = otv;
            otv = "";
            if (!checkBox_NoMassage.Checked)
            {
                MessageBox.Show("Ключ для расшифрования:" + key, "ВНИМАНИЕ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
