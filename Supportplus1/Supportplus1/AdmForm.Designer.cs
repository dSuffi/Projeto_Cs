namespace Supportplus1
{
    partial class AdmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgênciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFechamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Supportplus1.DataSet1();
            this.ticketTableAdapter = new Supportplus1.DataSet1TableAdapters.TicketTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolvidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensagemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackTableAdapter = new Supportplus1.DataSet1TableAdapters.FeedbackTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usuarioIdDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.mensagemDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.urgênciaDataGridViewTextBoxColumn,
            this.dataAberturaDataGridViewTextBoxColumn,
            this.dataFechamentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(1, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 80);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "UsuarioId";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // mensagemDataGridViewTextBoxColumn
            // 
            this.mensagemDataGridViewTextBoxColumn.DataPropertyName = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn.HeaderText = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn.Name = "mensagemDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // urgênciaDataGridViewTextBoxColumn
            // 
            this.urgênciaDataGridViewTextBoxColumn.DataPropertyName = "Urgência";
            this.urgênciaDataGridViewTextBoxColumn.HeaderText = "Urgência";
            this.urgênciaDataGridViewTextBoxColumn.Name = "urgênciaDataGridViewTextBoxColumn";
            // 
            // dataAberturaDataGridViewTextBoxColumn
            // 
            this.dataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.HeaderText = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.Name = "dataAberturaDataGridViewTextBoxColumn";
            // 
            // dataFechamentoDataGridViewTextBoxColumn
            // 
            this.dataFechamentoDataGridViewTextBoxColumn.DataPropertyName = "DataFechamento";
            this.dataFechamentoDataGridViewTextBoxColumn.HeaderText = "DataFechamento";
            this.dataFechamentoDataGridViewTextBoxColumn.Name = "dataFechamentoDataGridViewTextBoxColumn";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.resolvidoDataGridViewCheckBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.mensagemDataGridViewTextBoxColumn1,
            this.dataEnvioDataGridViewTextBoxColumn,
            this.ticketIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.feedbackBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 144);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // resolvidoDataGridViewCheckBoxColumn
            // 
            this.resolvidoDataGridViewCheckBoxColumn.DataPropertyName = "Resolvido";
            this.resolvidoDataGridViewCheckBoxColumn.HeaderText = "Resolvido";
            this.resolvidoDataGridViewCheckBoxColumn.Name = "resolvidoDataGridViewCheckBoxColumn";
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            // 
            // mensagemDataGridViewTextBoxColumn1
            // 
            this.mensagemDataGridViewTextBoxColumn1.DataPropertyName = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn1.HeaderText = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn1.Name = "mensagemDataGridViewTextBoxColumn1";
            // 
            // dataEnvioDataGridViewTextBoxColumn
            // 
            this.dataEnvioDataGridViewTextBoxColumn.DataPropertyName = "DataEnvio";
            this.dataEnvioDataGridViewTextBoxColumn.HeaderText = "DataEnvio";
            this.dataEnvioDataGridViewTextBoxColumn.Name = "dataEnvioDataGridViewTextBoxColumn";
            // 
            // ticketIdDataGridViewTextBoxColumn
            // 
            this.ticketIdDataGridViewTextBoxColumn.DataPropertyName = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.HeaderText = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.Name = "ticketIdDataGridViewTextBoxColumn";
            // 
            // feedbackBindingSource
            // 
            this.feedbackBindingSource.DataMember = "Feedback";
            this.feedbackBindingSource.DataSource = this.dataSet1;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chamados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feedback";
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(855, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdmForm";
            this.Text = "AdmForm";
            this.Load += new System.EventHandler(this.AdmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private DataSet1TableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgênciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFechamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private DataSet1TableAdapters.FeedbackTableAdapter feedbackTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resolvidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensagemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}