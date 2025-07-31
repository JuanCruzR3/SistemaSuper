namespace CapaPresentacion
{
    partial class frmPermisos
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
            dgvPermisos = new DataGridView();
            txtDescripcionRol = new TextBox();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnmodificar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            dgvGrupos = new DataGridView();
            btncancelar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnregresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // dgvPermisos
            // 
            dgvPermisos.BackgroundColor = SystemColors.Control;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.Location = new Point(356, 22);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.RowHeadersWidth = 62;
            dgvPermisos.RowTemplate.Height = 33;
            dgvPermisos.Size = new Size(508, 407);
            dgvPermisos.TabIndex = 0;
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Location = new Point(75, 60);
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.Size = new Size(261, 31);
            txtDescripcionRol.TabIndex = 1;
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
            btneliminar.Location = new Point(75, 231);
            btneliminar.Margin = new Padding(4, 5, 4, 5);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(261, 38);
            btneliminar.TabIndex = 20;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.RoyalBlue;
            btnmodificar.Cursor = Cursors.Hand;
            btnmodificar.FlatAppearance.BorderColor = Color.Black;
            btnmodificar.FlatStyle = FlatStyle.Flat;
            btnmodificar.ForeColor = Color.White;
            btnmodificar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnmodificar.IconColor = Color.White;
            btnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnmodificar.IconSize = 18;
            btnmodificar.Location = new Point(75, 183);
            btnmodificar.Margin = new Padding(4, 5, 4, 5);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(261, 38);
            btnmodificar.TabIndex = 19;
            btnmodificar.Text = "Modificar";
            btnmodificar.TextAlign = ContentAlignment.MiddleRight;
            btnmodificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnmodificar.UseVisualStyleBackColor = false;
            btnmodificar.Click += btnmodificar_Click;
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
            btnguardar.Location = new Point(75, 135);
            btnguardar.Margin = new Padding(4, 5, 4, 5);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(261, 38);
            btnguardar.TabIndex = 18;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // dgvGrupos
            // 
            dgvGrupos.BackgroundColor = SystemColors.Control;
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(887, 22);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.RowHeadersWidth = 62;
            dgvGrupos.RowTemplate.Height = 33;
            dgvGrupos.Size = new Size(508, 407);
            dgvGrupos.TabIndex = 21;
            dgvGrupos.CellContentClick += dgvGrupos_CellClick;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Coral;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.White;
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.Hand;
            btncancelar.IconColor = Color.White;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 16;
            btncancelar.Location = new Point(75, 279);
            btncancelar.Margin = new Padding(4, 5, 4, 5);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(261, 38);
            btncancelar.TabIndex = 22;
            btncancelar.Text = "Cancelar Selección";
            btncancelar.TextAlign = ContentAlignment.MiddleRight;
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 22);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 23;
            label1.Text = "Nombre del grupo:";
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.Teal;
            btnregresar.Cursor = Cursors.Hand;
            btnregresar.FlatAppearance.BorderColor = Color.Black;
            btnregresar.FlatStyle = FlatStyle.Flat;
            btnregresar.ForeColor = Color.White;
            btnregresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnregresar.IconColor = Color.White;
            btnregresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregresar.IconSize = 16;
            btnregresar.Location = new Point(734, 437);
            btnregresar.Margin = new Padding(4, 5, 4, 5);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(261, 38);
            btnregresar.TabIndex = 24;
            btnregresar.Text = "Regresar";
            btnregresar.TextAlign = ContentAlignment.MiddleRight;
            btnregresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // frmPermisos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 498);
            Controls.Add(btnregresar);
            Controls.Add(label1);
            Controls.Add(btncancelar);
            Controls.Add(dgvGrupos);
            Controls.Add(btneliminar);
            Controls.Add(btnmodificar);
            Controls.Add(btnguardar);
            Controls.Add(txtDescripcionRol);
            Controls.Add(dgvPermisos);
            Name = "frmPermisos";
            Text = "frmPermisos";
            Load += frmPermisos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPermisos;
        private TextBox txtDescripcionRol;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnmodificar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private DataGridView dgvGrupos;
        private FontAwesome.Sharp.IconButton btncancelar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnregresar;
    }
}