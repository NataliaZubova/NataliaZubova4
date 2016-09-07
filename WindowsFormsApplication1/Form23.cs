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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }
        private void Form23_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Больше":
                    {
                        crystalReportViewer1.SelectionFormula = "{@Суммма заказа} > " + Convert.ToSingle(textBox1.Text);
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
                case "Меньше":
                    {
                        crystalReportViewer1.SelectionFormula = "{@Суммма заказа} < " + Convert.ToSingle(textBox1.Text);
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
                case "Равно":
                    {
                        crystalReportViewer1.SelectionFormula = "{@Суммма заказа} = " + Convert.ToSingle(textBox1.Text);
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
            }

        }
    }
}
