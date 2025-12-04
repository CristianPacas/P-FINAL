namespace P_FINAL_U20240388.Forms
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.btnCancelar3 = new System.Windows.Forms.Button();
            this.btnAgregaraVenta = new System.Windows.Forms.Button();
            this.txtCategoria2 = new System.Windows.Forms.TextBox();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario2 = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario2 = new System.Windows.Forms.Label();
            this.txtNombreCliente2 = new System.Windows.Forms.TextBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnGrabaryTransmitir = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar3
            // 
            this.btnCancelar3.BackColor = System.Drawing.Color.Red;
            this.btnCancelar3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar3.ForeColor = System.Drawing.Color.White;
            this.btnCancelar3.Location = new System.Drawing.Point(579, 235);
            this.btnCancelar3.Name = "btnCancelar3";
            this.btnCancelar3.Size = new System.Drawing.Size(117, 54);
            this.btnCancelar3.TabIndex = 71;
            this.btnCancelar3.Text = "CANCELAR";
            this.btnCancelar3.UseVisualStyleBackColor = false;
            this.btnCancelar3.Click += new System.EventHandler(this.btnCancelar3_Click);
            // 
            // btnAgregaraVenta
            // 
            this.btnAgregaraVenta.BackColor = System.Drawing.Color.Lime;
            this.btnAgregaraVenta.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaraVenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregaraVenta.Location = new System.Drawing.Point(12, 304);
            this.btnAgregaraVenta.Name = "btnAgregaraVenta";
            this.btnAgregaraVenta.Size = new System.Drawing.Size(117, 54);
            this.btnAgregaraVenta.TabIndex = 70;
            this.btnAgregaraVenta.Text = "AGREGAR A VENTA";
            this.btnAgregaraVenta.UseVisualStyleBackColor = false;
            this.btnAgregaraVenta.Click += new System.EventHandler(this.btnAgregaraVenta_Click);
            // 
            // txtCategoria2
            // 
            this.txtCategoria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria2.Location = new System.Drawing.Point(44, 152);
            this.txtCategoria2.Name = "txtCategoria2";
            this.txtCategoria2.Size = new System.Drawing.Size(209, 24);
            this.txtCategoria2.TabIndex = 69;
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.BackColor = System.Drawing.Color.Black;
            this.lblCategoria2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria2.ForeColor = System.Drawing.Color.Ivory;
            this.lblCategoria2.Location = new System.Drawing.Point(102, 128);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(90, 21);
            this.lblCategoria2.TabIndex = 68;
            this.lblCategoria2.Text = "CATEGORIA";
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad2.Location = new System.Drawing.Point(345, 139);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(209, 24);
            this.txtCantidad2.TabIndex = 67;
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.BackColor = System.Drawing.Color.Black;
            this.lblCantidad2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad2.ForeColor = System.Drawing.Color.Ivory;
            this.lblCantidad2.Location = new System.Drawing.Point(403, 115);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(89, 21);
            this.lblCantidad2.TabIndex = 66;
            this.lblCantidad2.Text = "CANTIDAD:";
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo2.Location = new System.Drawing.Point(345, 62);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(209, 24);
            this.txtCodigo2.TabIndex = 65;
            this.txtCodigo2.TextChanged += new System.EventHandler(this.txtCodigo2_TextChanged);
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.BackColor = System.Drawing.Color.Black;
            this.lblCodigo2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.ForeColor = System.Drawing.Color.Ivory;
            this.lblCodigo2.Location = new System.Drawing.Point(403, 38);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(71, 21);
            this.lblCodigo2.TabIndex = 64;
            this.lblCodigo2.Text = "CODIGO:";
            // 
            // txtPrecioUnitario2
            // 
            this.txtPrecioUnitario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario2.Location = new System.Drawing.Point(629, 75);
            this.txtPrecioUnitario2.Name = "txtPrecioUnitario2";
            this.txtPrecioUnitario2.Size = new System.Drawing.Size(209, 24);
            this.txtPrecioUnitario2.TabIndex = 63;
            this.txtPrecioUnitario2.TextChanged += new System.EventHandler(this.txtPrecioUnitario2_TextChanged);
            // 
            // lblPrecioUnitario2
            // 
            this.lblPrecioUnitario2.AutoSize = true;
            this.lblPrecioUnitario2.BackColor = System.Drawing.Color.Black;
            this.lblPrecioUnitario2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario2.ForeColor = System.Drawing.Color.Ivory;
            this.lblPrecioUnitario2.Location = new System.Drawing.Point(663, 51);
            this.lblPrecioUnitario2.Name = "lblPrecioUnitario2";
            this.lblPrecioUnitario2.Size = new System.Drawing.Size(139, 21);
            this.lblPrecioUnitario2.TabIndex = 62;
            this.lblPrecioUnitario2.Text = "PRECIO UNITARIO";
            // 
            // txtNombreCliente2
            // 
            this.txtNombreCliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente2.Location = new System.Drawing.Point(44, 75);
            this.txtNombreCliente2.Name = "txtNombreCliente2";
            this.txtNombreCliente2.Size = new System.Drawing.Size(209, 24);
            this.txtNombreCliente2.TabIndex = 61;
            this.txtNombreCliente2.TextChanged += new System.EventHandler(this.txtNombre2_TextChanged);
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.BackColor = System.Drawing.Color.Black;
            this.lblNombre2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.ForeColor = System.Drawing.Color.Ivory;
            this.lblNombre2.Location = new System.Drawing.Point(102, 51);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(81, 21);
            this.lblNombre2.TabIndex = 60;
            this.lblNombre2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(309, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "SISTEMA DE FACTURACION";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(-1, 392);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(889, 424);
            this.dgvDetalleVenta.TabIndex = 72;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(629, 152);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(209, 24);
            this.txtPrecioTotal.TabIndex = 74;
            this.txtPrecioTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.BackColor = System.Drawing.Color.Black;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.ForeColor = System.Drawing.Color.Ivory;
            this.lblPrecioTotal.Location = new System.Drawing.Point(680, 128);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(111, 21);
            this.lblPrecioTotal.TabIndex = 73;
            this.lblPrecioTotal.Text = "PRECIO TOTAL";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.Color.Red;
            this.btnQuitarProducto.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProducto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarProducto.Location = new System.Drawing.Point(742, 235);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(117, 54);
            this.btnQuitarProducto.TabIndex = 75;
            this.btnQuitarProducto.Text = "QUITAR PRODUCTO";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            // 
            // btnGrabaryTransmitir
            // 
            this.btnGrabaryTransmitir.BackColor = System.Drawing.Color.Lime;
            this.btnGrabaryTransmitir.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabaryTransmitir.ForeColor = System.Drawing.Color.White;
            this.btnGrabaryTransmitir.Location = new System.Drawing.Point(214, 304);
            this.btnGrabaryTransmitir.Name = "btnGrabaryTransmitir";
            this.btnGrabaryTransmitir.Size = new System.Drawing.Size(117, 54);
            this.btnGrabaryTransmitir.TabIndex = 76;
            this.btnGrabaryTransmitir.Text = "GRABAR Y TRANSMITIR";
            this.btnGrabaryTransmitir.UseVisualStyleBackColor = false;
            this.btnGrabaryTransmitir.Click += new System.EventHandler(this.btnGrabaryTransmitir_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(345, 198);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(209, 24);
            this.txtProducto.TabIndex = 78;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.Color.Black;
            this.lblNombreProducto.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.Ivory;
            this.lblNombreProducto.Location = new System.Drawing.Point(403, 174);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(95, 21);
            this.lblNombreProducto.TabIndex = 77;
            this.lblNombreProducto.Text = "PRODUCTO:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(44, 226);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(209, 24);
            this.txtCodCliente.TabIndex = 80;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.BackColor = System.Drawing.Color.Black;
            this.lblCodCliente.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.ForeColor = System.Drawing.Color.Ivory;
            this.lblCodCliente.Location = new System.Drawing.Point(92, 198);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(112, 21);
            this.lblCodCliente.TabIndex = 79;
            this.lblCodCliente.Text = "COD. CLIENTE:";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(888, 812);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnGrabaryTransmitir);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.btnCancelar3);
            this.Controls.Add(this.btnAgregaraVenta);
            this.Controls.Add(this.txtCategoria2);
            this.Controls.Add(this.lblCategoria2);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.lblCantidad2);
            this.Controls.Add(this.txtCodigo2);
            this.Controls.Add(this.lblCodigo2);
            this.Controls.Add(this.txtPrecioUnitario2);
            this.Controls.Add(this.lblPrecioUnitario2);
            this.Controls.Add(this.txtNombreCliente2);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.label1);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar3;
        private System.Windows.Forms.Button btnAgregaraVenta;
        private System.Windows.Forms.TextBox txtCategoria2;
        private System.Windows.Forms.Label lblCategoria2;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.TextBox txtPrecioUnitario2;
        private System.Windows.Forms.Label lblPrecioUnitario2;
        private System.Windows.Forms.TextBox txtNombreCliente2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnGrabaryTransmitir;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCodCliente;
    }
}