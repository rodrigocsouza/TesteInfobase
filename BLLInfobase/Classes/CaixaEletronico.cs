using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLLInfobase.Interfaces;
using System.Configuration;
using BLLInfobase.Exceptions;


namespace BLLInfobase.Classes
{
    /// <summary>
    /// Classe principal do Caixa Eletrônico
    /// </summary>
    public class CaixaEletronico : ICaixaEletronico
    {
        #region Construtores
        /// <summary>
        /// Construtor principal do Caixa Eletrônico
        /// </summary>
        public CaixaEletronico()
        {
            //Inicializa as propriedades
            this.NotasDisponiveis = new List<Nota>();
            this.NotasSaque = new List<Nota>();
            this.ValorSaque = 0;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Lista das notas disponíveis, que são carregadas através do web.config
        /// </summary>
        public List<Nota> NotasDisponiveis { get; set; }
        /// <summary>
        /// Armazena o valor do saque desejado
        /// </summary>
        public int ValorSaque { get; set; }
        /// <summary>
        /// Lista as notas que serão entregues ao cliente
        /// </summary>
        public List<Nota> NotasSaque { get; set; }
        #endregion

        #region Métodos
        /// <summary>
        /// Verifica se o valor do saque é múltiplo de 10
        /// </summary>
        public void VerificaValorSaque()
        {
            if (this.ValorSaque % 10 != 0)
                throw new ValorSaqueInvalidoException();
        }

        /// <summary>
        /// Realiza o saque efetivamente
        /// </summary>
        public void RealizarSaque()
        {
            //Verifica se o valor é válido
            VerificaValorSaque();
            //Limpa a lista de notas que serão entregues para o cliente
            NotasSaque.Clear();
            //Faz a separação das notas
            while (ValorSaque > 0)
            {
                Nota notaSaque = new Nota();
                notaSaque = NotasDisponiveis.Where(x => x.ValorNota <= ValorSaque).FirstOrDefault();

                if (notaSaque.ValorNota != 0)
                {
                    NotasSaque.Add(notaSaque);
                    ValorSaque -= notaSaque.ValorNota;
                }
            }
        }

        /// <summary>
        /// Emite o resumo por escrito das notas que serão entregues ao cliente
        /// </summary>
        /// <returns></returns>
        public string ResumoSaque()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Nota notaDisponivel in NotasDisponiveis)
            {
                int t = NotasSaque.Count(x => x.ValorNota == notaDisponivel.ValorNota);
                if (t > 0)
                {
                    sb.AppendLine(string.Format("{0} {1} de {2}<br />", t , RetornaExtensoNota(t), notaDisponivel.ValorNota.ToString("R$ ##0.00")));
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Retorna o texto de notas respeitando o singular e plural
        /// </summary>
        /// <param name="totalNotas"></param>
        /// <returns></returns>
        public string RetornaExtensoNota(int totalNotas) { 
            string retorno = "nota";
            if (totalNotas > 1) {
                retorno = "notas";
            }
            return retorno;
        }

        /// <summary>
        /// Inicializa o Caixa Eletrônico com os valores das notas disponíveis no web.config
        /// </summary>
        public void InicializaNotasDisponiveis()
        {
            //Inicializa o caixa com as notas disponíveis obtidas a partir do web.config
            string notasWebConfig = ConfigurationManager.AppSettings["NotasDisponiveis"].ToString();
            foreach (string valor in notasWebConfig.Split(','))
            {
                    int iValorNota = 0;
                    Int32.TryParse(valor, out iValorNota);
                    if (iValorNota != 0)
                    {
                        this.NotasDisponiveis.Add(new Nota() { ValorNota = iValorNota });
                    }
                    else {
                        throw new ValorNotaWebConfigException();
                    }
            }
        }
        #endregion
    }
}
