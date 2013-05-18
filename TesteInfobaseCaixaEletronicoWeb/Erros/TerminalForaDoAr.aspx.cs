using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteInfobaseCaixaEletronicoWeb
{
    public partial class TerminalForaDoAr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["Excecao"] != null)
            {
                Exception ex = (Exception)Application["Excecao"];
                lblMsgErro.Text = ex.Message;
            }
            else {
                lblMsgErro.Text = string.Empty;
            }
            Application["Excecao"] = null;
        }
    }
}