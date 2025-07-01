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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_agregarLibroMenu = new System.Windows.Forms.Button();
            this.btn_alertasStockBajo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_verLibros = new System.Windows.Forms.Button();
            this.panel_agregarLibro = new System.Windows.Forms.Panel();
            this.comboBox_editoriales = new System.Windows.Forms.ComboBox();
            this.btn_agregarLibro = new System.Windows.Forms.Button();
            this.label_precio = new System.Windows.Forms.Label();
            this.txtBox_precio = new System.Windows.Forms.TextBox();
            this.textBox_StockMinimo = new System.Windows.Forms.TextBox();
            this.label_Editorial = new System.Windows.Forms.Label();
            this.label_Autor = new System.Windows.Forms.Label();
            this.txtBox_stockActual = new System.Windows.Forms.TextBox();
            this.txtBox_autor = new System.Windows.Forms.TextBox();
            this.txtBox_titulo = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_stockActual = new System.Windows.Forms.Label();
            this.label_stockMinimo = new System.Windows.Forms.Label();
            this.panel_editarLibro = new System.Windows.Forms.Panel();
            this.label_tituloEditar = new System.Windows.Forms.Label();
            this.txtBox_tituloEditar = new System.Windows.Forms.TextBox();
            this.label_AutorEditar = new System.Windows.Forms.Label();
            this.txtBox_AutorEditar = new System.Windows.Forms.TextBox();
            this.label_editorialEditar = new System.Windows.Forms.Label();
            this.comboBox_EditorialEditar = new System.Windows.Forms.ComboBox();
            this.label_StockActualEditar = new System.Windows.Forms.Label();
            this.textBox_StockActualEditar = new System.Windows.Forms.TextBox();
            this.label_StockMinimoEditar = new System.Windows.Forms.Label();
            this.txtBox_StockMinimoEditar = new System.Windows.Forms.TextBox();
            this.label_PrecioEditar = new System.Windows.Forms.Label();
            this.txtBox_PrecioEditar = new System.Windows.Forms.TextBox();
            this.btn_EditarLibro = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_editoriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_agregarLibro.SuspendLayout();
            this.panel_editarLibro.SuspendLayout();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.dataGrid_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_stock_CellContentClick);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_editoriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // btn_agregarLibroMenu
            // 
            this.btn_agregarLibroMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_agregarLibroMenu.FlatAppearance.BorderSize = 0;
            this.btn_agregarLibroMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarLibroMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_agregarLibroMenu.ForeColor = System.Drawing.Color.White;
            this.btn_agregarLibroMenu.Image = global::LibreriaUniversitaria.Properties.Resources.add_blanco;
            this.btn_agregarLibroMenu.Location = new System.Drawing.Point(197, 584);
            this.btn_agregarLibroMenu.Name = "btn_agregarLibroMenu";
            this.btn_agregarLibroMenu.Size = new System.Drawing.Size(164, 37);
            this.btn_agregarLibroMenu.TabIndex = 27;
            this.btn_agregarLibroMenu.Text = "Agregar libro";
            this.btn_agregarLibroMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregarLibroMenu.UseVisualStyleBackColor = false;
            this.btn_agregarLibroMenu.Click += new System.EventHandler(this.btn_agregarLibroMenu_Click);
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
            // panel_agregarLibro
            // 
            this.panel_agregarLibro.BackColor = System.Drawing.Color.Silver;
            this.panel_agregarLibro.Controls.Add(this.comboBox_editoriales);
            this.panel_agregarLibro.Controls.Add(this.btn_agregarLibro);
            this.panel_agregarLibro.Controls.Add(this.label_precio);
            this.panel_agregarLibro.Controls.Add(this.txtBox_precio);
            this.panel_agregarLibro.Controls.Add(this.textBox_StockMinimo);
            this.panel_agregarLibro.Controls.Add(this.label_Editorial);
            this.panel_agregarLibro.Controls.Add(this.label_Autor);
            this.panel_agregarLibro.Controls.Add(this.txtBox_stockActual);
            this.panel_agregarLibro.Controls.Add(this.txtBox_autor);
            this.panel_agregarLibro.Controls.Add(this.txtBox_titulo);
            this.panel_agregarLibro.Controls.Add(this.label_titulo);
            this.panel_agregarLibro.Controls.Add(this.label_stockActual);
            this.panel_agregarLibro.Controls.Add(this.label_stockMinimo);
            this.panel_agregarLibro.Location = new System.Drawing.Point(304, 152);
            this.panel_agregarLibro.Name = "panel_agregarLibro";
            this.panel_agregarLibro.Size = new System.Drawing.Size(393, 335);
            this.panel_agregarLibro.TabIndex = 31;
            // 
            // comboBox_editoriales
            // 
            this.comboBox_editoriales.FormattingEnabled = true;
            this.comboBox_editoriales.Location = new System.Drawing.Point(47, 195);
            this.comboBox_editoriales.Name = "comboBox_editoriales";
            this.comboBox_editoriales.Size = new System.Drawing.Size(112, 21);
            this.comboBox_editoriales.TabIndex = 13;
            // 
            // btn_agregarLibro
            // 
            this.btn_agregarLibro.Location = new System.Drawing.Point(136, 268);
            this.btn_agregarLibro.Name = "btn_agregarLibro";
            this.btn_agregarLibro.Size = new System.Drawing.Size(107, 30);
            this.btn_agregarLibro.TabIndex = 12;
            this.btn_agregarLibro.Text = "Agregar libro";
            this.btn_agregarLibro.UseVisualStyleBackColor = true;
            this.btn_agregarLibro.Click += new System.EventHandler(this.btn_agregarLibro_Click);
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(195, 118);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(37, 13);
            this.label_precio.TabIndex = 11;
            this.label_precio.Text = "Precio";
            // 
            // txtBox_precio
            // 
            this.txtBox_precio.Location = new System.Drawing.Point(198, 134);
            this.txtBox_precio.Name = "txtBox_precio";
            this.txtBox_precio.Size = new System.Drawing.Size(112, 20);
            this.txtBox_precio.TabIndex = 10;
            // 
            // textBox_StockMinimo
            // 
            this.textBox_StockMinimo.Location = new System.Drawing.Point(198, 88);
            this.textBox_StockMinimo.Name = "textBox_StockMinimo";
            this.textBox_StockMinimo.Size = new System.Drawing.Size(112, 20);
            this.textBox_StockMinimo.TabIndex = 9;
            // 
            // label_Editorial
            // 
            this.label_Editorial.AutoSize = true;
            this.label_Editorial.Location = new System.Drawing.Point(44, 177);
            this.label_Editorial.Name = "label_Editorial";
            this.label_Editorial.Size = new System.Drawing.Size(44, 13);
            this.label_Editorial.TabIndex = 8;
            this.label_Editorial.Text = "Editorial";
            // 
            // label_Autor
            // 
            this.label_Autor.AutoSize = true;
            this.label_Autor.Location = new System.Drawing.Point(44, 118);
            this.label_Autor.Name = "label_Autor";
            this.label_Autor.Size = new System.Drawing.Size(32, 13);
            this.label_Autor.TabIndex = 7;
            this.label_Autor.Text = "Autor";
            // 
            // txtBox_stockActual
            // 
            this.txtBox_stockActual.Location = new System.Drawing.Point(198, 195);
            this.txtBox_stockActual.Name = "txtBox_stockActual";
            this.txtBox_stockActual.Size = new System.Drawing.Size(112, 20);
            this.txtBox_stockActual.TabIndex = 6;
            // 
            // txtBox_autor
            // 
            this.txtBox_autor.Location = new System.Drawing.Point(47, 134);
            this.txtBox_autor.Name = "txtBox_autor";
            this.txtBox_autor.Size = new System.Drawing.Size(112, 20);
            this.txtBox_autor.TabIndex = 4;
            // 
            // txtBox_titulo
            // 
            this.txtBox_titulo.Location = new System.Drawing.Point(47, 88);
            this.txtBox_titulo.Name = "txtBox_titulo";
            this.txtBox_titulo.Size = new System.Drawing.Size(112, 20);
            this.txtBox_titulo.TabIndex = 3;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Location = new System.Drawing.Point(47, 72);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(33, 13);
            this.label_titulo.TabIndex = 2;
            this.label_titulo.Text = "Titulo";
            // 
            // label_stockActual
            // 
            this.label_stockActual.AutoSize = true;
            this.label_stockActual.Location = new System.Drawing.Point(198, 177);
            this.label_stockActual.Name = "label_stockActual";
            this.label_stockActual.Size = new System.Drawing.Size(67, 13);
            this.label_stockActual.TabIndex = 1;
            this.label_stockActual.Text = "Stock actual";
            // 
            // label_stockMinimo
            // 
            this.label_stockMinimo.AutoSize = true;
            this.label_stockMinimo.Location = new System.Drawing.Point(195, 72);
            this.label_stockMinimo.Name = "label_stockMinimo";
            this.label_stockMinimo.Size = new System.Drawing.Size(70, 13);
            this.label_stockMinimo.TabIndex = 0;
            this.label_stockMinimo.Text = "Stock minimo";
            // 
            // panel_editarLibro
            // 
            this.panel_editarLibro.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_editarLibro.Controls.Add(this.btn_EditarLibro);
            this.panel_editarLibro.Controls.Add(this.txtBox_PrecioEditar);
            this.panel_editarLibro.Controls.Add(this.label_PrecioEditar);
            this.panel_editarLibro.Controls.Add(this.txtBox_StockMinimoEditar);
            this.panel_editarLibro.Controls.Add(this.label_StockMinimoEditar);
            this.panel_editarLibro.Controls.Add(this.textBox_StockActualEditar);
            this.panel_editarLibro.Controls.Add(this.label_StockActualEditar);
            this.panel_editarLibro.Controls.Add(this.comboBox_EditorialEditar);
            this.panel_editarLibro.Controls.Add(this.label_editorialEditar);
            this.panel_editarLibro.Controls.Add(this.txtBox_AutorEditar);
            this.panel_editarLibro.Controls.Add(this.label_AutorEditar);
            this.panel_editarLibro.Controls.Add(this.txtBox_tituloEditar);
            this.panel_editarLibro.Controls.Add(this.label_tituloEditar);
            this.panel_editarLibro.Location = new System.Drawing.Point(304, 152);
            this.panel_editarLibro.Name = "panel_editarLibro";
            this.panel_editarLibro.Size = new System.Drawing.Size(393, 335);
            this.panel_editarLibro.TabIndex = 14;
            // 
            // label_tituloEditar
            // 
            this.label_tituloEditar.AutoSize = true;
            this.label_tituloEditar.Location = new System.Drawing.Point(80, 70);
            this.label_tituloEditar.Name = "label_tituloEditar";
            this.label_tituloEditar.Size = new System.Drawing.Size(33, 13);
            this.label_tituloEditar.TabIndex = 0;
            this.label_tituloEditar.Text = "Titulo";
            // 
            // txtBox_tituloEditar
            // 
            this.txtBox_tituloEditar.Location = new System.Drawing.Point(83, 86);
            this.txtBox_tituloEditar.Name = "txtBox_tituloEditar";
            this.txtBox_tituloEditar.Size = new System.Drawing.Size(100, 20);
            this.txtBox_tituloEditar.TabIndex = 1;
            // 
            // label_AutorEditar
            // 
            this.label_AutorEditar.AutoSize = true;
            this.label_AutorEditar.Location = new System.Drawing.Point(80, 156);
            this.label_AutorEditar.Name = "label_AutorEditar";
            this.label_AutorEditar.Size = new System.Drawing.Size(32, 13);
            this.label_AutorEditar.TabIndex = 2;
            this.label_AutorEditar.Text = "Autor";
            // 
            // txtBox_AutorEditar
            // 
            this.txtBox_AutorEditar.Location = new System.Drawing.Point(83, 172);
            this.txtBox_AutorEditar.Name = "txtBox_AutorEditar";
            this.txtBox_AutorEditar.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AutorEditar.TabIndex = 3;
            // 
            // label_editorialEditar
            // 
            this.label_editorialEditar.AutoSize = true;
            this.label_editorialEditar.Location = new System.Drawing.Point(80, 231);
            this.label_editorialEditar.Name = "label_editorialEditar";
            this.label_editorialEditar.Size = new System.Drawing.Size(44, 13);
            this.label_editorialEditar.TabIndex = 4;
            this.label_editorialEditar.Text = "Editorial";
            // 
            // comboBox_EditorialEditar
            // 
            this.comboBox_EditorialEditar.FormattingEnabled = true;
            this.comboBox_EditorialEditar.Location = new System.Drawing.Point(83, 247);
            this.comboBox_EditorialEditar.Name = "comboBox_EditorialEditar";
            this.comboBox_EditorialEditar.Size = new System.Drawing.Size(100, 21);
            this.comboBox_EditorialEditar.TabIndex = 5;
            // 
            // label_StockActualEditar
            // 
            this.label_StockActualEditar.AutoSize = true;
            this.label_StockActualEditar.Location = new System.Drawing.Point(216, 70);
            this.label_StockActualEditar.Name = "label_StockActualEditar";
            this.label_StockActualEditar.Size = new System.Drawing.Size(67, 13);
            this.label_StockActualEditar.TabIndex = 6;
            this.label_StockActualEditar.Text = "Stock actual";
            // 
            // textBox_StockActualEditar
            // 
            this.textBox_StockActualEditar.Location = new System.Drawing.Point(219, 86);
            this.textBox_StockActualEditar.Name = "textBox_StockActualEditar";
            this.textBox_StockActualEditar.Size = new System.Drawing.Size(100, 20);
            this.textBox_StockActualEditar.TabIndex = 7;
            // 
            // label_StockMinimoEditar
            // 
            this.label_StockMinimoEditar.AutoSize = true;
            this.label_StockMinimoEditar.Location = new System.Drawing.Point(216, 156);
            this.label_StockMinimoEditar.Name = "label_StockMinimoEditar";
            this.label_StockMinimoEditar.Size = new System.Drawing.Size(70, 13);
            this.label_StockMinimoEditar.TabIndex = 8;
            this.label_StockMinimoEditar.Text = "Stock minimo";
            // 
            // txtBox_StockMinimoEditar
            // 
            this.txtBox_StockMinimoEditar.Location = new System.Drawing.Point(219, 172);
            this.txtBox_StockMinimoEditar.Name = "txtBox_StockMinimoEditar";
            this.txtBox_StockMinimoEditar.Size = new System.Drawing.Size(100, 20);
            this.txtBox_StockMinimoEditar.TabIndex = 9;
            // 
            // label_PrecioEditar
            // 
            this.label_PrecioEditar.AutoSize = true;
            this.label_PrecioEditar.Location = new System.Drawing.Point(216, 231);
            this.label_PrecioEditar.Name = "label_PrecioEditar";
            this.label_PrecioEditar.Size = new System.Drawing.Size(37, 13);
            this.label_PrecioEditar.TabIndex = 10;
            this.label_PrecioEditar.Text = "Precio";
            // 
            // txtBox_PrecioEditar
            // 
            this.txtBox_PrecioEditar.Location = new System.Drawing.Point(219, 247);
            this.txtBox_PrecioEditar.Name = "txtBox_PrecioEditar";
            this.txtBox_PrecioEditar.Size = new System.Drawing.Size(100, 20);
            this.txtBox_PrecioEditar.TabIndex = 11;
            // 
            // btn_EditarLibro
            // 
            this.btn_EditarLibro.Location = new System.Drawing.Point(153, 287);
            this.btn_EditarLibro.Name = "btn_EditarLibro";
            this.btn_EditarLibro.Size = new System.Drawing.Size(90, 28);
            this.btn_EditarLibro.TabIndex = 12;
            this.btn_EditarLibro.Text = "Editar libro";
            this.btn_EditarLibro.UseVisualStyleBackColor = true;
            this.btn_EditarLibro.Click += new System.EventHandler(this.btn_EditarLibro_Click);
            // 
            // BibliotecarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 631);
            this.Controls.Add(this.panel_editarLibro);
            this.Controls.Add(this.panel_agregarLibro);
            this.Controls.Add(this.btn_verLibros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.dataGrid_stock);
            this.Controls.Add(this.btn_agregarLibroMenu);
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
            this.panel_agregarLibro.ResumeLayout(false);
            this.panel_agregarLibro.PerformLayout();
            this.panel_editarLibro.ResumeLayout(false);
            this.panel_editarLibro.PerformLayout();
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
        private System.Windows.Forms.Button btn_agregarLibroMenu;
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
        private System.Windows.Forms.Panel panel_agregarLibro;
        private System.Windows.Forms.Label label_stockMinimo;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_stockActual;
        private System.Windows.Forms.TextBox txtBox_precio;
        private System.Windows.Forms.TextBox textBox_StockMinimo;
        private System.Windows.Forms.Label label_Editorial;
        private System.Windows.Forms.Label label_Autor;
        private System.Windows.Forms.TextBox txtBox_stockActual;
        private System.Windows.Forms.TextBox txtBox_autor;
        private System.Windows.Forms.TextBox txtBox_titulo;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Button btn_agregarLibro;
        private System.Windows.Forms.ComboBox comboBox_editoriales;
        private System.Windows.Forms.Panel panel_editarLibro;
        private System.Windows.Forms.Label label_StockMinimoEditar;
        private System.Windows.Forms.TextBox textBox_StockActualEditar;
        private System.Windows.Forms.Label label_StockActualEditar;
        private System.Windows.Forms.ComboBox comboBox_EditorialEditar;
        private System.Windows.Forms.Label label_editorialEditar;
        private System.Windows.Forms.TextBox txtBox_AutorEditar;
        private System.Windows.Forms.Label label_AutorEditar;
        private System.Windows.Forms.TextBox txtBox_tituloEditar;
        private System.Windows.Forms.Label label_tituloEditar;
        private System.Windows.Forms.Button btn_EditarLibro;
        private System.Windows.Forms.TextBox txtBox_PrecioEditar;
        private System.Windows.Forms.Label label_PrecioEditar;
        private System.Windows.Forms.TextBox txtBox_StockMinimoEditar;
    }
}