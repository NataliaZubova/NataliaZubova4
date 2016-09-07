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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void компанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void покупательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }

        private void покупателиИЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();
        }

        private void товарыИЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7();
            f7.Show();
        }

        private void компанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f8 = new Form8();
            f8.Show();
        }

        private void товарыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f9 = new Form9();
            f9.Show();
        }

        private void заказыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f10 = new Form10();
            f10.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void предприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form11();
            f10.Show();
        }

        private void товарыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form f10 = new Form12();
            f10.Show();
        }

        private void десятьСамыхДорогихТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form13();
            f10.Show();
        }

        private void заказыПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form14();
            f10.Show();
        }

        private void заказыТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form15();
            f10.Show();
        }

        private void товарыToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form f10 = new Form16();
            f10.Show();
        }

        private void компанияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f10 = new Form17();
            f10.Show();
        }

        private void покупательToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f10 = new Form18();
            f10.Show();
        }

        private void заказыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form f10 = new Form19();
            f10.Show();
        }

        private void заказыПокупателяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f10 = new Form20();
            f10.Show();
        }

        private void продажиТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form21();
            f10.Show();
        }

        private void выборЗаказовПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form22();
            f10.Show();
        }

        private void выборЗаказовПоОбъемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form23();
            f10.Show();
        }

        private void выборЗаказовПоДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form24();
            f10.Show();
        }

        private void регистрацияТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form25();
            f10.Show();
            f10.MdiParent = this;

        }

        private void вводПокупателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form26();
            f10.MdiParent = this; 
            f10.Show();
        }

        private void заказыToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form f10 = new Form27();
            f10.MdiParent = this;
            f10.Show();
        }

        private void компанииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f10 = new Form28();
            f10.MdiParent = this;
            f10.Show();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void заказыПокупателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form29();
            f10.MdiParent = this;
            f10.Show();
        }

        private void заказыТовараToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form f10 = new Form30();
            f10.MdiParent = this;
            f10.Show();
        }

        private void заказыНаЗаданнуюДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f10 = new Form31();
            f10.MdiParent = this; 
            f10.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void мозаикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void поВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void поГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void каскадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }


    }

}
