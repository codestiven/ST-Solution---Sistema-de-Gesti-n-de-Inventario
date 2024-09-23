namespace Práctica_de_acceso_a_Datos
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.buscar_img = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.apellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.genero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.registrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.img = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar_img
            // 
            this.buscar_img.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buscar_img.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buscar_img.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buscar_img.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buscar_img.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_img.ForeColor = System.Drawing.Color.White;
            this.buscar_img.Location = new System.Drawing.Point(24, 319);
            this.buscar_img.Name = "buscar_img";
            this.buscar_img.Size = new System.Drawing.Size(212, 32);
            this.buscar_img.TabIndex = 1;
            this.buscar_img.Text = "Buscar imagen";
            this.buscar_img.Click += new System.EventHandler(this.img_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(286, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(61, 23);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Nombre";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // nombre
            // 
            this.nombre.BorderRadius = 10;
            this.nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombre.DefaultText = "";
            this.nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nombre.Location = new System.Drawing.Point(286, 129);
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.PlaceholderText = "";
            this.nombre.SelectedText = "";
            this.nombre.Size = new System.Drawing.Size(200, 36);
            this.nombre.TabIndex = 3;
            // 
            // apellido
            // 
            this.apellido.BorderRadius = 10;
            this.apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apellido.DefaultText = "";
            this.apellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.apellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.apellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apellido.Location = new System.Drawing.Point(519, 129);
            this.apellido.Name = "apellido";
            this.apellido.PasswordChar = '\0';
            this.apellido.PlaceholderText = "";
            this.apellido.SelectedText = "";
            this.apellido.Size = new System.Drawing.Size(200, 36);
            this.apellido.TabIndex = 5;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(519, 100);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(58, 23);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "apellido";
            // 
            // Correo
            // 
            this.Correo.Animated = true;
            this.Correo.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com"});
            this.Correo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Correo.BorderRadius = 10;
            this.Correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Correo.DefaultText = "";
            this.Correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Correo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Correo.Location = new System.Drawing.Point(286, 205);
            this.Correo.Name = "Correo";
            this.Correo.PasswordChar = '\0';
            this.Correo.PlaceholderText = "";
            this.Correo.SelectedText = "";
            this.Correo.Size = new System.Drawing.Size(433, 36);
            this.Correo.TabIndex = 6;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(286, 176);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(131, 23);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Correo Electronico";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(286, 248);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(82, 23);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Contraseña";
            // 
            // contraseña
            // 
            this.contraseña.BorderRadius = 10;
            this.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseña.DefaultText = "";
            this.contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contraseña.Location = new System.Drawing.Point(286, 277);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '\0';
            this.contraseña.PlaceholderText = "";
            this.contraseña.SelectedText = "";
            this.contraseña.Size = new System.Drawing.Size(433, 36);
            this.contraseña.TabIndex = 8;
            // 
            // fecha
            // 
            this.fecha.BorderRadius = 10;
            this.fecha.Checked = true;
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fecha.Location = new System.Drawing.Point(24, 409);
            this.fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(352, 36);
            this.fecha.TabIndex = 12;
            this.fecha.Value = new System.DateTime(2023, 4, 21, 13, 46, 51, 711);
            // 
            // genero
            // 
            this.genero.BackColor = System.Drawing.Color.Transparent;
            this.genero.BorderRadius = 10;
            this.genero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genero.ItemHeight = 30;
            this.genero.Items.AddRange(new object[] {
            "Hombre ",
            "Mujer",
            "Prefiero no decirlo"});
            this.genero.Location = new System.Drawing.Point(410, 409);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(341, 36);
            this.genero.StartIndex = 0;
            this.genero.TabIndex = 13;
            // 
            // registrar
            // 
            this.registrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registrar.ForeColor = System.Drawing.Color.White;
            this.registrar.Location = new System.Drawing.Point(286, 470);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(180, 45);
            this.registrar.TabIndex = 14;
            this.registrar.Text = "Registrar";
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(104, 12);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(535, 67);
            this.guna2HtmlLabel5.TabIndex = 15;
            this.guna2HtmlLabel5.Text = "Ingrese Su Credenciales";

            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // img
            // 
            this.img.Image = global::Práctica_de_acceso_a_Datos.Properties.Resources.perfil_de_usuario;
            this.img.Location = new System.Drawing.Point(24, 107);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(212, 206);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(286, 358);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(433, 36);
            this.guna2TextBox1.TabIndex = 16;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(286, 329);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(176, 23);
            this.guna2HtmlLabel6.TabIndex = 17;
            this.guna2HtmlLabel6.Text = "Codigo de administrador";
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 527);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.buscar_img);
            this.Controls.Add(this.img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro(usuario)";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img;
        private Guna.UI2.WinForms.Guna2Button buscar_img;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox nombre;
        private Guna.UI2.WinForms.Guna2TextBox apellido;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox Correo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox contraseña;
        private Guna.UI2.WinForms.Guna2DateTimePicker fecha;
        private Guna.UI2.WinForms.Guna2ComboBox genero;
        private Guna.UI2.WinForms.Guna2Button registrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}