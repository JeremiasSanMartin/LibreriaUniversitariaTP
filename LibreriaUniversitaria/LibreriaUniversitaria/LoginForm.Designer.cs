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
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_clave = new System.Windows.Forms.TextBox();
            this.comboBox_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.pctBox_linea2 = new System.Windows.Forms.PictureBox();
            this.pctBox_linea = new System.Windows.Forms.PictureBox();
            this.pctBox_usuario = new System.Windows.Forms.PictureBox();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.pctBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(765, 619);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(109, 33);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
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
            this.textBox_usuario.Location = new System.Drawing.Point(474, 315);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(376, 19);
            this.textBox_usuario.TabIndex = 9;
            this.textBox_usuario.Text = "Usuario";
            this.textBox_usuario.Enter += new System.EventHandler(this.textBox_usuario_Enter);
            this.textBox_usuario.Leave += new System.EventHandler(this.textBox_usuario_Leave);
            // 
            // textBox_clave
            // 
            this.textBox_clave.BackColor = System.Drawing.Color.White;
            this.textBox_clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_clave.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_clave.ForeColor = System.Drawing.Color.Gray;
            this.textBox_clave.Location = new System.Drawing.Point(474, 383);
            this.textBox_clave.Name = "textBox_clave";
            this.textBox_clave.Size = new System.Drawing.Size(376, 19);
            this.textBox_clave.TabIndex = 10;
            this.textBox_clave.Text = "Contraseña";
            this.textBox_clave.Enter += new System.EventHandler(this.textBox_clave_Enter);
            this.textBox_clave.Leave += new System.EventHandler(this.textBox_clave_Leave);
            // 
            // comboBox_tipoUsuario
            // 
            this.comboBox_tipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoUsuario.FormattingEnabled = true;
            this.comboBox_tipoUsuario.Location = new System.Drawing.Point(545, 440);
            this.comboBox_tipoUsuario.Name = "comboBox_tipoUsuario";
            this.comboBox_tipoUsuario.Size = new System.Drawing.Size(128, 21);
            this.comboBox_tipoUsuario.TabIndex = 11;
            // 
            // pctBox_linea2
            // 
            this.pctBox_linea2.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pctBox_linea2.Location = new System.Drawing.Point(472, 408);
            this.pctBox_linea2.Name = "pctBox_linea2";
            this.pctBox_linea2.Size = new System.Drawing.Size(378, 10);
            this.pctBox_linea2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_linea2.TabIndex = 15;
            this.pctBox_linea2.TabStop = false;
            // 
            // pctBox_linea
            // 
            this.pctBox_linea.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pctBox_linea.Location = new System.Drawing.Point(475, 340);
            this.pctBox_linea.Name = "pctBox_linea";
            this.pctBox_linea.Size = new System.Drawing.Size(377, 10);
            this.pctBox_linea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_linea.TabIndex = 14;
            this.pctBox_linea.TabStop = false;
            // 
            // pctBox_usuario
            // 
            this.pctBox_usuario.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__2_;
            this.pctBox_usuario.Location = new System.Drawing.Point(540, 131);
            this.pctBox_usuario.Name = "pctBox_usuario";
            this.pctBox_usuario.Size = new System.Drawing.Size(251, 165);
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
            this.btn_iniciarSesion.Location = new System.Drawing.Point(560, 494);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(212, 55);
            this.btn_iniciarSesion.TabIndex = 5;
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            this.btn_iniciarSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_iniciarSesion_MouseDown);
            this.btn_iniciarSesion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_iniciarSesion_MouseUp);
            // 
            // pctBox_logo
            // 
            this.pctBox_logo.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__1_;
            this.pctBox_logo.Location = new System.Drawing.Point(-136, -20);
            this.pctBox_logo.Name = "pctBox_logo";
            this.pctBox_logo.Size = new System.Drawing.Size(623, 732);
            this.pctBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox_logo.TabIndex = 12;
            this.pctBox_logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 664);
            this.Controls.Add(this.pctBox_linea2);
            this.Controls.Add(this.pctBox_linea);
            this.Controls.Add(this.pctBox_usuario);
            this.Controls.Add(this.textBox_clave);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.comboBox_tipoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.pctBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_linea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_clave;
        private System.Windows.Forms.ComboBox comboBox_tipoUsuario;
        private System.Windows.Forms.PictureBox pctBox_logo;
        private System.Windows.Forms.PictureBox pctBox_usuario;
        private System.Windows.Forms.PictureBox pctBox_linea;
        private System.Windows.Forms.PictureBox pctBox_linea2;
    }
}