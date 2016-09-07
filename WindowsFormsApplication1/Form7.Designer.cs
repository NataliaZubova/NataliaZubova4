namespace WindowsFormsApplication1
{
    partial class Form7
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
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet61 = new WindowsFormsApplication1.DataSet6();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataSet61BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet61BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Заказы.*\r\nFROM            Заказы";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Заказы", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("КодПокуп", "КодПокуп"),
                        new System.Data.Common.DataColumnMapping("КодТовара", "КодТовара"),
                        new System.Data.Common.DataColumnMapping("ДатаЗаказа", "ДатаЗаказа"),
                        new System.Data.Common.DataColumnMapping("Заказано", "Заказано"),
                        new System.Data.Common.DataColumnMapping("ДатаПрод", "ДатаПрод"),
                        new System.Data.Common.DataColumnMapping("Продано", "Продано")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=h7aqig8y1f.database.windows.net,1433;Initial Catalog=Продажа;Persist " +
    "Security Info=True;User ID=lele;Password=Qwerty123";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        Товары.*\r\nFROM            Товары";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Товары", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("КодТовара", "КодТовара"),
                        new System.Data.Common.DataColumnMapping("Категория", "Категория"),
                        new System.Data.Common.DataColumnMapping("НаимТов", "НаимТов"),
                        new System.Data.Common.DataColumnMapping("Цена", "Цена")})});
            // 
            // dataSet61
            // 
            this.dataSet61.DataSetName = "DataSet6";
            this.dataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.dataSet61BindingSource;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(13, 13);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(554, 517);
            this.dataGrid1.TabIndex = 0;
            // 
            // dataSet61BindingSource
            // 
            this.dataSet61BindingSource.DataSource = this.dataSet61;
            this.dataSet61BindingSource.Position = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 542);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Form7";
            this.Text = "Товары и заказы";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet61BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private DataSet6 dataSet61;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.BindingSource dataSet61BindingSource;
    }
}