namespace Presentacion
{
    partial class GerenteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.dataGrid_reportes = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_animacionMenu = new System.Windows.Forms.Timer(this.components);
            this.txtBox_busquedaReporte = new System.Windows.Forms.TextBox();
            this.dateTimePicker_mes = new System.Windows.Forms.DateTimePicker();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pctBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pctBox_salir = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lbl_bienvenida);
            this.panel1.Location = new System.Drawing.Point(79, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 68);
            this.panel1.TabIndex = 28;
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_bienvenida.ForeColor = System.Drawing.Color.White;
            this.lbl_bienvenida.Location = new System.Drawing.Point(4, 12);
            this.lbl_bienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(562, 46);
            this.lbl_bienvenida.TabIndex = 7;
            this.lbl_bienvenida.Text = "¡Bienvenido/a, (nombre y apellido)!";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panel_menu.Controls.Add(this.btn_Inicio);
            this.panel_menu.Controls.Add(this.btn_cerrarSesion);
            this.panel_menu.Controls.Add(this.btn_reportes);
            this.panel_menu.Controls.Add(this.btn_desplegar);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(233, 777);
            this.panel_menu.TabIndex = 26;
            // 
            // dataGrid_reportes
            // 
            this.dataGrid_reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_reportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_reportes.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_reportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_reportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_reportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_reportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.cliente,
            this.vendedor,
            this.total,
            this.detalle});
            this.dataGrid_reportes.EnableHeadersVisualStyles = false;
            this.dataGrid_reportes.GridColor = System.Drawing.Color.White;
            this.dataGrid_reportes.Location = new System.Drawing.Point(280, 137);
            this.dataGrid_reportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid_reportes.Name = "dataGrid_reportes";
            this.dataGrid_reportes.ReadOnly = true;
            this.dataGrid_reportes.RowHeadersVisible = false;
            this.dataGrid_reportes.RowHeadersWidth = 51;
            this.dataGrid_reportes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_reportes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_reportes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_reportes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.dataGrid_reportes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_reportes.RowTemplate.Height = 40;
            this.dataGrid_reportes.Size = new System.Drawing.Size(855, 625);
            this.dataGrid_reportes.TabIndex = 29;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 120;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cliente.FillWeight = 244.0171F;
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 140;
            // 
            // vendedor
            // 
            this.vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vendedor.FillWeight = 164.1291F;
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.MinimumWidth = 6;
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Width = 140;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total.FillWeight = 33.51697F;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // detalle
            // 
            this.detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.detalle.HeaderText = "Detalle";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 140;
            // 
            // timer_animacionMenu
            // 
            this.timer_animacionMenu.Interval = 5;
            this.timer_animacionMenu.Tick += new System.EventHandler(this.timer_animacionMenu_Tick);
            // 
            // txtBox_busquedaReporte
            // 
            this.txtBox_busquedaReporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBox_busquedaReporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_busquedaReporte.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_busquedaReporte.Location = new System.Drawing.Point(280, 96);
            this.txtBox_busquedaReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_busquedaReporte.Multiline = true;
            this.txtBox_busquedaReporte.Name = "txtBox_busquedaReporte";
            this.txtBox_busquedaReporte.Size = new System.Drawing.Size(231, 32);
            this.txtBox_busquedaReporte.TabIndex = 30;
            this.txtBox_busquedaReporte.Text = "Buscar vendedor...";
            // 
            // dateTimePicker_mes
            // 
            this.dateTimePicker_mes.CustomFormat = "MMMM";
            this.dateTimePicker_mes.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dateTimePicker_mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_mes.Location = new System.Drawing.Point(920, 96);
            this.dateTimePicker_mes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_mes.Name = "dateTimePicker_mes";
            this.dateTimePicker_mes.Size = new System.Drawing.Size(213, 32);
            this.dateTimePicker_mes.TabIndex = 31;
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
            this.btn_Inicio.Location = new System.Drawing.Point(0, 331);
            this.btn_Inicio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Inicio.Size = new System.Drawing.Size(255, 81);
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
            this.btn_cerrarSesion.Location = new System.Drawing.Point(1, 695);
            this.btn_cerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cerrarSesion.Size = new System.Drawing.Size(255, 81);
            this.btn_cerrarSesion.TabIndex = 23;
            this.btn_cerrarSesion.Text = "  Cerrar sesion";
            this.btn_cerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.Image = global::LibreriaUniversitaria.Properties.Resources.reportes;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 406);
            this.btn_reportes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_reportes.Size = new System.Drawing.Size(255, 81);
            this.btn_reportes.TabIndex = 19;
            this.btn_reportes.Text = "  Reportes";
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
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
            this.btn_desplegar.Location = new System.Drawing.Point(1, 12);
            this.btn_desplegar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_desplegar.Size = new System.Drawing.Size(81, 69);
            this.btn_desplegar.TabIndex = 22;
            this.btn_desplegar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_desplegar.UseVisualStyleBackColor = true;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibreriaUniversitaria.Properties.Resources.libreria;
            this.pictureBox1.Location = new System.Drawing.Point(79, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1091, 715);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pctBox_minimizar);
            this.flowLayoutPanel1.Controls.Add(this.pctBox_salir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(964, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 38);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // pctBox_minimizar
            // 
            this.pctBox_minimizar.Image = global::LibreriaUniversitaria.Properties.Resources.minimizar;
            this.pctBox_minimizar.Location = new System.Drawing.Point(3, 3);
            this.pctBox_minimizar.Name = "pctBox_minimizar";
            this.pctBox_minimizar.Size = new System.Drawing.Size(55, 36);
            this.pctBox_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_minimizar.TabIndex = 0;
            this.pctBox_minimizar.TabStop = false;
            this.pctBox_minimizar.Click += new System.EventHandler(this.pctBox_minimizar_Click);
            // 
            // pctBox_salir
            // 
            this.pctBox_salir.Image = global::LibreriaUniversitaria.Properties.Resources.cerrar;
            this.pctBox_salir.Location = new System.Drawing.Point(64, 3);
            this.pctBox_salir.Name = "pctBox_salir";
            this.pctBox_salir.Size = new System.Drawing.Size(55, 39);
            this.pctBox_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_salir.TabIndex = 1;
            this.pctBox_salir.TabStop = false;
            this.pctBox_salir.Click += new System.EventHandler(this.pctBox_salir_Click);
            // 
            // GerenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 777);
            this.Controls.Add(this.dateTimePicker_mes);
            this.Controls.Add(this.txtBox_busquedaReporte);
            this.Controls.Add(this.dataGrid_reportes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GerenteForm";
            this.Text = "GerenteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGrid_reportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.Timer timer_animacionMenu;
        private System.Windows.Forms.TextBox txtBox_busquedaReporte;
        private System.Windows.Forms.DateTimePicker dateTimePicker_mes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pctBox_minimizar;
        private System.Windows.Forms.PictureBox pctBox_salir;
    }
}