using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int soruno = 0, dogru = 0, yanlis = 0;





        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Enabled = false;
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "Avanos")
                        {
                            btna.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btna.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 2:
                        if (textBox1.Text == "BİYOGRAFİ")
                        {
                            btnb.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnb.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 3:
                        if (textBox1.Text == "CIRT CIRT")
                        {
                            btnc.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnc.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 4:
                        if (textBox1.Text == "Deprem")
                        {
                            btnd.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnd.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 5:
                        if (textBox1.Text == "Edebiyat")
                        {
                            btne.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btne.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 6:
                        if (textBox1.Text == "FİZİKİ HARİTA")
                        {
                            btnf.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnf.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 7:
                        if (textBox1.Text == "GÖKCEADA")
                        {
                            btng.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btng.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 8:
                        if (textBox1.Text == "HAK")
                        {
                            btnh.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnh.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 9:
                        if (textBox1.Text == "IRAK")
                        {
                            btnI.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 10:
                        if (textBox1.Text == "JAPONYA")
                        {
                            btnj.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnj.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 11:
                        if (textBox1.Text == "KAĞIT")
                        {
                            btnk.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnk.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 12:
                        if (textBox1.Text == "LED")
                        {
                            btnl.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnl.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 13:
                        if (textBox1.Text == "MAREŞAL")
                        {
                            btnm.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnm.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 14:
                        if (textBox1.Text == "NEM")
                        {
                            btnn.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnn.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 15:
                        if (textBox1.Text == "OLİMPİYAT")
                        {
                            btno.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btno.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 16:
                        if (textBox1.Text == "PATENT")
                        {
                            btnp.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnp.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 17:
                        if (textBox1.Text == "RAFİNERİ")
                        {
                            btnr.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnr.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 18:
                        if (textBox1.Text == "STANT")
                        {
                            btns.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btns.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 19:
                        if (textBox1.Text == "TALİMAT")
                        {
                            btnt.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnt.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 20:
                        if (textBox1.Text == "UÇAK")
                        {
                            btnu.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnu.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 21:
                        if (textBox1.Text == "VADİ")
                        {
                            btnv.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnv.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 22:
                        if (textBox1.Text == "YÖRÜK")
                        {
                            btny.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btny.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 23:
                        if (textBox1.Text == "ZİRAAT")
                        {
                            btnz.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnz.BackColor = Color.Red;
                            yanlis++;
                            lbltanlis.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                }
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Enabled = true;
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString() + ".Soru";
            if (soruno == 1)
            {
                richTextBox1.Text = "Nevşehir'in çömlek yapımıyla ünlü ilçesi neresidir?";
                btna.BackColor = Color.Yellow;
                anabuton.Text = "A";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Bir insanın yaşamındaki olayların belirli bir sıraya göre anlatılmasına ne ad verilir?";
                btnb.BackColor = Color.Yellow;
                anabuton.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Ayakkabılarımızda, montlarımızda, eldivenlerimizde kullanılan bir tarafı yumuşak, diğer tarafı dikenli ve sert bantlara ne ad verilir?\r\n";
                btnc.BackColor = Color.Yellow;
                anabuton.Text = "C";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Yer ka­bu­ğu­nun de­rin kat­man­la­rı­nın kı­rı­lıp yer de­ğiş­tirme­si sonucu aniden ortaya çıkan sar­sın­tı­lara ne denir?\r\n";
                btnd.BackColor = Color.Yellow;
                anabuton.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yazın, olay, düşünce, duygu ve hayalleri dil aracılığı ile estetik bir şekilde ifade etme sanatıdır.";
                btne.BackColor = Color.Yellow;
                anabuton.Text = "E";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Türkiye'nin yer şekillerinin belli olabilecek şekilde gösteren haritalardır.\r\n";
                btnf.BackColor = Color.Yellow;
                anabuton.Text = "F";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Ege Denizi’nin kuzeydoğusunda, Gelibolu Yarımadası’nın batısında yer alan Türkiye'nin en büyük adası hangisidir ?\r\n";
                btng.BackColor = Color.Yellow;
                anabuton.Text = "G";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Herhangi bir varlığın, kanunî gerekçelerle yapabilmesi olağan şeylere ne ad verilir?\r\n";
                btnh.BackColor = Color.Yellow;
                anabuton.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Güney komşumuzdur başkenti Bağdat’tır.\r\n";
                btnI.BackColor = Color.Yellow;
                anabuton.Text = "I";

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Başkenti Tokyo olan asya kıtasının doğusunda yer alan bir adalar ülkesidir .\r\n";
                btnj.BackColor = Color.Yellow;
                anabuton.Text = "J";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Genellikle ağaçtan elde edilen bir tüketim malzemesidir.\r\n";
                btnk.BackColor = Color.Yellow;
                anabuton.Text = "K";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Işık yayan elektrik devresi şeklinde bir tür lambaya ne ad verilir?\r\n";
                btnl.BackColor = Color.Yellow;
                anabuton.Text = "L";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "En yüksek askerî unvan, bu unvanı taşıyan asker.\r\n";
                btnm.BackColor = Color.Yellow;
                anabuton.Text = "M";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Havada bulunan su buharı.\r\n";
                btnn.BackColor = Color.Yellow;
                anabuton.Text = "N";

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Her dört yılda bir başka ülkede yapılan, amatörlerin ve ülkelerinde profesyonel olarak futbol, basketbol, voleybol vb. takım sporlarıyla uğraşanların katıldığı uluslararası spor yarışmaları.\r\n";
                btno.BackColor = Color.Yellow;
                anabuton.Text = "O";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Bilimsel ve teknik bir buluşun ya da böyle bir buluşu uygulama alanında kullanma hakkının kime ait olduğunu gösteren resmi belge.\r\n";
                btnp.BackColor = Color.Yellow;
                anabuton.Text = "P";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Şeker, petrol vb. maddelerin arıtıldığı yer.\r\n";
                btnr.BackColor = Color.Yellow;
                anabuton.Text = "R";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "İş yerlerinde, fuarlarda vb. yerlerde malların alıcılara gösterilmek üzere özel olarak hazırlanmış bölüm.\r\n";
                btns.BackColor = Color.Yellow;
                anabuton.Text = "S";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Üst makamlardan alt makamlara verilen buyruk.\r\n";
                btnt.BackColor = Color.Yellow;
                anabuton.Text = "T";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Kanatlarının altına havanın yaptığı basınç yardımıyla yükselip havada ilerleyebilen motorlu taşıt.\r\n";
                btnu.BackColor = Color.Yellow;
                anabuton.Text = "U";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "İki dağ arasındaki çukurca arazi veya geçit.\r\n";
                btnv.BackColor = Color.Yellow;
                anabuton.Text = "V";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Hayvancılıkla geçinen, genellikle Toroslarda yaşayan göçebe Türk oymağı.\r\n";
                btny.BackColor = Color.Yellow;
                anabuton.Text = "Y";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Topraktan çeşitli ürünler elde etmeye dayanan yaşamsal etkinlik.";
                btnz.BackColor = Color.Yellow;
                anabuton.Text = "Z";
            }
            if(soruno == 24)
            {
                linkLabel1.Text = "Yeniden Başla";
                MessageBox.Show("Oyun Tamamlandı \n Dogru:" + lbldogru.Text + "\n Yanlış: " + lbltanlis.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
