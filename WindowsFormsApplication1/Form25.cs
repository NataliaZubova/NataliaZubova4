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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.продажаDataSet.Товары);

        }
        private void Form25_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            товарыDataGridView.ReadOnly = true;
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);
            товарыDataGridView.ReadOnly = true;
            try
            {
                this.Validate();
                this.товарыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.продажаDataSet);
            }
            catch (System.Data.NoNullAllowedException)
            {
                this.Show();
                MessageBox.Show("Поле Наименование товара не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                this.товарыTableAdapter.Fill(this.продажаDataSet.Товары);
            }
            catch (System.Data.ConstraintException)
            {
                this.Show();
                MessageBox.Show("Предпринята попытка вставить уже имеющийся товар", "Ошибка", MessageBoxButtons.OK);
                this.товарыTableAdapter.Fill(this.продажаDataSet.Товары);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    this.Show();
                    MessageBox.Show("Уделение записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    this.товарыTableAdapter.Fill(this.продажаDataSet.Товары);
                }
            }
        }

        private void товарыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            товарыDataGridView.ReadOnly = false;
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
            товарыDataGridView.ReadOnly = true;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is Label || ctl is CheckBox || ctl is ComboBox || ctl is DateTimePicker)
                {
                    ctl.Enabled = true;
                }
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            товарыDataGridView.ReadOnly = true;
}

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            товарыDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            товарыDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            товарыDataGridView.ReadOnly = true;
        }

        private void товарыBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        
    }
}
