using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using System.Drawing;

namespace Practico1.Modelos
{
    public class RequestIndicadores
    {
        private static readonly string svcURL = "https://www.mindicador.cl";
        private static readonly string pathAPI = "api";
        private static readonly string fecha = DateTime.Now.ToString("dd-MM-yyyy");

        public static async Task<string> LlamaServicioAsync(string moneda)
        {
            string EmpResponse = string.Empty;
            var qryString = string.Concat(pathAPI, "/", moneda, "/", fecha);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(svcURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync(qryString);
                if (Res.IsSuccessStatusCode)
                {
                    EmpResponse = await Res.Content.ReadAsStringAsync();
                }
            }
            return EmpResponse;
        }

        public static async Task<string> ObtenerUfAsync()
        {
            string response = string.Empty;

            var result = await LlamaServicioAsync("uf");
            var json = JsonDocument.Parse(result);

            if (json.RootElement.TryGetProperty("serie", out var serie) && serie.GetArrayLength() > 0)
            {
                var valor = serie[0].GetProperty("valor");
                response = valor.ToString();
            }
            else
            {
                // Manejar el caso en el que no se encuentren elementos en la serie
                response = "Valor no disponible";
            }

            return response;
        }

        public static async Task<string> ObtenerDolarAsync()
        {
            string response = string.Empty;

            var result = await LlamaServicioAsync("dolar");
            var json = JsonDocument.Parse(result);

            if (json.RootElement.TryGetProperty("serie", out var serie) && serie.GetArrayLength() > 0)
            {
                var valor = serie[0].GetProperty("valor");
                response = valor.ToString();
            }
            else
            {
                // Manejar el caso en el que no se encuentren elementos en la serie
                response = "Valor del Dólar no disponible";
            }

            return response;
        }
    }
}
