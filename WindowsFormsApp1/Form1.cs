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
        Dictionary<Partecipane, Importo> accounts = new Dictionary<Partecipane, Importo>();
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
            Partecipane b1 = new Partecipane(textBox1.Text);
            Importo b2 = new Importo(Convert.ToInt16(textBox2.Text));
            
            accounts.Add(b1, b2);
            
            
            quota = quota + Convert.ToInt16( textBox2.Text);
            label5.Text = quota.ToString();
            string[] row = { textBox2.Text, textBox1.Text, textBox9.Text};

            var ListViewItem = new ListViewItem(row);
            listView1.Items.Add(ListViewItem);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void del_Click(object sender, EventArgs e)
        {
            Partecipane b3 = new Partecipane(textBox3.Text);
            accounts.Remove(b3);
           quota = quota - Convert.ToInt16(textBox7.Text);
            label5.Text = quota.ToString();

        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            Partecipane b4 = new Partecipane(textBox4.Text);
            quota = quota - Convert.ToInt16(textBox8.Text);
            label5.Text = quota.ToString();
            accounts.Remove(b4);
            Partecipane b5 = new Partecipane(textBox5.Text);
            Importo b3 = new Importo(Convert.ToInt16(textBox6.Text));
            accounts.Add(b5,b3);
            quota = quota + Convert.ToInt16(textBox6.Text);
            label5.Text = quota.ToString();
            string[] row = { textBox6.Text, textBox5.Text };

            var ListViewItem = new ListViewItem(row);
            listView1.Items.Add(ListViewItem);
            textBox4.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }
    }
}
