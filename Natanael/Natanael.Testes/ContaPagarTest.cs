using Natanael.Dominio.ContasPagar;
using NUnit.Framework;
using System;

namespace Natanael.Testes
{
    [TestFixture]
    public class ContaPagarTest
    {
        [Ignore("ignorar test")]
        public void TestarSeOsCamposEObrigatorios()
        {
            
            

        }

        [Ignore("ignorar test")]
        public void TestarAdicionar()
        {

        }

        [Test]
        [TestCase]
        public void TestarMultaAteTresDias()
        {
            DateTime dataDeVencimento = DateTime.Now;
            DateTime dataDePagamento = dataDeVencimento.AddDays(+3);

            var contaPagar = new ContaPagar("Notebook", 100, dataDeVencimento, dataDePagamento);
            var multa = contaPagar.ValorDaMulta;
            Assert.AreEqual(2, multa);
        }

        [Ignore("ignorar test")]
        public void TestarMultaSuperiorATresDias()
        {

        }

        [Ignore("ignorar test")]
        public void TestarMultaSuperiorA5Dias()
        {

        }
    }
}
