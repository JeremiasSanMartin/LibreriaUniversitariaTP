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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(827, 619);
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
            this.label3.Location = new System.Drawing.Point(496, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Usuario";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.BackColor = System.Drawing.Color.White;
            this.textBox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.ForeColor = System.Drawing.Color.Gray;
            this.textBox_usuario.Location = new System.Drawing.Point(498, 315);
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
            this.textBox_clave.Location = new System.Drawing.Point(498, 383);
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
            this.comboBox_tipoUsuario.Location = new System.Drawing.Point(569, 440);
            this.comboBox_tipoUsuario.Name = "comboBox_tipoUsuario";
            this.comboBox_tipoUsuario.Size = new System.Drawing.Size(128, 21);
            this.comboBox_tipoUsuario.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pictureBox4.Location = new System.Drawing.Point(496, 408);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(378, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pictureBox3.Location = new System.Drawing.Point(499, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(377, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__2_;
            this.pictureBox2.Location = new System.Drawing.Point(564, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
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
            this.btn_iniciarSesion.Location = new System.Drawing.Point(584, 494);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(212, 55);
            this.btn_iniciarSesion.TabIndex = 5;
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            this.btn_iniciarSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_iniciarSesion_MouseDown);
            this.btn_iniciarSesion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_iniciarSesion_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibreriaUniversitaria.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-136, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 664);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_clave);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_tipoUsuario);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}