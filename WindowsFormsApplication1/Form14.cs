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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            dataSet141.Clear();
            sqlDataAdapter1.Fill(dataSet141.Покупатели);
           
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlDataAdapter2.SelectCommand.Parameters[0].Value = dataSet141.Покупатели[comboBox1.SelectedIndex].КодПокуп;
            dataSet241.Clear();
            sqlDataAdapter2.Fill(dataSet241.Заказы);

        }
        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
