using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.LinkLabel;

namespace Lista_Filmów
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void DodawanieDanych(string tytul, string rezyser, string data, string aktor)
        {
            ListViewItem item = new ListViewItem(new string[] { tytul, rezyser, data, aktor });
            listView1.Items.Add(item);
        }
        private void DodawanieDanych(string[] dane)
        {
            ListViewItem item = new ListViewItem(dane);
            listView1.Items.Add(item);
        }
        private void UsuwanieDanych()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            //listView1.Refresh()
        }
        private string[] WierszeDoPliku()
        {
            string[] linie = new string[listView1.Items.Count];
            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for (int k = 0; k < item.SubItems.Count; k++)
                    linie[i] += item.SubItems[k].Text + "*";
                i++;
            }
            return linie;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            DodawanieDanych(tytul.Text, rezyser.Text, data.Text, aktor.Text);
        }

        private void usuńWybraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuwanieDanych();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
