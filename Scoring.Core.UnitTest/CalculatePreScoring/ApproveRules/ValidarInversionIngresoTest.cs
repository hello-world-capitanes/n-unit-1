using NUnit.Framework;
using Scoring.Core.Services.CalculatePreScoring.ApproveRules;
using Scoring.Core.Services.CalculatePreScoring.AproveRules;
using Scoring.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Scoring.Core.UnitTest.CalculatePreScoring.ApproveRules
{
    internal class ValidarInversionIngresoTest
    {
        private ValidarInversionIngreso _validarInversionIngreso;
        [SetUp]
        public void Setup()
        {
            _validarInversionIngreso = new ValidarInversionIngreso();
        }

        [Test]
        public void Should_True_When_Inversion_Menor_IngresosNeto()
        {
            //Given
            Solicitud solicitud = new Solicitud();
            solicitud.cliente = new Persona();

            solicitud.Inversion = 99;
            solicitud.cliente.IngresosNetosAnuales = 100;

            //When
            bool resultado = _validarInversionIngreso.IsApproved(solicitud);

            //Then
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Should_True_When_Inversion_Igual_IngresosNeto()
        {
            //Given
            Solicitud solicitud = new Solicitud();
            solicitud.cliente = new Persona();

            solicitud.Inversion = 100;
            solicitud.cliente.IngresosNetosAnuales = 100;

            //When
            bool resultado = _validarInversionIngreso.IsApproved(solicitud);

            //Then
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Should_True_When_Inversion_Mayor_IngresosNeto()
        {
            //Given
            Solicitud solicitud = new Solicitud();
            solicitud.cliente = new Persona();

            solicitud.Inversion = 101;
            solicitud.cliente.IngresosNetosAnuales = 100;

            //When
            bool resultado = _validarInversionIngreso.IsApproved(solicitud);

            //Then
            Assert.IsFalse(resultado);
        }
    }
}
