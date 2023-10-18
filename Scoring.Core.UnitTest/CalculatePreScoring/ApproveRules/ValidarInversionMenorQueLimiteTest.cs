using NUnit.Framework;
using Scoring.Core.Services.CalculatePreScoring.ApproveRules;
using Scoring.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring.Core.UnitTest.CalculatePreScoring.ApproveRules
{
    internal class ValidarInversionMenorQueLimiteTest
    {
        private ValidarInversionMenorQueLimite _validarInversionMenorQueLimite;
        [SetUp]
        public void Setup()
        {
            _validarInversionMenorQueLimite = new ValidarInversionMenorQueLimite();
        }

        [Test]
        public void Should_True_When_Inversion_Menor_Limite()
        {
            //Given
            Solicitud solicitud = new Solicitud();


            solicitud.Inversion = 99;
            double limite = 80000;

            //When
            bool resultado = _validarInversionMenorQueLimite.IsApproved(solicitud, limite);

            //Then
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Should_True_When_Inversion_Igual_Limite()
        {
            //Given
            Solicitud solicitud = new Solicitud();

            solicitud.Inversion = 80000;
            double limite = 80000;

            //When
            bool resultado = _validarInversionMenorQueLimite.IsApproved(solicitud, limite);

            //Then
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Should_True_When_Inversion_Mayor_IngresosNeto()
        {
            //Given
            Solicitud solicitud = new Solicitud();

            solicitud.Inversion = 80001;
            double limite = 80000;

            //When
            bool resultado = _validarInversionMenorQueLimite.IsApproved(solicitud, limite);

            //Then
            Assert.IsFalse(resultado);
        }
    }
}
