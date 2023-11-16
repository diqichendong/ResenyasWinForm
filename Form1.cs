using System.Collections;

namespace ResenyasPeliculas
{
    public partial class pantallaPrincipal : Form
    {
        private const string NOMBRE_FICHERO = "databank.data";
        private const string TEXTO_TOTAL = "Número total de reseñas: ";
        private List<Resenya> lista;
        private int actual;
        private string ultimoImagenPath;

        public pantallaPrincipal()
        {
            InitializeComponent();

            // Estado inicial
            lista = new List<Resenya>();
            cbTipo.SelectedIndex = 0;
            btnSubirImagen.Visible = false;
            lblTotal.Text = TEXTO_TOTAL + lista.Count;
            actual = 0;
            ultimoImagenPath = "";
            imgPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            // Cargar registros
            cargarRegistros();

            // Actualizar vista
            actualizarVista();
        }

        // Carga los registros del fichero
        private void cargarRegistros()
        {
            BinaryReader br;

            try
            {
                br = new BinaryReader(File.OpenRead(NOMBRE_FICHERO));
                while (br.PeekChar() != -1)
                {
                    this.lista.Add(Resenya.cargarResenya(br));
                }

                br.Close();
            }
            catch (Exception ex) { }
        }

        // Guardar registros en fichero
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            File.Delete(NOMBRE_FICHERO);
            BinaryWriter bw;

            try
            {

                bw = new BinaryWriter(File.OpenWrite(NOMBRE_FICHERO));

                foreach (Resenya r in lista)
                {
                    r.guardarResenya(bw);
                }
                bw.Close();
                MessageBox.Show("Datos guardados.");
            }
            catch (Exception ex) { }
        }

        // Actualiza la información de la vista
        private void actualizarVista()
        {
            activarCampos(false);

            if (lista.Count == 0)
            {
                activarBotones(false);
                btnCrear.Enabled = true;
                lblTotal.Text = TEXTO_TOTAL + lista.Count;
                cbTipo.SelectedIndex = 0;
                txtTitulo.Text = "";
                txtAnyo.Text = "";
                txtGenero.Text = "";
                numNota.Value = 5;
                txtContenido.Text = "";
                chkRecomendado.Checked = false;
                imgPoster.Image = null;
            }
            else
            {
                activarBotones(true);
                actualizarBotonesNav();

                Resenya r = lista[actual];
                imgPoster.Image = arrayAImage(r.Imagen);
                switch (r.Tipo)
                {
                    case 'P':
                        cbTipo.SelectedIndex = 0;
                        break;
                    case 'S':
                        cbTipo.SelectedIndex = 1;
                        break;
                    case 'D':
                        cbTipo.SelectedIndex = 2;
                        break;
                }
                txtTitulo.Text = r.Titulo;
                txtAnyo.Text = r.Anyo.ToString();
                txtGenero.Text = r.Generos;
                numNota.Text = r.Nota.ToString();
                txtContenido.Text = r.Contenido;
                chkRecomendado.Checked = r.Recomendado;
                lblTotal.Text = TEXTO_TOTAL + lista.Count;
            }
        }

        // Actualiza los botones de navegación
        private void actualizarBotonesNav()
        {
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;

            if (actual == 0)
            {
                btnAnterior.Enabled = false;
            }

            if (actual == lista.Count - 1)
            {
                btnSiguiente.Enabled = false;
            }
        }

        // Activa o desactiva los campos de la vista
        private void activarCampos(bool b)
        {
            cbTipo.Enabled = b;
            txtTitulo.ReadOnly = !b;
            txtAnyo.ReadOnly = !b;
            txtGenero.ReadOnly = !b;
            numNota.Enabled = b;
            txtContenido.ReadOnly = !b;
            chkRecomendado.AutoCheck = b;
        }

        // Activa o desactiva los botones de la vista
        private void activarBotones(bool b)
        {
            btnAnterior.Enabled = b;
            btnCrear.Enabled = b;
            btnBorrar.Enabled = b;
            btnSiguiente.Enabled = b;
            btnGuardar.Enabled = b;
        }

        //Evento botón Crear y Aceptar
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (btnCrear.Text == "Crear")
            {
                activarBotones(false);
                btnCrear.Text = "Aceptar";
                btnBorrar.Text = "Cancelar";
                btnSubirImagen.Visible = true;
                activarCampos(true);
                btnBorrar.Enabled = true;
                btnCrear.Enabled = true;

                imgPoster.Image = null;
                cbTipo.SelectedIndex = 0;
                txtTitulo.Text = "";
                txtAnyo.Text = "";
                txtGenero.Text = "";
                numNota.Value = 5;
                txtContenido.Text = "";
                chkRecomendado.Checked = false;
            }
            else
            {
                bool datosCorrectos = true;
                char tipo = '.';
                int anyo = -1;
                double nota;
                bool recomendado;
                string titulo, generos, contenido, imagenPath;

                titulo = txtTitulo.Text.Trim();
                generos = txtGenero.Text.Trim();
                contenido = txtContenido.Text.Trim();
                imagenPath = ultimoImagenPath;

                switch (cbTipo.Text)
                {
                    case "Película":
                        tipo = 'P';
                        break;
                    case "Serie":
                        tipo = 'S';
                        break;
                    case "Documental":
                        tipo = 'D';
                        break;
                }

                try
                {
                    anyo = int.Parse(txtAnyo.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El año tiene que ser un número.");
                    datosCorrectos = false;
                }

                nota = decimal.ToDouble(numNota.Value);

                if (titulo == "")
                {
                    MessageBox.Show("El título está vacío.");
                    datosCorrectos = false;
                }

                if (generos == "")
                {
                    MessageBox.Show("El género está vacío.");
                    datosCorrectos = false;
                }

                if (contenido == "")
                {
                    MessageBox.Show("La reseña está vacía.");
                    datosCorrectos = false;
                }

                if (imagenPath == "")
                {
                    MessageBox.Show("No se ha subido una imagen.");
                    datosCorrectos = false;
                }

                recomendado = chkRecomendado.Checked;

                if (datosCorrectos)
                {
                    lista.Add(
                        new Resenya(
                            tipo,
                            titulo,
                            anyo,
                            generos,
                            nota,
                            contenido,
                            recomendado,
                            imageAArray(Image.FromFile(imagenPath))
                        )
                    );
                    this.ultimoImagenPath = "";
                    btnCrear.Text = "Crear";
                    btnBorrar.Text = "Borrar";
                    btnSubirImagen.Visible = false;
                    activarCampos(false);
                    activarBotones(true);
                    actualizarVista();
                }
            }
        }

        // Evento botón Subir imagen
        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Multiselect = false;

            if (d.ShowDialog() == DialogResult.OK)
            {
                this.ultimoImagenPath = d.FileName;
            }
            imgPoster.Image = Image.FromFile(this.ultimoImagenPath);
        }

        // Evento botón Anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            actual--;
            actualizarVista();
        }

        // Evento botón Siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            actual++;
            actualizarVista();
        }

        // Evento botón Borrar y Cancelar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (btnBorrar.Text == "Cancelar")
            {
                this.ultimoImagenPath = "";
                btnCrear.Text = "Crear";
                btnBorrar.Text = "Borrar";
                btnSubirImagen.Visible = false;
                activarCampos(false);
                activarBotones(true);
                actualizarVista();
            }
            else
            {
                lista.Remove(lista[actual]);
                if (lista.Count - 1 < actual)
                {
                    if (actual > 0)
                    {
                        actual--;
                    }
                }

                actualizarVista();
            }
        }

        // Evento al cerrar la aplicación
        private void pantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnGuardar_Click(sender, e);
        }

        // Convierte de byte[] a Image
        private Image arrayAImage(byte[] arr)
        {
            using (MemoryStream ms = new MemoryStream(arr))
            {
                return Image.FromStream(ms);
            }
        }

        // Convierte de Image a byte[]
        private byte[] imageAArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
    }
}