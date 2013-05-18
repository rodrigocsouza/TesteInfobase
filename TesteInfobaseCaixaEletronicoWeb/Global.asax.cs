using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using BLLInfobase.Classes;
using BLLInfobase.Exceptions;
using System.Configuration;

namespace TesteInfobaseCaixaEletronicoWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Iniciliza o Caixa Eletrônico com as notas pré-configuradas no web.config
            try
            {
                CaixaEletronico cx = new CaixaEletronico();
                cx.InicializaNotasDisponiveis();
                Application["Constantes.CaixaEletronico"] = cx;
            }
            catch(Exception ex) {
                Application["Excecao"] = ex;
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}