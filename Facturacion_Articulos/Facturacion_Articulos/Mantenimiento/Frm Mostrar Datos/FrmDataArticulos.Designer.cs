namespace Facturacion_Articulos
{
    partial class FrmDataArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataArticulos));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmdExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.Location = new System.Drawing.Point(27, 125);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(655, 301);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdBuscar);
            this.panel1.Controls.Add(this.textBusqueda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxCriterio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 60);
            this.panel1.TabIndex = 16;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.FlatAppearance.BorderSize = 0;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.Image")));
            this.cmdBuscar.Location = new System.Drawing.Point(590, 3);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(52, 52);
            this.cmdBuscar.TabIndex = 15;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(323, 17);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(259, 27);
            this.textBusqueda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Texto a Buscar";
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "Nombre",
            "Costo ",
            "Precio",
            "Cantidad",
            "Estado "});
            this.cbxCriterio.Location = new System.Drawing.Point(64, 17);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(140, 29);
            this.cbxCriterio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Criterio";
            // 
            // cmdEditar
            // 
            this.cmdEditar.FlatAppearance.BorderSize = 0;
            this.cmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditar.Image")));
            this.cmdEditar.Location = new System.Drawing.Point(583, 429);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(51, 66);
            this.cmdEditar.TabIndex = 15;
            this.cmdEditar.UseVisualStyleBackColor = true;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(633, 428);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 67);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.FlatAppearance.BorderSize = 0;
            this.cmdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcel.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(526, 428);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(51, 66);
            this.cmdExcel.TabIndex = 24;
            this.cmdExcel.UseVisualStyleBackColor = true;
            // 
            // FrmDataArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(715, 491);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDataArticulos";
            this.Text = "FrmDataArticulos";
            this.Activated += new System.EventHandler(this.FrmDataArticulos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDataArticulos_FormClosing);
            this.Load += new System.EventHandler(this.FrmDataArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button cmdEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdExcel;
    }
}