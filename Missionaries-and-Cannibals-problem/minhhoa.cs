using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pplt
{
    public partial class minhhoa : Form
    {
        public int index = -1;

        public int flag=0;
        public int songuoidichuyen = 0, soquydichuyen = 0;
        public int songuoichenhlech, soquychenhlech, songuoibenbodich, soquybenbodich, songuoibenboxuatphat, soquybenboxuatphat;

        private void thuyen_Click(object sender, EventArgs e)
        {

        }

        public minhhoa()
        {
            InitializeComponent();
        }


        private void minhhoa_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.lst[0].ToString();
            anvatthetrenthuyen();

        }
        private void hienvatthe2benbo() //ham hien cac vat the 2 ben bo
        {
            nguoi1.Show();
            nguoi2.Show();
            nguoi3.Show();
            quy1.Show();
            quy2.Show();
            quy3.Show();
        }

        private void button1_Click(object sender, EventArgs e)  //cai dat nut back trong form minhhoa
        {
            this.Close();
        }

        private void setimage(int i,int loaivatthe) //ham cai dat xem xet cho nguoi nao len thuyen
        {
            if (i == 0)
            {
                if (loaivatthe == 1)
                {
                    nguoitrenthuyen1.Image = Image.FromFile("C:/Users/Hasegawa/Documents/Visual Studio 2015/Projects/pplt/pplt/sourceimgandprologcode/nhasu.png");
                    nguoitrenthuyen1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    nguoitrenthuyen1.Image = Image.FromFile("C:/Users/Hasegawa/Documents/Visual Studio 2015/Projects/pplt/pplt/sourceimgandprologcode/quy1.png");
                    nguoitrenthuyen1.SizeMode = PictureBoxSizeMode.StretchImage;
                   
                }
            }
            else
            {
                if (loaivatthe == 1)
                {
                    nguoitrenthuyen2.Image = Image.FromFile("C:/Users/Hasegawa/Documents/Visual Studio 2015/Projects/pplt/pplt/sourceimgandprologcode/nhasu.png");
                    nguoitrenthuyen2.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                }
                else
                {
                    nguoitrenthuyen2.Image = Image.FromFile("C:/Users/Hasegawa/Documents/Visual Studio 2015/Projects/pplt/pplt/sourceimgandprologcode/quy1.png");
                    nguoitrenthuyen2.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                   
                }
            }
        }
        private void hienvatthetrenthuyen(int i, int loaivatthe)//ham hien vat the tren thuyen loaivat the 1 la nguoi 2 la quy
        {
            if (i == 0)
            {
                
                nguoitrenthuyen1.Show();
            }
            else
            {
                
                nguoitrenthuyen2.Show();
            }
        }
        private void anvatthetrenthuyen()   //ham an vat the tren thuyen
        {
            nguoitrenthuyen1.Hide();
            nguoitrenthuyen2.Hide();
        }
        private void button2_Click(object sender, EventArgs e)  //cai dat nut next
        {
            index++;
            if(flag==1)
            {
                MessageBox.Show("Thuyen da den dich");
                return;
            }
            string[] trangthai = Form1.lst[index].Split(',');
            string[] trangthaisau;
            if (index < Form1.lst.Count - 1)
            {
                textBox1.Text = Form1.lst[index + 1].ToString();
                trangthaisau = Form1.lst[index + 1].Split(',');
                songuoibenboxuatphat = Convert.ToInt32(trangthaisau[0]);
                soquybenboxuatphat = Convert.ToInt32(trangthaisau[1]);
                songuoibenbodich = Convert.ToInt32(trangthaisau[2]);
                soquybenbodich = Convert.ToInt32(trangthaisau[3]);
            }
            else
            {
                MessageBox.Show("Thuyen da den dich");
                flag = 1;
            }

            if (trangthai[4] == "0")
            {
                songuoichenhlech = songuoibenbodich - Convert.ToInt32(trangthai[2]);
                soquychenhlech = soquybenbodich - Convert.ToInt32(trangthai[3]);
            }
            if (trangthai[4] == "1")
            {
                songuoichenhlech = songuoibenboxuatphat - Int32.Parse(trangthai[0]);
                soquychenhlech = soquybenboxuatphat - Int32.Parse(trangthai[1]);
            }
            songuoidichuyen = Math.Abs(songuoichenhlech);
            soquydichuyen = Math.Abs(soquychenhlech);
            if (trangthai[4] == "0")
            {

                for (int i = 1; i <= songuoidichuyen; i++)
                {

                    if (nguoi1.Location.X == 887)
                    {
                        nguoi1.Hide();
                        nguoi1.Location = new Point(16, 211);
                        continue;
                    }
                    if (nguoi2.Location.X == 953)
                    {
                        nguoi2.Hide();
                        nguoi2.Location = new Point(82, 211);
                        continue;

                    }
                    if (nguoi3.Location.X == 1019)
                    {
                        nguoi3.Hide();
                        nguoi2.Location = new Point(148, 211);
                        continue;
                    }
                }
                for (int i = 1; i <= soquydichuyen; i++)
                {

                    if (quy1.Location.X != 205)
                    {
                        quy1.Hide();
                        quy1.Location = new Point(205, 211);
                        continue;
                    }
                    if (quy2.Location.X != 271)
                    {
                        quy2.Hide();
                        quy2.Location = new Point(271, 211);
                        continue;
                    }
                    if (quy3.Location.X != 337)
                    {
                        quy3.Hide();
                        quy3.Location = new Point(337, 211);
                        continue;
                    }
                }
                if (index >= 0)
                {
                    for (int i = 0; i < songuoidichuyen; i++)
                    {
                        hienvatthetrenthuyen(i, 1);
                        setimage(i, 1);
                    }
                    for (int i = songuoidichuyen; i < songuoidichuyen + soquydichuyen; i++)
                    {
                        hienvatthetrenthuyen(i, 2);
                        setimage(i, 2);
                    }
                    timer2.Start();

                }

            }
            if (trangthai[4] == "1")
            {
                for (int i = 1; i <= songuoidichuyen; i++)
                {

                    if (nguoi1.Location.X == 16)
                    {
                        nguoi1.Hide();
                        nguoi1.Location = new Point(887, 211);
                        continue;
                    }
                    if (nguoi2.Location.X == 82)
                    {
                        nguoi2.Hide();
                        nguoi2.Location = new Point(953, 211);
                        continue;
                    }
                    if (nguoi3.Location.X == 148)
                    {
                        nguoi3.Hide();
                        nguoi3.Location = new Point(1019, 211);
                        continue;
                    }
                }
                for (int i = 1; i <= soquydichuyen; i++)
                {

                    if (quy1.Location.X != 1076)
                    {
                        quy1.Hide();
                        quy1.Location = new Point(1076, 211);
                        continue;
                    }
                    if (quy2.Location.X != 1142)
                    {
                        quy2.Hide();
                        quy2.Location = new Point(1142, 211);
                        continue;
                    }
                    if (quy3.Location.X != 712)
                    {
                        quy3.Hide();
                        quy3.Location = new Point(1208, 211);
                        continue;
                    }
                }
                if (index >= 0)
                {
                    for (int i = 0; i < songuoidichuyen; i++)
                    {
                        hienvatthetrenthuyen(i, 1);
                        setimage(i, 1);
                    }
                    for (int i = songuoidichuyen; i < songuoidichuyen + soquydichuyen; i++)
                    {
                        hienvatthetrenthuyen(i, 2);
                        setimage(i, 2);
                    }
                    timer1.Start();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)    //cai dat thuat toan di chuyen cua thuyen
        {
            nguoitrenthuyen1.SuspendLayout();
            thuyen.SuspendLayout();
            nguoitrenthuyen2.SuspendLayout();
            if (flag == 1)
                timer1.Stop();
            thuyen.Left += 10;
            nguoitrenthuyen1.Left += 10;
            nguoitrenthuyen2.Left += 10;
            if (thuyen.Location.X == 674)
            {
                anvatthetrenthuyen();
                hienvatthe2benbo();
                timer1.Stop();
            }
            thuyen.ResumeLayout();
            nguoitrenthuyen1.ResumeLayout();
            nguoitrenthuyen2.ResumeLayout();
        }

        private void timer2_Tick(object sender, EventArgs e) // tuong tu nhu timer1_Tick
        {
            if (flag == 1)
                timer2.Stop();
            thuyen.Left -= 10;
            nguoitrenthuyen1.Left -= 10;
            nguoitrenthuyen2.Left -= 10;
            if (thuyen.Location.X == 414)
            {
                anvatthetrenthuyen();
                hienvatthe2benbo();
                timer2.Stop();
            }
        }
    }
}
