using Moq;
using NUnit.Framework;
using Scoring.Core.Interfaces.CalculatePreScoring;
using Scoring.Core.Interfaces;
using Scoring.Core.Services;
using Scoring.Model.Entities;

using Scoring.Core.Services.CalculatePreScoring.AproveRules;

namespace Scoring.Core.UnitTest.CalculatePreScoring.ApproveRules
{
    internal class ValidarNacionalidadTest
    {
        private ValidarNacionalidad _validarNacionalidad;
        [SetUp]
        public void Setup()
        {
            _validarNacionalidad = new ValidarNacionalidad();
        }

        [Test]
        public void Should_True_When_Nacionalidad_Espaniola()
        {
            //Given
            Solicitud solicitud = new Solicitud();
            solicitud.cliente = new Persona();

            solicitud.cliente.Nacionalidad = "Espaniola";

            //When
            bool resultado = _validarNacionalidad.IsApproved(solicitud);

            //Then
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Should_False_When_Nacionalidad_NoEspaniola()
        {
            //Given
            Solicitud solicitud = new Solicitud();
            solicitud.cliente = new Persona();

            solicitud.cliente.Nacionalidad = "Portugesa";

            //When
            bool resultado = _validarNacionalidad.IsApproved(solicitud);

            //Then
            Assert.IsFalse(resultado);
        }
    }
}