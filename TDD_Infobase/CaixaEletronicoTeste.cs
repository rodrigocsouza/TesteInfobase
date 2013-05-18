using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLLInfobase.Classes;
using BLLInfobase.Exceptions;

namespace TDD_Infobase
{
    /// <summary>
    /// Classe de testes para a classe Caixa Eletrônico
    /// </summary>
    [TestClass]
    public class CaixaEletronicoTeste
    {
        /// <summary>
        /// Construtor da classe de testes
        /// </summary>
        public CaixaEletronicoTeste()
        {
            
        }

        /// <summary>
        /// O objeto a ser testado
        /// </summary>
        private CaixaEletronico CaixaEletronicoContext;

        /// <summary>
        /// Inicializa os objetos a serem testados
        /// </summary>
        [TestInitialize]
        public void Inicializa()
        {
            CaixaEletronicoContext = new CaixaEletronico();
            CaixaEletronicoContext.InicializaNotasDisponiveis();
        }

        /// <summary>
        /// Teste pra sacar R$ 100,00, deve retornar uma nota de R$ 100,00
        /// </summary>
        [TestMethod]
        public void Sacar100_RecebeUmaNota100()
        {
            //Preparar
            Nota notaEsperada = new Nota() { ValorNota = 100 };
            CaixaEletronicoContext.ValorSaque = 100;

            //Ação
            CaixaEletronicoContext.RealizarSaque();

            //Acerto
            Assert.AreEqual(notaEsperada.ValorNota, CaixaEletronicoContext.NotasSaque[0].ValorNota);
        }

        /// <summary>
        /// Teste para sacar R$ 50,00, deve retornar uma nota de R$ 50,00
        /// </summary>
        [TestMethod]
        public void Sacar50_RecebeUmaNota50()
        {
            //Preparar
            Nota notaEsperada = new Nota() { ValorNota = 50 };
            CaixaEletronicoContext.ValorSaque = 50;

            //Ação
            CaixaEletronicoContext.RealizarSaque();

            //Acerto
            Assert.AreEqual(notaEsperada.ValorNota, CaixaEletronicoContext.NotasSaque[0].ValorNota);
        }

        /// <summary>
        /// Teste para sacar R$ 20,00, deve retornar uma nota de R$ 20,00
        /// </summary>
        [TestMethod]
        public void Sacar20_RecebeUmaNota20()
        {
            //Preparar
            Nota notaEsperada = new Nota() { ValorNota = 20 };
            CaixaEletronicoContext.ValorSaque = 20;

            //Ação
            CaixaEletronicoContext.RealizarSaque();

            //Acerto
            Assert.AreEqual(notaEsperada.ValorNota, CaixaEletronicoContext.NotasSaque[0].ValorNota);
        }

        /// <summary>
        /// Teste para sacar R$ 10,00, deve retornar uma nota de R$ 10,00
        /// </summary>
        [TestMethod]
        public void Sacar10_RecebeUmaNota10()
        {
            //Preparar
            Nota notaEsperada = new Nota() { ValorNota = 10 };
            CaixaEletronicoContext.ValorSaque = 10;

            //Ação
            CaixaEletronicoContext.RealizarSaque();

            //Acerto
            Assert.AreEqual(notaEsperada.ValorNota, CaixaEletronicoContext.NotasSaque[0].ValorNota);
        }

        /// <summary>
        /// Teste para sacar R$ 30,00, deve retornar uma nota de R$ 20,00 e outra de R$ 10,00
        /// </summary>
        [TestMethod]
        public void Sacar30_RecebeUmaNota20Nota10()
        {
            //Preparar
            var notasEsperadas = new List<Nota>();
            notasEsperadas.Add(new Nota(){ ValorNota=20});
            notasEsperadas.Add(new Nota(){ ValorNota=10});

            CaixaEletronicoContext.ValorSaque = 30;

            //Ação
            CaixaEletronicoContext.RealizarSaque();

            //Acerto
            CollectionAssert.Equals(notasEsperadas, CaixaEletronicoContext.NotasSaque);
        }

        /// <summary>
        /// Teste para sacar R$ 80,00, deve retornar uma nota de R$ 50,00, uma nota de R$ 20,00 e outra de R$ 10,00
        /// </summary>
        [TestMethod]
        public void Sacar80_RecebeUmaNota50Nota20Nota10()
        {
            //Preparar
            var notasEsperadas = new List<Nota>();
            notasEsperadas.Add(new Nota() { ValorNota = 50 });
            notasEsperadas.Add(new Nota() { ValorNota = 20 });
            notasEsperadas.Add(new Nota() { ValorNota = 10 });

            CaixaEletronicoContext.ValorSaque = 80;

            //Ação
            CaixaEletronicoContext.RealizarSaque();

            //Acerto
            CollectionAssert.Equals(notasEsperadas, CaixaEletronicoContext.NotasSaque);
        }

        /// <summary>
        /// Testa a exceção gerada quando o usuário fornece um valor inválido, não múltiplo de 10
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ValorSaqueInvalidoException))]
        public void TestaExcecaoValorInvalidoNaoMultiplo10()
        {
            //Preparar valor não múltiplo de 10
            CaixaEletronicoContext.ValorSaque = 12;

            //Ação
            CaixaEletronicoContext.RealizarSaque();
        }

        /// <summary>
        /// Testa a exceção gerada quando o usuário fornece um valor menor que 10
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ValorSaqueInvalidoException))]
        public void TestaExcecaoValorInvalidoMenorQue10()
        {
            //Preparar valor não múltiplo de 10
            CaixaEletronicoContext.ValorSaque = 9;

            //Ação
            CaixaEletronicoContext.RealizarSaque();
        }

    }
}
