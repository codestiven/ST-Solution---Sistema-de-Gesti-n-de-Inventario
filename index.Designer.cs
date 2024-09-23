namespace Práctica_de_acceso_a_Datos
{
    partial class index
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.iniciar = new Guna.UI.WinForms.GunaButton();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gestion_de_InventarioDataSet3 = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet3();
            this.Registrarse = new Guna.UI2.WinForms.Guna2Button();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.contrasena = new Guna.UI2.WinForms.Guna2TextBox();
            this.correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // iniciar
            // 
            this.iniciar.Animated = true;
            this.iniciar.AnimationHoverSpeed = 0.07F;
            this.iniciar.AnimationSpeed = 0.03F;
            this.iniciar.BackColor = System.Drawing.Color.Transparent;
            this.iniciar.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.iniciar.BorderColor = System.Drawing.Color.Transparent;
            this.iniciar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.iniciar.FocusedColor = System.Drawing.Color.Empty;
            this.iniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.ForeColor = System.Drawing.Color.White;
            this.iniciar.Image = null;
            this.iniciar.ImageSize = new System.Drawing.Size(20, 20);
            this.iniciar.Location = new System.Drawing.Point(491, 308);
            this.iniciar.Name = "iniciar";
            this.iniciar.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.iniciar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.iniciar.OnHoverForeColor = System.Drawing.Color.White;
            this.iniciar.OnHoverImage = null;
            this.iniciar.OnPressedColor = System.Drawing.Color.Navy;
            this.iniciar.Radius = 10;
            this.iniciar.Size = new System.Drawing.Size(206, 42);
            this.iniciar.TabIndex = 0;
            this.iniciar.Text = "Entrar";
            this.iniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaGradient2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.pictureBox1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(373, 452);
            this.gunaGradient2Panel1.TabIndex = 1;
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 259);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(186, 67);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Solution";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(468, 71);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(249, 47);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Inicio de seccion";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // gestion_de_InventarioDataSet3
            // 
            this.gestion_de_InventarioDataSet3.DataSetName = "Gestion_de_InventarioDataSet3";
            this.gestion_de_InventarioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Registrarse
            // 
            this.Registrarse.BorderColor = System.Drawing.Color.Transparent;
            this.Registrarse.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Registrarse.CustomImages.ImageOffset = new System.Drawing.Point(25, 0);
            this.Registrarse.CustomizableEdges.BottomLeft = false;
            this.Registrarse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Registrarse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Registrarse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Registrarse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Registrarse.FillColor = System.Drawing.Color.Transparent;
            this.Registrarse.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Registrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.Registrarse.Image = global::Práctica_de_acceso_a_Datos.Properties.Resources.flecha_correcta;
            this.Registrarse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Registrarse.ImageOffset = new System.Drawing.Point(0, 3);
            this.Registrarse.Location = new System.Drawing.Point(491, 374);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(206, 45);
            this.Registrarse.TabIndex = 6;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaButton2.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::Práctica_de_acceso_a_Datos.Properties.Resources.configuraciones;
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(638, 12);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.RoyalBlue;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.LightSkyBlue;
            this.gunaButton2.OnHoverImage = global::Práctica_de_acceso_a_Datos.Properties.Resources.perfil1;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 15;
            this.gunaButton2.Size = new System.Drawing.Size(150, 43);
            this.gunaButton2.TabIndex = 5;
            this.gunaButton2.Text = "Administrador";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // contrasena
            // 
            this.contrasena.BorderColor = System.Drawing.Color.Transparent;
            this.contrasena.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.contrasena.BorderThickness = 0;
            this.contrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contrasena.DefaultText = "";
            this.contrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.contrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contrasena.IconLeft = global::Práctica_de_acceso_a_Datos.Properties.Resources.cerrar_con_llave;
            this.contrasena.Location = new System.Drawing.Point(451, 235);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '●';
            this.contrasena.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.contrasena.PlaceholderText = "Contraseña";
            this.contrasena.SelectedText = "";
            this.contrasena.Size = new System.Drawing.Size(295, 46);
            this.contrasena.TabIndex = 4;
            this.contrasena.UseSystemPasswordChar = true;
            this.contrasena.TextChanged += new System.EventHandler(this.contrasena_TextChanged);
            // 
            // correo
            // 
            this.correo.BorderColor = System.Drawing.Color.Transparent;
            this.correo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.correo.BorderThickness = 0;
            this.correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.correo.DefaultText = "";
            this.correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.correo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.correo.IconLeft = global::Práctica_de_acceso_a_Datos.Properties.Resources.usuario__1_1;
            this.correo.Location = new System.Drawing.Point(451, 157);
            this.correo.Name = "correo";
            this.correo.PasswordChar = '\0';
            this.correo.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.correo.PlaceholderText = "Correo Electronico";
            this.correo.SelectedText = "";
            this.correo.Size = new System.Drawing.Size(295, 45);
            this.correo.TabIndex = 3;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Práctica_de_acceso_a_Datos.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(42, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.iniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Seccion(usuario)";
            this.Load += new System.EventHandler(this.index_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton iniciar;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI2.WinForms.Guna2TextBox contrasena;
        private Guna.UI2.WinForms.Guna2TextBox correo;
        private Guna.UI2.WinForms.Guna2Button Registrarse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Gestion_de_InventarioDataSet3 gestion_de_InventarioDataSet3;
    }
}