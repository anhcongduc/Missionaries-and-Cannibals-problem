using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace pplt
{
    public partial class Form1 : Form
    {
        public bool Checkload = false;
        public string[] ac;
        public static List<string> lst;
        public string querytextbox;
        public const int Max= 50;
        public string tenfilepl;
        public List<String> resultquery = new List<string>();
        public int index = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);

        }
        private string Split(string ab) //xu ly string ket qua truy van tu stirng thanh list
        {
            ab = ab.Replace("],[", "Q");
            ab = ab.Replace("[[", "");
            ab = ab.Replace("]]", "");
            return ab;
        }
        private void Form1_Load(object sender, EventArgs e) //set moi truong nhung prolog
        {
            cmbPlfile.SelectedIndex = 0;
            cmbQuery.SelectedIndex = 0;
            cmbIndex.SelectedIndex = 0;
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\swipl");
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + @";C:\Program Files (x86)\swipl\bin");
        }

        private void button1_Click(object sender, EventArgs e)  // cai dat nut start trong form
        {
            if(Checkload==false)
            {
                MessageBox.Show("Phai load file truoc", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string s = "C:/Users/Hasegawa/Documents/Visual Studio 2015/Projects/pplt/pplt/sourceimgandprologcode/" + tenfilepl;
            string query = "consult('" + s + "')";
            string[] p = { "-q", "-f", query };
            PlEngine.Initialize(p);
            PlQuery q = new PlQuery(query);
            Assert.IsTrue(q.NextSolution());
            using (var a = new PlQuery(querytextbox))
            {
                int i = 0;
                foreach (var sol in a.SolutionVariables)
                {
                    if(i%2==0)
                        resultquery.Add(sol["P"].ToString());
                    i++;
                    if (i > Max)
                        break;
                }
                PlEngine.PlCleanup();
            }
           
            textBox1.Text ="List Thu "+index +" la P= " + resultquery[index];
           
        }



        private void button2_Click(object sender, EventArgs e)  //cai dat nut load trong form
        {
            Checkload = true;
            querytextbox = cmbQuery.SelectedItem.ToString();
            tenfilepl = cmbPlfile.SelectedItem.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)  //cai dat nut next trong form
        {
            index++;
            if (Checkload == false)
            {
                MessageBox.Show("Phai load file truoc", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (index == resultquery.Count)
            {
                MessageBox.Show("Truy Van Ket Thuc!!!");
            }
            if(index<resultquery.Count)
                textBox1.Text = "List Thu " + index + " la P= " + resultquery[index];
            if (index>resultquery.Count)
                MessageBox.Show("Truy Van Ket Thuc!!!");
        }

        private void button4_Click(object sender, EventArgs e) //cai dat nut reset trong form
        {
           
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)  //cai dat nut reset trong form
        {
            textBox1.Clear();
            Checkload = false;
            resultquery.Clear();
            index = 0;
        }

        private void cmbPlfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbQuery.SelectedIndex = cmbPlfile.SelectedIndex;
        }

        private void button6_Click(object sender, EventArgs e) //cai dat nut demo trong form
        {
            if (Checkload == false)
            {
                MessageBox.Show("Phai load file truoc", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String ab = "";
            int selected = cmbIndex.SelectedIndex;
            ab = resultquery[selected];
            ab = Split(ab);
            ac = ab.Split('Q');
            lst = new List<string>(ac);
            lst.Reverse();
            minhhoa mh = new minhhoa();
            mh.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e) //cai dat nut author trong form
        {
            Author At = new Author();
            At.ShowDialog();
        }
    }
}
