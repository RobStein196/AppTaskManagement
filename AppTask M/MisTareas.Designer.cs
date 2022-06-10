namespace AppTask_M
{
    partial class MisTareas
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
            this.tAREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPTASKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPTASKDataSet = new AppTask_M.APPTASKDataSet();
            this.tAREASTableAdapter = new AppTask_M.APPTASKDataSetTableAdapters.TAREASTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTANCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTIQUETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tAREASBindingSource
            // 
            this.tAREASBindingSource.DataMember = "TAREAS";
            this.tAREASBindingSource.DataSource = this.aPPTASKDataSetBindingSource;
            // 
            // aPPTASKDataSetBindingSource
            // 
            this.aPPTASKDataSetBindingSource.DataSource = this.aPPTASKDataSet;
            this.aPPTASKDataSetBindingSource.Position = 0;
            // 
            // aPPTASKDataSet
            // 
            this.aPPTASKDataSet.DataSetName = "APPTASKDataSet";
            this.aPPTASKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAREASTableAdapter
            // 
            this.tAREASTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppTask_M.Properties.Resources.icons8_calendario_64;
            this.pictureBox2.Location = new System.Drawing.Point(1056, 67);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tITULODataGridViewTextBoxColumn,
            this.iMPORTANCIADataGridViewTextBoxColumn,
            this.eTIQUETADataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.fECHAINDataGridViewTextBoxColumn,
            this.fECHAFINDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tAREASBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(194, 181);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 273);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_TAREA";
            this.Column1.HeaderText = "ID_Tarea";
            this.Column1.Name = "Column1";
            // 
            // tITULODataGridViewTextBoxColumn
            // 
            this.tITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO";
            this.tITULODataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tITULODataGridViewTextBoxColumn.Name = "tITULODataGridViewTextBoxColumn";
            this.tITULODataGridViewTextBoxColumn.Width = 90;
            // 
            // iMPORTANCIADataGridViewTextBoxColumn
            // 
            this.iMPORTANCIADataGridViewTextBoxColumn.DataPropertyName = "IMPORTANCIA";
            this.iMPORTANCIADataGridViewTextBoxColumn.HeaderText = "Importacia";
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
            this.fECHAINDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.fECHAINDataGridViewTextBoxColumn.Name = "fECHAINDataGridViewTextBoxColumn";
            // 
            // fECHAFINDataGridViewTextBoxColumn
            // 
            this.fECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHAFIN";
            this.fECHAFINDataGridViewTextBoxColumn.HeaderText = "Fecha Finalizacion";
            this.fECHAFINDataGridViewTextBoxColumn.Name = "fECHAFINDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTask_M.Properties.Resources._2124275_document_essential_app_check_icon;
            this.pictureBox1.Location = new System.Drawing.Point(267, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tareas pendientes";
            // 
            // datePick
            // 
            this.datePick.CustomFormat = "dd/MM/yyyy";
            this.datePick.Location = new System.Drawing.Point(837, 80);
            this.datePick.Margin = new System.Windows.Forms.Padding(2);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(172, 20);
            this.datePick.TabIndex = 10;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // MisTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 625);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisTareas";
            this.Text = "MisTareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MisTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource aPPTASKDataSetBindingSource;
        private APPTASKDataSet aPPTASKDataSet;
        private System.Windows.Forms.BindingSource tAREASBindingSource;
        private APPTASKDataSetTableAdapters.TAREASTableAdapter tAREASTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTANCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTIQUETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker datePick;
    }
}