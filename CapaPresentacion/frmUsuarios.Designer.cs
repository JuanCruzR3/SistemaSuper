﻿namespace CapaPresentacion
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdocumento = new TextBox();
            txtnombrecompleto = new TextBox();
            txtcorreo = new TextBox();
            txtclave = new TextBox();
            label5 = new Label();
            txtconfirmarclave = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cborol = new ComboBox();
            cboestado = new ComboBox();
            label8 = new Label();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label10 = new Label();
            txtid = new TextBox();
            label11 = new Label();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            btnPermisos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 902);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(37, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(37, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(37, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(37, 88);
            txtdocumento.Margin = new Padding(4, 5, 4, 5);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(260, 31);
            txtdocumento.TabIndex = 4;
            txtdocumento.KeyPress += textBoxNumeros_KeyPress;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(37, 167);
            txtnombrecompleto.Margin = new Padding(4, 5, 4, 5);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(260, 31);
            txtnombrecompleto.TabIndex = 5;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(37, 242);
            txtcorreo.Margin = new Padding(4, 5, 4, 5);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(260, 31);
            txtcorreo.TabIndex = 6;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(38, 319);
            txtclave.Margin = new Padding(4, 5, 4, 5);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(260, 31);
            txtclave.TabIndex = 8;
            txtclave.TextChanged += txtclave_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(37, 289);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 7;
            label5.Text = "Contraseña:";
            // 
            // txtconfirmarclave
            // 
            txtconfirmarclave.Location = new Point(38, 399);
            txtconfirmarclave.Margin = new Padding(4, 5, 4, 5);
            txtconfirmarclave.Name = "txtconfirmarclave";
            txtconfirmarclave.PasswordChar = '*';
            txtconfirmarclave.Size = new Size(260, 31);
            txtconfirmarclave.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(38, 369);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(189, 25);
            label6.TabIndex = 9;
            label6.Text = "Confirmar Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(37, 430);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 25);
            label7.TabIndex = 11;
            label7.Text = "Rol:";
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(37, 460);
            cborol.Margin = new Padding(4, 5, 4, 5);
            cborol.Name = "cborol";
            cborol.Size = new Size(260, 33);
            cborol.TabIndex = 12;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(37, 528);
            cboestado.Margin = new Padding(4, 5, 4, 5);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(260, 33);
            cboestado.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(37, 498);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 14;
            label8.Text = "Estado: ";
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.ForestGreen;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Folder;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 16;
            btnguardar.Location = new Point(37, 585);
            btnguardar.Margin = new Padding(4, 5, 4, 5);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(261, 38);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.RoyalBlue;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 18;
            btnlimpiar.Location = new Point(37, 633);
            btnlimpiar.Margin = new Padding(4, 5, 4, 5);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(261, 38);
            btnlimpiar.TabIndex = 16;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Firebrick;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btneliminar.IconColor = Color.White;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.IconSize = 16;
            btneliminar.Location = new Point(37, 681);
            btneliminar.Margin = new Padding(4, 5, 4, 5);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(261, 38);
            btneliminar.TabIndex = 17;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(37, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(234, 35);
            label9.TabIndex = 18;
            label9.Text = "Detalle Usuario";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Documento, NombreCompleto, Correo, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvdata.Location = new Point(384, 158);
            dgvdata.Margin = new Padding(4, 5, 4, 5);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(1227, 677);
            dgvdata.TabIndex = 19;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 8;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "IdUsuario";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 150;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.MinimumWidth = 8;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 8;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 8;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 150;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.MinimumWidth = 8;
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            IdRol.Width = 150;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 8;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 150;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.MinimumWidth = 8;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(385, 37);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(3, 0, 0, 0);
            label10.Size = new Size(1226, 100);
            label10.TabIndex = 20;
            label10.Text = "Lista de Usuarios";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            txtid.Location = new Point(263, 52);
            txtid.Margin = new Padding(4, 5, 4, 5);
            txtid.Name = "txtid";
            txtid.Size = new Size(34, 31);
            txtid.TabIndex = 21;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(873, 85);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 25);
            label11.TabIndex = 22;
            label11.Text = "Buscar por:";
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(976, 77);
            cbobusqueda.Margin = new Padding(4, 5, 4, 5);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(181, 33);
            cbobusqueda.TabIndex = 23;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(1167, 77);
            txtbusqueda.Margin = new Padding(4, 5, 4, 5);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(257, 31);
            txtbusqueda.TabIndex = 24;
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
            btnlimpiarbuscador.Location = new Point(1506, 75);
            btnlimpiarbuscador.Margin = new Padding(4, 5, 4, 5);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(54, 38);
            btnlimpiarbuscador.TabIndex = 26;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 16;
            btnbuscar.Location = new Point(1434, 75);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 38);
            btnbuscar.TabIndex = 25;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(218, 52);
            txtindice.Margin = new Padding(4, 5, 4, 5);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(34, 31);
            txtindice.TabIndex = 27;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // btnPermisos
            // 
            btnPermisos.BackColor = Color.DarkKhaki;
            btnPermisos.Cursor = Cursors.Hand;
            btnPermisos.FlatAppearance.BorderColor = Color.Black;
            btnPermisos.FlatStyle = FlatStyle.Flat;
            btnPermisos.ForeColor = Color.Black;
            btnPermisos.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnPermisos.IconColor = Color.Black;
            btnPermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPermisos.IconSize = 16;
            btnPermisos.Location = new Point(38, 729);
            btnPermisos.Margin = new Padding(4, 5, 4, 5);
            btnPermisos.Name = "btnPermisos";
            btnPermisos.Size = new Size(261, 38);
            btnPermisos.TabIndex = 28;
            btnPermisos.Text = "Grupos";
            btnPermisos.TextAlign = ContentAlignment.MiddleRight;
            btnPermisos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPermisos.UseVisualStyleBackColor = false;
            btnPermisos.Click += btnPermisos_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1713, 902);
            Controls.Add(btnPermisos);
            Controls.Add(txtindice);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(label8);
            Controls.Add(cboestado);
            Controls.Add(cborol);
            Controls.Add(label7);
            Controls.Add(txtconfirmarclave);
            Controls.Add(label6);
            Controls.Add(txtclave);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(txtnombrecompleto);
            Controls.Add(txtdocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdocumento;
        private TextBox txtnombrecompleto;
        private TextBox txtcorreo;
        private TextBox txtclave;
        private Label label5;
        private TextBox txtconfirmarclave;
        private Label label6;
        private Label label7;
        private ComboBox cborol;
        private ComboBox cboestado;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private Label label9;
        private DataGridView dgvdata;
        private Label label10;
        private TextBox txtid;
        private Label label11;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnPermisos;
    }
}