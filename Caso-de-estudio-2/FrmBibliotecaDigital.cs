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
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Anio { get; set; }
            public string Descripcion { get; set; }
        }

        private List<Libro> listaLibros = new List<Libro>();




        public FrmBibliotecaDigital()
        {
            InitializeComponent();
        }



        private void CargarLibros()
        {
            listaLibros.Clear();
            listaLibros.Add(new Libro { Id = 101, Titulo = "El Quijote", Autor = "Cervantes", Anio = 1605, Descripcion = "Novela de aventuras del caballero Don Quijote" });
            listaLibros.Add(new Libro { Id = 102, Titulo = "Cien Años de Soledad", Autor = "García Márquez", Anio = 1967, Descripcion = "Saga familiar en el pueblo de Macondo" });
            listaLibros.Add(new Libro { Id = 103, Titulo = "El Principito", Autor = "Saint-Exupéry", Anio = 1943, Descripcion = "Fábula poética sobre un príncipe viajero" });
            listaLibros.Add(new Libro { Id = 104, Titulo = "1984", Autor = "George Orwell", Anio = 1949, Descripcion = "Novela distrópica de control totalitario" });
            listaLibros.Add(new Libro { Id = 105, Titulo = "Orgullo y Prejuicio", Autor = "Jane Austen", Anio = 1813, Descripcion = "Romance periodístico inglés" });
        }

    }








}
