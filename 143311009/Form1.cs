using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _143311009
{
    public partial class Form1 : Form
    {
        int[] dizi = new int[5];
        int sure = 0;
        int basamak = 0;
        int hak = 0;
        int sayac = 0;
        bool kontrol1 = true, kontrol2 = true, kontrol3 = true, kontrol4 = true, kontrol5 = true;

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kagan = MessageBox.Show("Devam etmek için Evet'i, Oyunu kapatmak için Hayır'ı Tıklayınız.","Çıkış Uyarısı",MessageBoxButtons.YesNo);
            if (kagan == DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value == 2)
            {
                textBox3.Enabled = false;
            }else if ((int)numericUpDown1.Value == 3)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
            else if ((int)numericUpDown1.Value == 4)
            {
                textBox4.Enabled = true;
                textBox5.Enabled = false;
            }
            else if ((int)numericUpDown1.Value == 5)
            {
                textBox5.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            basamak = (int)numericUpDown1.Value;
            hak = (int)numericUpDown2.Value;
            sure = 20 * hak;


            if (radioButton1.Checked)
            {
                for (int i = 0; i < basamak; i++)
                {
                    dizi[i] = rnd.Next(1, 10);
                }
            }
            else
            {
                dizi[0] = rnd.Next(1, 10);
                for (int i = 1; i < dizi.Length; i++)
                {
                    dizi[i] = rnd.Next(1, 10);
                    for (int k = 0; k < i; k++)
                    {
                        while(dizi[i] == dizi[k])
                        {
                            dizi[i] = rnd.Next(1, 10);
                        }
                    }
                }
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = "Süre: " + sure;
            label10.Text = "Hak Sayısı: " + hak;
            String [] cvp = {textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text};
            sure--;
            if (sure == 0 || hak == 0)
            {
                timer1.Stop();
                MessageBox.Show("BİLEMEDİNİZ, OYUN BİTTİ - SAYI: "+(sayac*10).ToString());
            }


            if (textBox1.Text != "")
            {
                if (int.Parse(textBox1.Text) == dizi[0])
                {
                    label7.BackColor = Color.Blue;
                    sayac++;
                }
                else
                {
                    if (kontrol1 == true)
                    {
                        hak--;
                        sure -= 20;
                        label7.BackColor = Color.Gold;
                        kontrol1 = false;
                    }
                }

                for (int i = 1; i < basamak; i++)
                {
                    if(int.Parse(cvp[0]) == dizi[i])
                    {
                        label7.BackColor = Color.Red;
                    }
                }
            }

            if (textBox2.Text != "")
            {
                if (int.Parse(textBox2.Text) == dizi[1])
                {
                    label6.BackColor = Color.Blue;
                    sayac++;
                }
                else
                {
                    if (kontrol2 == true)
                    {
                        hak--;
                        sure -= 20;
                        label6.BackColor = Color.Gold;
                        kontrol2 = false;
                    }
                }

                for (int i = 0; i < basamak; i++)
                {
                    if (i != 1)
                    {
                        if (int.Parse(cvp[1]) == dizi[i])
                        {
                            label6.BackColor = Color.Red;
                        }
                    }
                }
            }


            if (basamak == 3)
            {
                if (textBox3.Text != "")
                {
                    if (int.Parse(textBox3.Text) == dizi[2])
                    {
                        label5.BackColor = Color.Blue;
                        sayac++;
                    }
                }
                else
                {
                    if (kontrol3 == true)
                    {
                        hak--;
                        sure -= 20;
                        label5.BackColor = Color.Gold;
                        kontrol3 = false;
                    }
                }

                for (int i = 0; i < basamak; i++)
                {
                    if (i != 2)
                    {
                        if (int.Parse(cvp[2]) == dizi[i])
                        {
                            label5.BackColor = Color.Red;
                        }
                    }
                }
            }

            if (basamak == 4)
            {
                if (textBox3.Text != "")
                {
                    if (int.Parse(textBox3.Text) == dizi[2])
                    {
                        label5.BackColor = Color.Blue;
                        sayac++;
                    }
                    else
                    {
                        if (kontrol3 == true)
                        {
                            hak--;
                            sure -= 20;
                            label5.BackColor = Color.Gold;
                            kontrol3 = false;
                        }
                    }

                    for (int i = 0; i < basamak; i++)
                    {
                        if (i != 2)
                        {
                            if (int.Parse(cvp[2]) == dizi[i])
                            {
                                label5.BackColor = Color.Red;
                            }
                        }
                    }
                }

                if (textBox4.Text != "")
                {
                    if (int.Parse(textBox4.Text) == dizi[3])
                    {
                        label4.BackColor = Color.Blue;
                        sayac++;
                    }
                    else
                    {
                        if (kontrol4 == true)
                        {
                            hak--;
                            sure -= 20;
                            label4.BackColor = Color.Gold;
                            kontrol4 = false;
                        }
                    }

                    for (int i = 0; i < basamak; i++)
                    {
                        if (i != 3)
                        {
                            if (int.Parse(cvp[3]) == dizi[i])
                            {
                                label4.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }

            if (basamak == 5)
            {
                if (textBox5.Text != "")
                {
                    if (int.Parse(textBox5.Text) == dizi[4])
                    {
                        label3.BackColor = Color.Blue;
                        sayac++;
                    }
                    else
                    {
                        if (kontrol5 == true)
                        {
                            hak--;
                            sure -= 20;
                            label3.BackColor = Color.Gold;
                            kontrol5 = false;
                        }
                    }

                    for (int i = 0; i < basamak; i++)
                    {
                        if (i != 4)
                        {
                            if (int.Parse(cvp[4]) == dizi[i])
                            {
                                label3.BackColor = Color.Red;
                            }
                        }
                    }
                }

                if (textBox3.Text != "")
                {
                    if (int.Parse(textBox3.Text) == dizi[2])
                    {
                        label5.BackColor = Color.Blue;
                        sayac++;
                    }
                    else
                    {
                        if (kontrol3 == true)
                        {
                            hak--;
                            sure -= 20;
                            label5.BackColor = Color.Gold;
                            kontrol3 = false;
                        }
                    }

                    for (int i = 0; i < basamak; i++)
                    {
                        if (i != 2)
                        {
                            if (int.Parse(cvp[2]) == dizi[i])
                            {
                                label5.BackColor = Color.Red;
                            }
                        }
                    }
                }

                if (textBox4.Text != "")
                {
                    if (int.Parse(textBox4.Text) == dizi[3])
                    {
                        label4.BackColor = Color.Blue;
                        sayac++;
                    }
                    else
                    {
                        if (kontrol4 == true)
                        {
                            hak--;
                            sure -= 20;
                            label4.BackColor = Color.Gold;
                            kontrol4 = false;
                        }
                    }

                    for (int i = 0; i < basamak; i++)
                    {
                        if (i != 3)
                        {
                            if (int.Parse(cvp[3]) == dizi[i])
                            {
                                label4.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }

            if(sayac == basamak)
            {
                timer1.Stop();
                MessageBox.Show("TEBRİKLER BİLDİNİZ!");
            }
        }
    }
}
