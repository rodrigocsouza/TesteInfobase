using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLLInfobase.Classes;

namespace BLLInfobase.Interfaces
{
    /// <summary>
    /// Interface base para a classe do CaixaEletronico
    /// </summary>
    public interface ICaixaEletronico
    {
        void RealizarSaque();
        void InicializaNotasDisponiveis();
        void VerificaValorSaque();
        string ResumoSaque();
        string RetornaExtensoNota(int totalNotas);
    }
}
