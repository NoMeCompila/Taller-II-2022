
namespace prueba2
{
    partial class FormClientes
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
            this.GBClientes = new System.Windows.Forms.GroupBox();
            this.chb_naranja = new System.Windows.Forms.CheckBox();
            this.chb_mastercard = new System.Windows.Forms.CheckBox();
            this.chb_visa = new System.Windows.Forms.CheckBox();
            this.TXT_tel = new System.Windows.Forms.TextBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_tarjetas = new System.Windows.Forms.Label();
            this.lbl_cambiante = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.rb_varon = new System.Windows.Forms.RadioButton();
            this.rb_mujer = new System.Windows.Forms.RadioButton();
            this.pic_sexo = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.GBClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sexo)).BeginInit();
            this.SuspendLayout();
            // 
            // GBClientes
            // 
            this.GBClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GBClientes.Controls.Add(this.chb_naranja);
            this.GBClientes.Controls.Add(this.chb_mastercard);
            this.GBClientes.Controls.Add(this.chb_visa);
            this.GBClientes.Controls.Add(this.TXT_tel);
            this.GBClientes.Controls.Add(this.txt_DNI);
            this.GBClientes.Controls.Add(this.txt_apellido);
            this.GBClientes.Controls.Add(this.txt_nombre);
            this.GBClientes.Controls.Add(this.lbl_tarjetas);
            this.GBClientes.Controls.Add(this.lbl_cambiante);
            this.GBClientes.Controls.Add(this.lbl_tel);
            this.GBClientes.Controls.Add(this.lbl_DNI);
            this.GBClientes.Controls.Add(this.lbl_apellido);
            this.GBClientes.Controls.Add(this.lbl_nombre);
            this.GBClientes.Controls.Add(this.label1);
            this.GBClientes.Location = new System.Drawing.Point(12, 59);
            this.GBClientes.Name = "GBClientes";
            this.GBClientes.Size = new System.Drawing.Size(290, 433);
            this.GBClientes.TabIndex = 0;
            this.GBClientes.TabStop = false;
            this.GBClientes.Enter += new System.EventHandler(this.GBClientes_Enter);
            // 
            // chb_naranja
            // 
            this.chb_naranja.AutoSize = true;
            this.chb_naranja.ForeColor = System.Drawing.Color.White;
            this.chb_naranja.Location = new System.Drawing.Point(134, 357);
            this.chb_naranja.Name = "chb_naranja";
            this.chb_naranja.Size = new System.Drawing.Size(76, 17);
            this.chb_naranja.TabIndex = 13;
            this.chb_naranja.Text = "NARANJA";
            this.chb_naranja.UseVisualStyleBackColor = true;
            // 
            // chb_mastercard
            // 
            this.chb_mastercard.AutoSize = true;
            this.chb_mastercard.ForeColor = System.Drawing.Color.White;
            this.chb_mastercard.Location = new System.Drawing.Point(134, 319);
            this.chb_mastercard.Name = "chb_mastercard";
            this.chb_mastercard.Size = new System.Drawing.Size(101, 17);
            this.chb_mastercard.TabIndex = 12;
            this.chb_mastercard.Text = "MASTERCARD";
            this.chb_mastercard.UseVisualStyleBackColor = true;
            // 
            // chb_visa
            // 
            this.chb_visa.AutoSize = true;
            this.chb_visa.ForeColor = System.Drawing.Color.White;
            this.chb_visa.Location = new System.Drawing.Point(134, 286);
            this.chb_visa.Name = "chb_visa";
            this.chb_visa.Size = new System.Drawing.Size(50, 17);
            this.chb_visa.TabIndex = 11;
            this.chb_visa.Text = "VISA";
            this.chb_visa.UseVisualStyleBackColor = true;
            // 
            // TXT_tel
            // 
            this.TXT_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TXT_tel.Location = new System.Drawing.Point(134, 218);
            this.TXT_tel.Name = "TXT_tel";
            this.TXT_tel.Size = new System.Drawing.Size(100, 24);
            this.TXT_tel.TabIndex = 10;
            this.TXT_tel.TextChanged += new System.EventHandler(this.TXT_tel_TextChanged);
            this.TXT_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_tel_KeyPress);
            // 
            // txt_DNI
            // 
            this.txt_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_DNI.Location = new System.Drawing.Point(134, 176);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(100, 24);
            this.txt_DNI.TabIndex = 9;
            this.txt_DNI.TextChanged += new System.EventHandler(this.txt_DNI_TextChanged);
            this.txt_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DNI_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_apellido.Location = new System.Drawing.Point(134, 130);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 24);
            this.txt_apellido.TabIndex = 8;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_nombre.Location = new System.Drawing.Point(134, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 24);
            this.txt_nombre.TabIndex = 7;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_tarjetas
            // 
            this.lbl_tarjetas.AutoSize = true;
            this.lbl_tarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_tarjetas.ForeColor = System.Drawing.Color.White;
            this.lbl_tarjetas.Location = new System.Drawing.Point(40, 316);
            this.lbl_tarjetas.Name = "lbl_tarjetas";
            this.lbl_tarjetas.Size = new System.Drawing.Size(65, 18);
            this.lbl_tarjetas.TabIndex = 6;
            this.lbl_tarjetas.Text = "Tarjetas:";
            // 
            // lbl_cambiante
            // 
            this.lbl_cambiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambiante.ForeColor = System.Drawing.Color.Red;
            this.lbl_cambiante.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_cambiante.Location = new System.Drawing.Point(155, 11);
            this.lbl_cambiante.Name = "lbl_cambiante";
            this.lbl_cambiante.Size = new System.Drawing.Size(125, 46);
            this.lbl_cambiante.TabIndex = 5;
            this.lbl_cambiante.Text = "modificar";
            this.lbl_cambiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_tel.ForeColor = System.Drawing.Color.White;
            this.lbl_tel.Location = new System.Drawing.Point(66, 221);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(36, 18);
            this.lbl_tel.TabIndex = 4;
            this.lbl_tel.Text = "Tel.:";
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_DNI.ForeColor = System.Drawing.Color.White;
            this.lbl_DNI.Location = new System.Drawing.Point(66, 179);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(37, 18);
            this.lbl_DNI.TabIndex = 3;
            this.lbl_DNI.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_apellido.Location = new System.Drawing.Point(40, 133);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(63, 18);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido:";
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(37, 88);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(66, 18);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido:";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Red;
            this.LTitulo.Location = new System.Drawing.Point(193, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(99, 24);
            this.LTitulo.TabIndex = 1;
            this.LTitulo.Text = "CLIENTES";
            this.LTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // rb_varon
            // 
            this.rb_varon.AutoSize = true;
            this.rb_varon.Checked = true;
            this.rb_varon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb_varon.Location = new System.Drawing.Point(379, 240);
            this.rb_varon.Name = "rb_varon";
            this.rb_varon.Size = new System.Drawing.Size(64, 21);
            this.rb_varon.TabIndex = 6;
            this.rb_varon.TabStop = true;
            this.rb_varon.Text = "Varon";
            this.rb_varon.UseVisualStyleBackColor = true;
            this.rb_varon.CheckedChanged += new System.EventHandler(this.rb_varon_CheckedChanged);
            // 
            // rb_mujer
            // 
            this.rb_mujer.AutoSize = true;
            this.rb_mujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb_mujer.Location = new System.Drawing.Point(379, 267);
            this.rb_mujer.Name = "rb_mujer";
            this.rb_mujer.Size = new System.Drawing.Size(61, 21);
            this.rb_mujer.TabIndex = 7;
            this.rb_mujer.Text = "Mujer";
            this.rb_mujer.UseVisualStyleBackColor = true;
            this.rb_mujer.CheckedChanged += new System.EventHandler(this.rb_mujer_CheckedChanged);
            // 
            // pic_sexo
            // 
            this.pic_sexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_sexo.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.pic_sexo.Image = global::prueba2.Properties.Resources.male;
            this.pic_sexo.Location = new System.Drawing.Point(355, 102);
            this.pic_sexo.Name = "pic_sexo";
            this.pic_sexo.Size = new System.Drawing.Size(126, 120);
            this.pic_sexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_sexo.TabIndex = 5;
            this.pic_sexo.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::prueba2.Properties.Resources.exit_icon__1_;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(364, 402);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 53);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = global::prueba2.Properties.Resources.remove_ico__1_;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(417, 326);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 53);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::prueba2.Properties.Resources.save_icon__2_;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(311, 326);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 53);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(524, 520);
            this.ControlBox = false;
            this.Controls.Add(this.rb_mujer);
            this.Controls.Add(this.rb_varon);
            this.Controls.Add(this.pic_sexo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.GBClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.GBClientes.ResumeLayout(false);
            this.GBClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBClientes;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_cambiante;
        private System.Windows.Forms.Label lbl_tarjetas;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox TXT_tel;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.CheckBox chb_naranja;
        private System.Windows.Forms.CheckBox chb_mastercard;
        private System.Windows.Forms.CheckBox chb_visa;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pic_sexo;
        private System.Windows.Forms.RadioButton rb_varon;
        private System.Windows.Forms.RadioButton rb_mujer;
    }
}