using ApiAsignacion.Models;

namespace ApiAsignacion.Interfaces
{
    public interface IPaises
    {
        
        string MostrarPaises ();
        string MostrarContinentes (string continente);
        string MayorPoblacion(int numero);
        string[] Nombre(string nombre);

    }
}
