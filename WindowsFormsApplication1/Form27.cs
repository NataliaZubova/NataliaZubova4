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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void Form27_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.продажаDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.продажаDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.продажаDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.продажаDataSet.Заказы);

        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

        private void заказыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = false;
                }
            } 
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = true;
                }
            }
        }
    }
}
