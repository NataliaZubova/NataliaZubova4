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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.продажаDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.продажаDataSet.Покупатели);

        }
        private void Form26_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void покупателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

        private void покупателиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.покупателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);
                        foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox)
                {
                    ctl.Enabled = false;
                }
            }
                        this.Validate();
                        this.покупателиBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

        private void кодПокупTextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
