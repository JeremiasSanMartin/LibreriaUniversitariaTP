namespace Presentacion
{
    partial class AdminForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_usuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inactivar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.btn_nuevoUsuario = new System.Windows.Forms.Button();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.timer_animacionMenu = new System.Windows.Forms.Timer(this.components);
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pctBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pctBox_salir = new System.Windows.Forms.PictureBox();
            this.timer_carrusel = new System.Windows.Forms.Timer(this.components);
            this.panel_crearUsuario = new System.Windows.Forms.Panel();
            this.txtBox_DNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            this.cBox_rolCrear = new System.Windows.Forms.ComboBox();
            this.txtBox_contrasenaCrear = new System.Windows.Forms.TextBox();
            this.txtBox_usuarioCrear = new System.Windows.Forms.TextBox();
            this.txtBox_apellidoCrear = new System.Windows.Forms.TextBox();
            this.lbl_creaUsuario = new System.Windows.Forms.Label();
            this.txtBox_nombreCrear = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuarios)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).BeginInit();
            this.panel_crearUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_usuarios
            // 
            this.dataGrid_usuarios.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombreUsuario,
            this.nombre,
            this.apellido,
            this.password,
            this.rol,
            this.inactivar});
            this.dataGrid_usuarios.EnableHeadersVisualStyles = false;
            this.dataGrid_usuarios.GridColor = System.Drawing.Color.White;
            this.dataGrid_usuarios.Location = new System.Drawing.Point(232, 87);
            this.dataGrid_usuarios.Name = "dataGrid_usuarios";
            this.dataGrid_usuarios.ReadOnly = true;
            this.dataGrid_usuarios.RowHeadersVisible = false;
            this.dataGrid_usuarios.RowHeadersWidth = 51;
            this.dataGrid_usuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_usuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_usuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_usuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.dataGrid_usuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_usuarios.RowTemplate.Height = 40;
            this.dataGrid_usuarios.Size = new System.Drawing.Size(601, 499);
            this.dataGrid_usuarios.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombreUsuario.HeaderText = "Nombre de Usuario";
            this.nombreUsuario.MinimumWidth = 6;
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.password.HeaderText = "Contraseña";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rol.HeaderText = "Rol";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // inactivar
            // 
            this.inactivar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.inactivar.DefaultCellStyle = dataGridViewCellStyle10;
            this.inactivar.HeaderText = "";
            this.inactivar.Image = global::LibreriaUniversitaria.Properties.Resources.inactivar;
            this.inactivar.MinimumWidth = 6;
            this.inactivar.Name = "inactivar";
            this.inactivar.ReadOnly = true;
            this.inactivar.Width = 50;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panel_menu.Controls.Add(this.btn_cerrarSesion);
            this.panel_menu.Controls.Add(this.btn_usuarios);
            this.panel_menu.Controls.Add(this.btn_Inicio);
            this.panel_menu.Controls.Add(this.btn_nuevoUsuario);
            this.panel_menu.Controls.Add(this.btn_desplegar);
            this.panel_menu.Location = new System.Drawing.Point(0, -1);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(65, 634);
            this.panel_menu.TabIndex = 6;
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarSesion.Image = global::LibreriaUniversitaria.Properties.Resources.cierrasesion;
            this.btn_cerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(0, 568);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cerrarSesion.Size = new System.Drawing.Size(191, 66);
            this.btn_cerrarSesion.TabIndex = 23;
            this.btn_cerrarSesion.Text = "  Cerrar sesion";
            this.btn_cerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_usuarios.Image = global::LibreriaUniversitaria.Properties.Resources.usuarios__4_;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 301);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_usuarios.Size = new System.Drawing.Size(191, 66);
            this.btn_usuarios.TabIndex = 20;
            this.btn_usuarios.Text = "  Usuarios";
            this.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.FlatAppearance.BorderSize = 0;
            this.btn_Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.Image = global::LibreriaUniversitaria.Properties.Resources.inicio__2_;
            this.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 240);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Inicio.Size = new System.Drawing.Size(191, 66);
            this.btn_Inicio.TabIndex = 19;
            this.btn_Inicio.Text = "  Inicio";
            this.btn_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // btn_nuevoUsuario
            // 
            this.btn_nuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btn_nuevoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btn_nuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_nuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_nuevoUsuario.Image = global::LibreriaUniversitaria.Properties.Resources.agg__1_;
            this.btn_nuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevoUsuario.Location = new System.Drawing.Point(0, 362);
            this.btn_nuevoUsuario.Name = "btn_nuevoUsuario";
            this.btn_nuevoUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_nuevoUsuario.Size = new System.Drawing.Size(191, 66);
            this.btn_nuevoUsuario.TabIndex = 18;
            this.btn_nuevoUsuario.Text = "  Nuevo Usuario";
            this.btn_nuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevoUsuario.UseVisualStyleBackColor = true;
            this.btn_nuevoUsuario.Click += new System.EventHandler(this.btn_nuevoUsuario_Click);
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.FlatAppearance.BorderSize = 0;
            this.btn_desplegar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_desplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desplegar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_desplegar.ForeColor = System.Drawing.Color.White;
            this.btn_desplegar.Image = global::LibreriaUniversitaria.Properties.Resources.desplegar__4_;
            this.btn_desplegar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_desplegar.Location = new System.Drawing.Point(1, 10);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_desplegar.Size = new System.Drawing.Size(61, 56);
            this.btn_desplegar.TabIndex = 22;
            this.btn_desplegar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_desplegar.UseVisualStyleBackColor = true;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // timer_animacionMenu
            // 
            this.timer_animacionMenu.Interval = 5;
            this.timer_animacionMenu.Tick += new System.EventHandler(this.timer_animacionMenu_Tick);
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_bienvenida.ForeColor = System.Drawing.Color.White;
            this.lbl_bienvenida.Location = new System.Drawing.Point(3, 10);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(447, 37);
            this.lbl_bienvenida.TabIndex = 7;
            this.lbl_bienvenida.Text = "¡Bienvenido/a, (nombre y apellido)!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lbl_bienvenida);
            this.panel1.Location = new System.Drawing.Point(59, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 55);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pctBox_minimizar);
            this.flowLayoutPanel1.Controls.Add(this.pctBox_salir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(725, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(93, 31);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // pctBox_minimizar
            // 
            this.pctBox_minimizar.Image = global::LibreriaUniversitaria.Properties.Resources.minimizar;
            this.pctBox_minimizar.Location = new System.Drawing.Point(2, 2);
            this.pctBox_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.pctBox_minimizar.Name = "pctBox_minimizar";
            this.pctBox_minimizar.Size = new System.Drawing.Size(41, 29);
            this.pctBox_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_minimizar.TabIndex = 0;
            this.pctBox_minimizar.TabStop = false;
            this.pctBox_minimizar.Click += new System.EventHandler(this.pctBox_minimizar_Click);
            // 
            // pctBox_salir
            // 
            this.pctBox_salir.Image = global::LibreriaUniversitaria.Properties.Resources.cerrar;
            this.pctBox_salir.Location = new System.Drawing.Point(47, 2);
            this.pctBox_salir.Margin = new System.Windows.Forms.Padding(2);
            this.pctBox_salir.Name = "pctBox_salir";
            this.pctBox_salir.Size = new System.Drawing.Size(41, 32);
            this.pctBox_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_salir.TabIndex = 1;
            this.pctBox_salir.TabStop = false;
            this.pctBox_salir.Click += new System.EventHandler(this.pctBox_salir_Click);
            // 
            // timer_carrusel
            // 
            this.timer_carrusel.Interval = 3000;
            // 
            // panel_crearUsuario
            // 
            this.panel_crearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(55)))), ((int)(((byte)(125)))));
            this.panel_crearUsuario.Controls.Add(this.txtBox_DNI);
            this.panel_crearUsuario.Controls.Add(this.label1);
            this.panel_crearUsuario.Controls.Add(this.btn_crearUsuario);
            this.panel_crearUsuario.Controls.Add(this.cBox_rolCrear);
            this.panel_crearUsuario.Controls.Add(this.txtBox_contrasenaCrear);
            this.panel_crearUsuario.Controls.Add(this.txtBox_usuarioCrear);
            this.panel_crearUsuario.Controls.Add(this.txtBox_apellidoCrear);
            this.panel_crearUsuario.Controls.Add(this.lbl_creaUsuario);
            this.panel_crearUsuario.Controls.Add(this.txtBox_nombreCrear);
            this.panel_crearUsuario.Location = new System.Drawing.Point(303, 128);
            this.panel_crearUsuario.Name = "panel_crearUsuario";
            this.panel_crearUsuario.Size = new System.Drawing.Size(445, 423);
            this.panel_crearUsuario.TabIndex = 12;
            // 
            // txtBox_DNI
            // 
            this.txtBox_DNI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_DNI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_DNI.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_DNI.Location = new System.Drawing.Point(40, 253);
            this.txtBox_DNI.Multiline = true;
            this.txtBox_DNI.Name = "txtBox_DNI";
            this.txtBox_DNI.Size = new System.Drawing.Size(177, 40);
            this.txtBox_DNI.TabIndex = 19;
            this.txtBox_DNI.Text = "DNI de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "SOLO VISTA";
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btn_crearUsuario.FlatAppearance.BorderSize = 0;
            this.btn_crearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_crearUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_crearUsuario.Location = new System.Drawing.Point(116, 335);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(212, 42);
            this.btn_crearUsuario.TabIndex = 18;
            this.btn_crearUsuario.Text = "Crear usuario";
            this.btn_crearUsuario.UseVisualStyleBackColor = false;
            this.btn_crearUsuario.Click += new System.EventHandler(this.btn_crearUsuario_Click);
            // 
            // cBox_rolCrear
            // 
            this.cBox_rolCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_rolCrear.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cBox_rolCrear.ForeColor = System.Drawing.Color.Gray;
            this.cBox_rolCrear.FormattingEnabled = true;
            this.cBox_rolCrear.Location = new System.Drawing.Point(234, 265);
            this.cBox_rolCrear.Name = "cBox_rolCrear";
            this.cBox_rolCrear.Size = new System.Drawing.Size(177, 28);
            this.cBox_rolCrear.TabIndex = 17;
            // 
            // txtBox_contrasenaCrear
            // 
            this.txtBox_contrasenaCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_contrasenaCrear.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBox_contrasenaCrear.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_contrasenaCrear.Location = new System.Drawing.Point(234, 192);
            this.txtBox_contrasenaCrear.Multiline = true;
            this.txtBox_contrasenaCrear.Name = "txtBox_contrasenaCrear";
            this.txtBox_contrasenaCrear.Size = new System.Drawing.Size(177, 40);
            this.txtBox_contrasenaCrear.TabIndex = 16;
            this.txtBox_contrasenaCrear.Text = "Contraseña";
            // 
            // txtBox_usuarioCrear
            // 
            this.txtBox_usuarioCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_usuarioCrear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_usuarioCrear.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_usuarioCrear.Location = new System.Drawing.Point(40, 192);
            this.txtBox_usuarioCrear.Multiline = true;
            this.txtBox_usuarioCrear.Name = "txtBox_usuarioCrear";
            this.txtBox_usuarioCrear.Size = new System.Drawing.Size(177, 40);
            this.txtBox_usuarioCrear.TabIndex = 15;
            this.txtBox_usuarioCrear.Text = "Nombre de usuario";
            // 
            // txtBox_apellidoCrear
            // 
            this.txtBox_apellidoCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_apellidoCrear.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBox_apellidoCrear.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_apellidoCrear.Location = new System.Drawing.Point(234, 125);
            this.txtBox_apellidoCrear.Multiline = true;
            this.txtBox_apellidoCrear.Name = "txtBox_apellidoCrear";
            this.txtBox_apellidoCrear.Size = new System.Drawing.Size(177, 40);
            this.txtBox_apellidoCrear.TabIndex = 14;
            this.txtBox_apellidoCrear.Text = "Apellido";
            // 
            // lbl_creaUsuario
            // 
            this.lbl_creaUsuario.AutoSize = true;
            this.lbl_creaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_creaUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_creaUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_creaUsuario.Location = new System.Drawing.Point(79, 57);
            this.lbl_creaUsuario.Name = "lbl_creaUsuario";
            this.lbl_creaUsuario.Size = new System.Drawing.Size(292, 37);
            this.lbl_creaUsuario.TabIndex = 8;
            this.lbl_creaUsuario.Text = "Crea un nuevo usuario";
            this.lbl_creaUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBox_nombreCrear
            // 
            this.txtBox_nombreCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_nombreCrear.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBox_nombreCrear.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_nombreCrear.Location = new System.Drawing.Point(40, 125);
            this.txtBox_nombreCrear.Multiline = true;
            this.txtBox_nombreCrear.Name = "txtBox_nombreCrear";
            this.txtBox_nombreCrear.Size = new System.Drawing.Size(177, 40);
            this.txtBox_nombreCrear.TabIndex = 13;
            this.txtBox_nombreCrear.Text = "Nombre";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::LibreriaUniversitaria.Properties.Resources.usuarios__2_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibreriaUniversitaria.Properties.Resources.libreria;
            this.pictureBox1.Location = new System.Drawing.Point(62, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 581);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::LibreriaUniversitaria.Properties.Resources.usuarios__2_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 25;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_crearUsuario);
            this.Controls.Add(this.dataGrid_usuarios);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuarios)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).EndInit();
            this.panel_crearUsuario.ResumeLayout(false);
            this.panel_crearUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid_usuarios;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Timer timer_animacionMenu;
        private System.Windows.Forms.Button btn_nuevoUsuario;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_carrusel;
        private System.Windows.Forms.Panel panel_crearUsuario;
        private System.Windows.Forms.TextBox txtBox_nombreCrear;
        private System.Windows.Forms.ComboBox cBox_rolCrear;
        private System.Windows.Forms.TextBox txtBox_contrasenaCrear;
        private System.Windows.Forms.TextBox txtBox_usuarioCrear;
        private System.Windows.Forms.TextBox txtBox_apellidoCrear;
        private System.Windows.Forms.Label lbl_creaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_crearUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pctBox_minimizar;
        private System.Windows.Forms.PictureBox pctBox_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewImageColumn inactivar;
        private System.Windows.Forms.TextBox txtBox_DNI;
    }
}

