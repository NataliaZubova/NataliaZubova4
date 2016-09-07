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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.продажаDataSet.Заказы);

        }
        private void Form31_FormClosing(object sender, FormClosingEventArgs e)
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

        private void заказыНаЗаданнуюДатуToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.заказыTableAdapter.ЗаказыНаЗаданнуюДату(this.продажаDataSet.Заказы, ((System.DateTime)(System.Convert.ChangeType(paramToolStripTextBox.Text, typeof(System.DateTime)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                this.заказыTableAdapter.ЗаказыНаЗаданнуюДату(this.продажаDataSet.Заказы, ((System.DateTime)(System.Convert.ChangeType(System.Convert.ToString(monthCalendar1.SelectionEnd).Substring(0, 10), typeof(System.DateTime)))));
            }
            catch
            {
                MessageBox.Show("Ошибка выбора данных.", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
