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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            dataSet171.Clear();
            sqlDataAdapter1.Fill(dataSet171.Компания);
        }
        private void Form17_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSet171.Компания);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Сохранить_Click(object sender, EventArgs e)
        {
           
            try
            {
                компанияBindingSource.EndEdit();
                sqlDataAdapter1.Update(dataSet171.Компания);
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие не может содержать пустое значение", "Ошибка", MessageBoxButtons.OK);
                dataSet171.Clear();
                sqlDataAdapter1.Fill(dataSet171.Компания);
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Предпринята попытка вставить уже имеющееся предприятие", "Ошибка", MessageBoxButtons.OK);
                dataSet171.Clear();
                sqlDataAdapter1.Fill(dataSet171.Компания);
            }
            catch (System.Data.SqlClient.SqlException s1)
            {
                if (s1.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Удaление записей невозможно. В таблице Заказы имеются связанные записи", "Ошибка", MessageBoxButtons.OK);
                    dataSet171.Clear();
                    sqlDataAdapter1.Fill(dataSet171.Компания);
                }
            }

        }
    }
}
