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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.продажаDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.продажаDataSet.Заказы);

        }
        private void Form21_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

        private void заказыТовараToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.заказыTableAdapter.ЗаказыТовара(this.продажаDataSet.Заказы, ((int)(System.Convert.ChangeType(paramToolStripTextBox.Text, typeof(int)))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.заказыTableAdapter.ЗаказыТовара(this.продажаDataSet.Заказы, ((int)(System.Convert.ChangeType(this.listBox1.SelectedValue, typeof(int)))));

            }
            catch
            {
                MessageBox.Show("Ошибка выбора данных.", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
