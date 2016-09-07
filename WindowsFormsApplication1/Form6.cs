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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataSet71.Clear();
            sqlDataAdapter1.Fill(dataSet71.Заказы);
            sqlDataAdapter2.Fill(dataSet71.Покупатели);


        }
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

    }
}
