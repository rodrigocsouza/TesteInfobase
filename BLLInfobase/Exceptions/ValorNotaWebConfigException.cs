using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLInfobase.Exceptions
{
    /// <summary>
    /// Classe de exceção quando os valores do web.config não estão corretos
    /// </summary>
    public class ValorNotaWebConfigException: Exception
    {
        //Mensagem retornada ao usuário
        public override string Message
        {
            get
            {
                return "Verifique os valores das notas no web.config";
            }
        }
    }
}
