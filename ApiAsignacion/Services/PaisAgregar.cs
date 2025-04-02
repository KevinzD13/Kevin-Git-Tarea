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


        public string MostrarContinentes(string continente)
        {
            var paisesContinentes = listaP.Where(p => p.Continente == continente);
            return JsonConvert.SerializeObject(paisesContinentes, Formatting.Indented);
        }



        public string MayorPoblacion(int n)
        {
            for (int i = 0; i < listaP.Count - 1; i++)
            {
             for (int j = 0; j < listaP.Count - 1 - i; j++)
              { 
              if (listaP[j].Poblacion < listaP[j + 1].Poblacion)
               {

                 var temp = listaP[j];
                 listaP[j] = listaP[j + 1];
                 listaP[j + 1] = temp;
                }
               }
            }

            var paisesConMayorPoblacion = listaP.Take(n).ToList();

            return JsonConvert.SerializeObject(paisesConMayorPoblacion, Formatting.Indented);
        }

        public string[] Nombre(string nombre)
        {
            string[] palabra = nombre.Split(' ');
            if (palabra.Length < 2)
            {
                return new string[] { "Se requiere al menos 1 nombre y 2 apellidos" };
            }
            else
            {
                return new string[] { palabra[0], palabra[2] };
            }
        }
    }
}
