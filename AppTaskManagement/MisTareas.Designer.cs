
namespace AppTaskManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tAREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPTASKDataSet = new AppTaskManagement.APPTASKDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tAREASTableAdapter = new AppTaskManagement.APPTASKDataSetTableAdapters.TAREASTableAdapter();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.iDTAREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTIQUETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLTIMAMODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPORTANCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tareas pendientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTAREADataGridViewTextBoxColumn,
            this.tITULODataGridViewTextBoxColumn,
            this.eTIQUETADataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.fECHAINDataGridViewTextBoxColumn,
            this.fECHAFINDataGridViewTextBoxColumn,
            this.uLTIMAMODDataGridViewTextBoxColumn,
            this.iMPORTANCIADataGridViewTextBoxColumn,
            this.iDUSUARIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tAREASBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 427);
            this.dataGridView1.TabIndex = 3;
            // 
            // tAREASBindingSource
            // 
            this.tAREASBindingSource.DataMember = "TAREAS";
            this.tAREASBindingSource.DataSource = this.aPPTASKDataSet;
            // 
            // aPPTASKDataSet
            // 
            this.aPPTASKDataSet.DataSetName = "APPTASKDataSet";
            this.aPPTASKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppTaskManagement.Properties.Resources.icons8_calendario_64;
            this.pictureBox2.Location = new System.Drawing.Point(887, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTaskManagement.Properties.Resources._2124275_document_essential_app_check_icon;
            this.pictureBox1.Location = new System.Drawing.Point(450, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tAREASTableAdapter
            // 
            this.tAREASTableAdapter.ClearBeforeFill = true;
            // 
            // datePick
            // 
            this.datePick.CustomFormat = "dd/MM/yyyy";
            this.datePick.Location = new System.Drawing.Point(565, 44);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(228, 22);
            this.datePick.TabIndex = 5;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // iDTAREADataGridViewTextBoxColumn
            // 
            this.iDTAREADataGridViewTextBoxColumn.DataPropertyName = "ID_TAREA";
            this.iDTAREADataGridViewTextBoxColumn.HeaderText = "ID_TAREA";
            this.iDTAREADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDTAREADataGridViewTextBoxColumn.Name = "iDTAREADataGridViewTextBoxColumn";
            this.iDTAREADataGridViewTextBoxColumn.Width = 125;
            // 
            // tITULODataGridViewTextBoxColumn
            // 
            this.tITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO";
            this.tITULODataGridViewTextBoxColumn.HeaderText = "TITULO";
            this.tITULODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tITULODataGridViewTextBoxColumn.Name = "tITULODataGridViewTextBoxColumn";
            this.tITULODataGridViewTextBoxColumn.Width = 125;
            // 
            // eTIQUETADataGridViewTextBoxColumn
            // 
            this.eTIQUETADataGridViewTextBoxColumn.DataPropertyName = "ETIQUETA";
            this.eTIQUETADataGridViewTextBoxColumn.HeaderText = "ETIQUETA";
            this.eTIQUETADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTIQUETADataGridViewTextBoxColumn.Name = "eTIQUETADataGridViewTextBoxColumn";
            this.eTIQUETADataGridViewTextBoxColumn.Width = 125;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHAINDataGridViewTextBoxColumn
            // 
            this.fECHAINDataGridViewTextBoxColumn.DataPropertyName = "FECHAIN";
            this.fECHAINDataGridViewTextBoxColumn.HeaderText = "FECHAIN";
            this.fECHAINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAINDataGridViewTextBoxColumn.Name = "fECHAINDataGridViewTextBoxColumn";
            this.fECHAINDataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHAFINDataGridViewTextBoxColumn
            // 
            this.fECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHAFIN";
            this.fECHAFINDataGridViewTextBoxColumn.HeaderText = "FECHAFIN";
            this.fECHAFINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAFINDataGridViewTextBoxColumn.Name = "fECHAFINDataGridViewTextBoxColumn";
            this.fECHAFINDataGridViewTextBoxColumn.Width = 125;
            // 
            // uLTIMAMODDataGridViewTextBoxColumn
            // 
            this.uLTIMAMODDataGridViewTextBoxColumn.DataPropertyName = "ULTIMAMOD";
            this.uLTIMAMODDataGridViewTextBoxColumn.HeaderText = "ULTIMAMOD";
            this.uLTIMAMODDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uLTIMAMODDataGridViewTextBoxColumn.Name = "uLTIMAMODDataGridViewTextBoxColumn";
            this.uLTIMAMODDataGridViewTextBoxColumn.Width = 125;
            // 
            // iMPORTANCIADataGridViewTextBoxColumn
            // 
            this.iMPORTANCIADataGridViewTextBoxColumn.DataPropertyName = "IMPORTANCIA";
            this.iMPORTANCIADataGridViewTextBoxColumn.HeaderText = "IMPORTANCIA";
            this.iMPORTANCIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iMPORTANCIADataGridViewTextBoxColumn.Name = "iMPORTANCIADataGridViewTextBoxColumn";
            this.iMPORTANCIADataGridViewTextBoxColumn.Width = 125;
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.Width = 125;
            // 
            // MisTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MisTareas";
            this.Text = "MisTareas";
            this.Load += new System.EventHandler(this.MisTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPTASKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private APPTASKDataSet aPPTASKDataSet;
        private System.Windows.Forms.BindingSource tAREASBindingSource;
        private APPTASKDataSetTableAdapters.TAREASTableAdapter tAREASTableAdapter;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTAREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTIQUETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLTIMAMODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPORTANCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
    }
}