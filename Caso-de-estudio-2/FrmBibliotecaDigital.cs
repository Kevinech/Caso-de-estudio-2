using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_de_estudio_2
{
    public partial class FrmBibliotecaDigital : Form
    {

        public class Libro
        {
            public string Nombre { get; set; }
            public string Autor { get; set; }
            public string Categoria { get; set; }
            public string Codigo { get; set; }
        }


        List<Libro> libros = new List<Libro>();




        public FrmBibliotecaDigital()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbAutor.Text) ||
                string.IsNullOrWhiteSpace(tbCategoria.Text) ||
                string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar el libro.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Si pasa la validación, entonces crea el libro
            Libro nuevo = new Libro()
            {
                Nombre = tbNombre.Text,
                Autor = tbAutor.Text,
                Categoria = tbCategoria.Text,
                Codigo = tbCodigo.Text
            };

            libros.Add(nuevo);

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;

            // Actualiza ComboBox de búsqueda de categorías
            var categoriasUnicas = libros.Select(l => l.Categoria).Distinct().ToList();
            cbCategorias.Items.Clear();
            cbCategorias.Items.AddRange(categoriasUnicas.ToArray());

            // Limpia campos
            tbNombre.Clear();
            tbAutor.Clear();
            tbCodigo.Clear();
            tbCategoria.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbCategorias.SelectedItem != null)
            {
                string categoriaBuscar = cbCategorias.SelectedItem.ToString();
                var resultados = libros.Where(l => l.Categoria == categoriaBuscar).ToList();

                dgvLibros.DataSource = null;
                dgvLibros.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    rtbAlertas.SelectionColor = Color.Red;
                    rtbAlertas.AppendText("No se encontraron libros en esta categoría.\n");
                }
                else
                {
                    rtbAlertas.SelectionColor = Color.Green;
                    rtbAlertas.AppendText($"{resultados.Count} libros encontrados en la categoría.\n");

                }

            }
            else
            {

                rtbAlertas.AppendText("Debe seleccionar una categoría para continuar\n");

            }



        }
    }








}
