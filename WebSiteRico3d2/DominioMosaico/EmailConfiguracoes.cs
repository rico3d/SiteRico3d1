using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteRico3d2.DominioMosaico
{
    public class EmailConfiguracoes
    {
        public bool UsarSsl = false;

        public string ServidorSmtp = "mail39.redehost.com.br";

        public int ServidorPorta = 587;

        public string Usuario = "ricardo.pinto@rico3d.com.br";

        public bool EscreverArquivo = false;

        public string PastaArquivo = @"c:\envioemail";

        public string De = "ricardo.pinto@rico3d.com.br";

        public string Para = "ricardo.pinto@rico3d.com.br";

        public string Senha = "PqpTnc@45";

    }
}