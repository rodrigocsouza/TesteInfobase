using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLLInfobase.Classes;

namespace ViewInfobase.Commom
{
    public class BasePage : System.Web.UI.Page
    {
        /// <summary>
        /// Retorna o objeto CaixaEletronico armazenado no cache da aplicação
        /// </summary>
        public CaixaEletronico Caixa
        {
            get
            {
                try
                {
                    return (CaixaEletronico)Application["Constantes.CaixaEletronico"];
                }
                catch (Exception exx) {
                    Application["Excecao"] = exx;
                    return new CaixaEletronico();   
                }
            }
        }
    }
}
