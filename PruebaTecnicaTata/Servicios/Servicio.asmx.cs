using PruebaTecnicaTata.Clases;
using PruebaTecnicaTata.Util.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PruebaTecnicaTata.Servicios
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicio : System.Web.Services.WebService
    {

        [WebMethod]
        public string CantidadPalabras(string cadena, string clave)
        {
            if (clsSha256.CompararSha256(cadena + "k#eR27%*-jh8*", clave) == true)
            {

                return new clsPrincipal().GetResultado(cadena);
            }
            else
            {
                throw new HttpException("No es posible procesar la solicitud, error de clave");

            }
        }
    }
}
