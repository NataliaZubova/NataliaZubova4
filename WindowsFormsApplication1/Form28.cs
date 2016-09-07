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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "продажаDataSet.Компания". При необходимости она может быть перемещена или удалена.
            this.компанияTableAdapter.Fill(this.продажаDataSet.Компания);

        }
        private void Form28_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void компанияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            компанияDataGridView.ReadOnly = true;
            this.Validate();
            this.компанияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            компанияDataGridView.ReadOnly = true;
            this.Validate();
            this.компанияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            компанияDataGridView.ReadOnly = false;
            this.Validate();
            this.компанияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.продажаDataSet);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            компанияDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            компанияDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            компанияDataGridView.ReadOnly = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            компанияDataGridView.ReadOnly = true;
        }
    }
}
