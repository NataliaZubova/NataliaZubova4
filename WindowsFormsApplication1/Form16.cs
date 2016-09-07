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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            dataSet161.Clear();
            sqlDataAdapter1.Fill(dataSet161.Товары);
        }
        private void Form16_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                sqlDataAdapter1.Update(dataSet161.Товары);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Ошибка", "Невозможно сохранить изменения из-за ошибки", MessageBoxButtons.OK);
                }
            }
        }
    }
}
