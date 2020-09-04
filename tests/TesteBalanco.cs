using NUnit.Framework;
using Padawan.Financeiro.Negocio;
using Padawan.Financeiro.Negocio.Models;
namespace Tests
{
    public class TesteBalanco
    {
        [SetUp]
        public void Setup()
        {
        }

<<<<<<< HEAD
        [Test]
        public void ValorSaldoInicial()
        {
            Balanco balanco = new Balanco();
            Assert.AreEqual(0.0, balanco.Saldo);
        }

        [Test]
        public void AdicionarCredito()
        {
            Balanco balanco = new Balanco();
            balanco.Add(new Credito(1000.00));
            Assert.AreEqual(1000.00, balanco.Saldo);
        }
=======
        [Test]
        public void ValorSaldoInicial()
        {
            Balanco balanco = new Balanco();
            Assert.Equals(0.0, balanco.Saldo);
        }
>>>>>>> upstream/master


        [Test]
        public void AdicionarDebito()
        {
            Balanco balanco = new Balanco();
            balanco.Add(new Debito(650.25));
            Assert.AreEqual(-650.25, balanco.Saldo);

        }

        [Test]
        public void AdicionarDebitoCredito()
        {
            Balanco balanco = new Balanco();
            balanco.Add(new Debito(200.00));
            balanco.Add(new Credito(550.25));
            Assert.AreEqual(350.25, balanco.Saldo);
        }
    }
}