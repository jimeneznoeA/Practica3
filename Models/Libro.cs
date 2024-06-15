using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.Xml;
using System.ComponentModel.DataAnnotations;
using Practica3.Context;
namespace Practica3.Models
{
    public class Libro
    {
        [Key]
        public int idLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int IDEditorial { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public string Comentarios { get; set; }
        public string Foto { get; set; }


    }
}