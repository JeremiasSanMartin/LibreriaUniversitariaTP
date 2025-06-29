namespace Presentacion
{
    partial class BibliotecarioForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_editoriales = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pctBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pctBox_salir = new System.Windows.Forms.PictureBox();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.timer_animacionMenu = new System.Windows.Forms.Timer(this.components);
            this.dataGrid_stock = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGrid_editoriales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto_editoral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_agregarStock = new System.Windows.Forms.Button();
            this.btn_alertasStockBajo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_verLibros = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_editoriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panel_menu.Controls.Add(this.btn_Inicio);
            this.panel_menu.Controls.Add(this.btn_cerrarSesion);
            this.panel_menu.Controls.Add(this.btn_editoriales);
            this.panel_menu.Controls.Add(this.btn_stock);
            this.panel_menu.Controls.Add(this.btn_desplegar);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(65, 631);
            this.panel_menu.TabIndex = 8;
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
            this.btn_Inicio.TabIndex = 24;
            this.btn_Inicio.Text = "  Inicio";
            this.btn_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
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
            this.btn_cerrarSesion.Location = new System.Drawing.Point(1, 565);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cerrarSesion.Size = new System.Drawing.Size(191, 66);
            this.btn_cerrarSesion.TabIndex = 23;
            this.btn_cerrarSesion.Text = "  Cerrar sesion";
            this.btn_cerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // btn_editoriales
            // 
            this.btn_editoriales.FlatAppearance.BorderSize = 0;
            this.btn_editoriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btn_editoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editoriales.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_editoriales.ForeColor = System.Drawing.Color.White;
            this.btn_editoriales.Image = global::LibreriaUniversitaria.Properties.Resources.editorial;
            this.btn_editoriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editoriales.Location = new System.Drawing.Point(0, 362);
            this.btn_editoriales.Name = "btn_editoriales";
            this.btn_editoriales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_editoriales.Size = new System.Drawing.Size(191, 66);
            this.btn_editoriales.TabIndex = 20;
            this.btn_editoriales.Text = "  Editoriales";
            this.btn_editoriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editoriales.UseVisualStyleBackColor = true;
            this.btn_editoriales.Click += new System.EventHandler(this.btn_editoriales_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.Image = global::LibreriaUniversitaria.Properties.Resources.librostock;
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Location = new System.Drawing.Point(0, 301);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_stock.Size = new System.Drawing.Size(191, 66);
            this.btn_stock.TabIndex = 19;
            this.btn_stock.Text = "  Stock";
            this.btn_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lbl_bienvenida);
            this.panel1.Location = new System.Drawing.Point(59, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 55);
            this.panel1.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pctBox_minimizar);
            this.flowLayoutPanel1.Controls.Add(this.pctBox_salir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(723, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(93, 31);
            this.flowLayoutPanel1.TabIndex = 30;
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
            // timer_animacionMenu
            // 
            this.timer_animacionMenu.Interval = 5;
            this.timer_animacionMenu.Tick += new System.EventHandler(this.timer_animacionMenu_Tick);
            // 
            // dataGrid_stock
            // 
            this.dataGrid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_stock.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.autor,
            this.editorial,
            this.stock,
            this.stock_minimo,
            this.precio,
            this.editar});
            this.dataGrid_stock.EnableHeadersVisualStyles = false;
            this.dataGrid_stock.GridColor = System.Drawing.Color.White;
            this.dataGrid_stock.Location = new System.Drawing.Point(150, 70);
            this.dataGrid_stock.Name = "dataGrid_stock";
            this.dataGrid_stock.ReadOnly = true;
            this.dataGrid_stock.RowHeadersVisible = false;
            this.dataGrid_stock.RowHeadersWidth = 51;
            this.dataGrid_stock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_stock.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_stock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_stock.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.dataGrid_stock.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_stock.RowTemplate.Height = 40;
            this.dataGrid_stock.Size = new System.Drawing.Size(709, 508);
            this.dataGrid_stock.TabIndex = 26;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.titulo.FillWeight = 244.0171F;
            this.titulo.HeaderText = "Titulo";
            this.titulo.MinimumWidth = 6;
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 120;
            // 
            // autor
            // 
            this.autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.autor.FillWeight = 164.1291F;
            this.autor.HeaderText = "Autor";
            this.autor.MinimumWidth = 6;
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.Width = 120;
            // 
            // editorial
            // 
            this.editorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editorial.FillWeight = 75.58714F;
            this.editorial.HeaderText = "Editorial";
            this.editorial.MinimumWidth = 6;
            this.editorial.Name = "editorial";
            this.editorial.ReadOnly = true;
            this.editorial.Width = 125;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stock.FillWeight = 31.78815F;
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 60;
            // 
            // stock_minimo
            // 
            this.stock_minimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stock_minimo.HeaderText = "Stock minimo";
            this.stock_minimo.MinimumWidth = 6;
            this.stock_minimo.Name = "stock_minimo";
            this.stock_minimo.ReadOnly = true;
            this.stock_minimo.Width = 60;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precio.FillWeight = 33.51697F;
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar.FillWeight = 50.96173F;
            this.editar.HeaderText = "";
            this.editar.Image = global::LibreriaUniversitaria.Properties.Resources.editar;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 50;
            // 
            // dataGrid_editoriales
            // 
            this.dataGrid_editoriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_editoriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_editoriales.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_editoriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_editoriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_editoriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_editoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_editoriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.contacto_editoral});
            this.dataGrid_editoriales.EnableHeadersVisualStyles = false;
            this.dataGrid_editoriales.GridColor = System.Drawing.Color.White;
            this.dataGrid_editoriales.Location = new System.Drawing.Point(222, 70);
            this.dataGrid_editoriales.Name = "dataGrid_editoriales";
            this.dataGrid_editoriales.ReadOnly = true;
            this.dataGrid_editoriales.RowHeadersVisible = false;
            this.dataGrid_editoriales.RowHeadersWidth = 51;
            this.dataGrid_editoriales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_editoriales.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_editoriales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_editoriales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.dataGrid_editoriales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_editoriales.RowTemplate.Height = 40;
            this.dataGrid_editoriales.Size = new System.Drawing.Size(501, 524);
            this.dataGrid_editoriales.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.FillWeight = 75.58714F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Editorial";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // contacto_editoral
            // 
            this.contacto_editoral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.contacto_editoral.HeaderText = "Contacto";
            this.contacto_editoral.MinimumWidth = 6;
            this.contacto_editoral.Name = "contacto_editoral";
            this.contacto_editoral.ReadOnly = true;
            this.contacto_editoral.Width = 250;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50.96173F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::LibreriaUniversitaria.Properties.Resources.editar;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btn_agregarStock
            // 
            this.btn_agregarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_agregarStock.FlatAppearance.BorderSize = 0;
            this.btn_agregarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarStock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_agregarStock.ForeColor = System.Drawing.Color.White;
            this.btn_agregarStock.Image = global::LibreriaUniversitaria.Properties.Resources.add_blanco;
            this.btn_agregarStock.Location = new System.Drawing.Point(197, 584);
            this.btn_agregarStock.Name = "btn_agregarStock";
            this.btn_agregarStock.Size = new System.Drawing.Size(164, 37);
            this.btn_agregarStock.TabIndex = 27;
            this.btn_agregarStock.Text = "Agregar stock";
            this.btn_agregarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregarStock.UseVisualStyleBackColor = false;
            // 
            // btn_alertasStockBajo
            // 
            this.btn_alertasStockBajo.BackColor = System.Drawing.Color.White;
            this.btn_alertasStockBajo.FlatAppearance.BorderSize = 0;
            this.btn_alertasStockBajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alertasStockBajo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_alertasStockBajo.ForeColor = System.Drawing.Color.Red;
            this.btn_alertasStockBajo.Image = global::LibreriaUniversitaria.Properties.Resources.alerta__2_;
            this.btn_alertasStockBajo.Location = new System.Drawing.Point(649, 584);
            this.btn_alertasStockBajo.Name = "btn_alertasStockBajo";
            this.btn_alertasStockBajo.Size = new System.Drawing.Size(210, 37);
            this.btn_alertasStockBajo.TabIndex = 28;
            this.btn_alertasStockBajo.Text = "Ver alertas de stock bajo";
            this.btn_alertasStockBajo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alertasStockBajo.UseVisualStyleBackColor = false;
            this.btn_alertasStockBajo.Click += new System.EventHandler(this.btn_alertasStockBajo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibreriaUniversitaria.Properties.Resources.libreria;
            this.pictureBox1.Location = new System.Drawing.Point(53, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 581);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_verLibros
            // 
            this.btn_verLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btn_verLibros.FlatAppearance.BorderSize = 0;
            this.btn_verLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verLibros.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_verLibros.ForeColor = System.Drawing.Color.White;
            this.btn_verLibros.Image = global::LibreriaUniversitaria.Properties.Resources.add_blanco;
            this.btn_verLibros.Location = new System.Drawing.Point(383, 584);
            this.btn_verLibros.Name = "btn_verLibros";
            this.btn_verLibros.Size = new System.Drawing.Size(164, 37);
            this.btn_verLibros.TabIndex = 30;
            this.btn_verLibros.Text = "Ver libros";
            this.btn_verLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_verLibros.UseVisualStyleBackColor = false;
            this.btn_verLibros.Click += new System.EventHandler(this.btn_verLibros_Click);
            // 
            // BibliotecarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 631);
            this.Controls.Add(this.btn_verLibros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.dataGrid_stock);
            this.Controls.Add(this.btn_agregarStock);
            this.Controls.Add(this.btn_alertasStockBajo);
            this.Controls.Add(this.dataGrid_editoriales);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BibliotecarioForm";
            this.Text = "BibliotecarioForm";
            this.panel_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_editoriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Button btn_editoriales;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Timer timer_animacionMenu;
        private System.Windows.Forms.DataGridView dataGrid_stock;
        private System.Windows.Forms.Button btn_agregarStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_alertasStockBajo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dataGrid_editoriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto_editoral;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pctBox_minimizar;
        private System.Windows.Forms.PictureBox pctBox_salir;
        private System.Windows.Forms.Button btn_verLibros;
    }
}