namespace Supportplus1
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTicket = new System.Windows.Forms.TextBox();
            this.botao = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.CmbUrgencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitação de serviço/Ticket";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtTicket
            // 
            this.TxtTicket.Location = new System.Drawing.Point(12, 115);
            this.TxtTicket.Multiline = true;
            this.TxtTicket.Name = "TxtTicket";
            this.TxtTicket.Size = new System.Drawing.Size(303, 208);
            this.TxtTicket.TabIndex = 2;
            this.TxtTicket.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botao
            // 
            this.botao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botao.Location = new System.Drawing.Point(568, 392);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(75, 23);
            this.botao.TabIndex = 3;
            this.botao.Text = "Enviar";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.button1_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Voltar.Location = new System.Drawing.Point(487, 392);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 4;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmbUrgencia
            // 
            this.CmbUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrgencia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbUrgencia.FormattingEnabled = true;
            this.CmbUrgencia.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.CmbUrgencia.Location = new System.Drawing.Point(12, 359);
            this.CmbUrgencia.Name = "CmbUrgencia";
            this.CmbUrgencia.Size = new System.Drawing.Size(80, 24);
            this.CmbUrgencia.TabIndex = 5;
            this.CmbUrgencia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urgência";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(604, 452);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 55);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(658, 424);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbUrgencia);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.TxtTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TicketForm";
            this.Text = "Support Plus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicketForm_FormClosed);
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTicket;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.ComboBox CmbUrgencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}