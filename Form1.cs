using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String a = (textBox1.Text);
            String[] alfabe = { " ","\u2801", "\u2803","\u2809", "\u2821", "\u2819", "\u2821", "\u280B", "\u281B","\u2823","\u2813", "\u2814", "\u280A", "\u281A", "\u2805", "\u2838", "\u280D", "\u281D", "\u2815", "\u282A", "\u280F", "\u281F", "\u2817", "\u280E", "\u2829", "\u281E", "\u2825", "\u2833", "\u2827", "\u283A", "\u282D", "\u283D", "\u2835","\u28A4", "\u2802", "\u2844", "\u2812", "\u2826", "\u2816", "\u28C0", "\u2830 \u28C4","\u28A0 \u2812","\u2830 \u2884","\u2830 \u28C0","\u2830 \u2836","\u28A4 \u28A4 \u28A4", "\u2826 \u2834", "\u2836", "\u2836", "\u2808","\u2840" };
            String[] harf = { " ","a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "q", "r", "s", "ş", "t", "u", "ü", "v", "w", "x", "y", "z",".",",",";",":","?","!","-","*","/","+","-","=","...",@"""","(",")","^","'"};
            String[] bharf = { " ", "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "Q", "R", "S", "Ş", "T", "U", "Ü", "V", "W", "X", "Y", "Z",};
            String[] rakam = { "1", "2", "3", "4", "5", "6", "7", "8", "9","0" };
            string[] irakam = { "\u2801", "\u2803", "\u2809", "\u2819", "\u2821", "\u280B", "\u281B", "\u2813", "\u280A", "\u281A" };
            string[] sayisa = { "\u283C", "\u28C0 \u28C0" };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    label2.Text += "\u2820";
                }
                for (int j = 0; j < alfabe.Length; j++)
                {
                    if (Convert.ToString(a[i]) == harf[j])
                    {
                        label2.Text += alfabe[j];
                    }

                }
                for (int j = 0; j < irakam.Length; j++)
                {
                    if (Convert.ToString(a[i]) == rakam[j])
                       
                        label2.Text += irakam[j];
                }
                for (int j = 0; j <bharf.Length; j++)
                {
                    if (Convert.ToString(a[i]) == bharf[j])
                    {                      
                        label2.Text += alfabe[j];
                    }
                        
                }
            }

        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void çeviriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
                
                   
                
            }
                
            
    
            

