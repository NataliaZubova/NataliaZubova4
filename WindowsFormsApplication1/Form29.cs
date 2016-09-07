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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.продажаDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.продажаDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.продажаDataSet.Заказы);
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

        private void заказыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

        private void заказыBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

      /*  private void заказыПокупателяToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.заказыTableAdapter.ЗаказыПокупателя(this.продажаDataSet.Заказы, ((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        private void кодПокупComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.заказыTableAdapter.ЗаказыПокупателя(this.продажаDataSet.Заказы, System.Convert.ToInt32(this.кодПокупComboBox.SelectedValue));
        }
         
        private void кодПокупLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
