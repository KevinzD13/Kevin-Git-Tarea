using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace ApiAsignacion.Models
{
    public class PaisIn
    {

        public int Id { get; set; }
        public string Pais {  get; set; }
        public string Continente { get; set; }
        public int Poblacion { get; set; }

    }
}
