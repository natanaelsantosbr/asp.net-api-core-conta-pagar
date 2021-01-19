using Microsoft.VisualStudio.TestTools.UnitTesting;
using Natanael.Dominio.ContasPagar;
using System;

namespace Natanael.Tests
{
    [TestClass]
    public class ContaPagarTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestarSeNomeEObrigatorio()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = DateTime.Now.AddDays(10);

            var contaPagar = new ContaPagar("", 100, dataDeVencimento, dataDePagamento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestarSeValorEObrigatorio()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = DateTime.Now.AddDays(10);

            var contaPagar = new ContaPagar("Notebook", 0, dataDeVencimento, dataDePagamento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestarSeDataDeVencimentoEObrigatorio()
        {
            DateTime dataDeVencimento = DateTime.MinValue;
            DateTime dataDePagamento = DateTime.Now.AddDays(10);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestarSeDataDePagamentoEObrigatorio()
        {
            DateTime dataDeVencimento = DateTime.Now.AddDays(10);
            DateTime dataDePagamento = DateTime.MinValue; 

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
        }


        [TestMethod]
        public void TestarMultaAteTresDias()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = dataDeVencimento.AddDays(+3);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
            var multa = contaPagar.ValorDaMulta;
            Assert.AreEqual(2, multa);
        }

        [TestMethod]
        public void TestarJurosAteTresDias()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = dataDeVencimento.AddDays(+3);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
            var juros = contaPagar.ValorDosJuros;
            Assert.AreEqual(0.30, juros);
        }

        [TestMethod]
        public void TestarMultaSuperiorTresDias()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = dataDeVencimento.AddDays(+5);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
            var multa = contaPagar.ValorDaMulta;
            Assert.AreEqual(3, multa);
        }

        [TestMethod]
        public void TestarJurosSuperiorTresDias()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = dataDeVencimento.AddDays(+5);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
            var juros = contaPagar.ValorDosJuros;
            Assert.AreEqual(1, juros);
        }

        [TestMethod]
        public void TestarMultaSuperiorCincoDias()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = dataDeVencimento.AddDays(+34);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
            var multa = contaPagar.ValorDaMulta;
            Assert.AreEqual(5, multa);
        }

        [TestMethod]
        public void TestarJurosSuperiorCincoDias()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = dataDeVencimento.AddDays(+34);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
            var juros = contaPagar.ValorDosJuros;
            Assert.AreEqual(10.19, juros);
        }
    }
}
