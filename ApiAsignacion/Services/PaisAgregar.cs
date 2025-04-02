using ApiAsignacion.Interfaces;
using ApiAsignacion.Models;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Diagnostics.Metrics;
using System.Net.Http.Json;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiAsignacion.Services
{
    public class PaisAgregar : IPaises
    {

        private List<PaisIn> listaP;
        private PaisIn temp;

        public PaisAgregar()
        {
            string jsonInfo = File.ReadAllText("C:\\Users\\kevin\\source\\repos\\Practica numero 4\\ApiAsignacion\\Json Sample\\Practica4.json");
            listaP = JsonConvert.DeserializeObject<List<PaisIn>>(jsonInfo);
        }



        public string MostrarPaises()
        {
            return JsonConvert.SerializeObject(listaP, Formatting.Indented);
        }



    }
}
