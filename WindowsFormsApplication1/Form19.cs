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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            dataSet191.Clear();
            sqlDataAdapter1.Fill(dataSet191.Заказы);
        }
        private void Form19_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                sqlDataAdapter1.Update(dataSet191.Заказы);
            }
            catch (System.Data.SqlClient.SqlException s4)
            {
                if (s4.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Редактирование записей невозможно. В таблице указаны неверные значения.", "Ошибка", MessageBoxButtons.OK);
                    dataSet191.Clear();
                    sqlDataAdapter1.Fill(dataSet191.Заказы);
                }
            }
        }
    }
}
