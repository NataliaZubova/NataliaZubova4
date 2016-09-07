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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            dataSet201.Clear();
            sqlDataAdapter1.Fill(dataSet201.Покупатели);
        }
        private void Form22_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{Команда.КодПокуп} = " + dataSet201.Покупатели[comboBox1.SelectedIndex].КодПокуп ;
            crystalReportViewer1.RefreshReport();

        }
    }
}
