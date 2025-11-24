using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Opcional: limpia los campos después de agregar
            tbNombre.Clear();
            tbAutor.Clear();
            tbCodigo.Clear();
            tbCategoria.Clear();
        }
    }








}
