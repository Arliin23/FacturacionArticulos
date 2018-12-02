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
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.nUDCostoUnitario = new System.Windows.Forms.TextBox();
            this.nUDPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cbxEstado.Location = new System.Drawing.Point(217, 342);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(179, 30);
            this.cbxEstado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(217, 112);
            this.TextID.Name = "TextID";
            this.TextID.ReadOnly = true;
            this.TextID.Size = new System.Drawing.Size(179, 31);
            this.TextID.TabIndex = 13;
            // 
            // nUDCostoUnitario
            // 
            this.nUDCostoUnitario.Location = new System.Drawing.Point(217, 206);
            this.nUDCostoUnitario.MaxLength = 4;
            this.nUDCostoUnitario.Name = "nUDCostoUnitario";
            this.nUDCostoUnitario.Size = new System.Drawing.Size(179, 31);
            this.nUDCostoUnitario.TabIndex = 17;
            this.nUDCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nUDCostoUnitario_KeyPress);
            // 
            // nUDPrecioUnitario
            // 
            this.nUDPrecioUnitario.Location = new System.Drawing.Point(217, 251);
            this.nUDPrecioUnitario.MaxLength = 4;
            this.nUDPrecioUnitario.Name = "nUDPrecioUnitario";
            this.nUDPrecioUnitario.Size = new System.Drawing.Size(179, 31);
            this.nUDPrecioUnitario.TabIndex = 18;
            this.nUDPrecioUnitario.TextChanged += new System.EventHandler(this.nUDPrecioUnitario_TextChanged);
            this.nUDPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nUDPrecioUnitario_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad";
            // 
            // nUDCantidad
            // 
            this.nUDCantidad.Location = new System.Drawing.Point(217, 295);
            this.nUDCantidad.MaxLength = 4;
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(179, 31);
            this.nUDCantidad.TabIndex = 20;
            this.nUDCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nUDCantidad_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 159);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 31);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(503, 493);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nUDCantidad);
            this.Controls.Add(this.label7);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmArticulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmArticulos_FormClosing);
            this.Load += new System.EventHandler(this.FrmArticulos_Load_1);
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
        private System.Windows.Forms.TextBox nUDCostoUnitario;
        private System.Windows.Forms.TextBox nUDPrecioUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nUDCantidad;
        private System.Windows.Forms.TextBox txtNombre;
    }
}