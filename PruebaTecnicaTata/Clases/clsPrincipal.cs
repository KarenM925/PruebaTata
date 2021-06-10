using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace PruebaTecnicaTata.Clases
{
    public class clsPrincipal
    {

        public string GetResultado(string texto)
        {
            List<clsPalabras> lstPalabras = new List<clsPalabras>();
            IEnumerable<string> palabras = GetPalabrasList(texto);

            var query = palabras
                .GroupBy(x => x)
                .Select(group => new { palabra = group.Key, cantidad = group.Count() })
                .ToList();

            foreach (var dto in query)
            {
                clsPalabras obj = new clsPalabras();
                obj.palabra = dto.palabra;
                obj.cantidad = dto.cantidad;
                lstPalabras.Add(obj);
            }

            string strJson = JsonConvert.SerializeObject(lstPalabras);

            return strJson;
        }

        private IEnumerable<string> GetPalabrasList(string texto)
        {
            return texto.Split(' ').Where(tx => !tx.Equals(""));
        }

    }
}