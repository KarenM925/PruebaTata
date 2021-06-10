using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PruebaTecnicaTata.Util.Clases
{
    public class clsSha256
    {
        public string CalcularSha256(string strDatos)
        {
            return CalcularSha256(Encoding.ASCII.GetBytes(strDatos));
        }

        private static string CalcularSha256(byte[] arraryDatos)
        {
            SHA256 objSha = SHA256Managed.Create();
            return Convert.ToBase64String(objSha.ComputeHash(arraryDatos));
        }

        private static bool CompararSha256(byte[] btDatos, string strSha256)
        {
            string strAux = CalcularSha256(btDatos);

            if (strAux == strSha256)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CompararSha256(string strDatos, string strSha256)
        {
            return CompararSha256(Encoding.ASCII.GetBytes(strDatos), strSha256);
        }
    }
}