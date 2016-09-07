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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            dataSet181.Clear();
            sqlDataAdapter1.Fill(dataSet181.Покупатели);
        }
        private void Form18_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSet181.Покупатели);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dataSet181, "покупатели"].Position = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet181, "покупатели"].Position -= 1;
            button3.Enabled = true;
            button4.Enabled = true;
            if (this.BindingContext[dataSet181, "покупатели"].Position == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet181, "покупатели"].Position += 1;
            button1.Enabled = true;
            button2.Enabled = true;
            if (this.BindingContext[dataSet181, "покупатели"].Position == this.BindingContext[dataSet181, "покупатели"].Count - 1)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet181, "покупатели"].Position =
            this.BindingContext[dataSet181, "покупатели"].Count - 1;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            if (this.BindingContext[dataSet181, "покупатели"].Position ==
            this.BindingContext[dataSet181, "покупатели"].Count - 1)
                button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet181, "покупатели"].EndCurrentEdit();
            this.BindingContext[dataSet181, "покупатели"].AddNew();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[dataSet181, "покупатели"].Count > 0)
            {
                this.BindingContext[dataSet181, "покупатели"].RemoveAt(this.BindingContext[dataSet181, "покупатели"].Position);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {            
            try
            {
                this.BindingContext[dataSet181, "покупатели"].EndCurrentEdit();
                sqlDataAdapter1.Update(dataSet181.Покупатели);
            }
            catch (System.Data.SqlClient.SqlException s3)
            {
                if (s3.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Редактирование записей невозможно. В таблице Заказы именются связанные записи, код клиента должен быть уникальным", "Ошибка", MessageBoxButtons.OK);
                    dataSet181.Clear();
                    sqlDataAdapter1.Fill(dataSet181, "покупатели");
                }
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("Поле Предприятие и Кредит не может содержать  значение Null", "Ошибка", MessageBoxButtons.OK);
                dataSet181.Clear();
                sqlDataAdapter1.Fill(dataSet181, "покупатели");
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet181, "покупатели"].CancelCurrentEdit();
        }
    }
}
