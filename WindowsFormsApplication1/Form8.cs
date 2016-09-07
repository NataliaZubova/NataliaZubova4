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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataSet81.Clear();
            sqlDataAdapter1.Fill(dataSet81.Заказы);
            sqlDataAdapter2.Fill(dataSet81.Компания);
            sqlDataAdapter3.Fill(dataSet81.Покупатели);
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

    }
}
