using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> accounts = new Dictionary<string, double>();
        int quota;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void NEGROOOOO_Click(object sender, EventArgs e)
        {
            accounts.Add(textBox1.Text, Convert.ToInt16(textBox2.Text));

            quota = quota + Convert.ToInt16( textBox2.Text);
            label5.Text = quota.ToString();
            string[] row = { textBox1.Text, textBox2.Text };

            var ListViewItem = new ListViewItem(row);
            listView1.Items.Add(ListViewItem);
        }

        private void del_Click(object sender, EventArgs e)
        {
            accounts.Remove(del.Text);
           // quota = quota - 

        }
    }
}
