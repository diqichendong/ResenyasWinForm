namespace ResenyasPeliculas
{
    partial class pantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaPrincipal));
            lblTotal = new Label();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            txtAnyo = new TextBox();
            lblAnyo = new Label();
            lblGenero = new Label();
            txtGenero = new TextBox();
            imgPoster = new PictureBox();
            lblTipo = new Label();
            cbTipo = new ComboBox();
            lblNota = new Label();
            numNota = new NumericUpDown();
            txtContenido = new TextBox();
            lblContenido = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnCrear = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            chkRecomendado = new CheckBox();
            btnSubirImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)imgPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(26, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(230, 28);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Número total de reseñas:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(379, 154);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(88, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(484, 154);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(365, 39);
            txtTitulo.TabIndex = 2;
            // 
            // txtAnyo
            // 
            txtAnyo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnyo.Location = new Point(484, 209);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(365, 39);
            txtAnyo.TabIndex = 4;
            // 
            // lblAnyo
            // 
            lblAnyo.AutoSize = true;
            lblAnyo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnyo.Location = new Point(399, 212);
            lblAnyo.Name = "lblAnyo";
            lblAnyo.Size = new Size(68, 32);
            lblAnyo.TabIndex = 3;
            lblAnyo.Text = "Año:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.Location = new Point(334, 268);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(133, 32);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Género(s):";
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenero.Location = new Point(484, 265);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(365, 39);
            txtGenero.TabIndex = 6;
            // 
            // imgPoster
            // 
            imgPoster.BackgroundImage = (Image)resources.GetObject("imgPoster.BackgroundImage");
            imgPoster.BackgroundImageLayout = ImageLayout.Stretch;
            imgPoster.Location = new Point(101, 93);
            imgPoster.Name = "imgPoster";
            imgPoster.Size = new Size(171, 236);
            imgPoster.TabIndex = 7;
            imgPoster.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(395, 97);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(72, 32);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Película", "Serie", "Documental" });
            cbTipo.Location = new Point(484, 94);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(182, 40);
            cbTipo.TabIndex = 9;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota.Location = new Point(390, 325);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(77, 32);
            lblNota.TabIndex = 10;
            lblNota.Text = "Nota:";
            // 
            // numNota
            // 
            numNota.DecimalPlaces = 1;
            numNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numNota.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numNota.Location = new Point(484, 323);
            numNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numNota.Name = "numNota";
            numNota.ReadOnly = true;
            numNota.Size = new Size(87, 39);
            numNota.TabIndex = 11;
            numNota.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // txtContenido
            // 
            txtContenido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContenido.Location = new Point(101, 454);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ScrollBars = ScrollBars.Vertical;
            txtContenido.Size = new Size(748, 225);
            txtContenido.TabIndex = 12;
            // 
            // lblContenido
            // 
            lblContenido.AutoSize = true;
            lblContenido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContenido.Location = new Point(101, 408);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(101, 32);
            lblContenido.TabIndex = 13;
            lblContenido.Text = "Reseña:";
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnterior.Location = new Point(104, 763);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(143, 51);
            btnAnterior.TabIndex = 14;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(706, 763);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(143, 51);
            btnSiguiente.TabIndex = 15;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrear.Location = new Point(334, 763);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(143, 51);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(483, 763);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(143, 51);
            btnBorrar.TabIndex = 17;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(413, 835);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 51);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkRecomendado
            // 
            chkRecomendado.AutoSize = true;
            chkRecomendado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkRecomendado.Location = new Point(100, 699);
            chkRecomendado.Name = "chkRecomendado";
            chkRecomendado.Size = new Size(228, 36);
            chkRecomendado.TabIndex = 19;
            chkRecomendado.Text = "¿La recomiendas?";
            chkRecomendado.UseVisualStyleBackColor = true;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.Location = new Point(100, 335);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(172, 34);
            btnSubirImagen.TabIndex = 20;
            btnSubirImagen.Text = "Subir imagen";
            btnSubirImagen.UseVisualStyleBackColor = true;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // pantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 907);
            Controls.Add(btnSubirImagen);
            Controls.Add(chkRecomendado);
            Controls.Add(btnGuardar);
            Controls.Add(btnBorrar);
            Controls.Add(btnCrear);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(lblContenido);
            Controls.Add(txtContenido);
            Controls.Add(numNota);
            Controls.Add(lblNota);
            Controls.Add(cbTipo);
            Controls.Add(lblTipo);
            Controls.Add(imgPoster);
            Controls.Add(txtGenero);
            Controls.Add(lblGenero);
            Controls.Add(txtAnyo);
            Controls.Add(lblAnyo);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblTotal);
            Name = "pantallaPrincipal";
            Text = "Reseñas";
            FormClosing += pantallaPrincipal_FormClosing;
            ((System.ComponentModel.ISupportInitialize)imgPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private TextBox txtAnyo;
        private Label lblAnyo;
        private Label lblGenero;
        private TextBox txtGenero;
        private PictureBox imgPoster;
        private Label lblTipo;
        private ComboBox cbTipo;
        private Label lblNota;
        private NumericUpDown numNota;
        private TextBox txtContenido;
        private Label lblContenido;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnCrear;
        private Button btnBorrar;
        private Button btnGuardar;
        private CheckBox chkRecomendado;
        private Button btnSubirImagen;
    }
}