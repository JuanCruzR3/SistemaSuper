﻿namespace CapaPresentacion
{
    partial class frmReporteCompras
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
            txtfechainicio = new DateTimePicker();
            label10 = new Label();
            txtfechafin = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cboproveedor = new ComboBox();
            label3 = new Label();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            dgvdata = new DataGridView();
            btnexpotar = new FontAwesome.Sharp.IconButton();
            btnbuscarpor = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobuscarpor = new ComboBox();
            label11 = new Label();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(150, 73);
            txtfechainicio.Margin = new Padding(4, 5, 4, 5);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(140, 31);
            txtfechainicio.TabIndex = 0;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(17, 15);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(3, 0, 0, 0);
            label10.Size = new Size(1679, 114);
            label10.TabIndex = 73;
            label10.Text = "Reporte Compras";
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(417, 73);
            txtfechafin.Margin = new Padding(4, 5, 4, 5);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(140, 31);
            txtfechafin.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(37, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 75;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(323, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 76;
            label2.Text = "Fecha Fin:";
            // 
            // cboproveedor
            // 
            cboproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboproveedor.FormattingEnabled = true;
            cboproveedor.Location = new Point(690, 73);
            cboproveedor.Margin = new Padding(4, 5, 4, 5);
            cboproveedor.Name = "cboproveedor";
            cboproveedor.Size = new Size(233, 33);
            cboproveedor.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(590, 83);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 78;
            label3.Text = "Proveedor:";
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.BackColor = Color.White;
            btnbuscarproveedor.Cursor = Cursors.Hand;
            btnbuscarproveedor.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproveedor.FlatStyle = FlatStyle.Flat;
            btnbuscarproveedor.ForeColor = Color.Black;
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 16;
            btnbuscarproveedor.Location = new Point(933, 70);
            btnbuscarproveedor.Margin = new Padding(4, 5, 4, 5);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(127, 38);
            btnbuscarproveedor.TabIndex = 79;
            btnbuscarproveedor.Text = "Buscar";
            btnbuscarproveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproveedor.UseVisualStyleBackColor = false;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(17, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(3, 0, 0, 0);
            label4.Size = new Size(1679, 745);
            label4.TabIndex = 80;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(37, 220);
            dgvdata.Margin = new Padding(4, 5, 4, 5);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1634, 546);
            dgvdata.TabIndex = 81;
            // 
            // btnexpotar
            // 
            btnexpotar.BackColor = SystemColors.Control;
            btnexpotar.Cursor = Cursors.Hand;
            btnexpotar.FlatAppearance.BorderColor = Color.Black;
            btnexpotar.FlatStyle = FlatStyle.Flat;
            btnexpotar.ForeColor = Color.Black;
            btnexpotar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexpotar.IconColor = Color.LimeGreen;
            btnexpotar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexpotar.IconSize = 16;
            btnexpotar.ImageAlign = ContentAlignment.MiddleLeft;
            btnexpotar.Location = new Point(37, 165);
            btnexpotar.Margin = new Padding(4, 5, 4, 5);
            btnexpotar.Name = "btnexpotar";
            btnexpotar.Size = new Size(191, 45);
            btnexpotar.TabIndex = 82;
            btnexpotar.Text = "Descargar Excel";
            btnexpotar.UseVisualStyleBackColor = false;
            btnexpotar.Click += btnexpotar_Click;
            // 
            // btnbuscarpor
            // 
            btnbuscarpor.BackColor = Color.White;
            btnbuscarpor.Cursor = Cursors.Hand;
            btnbuscarpor.FlatAppearance.BorderColor = Color.Black;
            btnbuscarpor.FlatStyle = FlatStyle.Flat;
            btnbuscarpor.ForeColor = Color.Black;
            btnbuscarpor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarpor.IconColor = Color.Black;
            btnbuscarpor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarpor.IconSize = 16;
            btnbuscarpor.Location = new Point(1529, 165);
            btnbuscarpor.Margin = new Padding(4, 5, 4, 5);
            btnbuscarpor.Name = "btnbuscarpor";
            btnbuscarpor.Size = new Size(63, 38);
            btnbuscarpor.TabIndex = 86;
            btnbuscarpor.UseVisualStyleBackColor = false;
            btnbuscarpor.Click += btnbuscarpor_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.Black;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 18;
            btnlimpiarbuscador.Location = new Point(1600, 165);
            btnlimpiarbuscador.Margin = new Padding(4, 5, 4, 5);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(54, 38);
            btnlimpiarbuscador.TabIndex = 87;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(1261, 167);
            txtbusqueda.Margin = new Padding(4, 5, 4, 5);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(257, 31);
            txtbusqueda.TabIndex = 85;
            // 
            // cbobuscarpor
            // 
            cbobuscarpor.BackColor = SystemColors.Control;
            cbobuscarpor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscarpor.FormattingEnabled = true;
            cbobuscarpor.Location = new Point(1070, 167);
            cbobuscarpor.Margin = new Padding(4, 5, 4, 5);
            cbobuscarpor.Name = "cbobuscarpor";
            cbobuscarpor.Size = new Size(181, 33);
            cbobuscarpor.TabIndex = 84;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(967, 175);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 25);
            label11.TabIndex = 83;
            label11.Text = "Buscar por:";
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 8;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 150;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.MinimumWidth = 8;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            TipoDocumento.Width = 150;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.MinimumWidth = 8;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            NumeroDocumento.Width = 150;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 8;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            MontoTotal.Width = 75;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.MinimumWidth = 8;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.ReadOnly = true;
            UsuarioRegistro.Width = 90;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor ";
            DocumentoProveedor.MinimumWidth = 8;
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            DocumentoProveedor.Width = 150;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 8;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 120;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.MinimumWidth = 8;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 85;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.MinimumWidth = 8;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 120;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 8;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 90;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 8;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 80;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 8;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 75;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 80;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Subtotal";
            SubTotal.MinimumWidth = 8;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 90;
            // 
            // frmReporteCompras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1707, 952);
            Controls.Add(btnbuscarpor);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobuscarpor);
            Controls.Add(label11);
            Controls.Add(btnexpotar);
            Controls.Add(dgvdata);
            Controls.Add(label4);
            Controls.Add(btnbuscarproveedor);
            Controls.Add(label3);
            Controls.Add(cboproveedor);
            Controls.Add(txtfechafin);
            Controls.Add(txtfechainicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmReporteCompras";
            Text = "frmReporteCompras";
            Load += frmReporteCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker txtfechainicio;
        private Label label10;
        private DateTimePicker txtfechafin;
        private Label label1;
        private Label label2;
        private ComboBox cboproveedor;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private Label label4;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnexpotar;
        private FontAwesome.Sharp.IconButton btnbuscarpor;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbobuscarpor;
        private Label label11;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}