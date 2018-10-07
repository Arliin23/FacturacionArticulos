namespace Facturacion_Articulos
{
    partial class FrmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.nUDCostoUnitario = new System.Windows.Forms.NumericUpDown();
            this.nUDPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCostoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrecioUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(171, 415);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(51, 66);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.FlatAppearance.BorderSize = 0;
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(289, 415);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(51, 66);
            this.cmdCerrar.TabIndex = 8;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.FlatAppearance.BorderSize = 0;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
            this.cmdEliminar.Location = new System.Drawing.Point(228, 415);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(55, 66);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cbxEstado.Location = new System.Drawing.Point(217, 376);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(179, 30);
            this.cbxEstado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(217, 101);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(179, 31);
            this.TextID.TabIndex = 13;
            // 
            // nUDCostoUnitario
            // 
            this.nUDCostoUnitario.Location = new System.Drawing.Point(217, 260);
            this.nUDCostoUnitario.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nUDCostoUnitario.Name = "nUDCostoUnitario";
            this.nUDCostoUnitario.Size = new System.Drawing.Size(179, 31);
            this.nUDCostoUnitario.TabIndex = 14;
            // 
            // nUDPrecioUnitario
            // 
            this.nUDPrecioUnitario.Location = new System.Drawing.Point(217, 311);
            this.nUDPrecioUnitario.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nUDPrecioUnitario.Name = "nUDPrecioUnitario";
            this.nUDPrecioUnitario.Size = new System.Drawing.Size(179, 31);
            this.nUDPrecioUnitario.TabIndex = 15;
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(217, 138);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(179, 96);
            this.rtxtDescripcion.TabIndex = 16;
            this.rtxtDescripcion.Text = "";
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(535, 493);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.nUDPrecioUnitario);
            this.Controls.Add(this.nUDCostoUnitario);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmArticulos";
            this.Text = "FrmArticulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmArticulos_FormClosing);
            this.Load += new System.EventHandler(this.FrmArticulos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nUDCostoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrecioUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.NumericUpDown nUDCostoUnitario;
        private System.Windows.Forms.NumericUpDown nUDPrecioUnitario;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
    }
}