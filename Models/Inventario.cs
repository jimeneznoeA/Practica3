using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;
using Practica3.Context;
namespace Practica3.Models
{
    public class Inventario
    {
        [Key]
      public int  IDInventario { get; set; }
       public int  IDLibro { get; set; }
       public int IDSucursal { get; set; }
      public int  Existencia { get; set; }

    }
}
