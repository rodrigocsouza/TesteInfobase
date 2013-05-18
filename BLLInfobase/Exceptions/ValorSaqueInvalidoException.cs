using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLInfobase.Exceptions
{
    /// <summary>
    /// Exceção a ser retornada quando o valor do saque é inválido
    /// </summary>
    public class ValorSaqueInvalidoException : Exception
    {
        //Mensagem retornada ao usuário
        public override string Message
        {
            get
            {
                return "O valor do saque não é válido";
            }
        }
    }
}
