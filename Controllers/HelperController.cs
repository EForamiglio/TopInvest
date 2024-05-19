using Microsoft.AspNetCore.Http;
using System;

namespace TopInvest.Controllers
{
    public class HelperController
    {
        public static Boolean VerificaUserLogado(ISession session)
        {
            string logado = session.GetString("Logado");
            if (logado == null)
                return false;
            else
                return true;
        }

        public static Boolean VerificaUserAdm(ISession session)
        {
            string adm = session.GetString("Adm");
            if (adm == null)
                return false;

            return true;
        }
    }
}
