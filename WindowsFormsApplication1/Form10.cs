using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataSet101.Clear();
            sqlDataAdapter1.Fill(dataSet101.Заказы);
        }
        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet101, "заказы"].Position = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet101, "заказы"].Position -= 1;
            button3.Enabled = true;
            button4.Enabled = true;
            if (this.BindingContext[dataSet101, "заказы"].Position == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet101, "заказы"].Position += 1;
            button1.Enabled = true;
            button2.Enabled = true;
            if (this.BindingContext[dataSet101, "заказы"].Position == this.BindingContext[dataSet101, "заказы"].Count - 1)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet101, "заказы"].Position =
            this.BindingContext[dataSet101, "заказы"].Count - 1;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            if (this.BindingContext[dataSet101, "заказы"].Position ==
            this.BindingContext[dataSet101, "заказы"].Count - 1)
            button4.Enabled = false;
        }
    }
}
