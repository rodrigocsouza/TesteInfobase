using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLLInfobase.Classes;

namespace ViewInfobase.Commom
{
    public class BasePage : System.Web.UI.Page
    {
        public CaixaEletronico MyProperty { get; set; }

        public CaixaEletronico Caixa
            { get; set; }
       /* {
            get { return }
            
            {
                return;// Caixa.AbasteceValoresCaixa((List<Nota>)Session["Constantes.NotasDisponiveis"]);
            }
        }*/
    }
}
