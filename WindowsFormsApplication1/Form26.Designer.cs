namespace WindowsFormsApplication1
{
    partial class Form26
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label индексLabel;
            System.Windows.Forms.Label странаLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label областьLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label предпрLabel;
            System.Windows.Forms.Label кредитLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            this.продажаDataSet = new WindowsFormsApplication1.ПродажаDataSet();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиTableAdapter = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.ПокупателиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ПродажаDataSetTableAdapters.TableAdapterManager();
            this.покупателиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.покупателиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодПокупTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.индексTextBox = new System.Windows.Forms.TextBox();
            this.странаTextBox = new System.Windows.Forms.TextBox();
            this.городTextBox = new System.Windows.Forms.TextBox();
            this.областьTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.предпрTextBox = new System.Windows.Forms.TextBox();
            this.кредитCheckBox = new System.Windows.Forms.CheckBox();
            кодПокупLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            индексLabel = new System.Windows.Forms.Label();
            странаLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            областьLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            предпрLabel = new System.Windows.Forms.Label();
            кредитLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingNavigator)).BeginInit();
            this.покупателиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодПокупLabel
            // 
            кодПокупLabel.AutoSize = true;
            кодПокупLabel.Location = new System.Drawing.Point(12, 47);
            кодПокупLabel.Name = "кодПокупLabel";
            кодПокупLabel.Size = new System.Drawing.Size(63, 13);
            кодПокупLabel.TabIndex = 1;
            кодПокупLabel.Text = "Код Покуп:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(12, 73);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(12, 99);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(12, 125);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 151);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 9;
            телефонLabel.Text = "Телефон:";
            // 
            // индексLabel
            // 
            индексLabel.AutoSize = true;
            индексLabel.Location = new System.Drawing.Point(12, 177);
            индексLabel.Name = "индексLabel";
            индексLabel.Size = new System.Drawing.Size(48, 13);
            индексLabel.TabIndex = 11;
            индексLabel.Text = "Индекс:";
            // 
            // странаLabel
            // 
            странаLabel.AutoSize = true;
            странаLabel.Location = new System.Drawing.Point(12, 203);
            странаLabel.Name = "странаLabel";
            странаLabel.Size = new System.Drawing.Size(46, 13);
            странаLabel.TabIndex = 13;
            странаLabel.Text = "Страна:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.Location = new System.Drawing.Point(12, 229);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(40, 13);
            городLabel.TabIndex = 15;
            городLabel.Text = "Город:";
            // 
            // областьLabel
            // 
            областьLabel.AutoSize = true;
            областьLabel.Location = new System.Drawing.Point(12, 255);
            областьLabel.Name = "областьLabel";
            областьLabel.Size = new System.Drawing.Size(53, 13);
            областьLabel.TabIndex = 17;
            областьLabel.Text = "Область:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(12, 281);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 19;
            адресLabel.Text = "Адрес:";
            // 
            // предпрLabel
            // 
            предпрLabel.AutoSize = true;
            предпрLabel.Location = new System.Drawing.Point(12, 307);
            предпрLabel.Name = "предпрLabel";
            предпрLabel.Size = new System.Drawing.Size(48, 13);
            предпрLabel.TabIndex = 21;
            предпрLabel.Text = "Предпр:";
            // 
            // кредитLabel
            // 
            кредитLabel.AutoSize = true;
            кредитLabel.Location = new System.Drawing.Point(12, 335);
            кредитLabel.Name = "кредитLabel";
            кредитLabel.Size = new System.Drawing.Size(46, 13);
            кредитLabel.TabIndex = 23;
            кредитLabel.Text = "Кредит:";
            // 
            // продажаDataSet
            // 
            this.продажаDataSet.DataSetName = "ПродажаDataSet";
            this.продажаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ПродажаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КомпанияTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = this.покупателиTableAdapter;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // покупателиBindingNavigator
            // 
            this.покупателиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.покупателиBindingNavigator.BindingSource = this.покупателиBindingSource;
            this.покупателиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.покупателиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.покупателиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.покупателиBindingNavigatorSaveItem});
            this.покупателиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.покупателиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.покупателиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.покупателиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.покупателиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.покупателиBindingNavigator.Name = "покупателиBindingNavigator";
            this.покупателиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.покупателиBindingNavigator.Size = new System.Drawing.Size(462, 25);
            this.покупателиBindingNavigator.TabIndex = 0;
            this.покупателиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // покупателиBindingNavigatorSaveItem
            // 
            this.покупателиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.покупателиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("покупателиBindingNavigatorSaveItem.Image")));
            this.покупателиBindingNavigatorSaveItem.Name = "покупателиBindingNavigatorSaveItem";
            this.покупателиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.покупателиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.покупателиBindingNavigatorSaveItem.Click += new System.EventHandler(this.покупателиBindingNavigatorSaveItem_Click_1);
            // 
            // кодПокупTextBox
            // 
            this.кодПокупTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "КодПокуп", true));
            this.кодПокупTextBox.Enabled = false;
            this.кодПокупTextBox.Location = new System.Drawing.Point(81, 44);
            this.кодПокупTextBox.Name = "кодПокупTextBox";
            this.кодПокупTextBox.Size = new System.Drawing.Size(104, 20);
            this.кодПокупTextBox.TabIndex = 2;
            this.кодПокупTextBox.TextChanged += new System.EventHandler(this.кодПокупTextBox_TextChanged);
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Фамилия", true));
            this.фамилияTextBox.Enabled = false;
            this.фамилияTextBox.Location = new System.Drawing.Point(81, 70);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(104, 20);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Имя", true));
            this.имяTextBox.Enabled = false;
            this.имяTextBox.Location = new System.Drawing.Point(81, 96);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(104, 20);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Отчество", true));
            this.отчествоTextBox.Enabled = false;
            this.отчествоTextBox.Location = new System.Drawing.Point(81, 122);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(104, 20);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Телефон", true));
            this.телефонTextBox.Enabled = false;
            this.телефонTextBox.Location = new System.Drawing.Point(81, 148);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(104, 20);
            this.телефонTextBox.TabIndex = 10;
            // 
            // индексTextBox
            // 
            this.индексTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Индекс", true));
            this.индексTextBox.Enabled = false;
            this.индексTextBox.Location = new System.Drawing.Point(81, 174);
            this.индексTextBox.Name = "индексTextBox";
            this.индексTextBox.Size = new System.Drawing.Size(104, 20);
            this.индексTextBox.TabIndex = 12;
            // 
            // странаTextBox
            // 
            this.странаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Страна", true));
            this.странаTextBox.Enabled = false;
            this.странаTextBox.Location = new System.Drawing.Point(81, 200);
            this.странаTextBox.Name = "странаTextBox";
            this.странаTextBox.Size = new System.Drawing.Size(104, 20);
            this.странаTextBox.TabIndex = 14;
            // 
            // городTextBox
            // 
            this.городTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Город", true));
            this.городTextBox.Enabled = false;
            this.городTextBox.Location = new System.Drawing.Point(81, 226);
            this.городTextBox.Name = "городTextBox";
            this.городTextBox.Size = new System.Drawing.Size(104, 20);
            this.городTextBox.TabIndex = 16;
            // 
            // областьTextBox
            // 
            this.областьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Область", true));
            this.областьTextBox.Enabled = false;
            this.областьTextBox.Location = new System.Drawing.Point(81, 252);
            this.областьTextBox.Name = "областьTextBox";
            this.областьTextBox.Size = new System.Drawing.Size(104, 20);
            this.областьTextBox.TabIndex = 18;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Адрес", true));
            this.адресTextBox.Enabled = false;
            this.адресTextBox.Location = new System.Drawing.Point(81, 278);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(104, 20);
            this.адресTextBox.TabIndex = 20;
            // 
            // предпрTextBox
            // 
            this.предпрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Предпр", true));
            this.предпрTextBox.Enabled = false;
            this.предпрTextBox.Location = new System.Drawing.Point(81, 304);
            this.предпрTextBox.Name = "предпрTextBox";
            this.предпрTextBox.Size = new System.Drawing.Size(104, 20);
            this.предпрTextBox.TabIndex = 22;
            // 
            // кредитCheckBox
            // 
            this.кредитCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.покупателиBindingSource, "Кредит", true));
            this.кредитCheckBox.Location = new System.Drawing.Point(81, 330);
            this.кредитCheckBox.Name = "кредитCheckBox";
            this.кредитCheckBox.Size = new System.Drawing.Size(104, 24);
            this.кредитCheckBox.TabIndex = 24;
            this.кредитCheckBox.Text = "checkBox1";
            this.кредитCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 463);
            this.Controls.Add(кодПокупLabel);
            this.Controls.Add(this.кодПокупTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(индексLabel);
            this.Controls.Add(this.индексTextBox);
            this.Controls.Add(странаLabel);
            this.Controls.Add(this.странаTextBox);
            this.Controls.Add(городLabel);
            this.Controls.Add(this.городTextBox);
            this.Controls.Add(областьLabel);
            this.Controls.Add(this.областьTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(предпрLabel);
            this.Controls.Add(this.предпрTextBox);
            this.Controls.Add(кредитLabel);
            this.Controls.Add(this.кредитCheckBox);
            this.Controls.Add(this.покупателиBindingNavigator);
            this.Name = "Form26";
            this.Text = "Ввод покупателей";
            this.Activated += new System.EventHandler(this.Form26_Load);
            this.Load += new System.EventHandler(this.Form26_Load);
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingNavigator)).EndInit();
            this.покупателиBindingNavigator.ResumeLayout(false);
            this.покупателиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ПродажаDataSet продажаDataSet;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private ПродажаDataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private ПродажаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator покупателиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton покупателиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодПокупTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox индексTextBox;
        private System.Windows.Forms.TextBox странаTextBox;
        private System.Windows.Forms.TextBox городTextBox;
        private System.Windows.Forms.TextBox областьTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox предпрTextBox;
        private System.Windows.Forms.CheckBox кредитCheckBox;

    }
}