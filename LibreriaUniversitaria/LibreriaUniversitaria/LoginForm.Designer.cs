namespace Presentacion
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_clave = new System.Windows.Forms.TextBox();
            this.comboBox_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.pctBox_linea2 = new System.Windows.Forms.PictureBox();
            this.pctBox_linea = new System.Windows.Forms.PictureBox();
            this.pctBox_usuario = new System.Windows.Forms.PictureBox();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.pctBox_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pctBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pctBox_salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 554);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Usuario";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_usuario.BackColor = System.Drawing.Color.White;
            this.textBox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.ForeColor = System.Drawing.Color.Gray;
            this.textBox_usuario.Location = new System.Drawing.Point(592, 394);
            this.textBox_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(470, 23);
            this.textBox_usuario.TabIndex = 9;
            this.textBox_usuario.Text = "Usuario";
            this.textBox_usuario.Enter += new System.EventHandler(this.textBox_usuario_Enter);
            this.textBox_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_usuario_KeyDown);
            this.textBox_usuario.Leave += new System.EventHandler(this.textBox_usuario_Leave);
            // 
            // textBox_clave
            // 
            this.textBox_clave.BackColor = System.Drawing.Color.White;
            this.textBox_clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_clave.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_clave.ForeColor = System.Drawing.Color.Gray;
            this.textBox_clave.Location = new System.Drawing.Point(592, 479);
            this.textBox_clave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_clave.Name = "textBox_clave";
            this.textBox_clave.Size = new System.Drawing.Size(470, 23);
            this.textBox_clave.TabIndex = 10;
            this.textBox_clave.Text = "Contraseña";
            this.textBox_clave.Enter += new System.EventHandler(this.textBox_clave_Enter);
            this.textBox_clave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_clave_KeyDown);
            this.textBox_clave.Leave += new System.EventHandler(this.textBox_clave_Leave);
            // 
            // comboBox_tipoUsuario
            // 
            this.comboBox_tipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoUsuario.FormattingEnabled = true;
            this.comboBox_tipoUsuario.Location = new System.Drawing.Point(681, 550);
            this.comboBox_tipoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_tipoUsuario.Name = "comboBox_tipoUsuario";
            this.comboBox_tipoUsuario.Size = new System.Drawing.Size(159, 24);
            this.comboBox_tipoUsuario.TabIndex = 11;
            this.comboBox_tipoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_tipoUsuario_KeyDown);
            // 
            // pctBox_linea2
            // 
            this.pctBox_linea2.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pctBox_linea2.Location = new System.Drawing.Point(590, 510);
            this.pctBox_linea2.Margin = new System.Windows.Forms.Padding(4);
            this.pctBox_linea2.Name = "pctBox_linea2";
            this.pctBox_linea2.Size = new System.Drawing.Size(472, 12);
            this.pctBox_linea2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_linea2.TabIndex = 15;
            this.pctBox_linea2.TabStop = false;
            // 
            // pctBox_linea
            // 
            this.pctBox_linea.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pctBox_linea.Location = new System.Drawing.Point(594, 425);
            this.pctBox_linea.Margin = new System.Windows.Forms.Padding(4);
            this.pctBox_linea.Name = "pctBox_linea";
            this.pctBox_linea.Size = new System.Drawing.Size(471, 12);
            this.pctBox_linea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_linea.TabIndex = 14;
            this.pctBox_linea.TabStop = false;
            // 
            // pctBox_usuario
            // 
            this.pctBox_usuario.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__2_;
            this.pctBox_usuario.Location = new System.Drawing.Point(675, 164);
            this.pctBox_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.pctBox_usuario.Name = "pctBox_usuario";
            this.pctBox_usuario.Size = new System.Drawing.Size(314, 206);
            this.pctBox_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_usuario.TabIndex = 13;
            this.pctBox_usuario.TabStop = false;
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.BackColor = System.Drawing.Color.White;
            this.btn_iniciarSesion.BackgroundImage = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__4_;
            this.btn_iniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_iniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_iniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_iniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_iniciarSesion.Location = new System.Drawing.Point(700, 618);
            this.btn_iniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(265, 69);
            this.btn_iniciarSesion.TabIndex = 5;
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            this.btn_iniciarSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_iniciarSesion_MouseDown);
            this.btn_iniciarSesion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_iniciarSesion_MouseUp);
            // 
            // pctBox_logo
            // 
            this.pctBox_logo.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__1_;
            this.pctBox_logo.Location = new System.Drawing.Point(-170, -25);
            this.pctBox_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pctBox_logo.Name = "pctBox_logo";
            this.pctBox_logo.Size = new System.Drawing.Size(779, 915);
            this.pctBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_logo.TabIndex = 12;
            this.pctBox_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 39);
            this.panel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pctBox_minimizar);
            this.flowLayoutPanel1.Controls.Add(this.pctBox_salir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(985, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 38);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.pctBox_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
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
            this.pctBox_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 830);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctBox_linea2);
            this.Controls.Add(this.pctBox_linea);
            this.Controls.Add(this.pctBox_usuario);
            this.Controls.Add(this.textBox_clave);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.comboBox_tipoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_clave;
        private System.Windows.Forms.ComboBox comboBox_tipoUsuario;
        private System.Windows.Forms.PictureBox pctBox_logo;
        private System.Windows.Forms.PictureBox pctBox_usuario;
        private System.Windows.Forms.PictureBox pctBox_linea;
        private System.Windows.Forms.PictureBox pctBox_linea2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pctBox_minimizar;
        private System.Windows.Forms.PictureBox pctBox_salir;
    }
}