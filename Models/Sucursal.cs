using System.ComponentModel.DataAnnotations;
using Practica3.Context;
namespace Practica3.Models
{
    public class Sucursal
    {
        [Key]
        public int  IDSucursal { get; set; } 
       public string Nombre { get; set; }
      public string Encargado { get; set; } 
       public string Direccion { get; set; }
      public string  Ciudad { get; set; }
      public string  Telefono { get; set; }
      public string  Email { get; set; }
     public string   Comentario { get; set; }
    }
}
