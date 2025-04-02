using ApiAsignacion.Models;

namespace ApiAsignacion.Interfaces
{
    public interface IPaises
    {
        
        string MostrarPaises ();
        string ActualizarPais(int id, PaisIn paisActualizado);
        string AgregarPais(PaisIn paisActualizado);
    }
}
