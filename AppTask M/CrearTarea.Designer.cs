namespace AppTask_M
{
    partial class CrearTarea
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbImport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxDescrip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtetiqueta = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.btnModi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aPPTASKDataSet = new AppTask_M.APPTASKDataSet();
            this.aPPTASKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAREASTableAdapter = new AppTask_M.APPTASKDataSetTableAdapters.TAREASTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTANCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTIQUETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLTIMAMODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 37);
            this.button3.TabIndex = 30;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(350, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Etiqueta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbImport
            // 
            this.cmbImport.FormattingEnabled = true;
            this.cmbImport.Items.AddRange(new object[] {
            "Baja",
            "Normal",
            "Alta"});
            this.cmbImport.Location = new System.Drawing.Point(108, 215);
            this.cmbImport.Name = "cmbImport";
            this.cmbImport.Size = new System.Drawing.Size(379, 21);
            this.cmbImport.TabIndex = 25;
            this.cmbImport.SelectedIndexChanged += new System.EventHandler(this.cmbImport_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Titulo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Importancia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Finalizacion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha de inicio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(108, 111);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(379, 20);
            this.txtTitulo.TabIndex = 18;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Crear/Modificar Tarea";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 192);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(379, 20);
            this.dateTimePicker2.TabIndex = 32;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(108, 166);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(375, 20);
            this.dateTimePicker3.TabIndex = 33;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Descripcion:";
            // 
            // txtboxDescrip
            // 
            this.txtboxDescrip.Location = new System.Drawing.Point(108, 140);
            this.txtboxDescrip.Name = "txtboxDescrip";
            this.txtboxDescrip.Size = new System.Drawing.Size(379, 20);
            this.txtboxDescrip.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Estado";
            // 
            // txtetiqueta
            // 
            this.txtetiqueta.Location = new System.Drawing.Point(108, 241);
            this.txtetiqueta.Name = "txtetiqueta";
            this.txtetiqueta.Size = new System.Drawing.Size(379, 20);
            this.txtetiqueta.TabIndex = 38;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Sin terminar",
            "Terminada"});
            this.comboBoxEstado.Location = new System.Drawing.Point(108, 270);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(379, 21);
            this.comboBoxEstado.TabIndex = 37;
            // 
            // btnModi
            // 
            this.btnModi.Location = new System.Drawing.Point(350, 321);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(123, 37);
            this.btnModi.TabIndex = 39;
            this.btnModi.Text = "Modificar";
            this.btnModi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSUARIODataGridViewTextBoxColumn,
            this.tITULODataGridViewTextBoxColumn,
            this.iMPORTANCIADataGridViewTextBoxColumn,
            this.eTIQUETADataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.fECHAINDataGridViewTextBoxColumn,
            this.fECHAFINDataGridViewTextBoxColumn,
            this.uLTIMAMODDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tAREASBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(515, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 315);
            this.dataGridView1.TabIndex = 40;
            // 
            // aPPTASKDataSet
            // 
            this.aPPTASKDataSet.DataSetName = "APPTASKDataSet";
            this.aPPTASKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPTASKDataSetBindingSource
            // 
            this.aPPTASKDataSetBindingSource.DataSource = this.aPPTASKDataSet;
            this.aPPTASKDataSetBindingSource.Position = 0;
            // 
            // tAREASBindingSource
            // 
            this.tAREASBindingSource.DataMember = "TAREAS";
            this.tAREASBindingSource.DataSource = this.aPPTASKDataSetBindingSource;
            // 
            // tAREASTableAdapter
            // 
            this.tAREASTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1091, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 44;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(982, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Buscar";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(955, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "ID: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(985, 75);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 43;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_TAREA";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_TAREA";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            // 
            // tITULODataGridViewTextBoxColumn
            // 
            this.tITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO";
            this.tITULODataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tITULODataGridViewTextBoxColumn.Name = "tITULODataGridViewTextBoxColumn";
            // 
            // iMPORTANCIADataGridViewTextBoxColumn
            // 
            this.iMPORTANCIADataGridViewTextBoxColumn.DataPropertyName = "IMPORTANCIA";
            this.iMPORTANCIADataGridViewTextBoxColumn.HeaderText = "Importancia";
            this.iMPORTANCIADataGridViewTextBoxColumn.Name = "iMPORTANCIADataGridViewTextBoxColumn";
            // 
            // eTIQUETADataGridViewTextBoxColumn
            // 
            this.eTIQUETADataGridViewTextBoxColumn.DataPropertyName = "ETIQUETA";
            this.eTIQUETADataGridViewTextBoxColumn.HeaderText = "Etiqueta";
            this.eTIQUETADataGridViewTextBoxColumn.Name = "eTIQUETADataGridViewTextBoxColumn";
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // fECHAINDataGridViewTextBoxColumn
            // 
            this.fECHAINDataGridViewTextBoxColumn.DataPropertyName = "FECHAIN";
            this.fECHAINDataGridViewTextBoxColumn.HeaderText = "Fecha inicio";
            this.fECHAINDataGridViewTextBoxColumn.Name = "fECHAINDataGridViewTextBoxColumn";
            // 
            // fECHAFINDataGridViewTextBoxColumn
            // 
            this.fECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHAFIN";
            this.fECHAFINDataGridViewTextBoxColumn.HeaderText = "Fecha finalizacion";
            this.fECHAFINDataGridViewTextBoxColumn.Name = "fECHAFINDataGridViewTextBoxColumn";
            // 
            // uLTIMAMODDataGridViewTextBoxColumn
            // 
            this.uLTIMAMODDataGridViewTextBoxColumn.DataPropertyName = "ULTIMAMOD";
            this.uLTIMAMODDataGridViewTextBoxColumn.HeaderText = "Ultima modificacion";
            this.uLTIMAMODDataGridViewTextBoxColumn.Name = "uLTIMAMODDataGridViewTextBoxColumn";
            // 
            // CrearTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 696);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.txtetiqueta);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxDescrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbImport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Name = "CrearTarea";
            this.Text = "CrearTareas";
            this.Load += new System.EventHandler(this.CrearTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbImport;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtboxDescrip;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtetiqueta;
        public System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aPPTASKDataSetBindingSource;
        private APPTASKDataSet aPPTASKDataSet;
        private System.Windows.Forms.BindingSource tAREASBindingSource;
        private APPTASKDataSetTableAdapters.TAREASTableAdapter tAREASTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTANCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTIQUETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLTIMAMODDataGridViewTextBoxColumn;
    }
}