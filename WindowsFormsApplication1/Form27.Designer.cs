namespace WindowsFormsApplication1
{
    partial class Form27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form27));
            System.Windows.Forms.Label кодПокупLabel;
            System.Windows.Forms.Label кодТовараLabel;
            System.Windows.Forms.Label датаЗаказаLabel;
            System.Windows.Forms.Label заказаноLabel;
            System.Windows.Forms.Label датаПродLabel;
            System.Windows.Forms.Label проданоLabel;
            this.продажаDataSet = new WindowsFormsApplication1.ПродажаDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.TableAdapterManager();
            this.заказыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.заказыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодПокупComboBox = new System.Windows.Forms.ComboBox();
            this.кодТовараComboBox = new System.Windows.Forms.ComboBox();
            this.датаЗаказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.заказаноTextBox = new System.Windows.Forms.TextBox();
            this.датаПродDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.проданоTextBox = new System.Windows.Forms.TextBox();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиTableAdapter = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.ПокупателиTableAdapter();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.ТоварыTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.ПокупателиTableAdapter = this.покупателиTableAdapter;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
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
            this.заказыBindingNavigator.Size = new System.Drawing.Size(487, 25);
            this.заказыBindingNavigator.TabIndex = 0;
            this.заказыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // заказыBindingNavigatorSaveItem
            // 
            this.заказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыBindingNavigatorSaveItem.Image")));
            this.заказыBindingNavigatorSaveItem.Name = "заказыBindingNavigatorSaveItem";
            this.заказыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказыBindingNavigatorSaveItem_Click_1);
            // 
            // кодПокупLabel
            // 
            кодПокупLabel.AutoSize = true;
            кодПокупLabel.Location = new System.Drawing.Point(93, 57);
            кодПокупLabel.Name = "кодПокупLabel";
            кодПокупLabel.Size = new System.Drawing.Size(63, 13);
            кодПокупLabel.TabIndex = 1;
            кодПокупLabel.Text = "Код Покуп:";
            // 
            // кодПокупComboBox
            // 
            this.кодПокупComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заказыBindingSource, "КодПокуп", true));
            this.кодПокупComboBox.DataSource = this.покупателиBindingSource;
            this.кодПокупComboBox.DisplayMember = "Фамилия";
            this.кодПокупComboBox.Enabled = false;
            this.кодПокупComboBox.FormattingEnabled = true;
            this.кодПокупComboBox.Location = new System.Drawing.Point(175, 54);
            this.кодПокупComboBox.Name = "кодПокупComboBox";
            this.кодПокупComboBox.Size = new System.Drawing.Size(200, 21);
            this.кодПокупComboBox.TabIndex = 2;
            this.кодПокупComboBox.ValueMember = "КодПокуп";
            // 
            // кодТовараLabel
            // 
            кодТовараLabel.AutoSize = true;
            кодТовараLabel.Location = new System.Drawing.Point(93, 84);
            кодТовараLabel.Name = "кодТовараLabel";
            кодТовараLabel.Size = new System.Drawing.Size(69, 13);
            кодТовараLabel.TabIndex = 3;
            кодТовараLabel.Text = "Код Товара:";
            // 
            // кодТовараComboBox
            // 
            this.кодТовараComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заказыBindingSource, "КодТовара", true));
            this.кодТовараComboBox.DataSource = this.товарыBindingSource;
            this.кодТовараComboBox.DisplayMember = "НаимТов";
            this.кодТовараComboBox.Enabled = false;
            this.кодТовараComboBox.FormattingEnabled = true;
            this.кодТовараComboBox.Location = new System.Drawing.Point(175, 81);
            this.кодТовараComboBox.Name = "кодТовараComboBox";
            this.кодТовараComboBox.Size = new System.Drawing.Size(200, 21);
            this.кодТовараComboBox.TabIndex = 4;
            this.кодТовараComboBox.ValueMember = "КодТовара";
            // 
            // датаЗаказаLabel
            // 
            датаЗаказаLabel.AutoSize = true;
            датаЗаказаLabel.Location = new System.Drawing.Point(93, 112);
            датаЗаказаLabel.Name = "датаЗаказаLabel";
            датаЗаказаLabel.Size = new System.Drawing.Size(76, 13);
            датаЗаказаLabel.TabIndex = 5;
            датаЗаказаLabel.Text = "Дата Заказа:";
            // 
            // датаЗаказаDateTimePicker
            // 
            this.датаЗаказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "ДатаЗаказа", true));
            this.датаЗаказаDateTimePicker.Enabled = false;
            this.датаЗаказаDateTimePicker.Location = new System.Drawing.Point(175, 108);
            this.датаЗаказаDateTimePicker.Name = "датаЗаказаDateTimePicker";
            this.датаЗаказаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаЗаказаDateTimePicker.TabIndex = 6;
            // 
            // заказаноLabel
            // 
            заказаноLabel.AutoSize = true;
            заказаноLabel.Location = new System.Drawing.Point(93, 137);
            заказаноLabel.Name = "заказаноLabel";
            заказаноLabel.Size = new System.Drawing.Size(59, 13);
            заказаноLabel.TabIndex = 7;
            заказаноLabel.Text = "Заказано:";
            // 
            // заказаноTextBox
            // 
            this.заказаноTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Заказано", true));
            this.заказаноTextBox.Enabled = false;
            this.заказаноTextBox.Location = new System.Drawing.Point(175, 134);
            this.заказаноTextBox.Name = "заказаноTextBox";
            this.заказаноTextBox.Size = new System.Drawing.Size(200, 20);
            this.заказаноTextBox.TabIndex = 8;
            // 
            // датаПродLabel
            // 
            датаПродLabel.AutoSize = true;
            датаПродLabel.Location = new System.Drawing.Point(93, 164);
            датаПродLabel.Name = "датаПродLabel";
            датаПродLabel.Size = new System.Drawing.Size(65, 13);
            датаПродLabel.TabIndex = 9;
            датаПродLabel.Text = "Дата Прод:";
            // 
            // датаПродDateTimePicker
            // 
            this.датаПродDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "ДатаПрод", true));
            this.датаПродDateTimePicker.Enabled = false;
            this.датаПродDateTimePicker.Location = new System.Drawing.Point(175, 160);
            this.датаПродDateTimePicker.Name = "датаПродDateTimePicker";
            this.датаПродDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаПродDateTimePicker.TabIndex = 10;
            // 
            // проданоLabel
            // 
            проданоLabel.AutoSize = true;
            проданоLabel.Location = new System.Drawing.Point(93, 189);
            проданоLabel.Name = "проданоLabel";
            проданоLabel.Size = new System.Drawing.Size(54, 13);
            проданоLabel.TabIndex = 11;
            проданоLabel.Text = "Продано:";
            // 
            // проданоTextBox
            // 
            this.проданоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Продано", true));
            this.проданоTextBox.Enabled = false;
            this.проданоTextBox.Location = new System.Drawing.Point(175, 186);
            this.проданоTextBox.Name = "проданоTextBox";
            this.проданоTextBox.Size = new System.Drawing.Size(200, 20);
            this.проданоTextBox.TabIndex = 12;
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.продажаDataSet;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.продажаDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // Form27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 318);
            this.Controls.Add(кодПокупLabel);
            this.Controls.Add(this.кодПокупComboBox);
            this.Controls.Add(кодТовараLabel);
            this.Controls.Add(this.кодТовараComboBox);
            this.Controls.Add(датаЗаказаLabel);
            this.Controls.Add(this.датаЗаказаDateTimePicker);
            this.Controls.Add(заказаноLabel);
            this.Controls.Add(this.заказаноTextBox);
            this.Controls.Add(датаПродLabel);
            this.Controls.Add(this.датаПродDateTimePicker);
            this.Controls.Add(проданоLabel);
            this.Controls.Add(this.проданоTextBox);
            this.Controls.Add(this.заказыBindingNavigator);
            this.Name = "Form27";
            this.Text = "Заказы";
            this.Activated += new System.EventHandler(this.Form27_Load);
            this.Load += new System.EventHandler(this.Form27_Load);
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).EndInit();
            this.заказыBindingNavigator.ResumeLayout(false);
            this.заказыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox кодПокупComboBox;
        private System.Windows.Forms.ComboBox кодТовараComboBox;
        private System.Windows.Forms.DateTimePicker датаЗаказаDateTimePicker;
        private System.Windows.Forms.TextBox заказаноTextBox;
        private System.Windows.Forms.DateTimePicker датаПродDateTimePicker;
        private System.Windows.Forms.TextBox проданоTextBox;
        private ПродажаDataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private ПродажаDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.BindingSource товарыBindingSource;

    }
}