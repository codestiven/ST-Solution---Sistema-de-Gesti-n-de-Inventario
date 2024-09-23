namespace Práctica_de_acceso_a_Datos.controles.producto
{
    partial class Modiciar_producto
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
            this.guardar = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.precio = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.Animated = true;
            this.guardar.BorderRadius = 20;
            this.guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(294, 490);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(180, 45);
            this.guardar.TabIndex = 23;
            this.guardar.Text = "guardar";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "descripcion";
            // 
            // descripcion
            // 
            this.descripcion.BorderRadius = 8;
            this.descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descripcion.DefaultText = "";
            this.descripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descripcion.Location = new System.Drawing.Point(95, 222);
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.PlaceholderText = "";
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(629, 36);
            this.descripcion.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "fecha de registro";
            // 
            // fecha
            // 
            this.fecha.BorderRadius = 8;
            this.fecha.Checked = true;
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fecha.Location = new System.Drawing.Point(95, 415);
            this.fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(629, 36);
            this.fecha.TabIndex = 19;
            this.fecha.Value = new System.DateTime(2023, 4, 21, 20, 40, 23, 481);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "precio_unitario";
            // 
            // precio
            // 
            this.precio.BorderRadius = 8;
            this.precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.precio.DefaultText = "";
            this.precio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.precio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.precio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.precio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.precio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.precio.Location = new System.Drawing.Point(424, 311);
            this.precio.Name = "precio";
            this.precio.PasswordChar = '\0';
            this.precio.PlaceholderText = "";
            this.precio.SelectedText = "";
            this.precio.Size = new System.Drawing.Size(300, 36);
            this.precio.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "cantidad";
            // 
            // cantidad
            // 
            this.cantidad.BorderRadius = 8;
            this.cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cantidad.DefaultText = "";
            this.cantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cantidad.Location = new System.Drawing.Point(95, 311);
            this.cantidad.Name = "cantidad";
            this.cantidad.PasswordChar = '\0';
            this.cantidad.PlaceholderText = "";
            this.cantidad.SelectedText = "";
            this.cantidad.Size = new System.Drawing.Size(300, 36);
            this.cantidad.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre del producto";
            // 
            // Nombre
            // 
            this.Nombre.BorderRadius = 8;
            this.Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombre.DefaultText = "";
            this.Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nombre.Location = new System.Drawing.Point(95, 128);
            this.Nombre.Name = "Nombre";
            this.Nombre.PasswordChar = '\0';
            this.Nombre.PlaceholderText = "";
            this.Nombre.SelectedText = "";
            this.Nombre.Size = new System.Drawing.Size(629, 36);
            this.Nombre.TabIndex = 13;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(81, 32);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(376, 57);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Agregar producto";
            // 
            // id
            // 
            this.id.BorderRadius = 8;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.DefaultText = "";
            this.id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.Location = new System.Drawing.Point(474, 49);
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.PlaceholderText = "Id";
            this.id.SelectedText = "";
            this.id.Size = new System.Drawing.Size(250, 36);
            this.id.TabIndex = 24;
            // 
            // Modiciar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.id);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "Modiciar_producto";
            this.Text = "Modiciar_producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guardar;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox descripcion;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox precio;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox cantidad;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Nombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox id;
    }
}