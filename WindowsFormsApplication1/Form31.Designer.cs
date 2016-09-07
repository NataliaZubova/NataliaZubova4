namespace WindowsFormsApplication1
{
    partial class Form31
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label кодПокупLabel;
            System.Windows.Forms.Label кодТовараLabel;
            System.Windows.Forms.Label датаЗаказаLabel;
            System.Windows.Forms.Label заказаноLabel;
            System.Windows.Forms.Label датаПродLabel;
            System.Windows.Forms.Label проданоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form31));
            this.продажаDataSet = new WindowsFormsApplication1.ПродажаDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.TableAdapterManager();
            this.заказыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заказыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодПокупTextBox = new System.Windows.Forms.TextBox();
            this.кодТовараTextBox = new System.Windows.Forms.TextBox();
            this.датаЗаказаTextBox = new System.Windows.Forms.TextBox();
            this.заказаноTextBox = new System.Windows.Forms.TextBox();
            this.датаПродTextBox = new System.Windows.Forms.TextBox();
            this.проданоTextBox = new System.Windows.Forms.TextBox();
            this.заказыНаЗаданнуюДатуToolStrip = new System.Windows.Forms.ToolStrip();
            this.paramToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paramToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.заказыНаЗаданнуюДатуToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            кодПокупLabel = new System.Windows.Forms.Label();
            кодТовараLabel = new System.Windows.Forms.Label();
            датаЗаказаLabel = new System.Windows.Forms.Label();
            заказаноLabel = new System.Windows.Forms.Label();
            датаПродLabel = new System.Windows.Forms.Label();
            проданоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).BeginInit();
            this.заказыBindingNavigator.SuspendLayout();
            this.заказыНаЗаданнуюДатуToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодПокупLabel
            // 
            кодПокупLabel.AutoSize = true;
            кодПокупLabel.Location = new System.Drawing.Point(26, 127);
            кодПокупLabel.Name = "кодПокупLabel";
            кодПокупLabel.Size = new System.Drawing.Size(63, 13);
            кодПокупLabel.TabIndex = 1;
            кодПокупLabel.Text = "Код Покуп:";
            // 
            // кодТовараLabel
            // 
            кодТовараLabel.AutoSize = true;
            кодТовараLabel.Location = new System.Drawing.Point(26, 153);
            кодТовараLabel.Name = "кодТовараLabel";
            кодТовараLabel.Size = new System.Drawing.Size(69, 13);
            кодТовараLabel.TabIndex = 3;
            кодТовараLabel.Text = "Код Товара:";
            // 
            // датаЗаказаLabel
            // 
            датаЗаказаLabel.AutoSize = true;
            датаЗаказаLabel.Location = new System.Drawing.Point(26, 179);
            датаЗаказаLabel.Name = "датаЗаказаLabel";
            датаЗаказаLabel.Size = new System.Drawing.Size(76, 13);
            датаЗаказаLabel.TabIndex = 5;
            датаЗаказаLabel.Text = "Дата Заказа:";
            // 
            // заказаноLabel
            // 
            заказаноLabel.AutoSize = true;
            заказаноLabel.Location = new System.Drawing.Point(26, 205);
            заказаноLabel.Name = "заказаноLabel";
            заказаноLabel.Size = new System.Drawing.Size(59, 13);
            заказаноLabel.TabIndex = 7;
            заказаноLabel.Text = "Заказано:";
            // 
            // датаПродLabel
            // 
            датаПродLabel.AutoSize = true;
            датаПродLabel.Location = new System.Drawing.Point(26, 231);
            датаПродLabel.Name = "датаПродLabel";
            датаПродLabel.Size = new System.Drawing.Size(65, 13);
            датаПродLabel.TabIndex = 9;
            датаПродLabel.Text = "Дата Прод:";
            // 
            // проданоLabel
            // 
            проданоLabel.AutoSize = true;
            проданоLabel.Location = new System.Drawing.Point(26, 257);
            проданоLabel.Name = "проданоLabel";
            проданоLabel.Size = new System.Drawing.Size(54, 13);
            проданоLabel.TabIndex = 11;
            проданоLabel.Text = "Продано:";
            // 
            // продажаDataSet
            // 
            this.продажаDataSet.DataSetName = "ПродажаDataSet";
            this.продажаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.продажаDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ПродажаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.КомпанияTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // заказыBindingNavigator
            // 
            this.заказыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказыBindingNavigator.BindingSource = this.заказыBindingSource;
            this.заказыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заказыBindingNavigatorSaveItem});
            this.заказыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказыBindingNavigator.Name = "заказыBindingNavigator";
            this.заказыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказыBindingNavigator.Size = new System.Drawing.Size(670, 25);
            this.заказыBindingNavigator.TabIndex = 0;
            this.заказыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заказыBindingNavigatorSaveItem
            // 
            this.заказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыBindingNavigatorSaveItem.Image")));
            this.заказыBindingNavigatorSaveItem.Name = "заказыBindingNavigatorSaveItem";
            this.заказыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказыBindingNavigatorSaveItem_Click);
            // 
            // кодПокупTextBox
            // 
            this.кодПокупTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодПокуп", true));
            this.кодПокупTextBox.Location = new System.Drawing.Point(108, 124);
            this.кодПокупTextBox.Name = "кодПокупTextBox";
            this.кодПокупTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодПокупTextBox.TabIndex = 2;
            // 
            // кодТовараTextBox
            // 
            this.кодТовараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодТовара", true));
            this.кодТовараTextBox.Location = new System.Drawing.Point(108, 150);
            this.кодТовараTextBox.Name = "кодТовараTextBox";
            this.кодТовараTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодТовараTextBox.TabIndex = 4;
            // 
            // датаЗаказаTextBox
            // 
            this.датаЗаказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "ДатаЗаказа", true));
            this.датаЗаказаTextBox.Location = new System.Drawing.Point(108, 176);
            this.датаЗаказаTextBox.Name = "датаЗаказаTextBox";
            this.датаЗаказаTextBox.Size = new System.Drawing.Size(100, 20);
            this.датаЗаказаTextBox.TabIndex = 6;
            // 
            // заказаноTextBox
            // 
            this.заказаноTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Заказано", true));
            this.заказаноTextBox.Location = new System.Drawing.Point(108, 202);
            this.заказаноTextBox.Name = "заказаноTextBox";
            this.заказаноTextBox.Size = new System.Drawing.Size(100, 20);
            this.заказаноTextBox.TabIndex = 8;
            // 
            // датаПродTextBox
            // 
            this.датаПродTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "ДатаПрод", true));
            this.датаПродTextBox.Location = new System.Drawing.Point(108, 228);
            this.датаПродTextBox.Name = "датаПродTextBox";
            this.датаПродTextBox.Size = new System.Drawing.Size(100, 20);
            this.датаПродTextBox.TabIndex = 10;
            // 
            // проданоTextBox
            // 
            this.проданоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Продано", true));
            this.проданоTextBox.Location = new System.Drawing.Point(108, 254);
            this.проданоTextBox.Name = "проданоTextBox";
            this.проданоTextBox.Size = new System.Drawing.Size(100, 20);
            this.проданоTextBox.TabIndex = 12;
            // 
            // заказыНаЗаданнуюДатуToolStrip
            // 
            this.заказыНаЗаданнуюДатуToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramToolStripLabel,
            this.paramToolStripTextBox,
            this.заказыНаЗаданнуюДатуToolStripButton});
            this.заказыНаЗаданнуюДатуToolStrip.Location = new System.Drawing.Point(0, 25);
            this.заказыНаЗаданнуюДатуToolStrip.Name = "заказыНаЗаданнуюДатуToolStrip";
            this.заказыНаЗаданнуюДатуToolStrip.Size = new System.Drawing.Size(670, 25);
            this.заказыНаЗаданнуюДатуToolStrip.TabIndex = 13;
            this.заказыНаЗаданнуюДатуToolStrip.Text = "заказыНаЗаданнуюДатуToolStrip";
            // 
            // paramToolStripLabel
            // 
            this.paramToolStripLabel.Name = "paramToolStripLabel";
            this.paramToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.paramToolStripLabel.Text = "param:";
            // 
            // paramToolStripTextBox
            // 
            this.paramToolStripTextBox.Name = "paramToolStripTextBox";
            this.paramToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // заказыНаЗаданнуюДатуToolStripButton
            // 
            this.заказыНаЗаданнуюДатуToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.заказыНаЗаданнуюДатуToolStripButton.Name = "заказыНаЗаданнуюДатуToolStripButton";
            this.заказыНаЗаданнуюДатуToolStripButton.Size = new System.Drawing.Size(145, 22);
            this.заказыНаЗаданнуюДатуToolStripButton.Text = "ЗаказыНаЗаданнуюДату";
            this.заказыНаЗаданнуюДатуToolStripButton.Click += new System.EventHandler(this.заказыНаЗаданнуюДатуToolStripButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(350, 108);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 407);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.заказыНаЗаданнуюДатуToolStrip);
            this.Controls.Add(кодПокупLabel);
            this.Controls.Add(this.кодПокупTextBox);
            this.Controls.Add(кодТовараLabel);
            this.Controls.Add(this.кодТовараTextBox);
            this.Controls.Add(датаЗаказаLabel);
            this.Controls.Add(this.датаЗаказаTextBox);
            this.Controls.Add(заказаноLabel);
            this.Controls.Add(this.заказаноTextBox);
            this.Controls.Add(датаПродLabel);
            this.Controls.Add(this.датаПродTextBox);
            this.Controls.Add(проданоLabel);
            this.Controls.Add(this.проданоTextBox);
            this.Controls.Add(this.заказыBindingNavigator);
            this.Name = "Form31";
            this.Text = "Заказы на заданную дату";
            this.Load += new System.EventHandler(this.Form31_Load);
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).EndInit();
            this.заказыBindingNavigator.ResumeLayout(false);
            this.заказыBindingNavigator.PerformLayout();
            this.заказыНаЗаданнуюДатуToolStrip.ResumeLayout(false);
            this.заказыНаЗаданнуюДатуToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ПродажаDataSet продажаDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private ПродажаDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private ПродажаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заказыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодПокупTextBox;
        private System.Windows.Forms.TextBox кодТовараTextBox;
        private System.Windows.Forms.TextBox датаЗаказаTextBox;
        private System.Windows.Forms.TextBox заказаноTextBox;
        private System.Windows.Forms.TextBox датаПродTextBox;
        private System.Windows.Forms.TextBox проданоTextBox;
        private System.Windows.Forms.ToolStrip заказыНаЗаданнуюДатуToolStrip;
        private System.Windows.Forms.ToolStripLabel paramToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paramToolStripTextBox;
        private System.Windows.Forms.ToolStripButton заказыНаЗаданнуюДатуToolStripButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}