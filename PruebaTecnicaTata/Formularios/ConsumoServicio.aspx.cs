using Newtonsoft.Json;
using PruebaTecnicaTata.Servicios;
using PruebaTecnicaTata.Util.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaTecnicaTata.Formularios
{
    public partial class ConsumoServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnprocesos_Click(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio();
            string sha256 = new clsSha256().CalcularSha256(texto.InnerText + "k#eR27%*-jh8*");

            string resul = servicio.CantidadPalabras(texto.InnerText, sha256);

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(resul, typeof(DataTable));
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}