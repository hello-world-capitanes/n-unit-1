using Moq;
using NUnit.Framework;
using Scoring.Core.Interfaces;
using Scoring.Core.Interfaces.CalculatePreScoring;
using Scoring.Core.Services;
using Scoring.Model.Entities;

namespace Scoring.Core.UnitTest
{
    public class PreSolicitudRentingTest
    {
        private IPreSolicitudRenting service;
        private Solicitud solicitud;

        private Mock<IApprovePreRequestProcess> approvePreRequestProcessMock = new Mock<IApprovePreRequestProcess>();
        [SetUp]
        public void Setup()
        {
            this.service = new PreSolicitudRenting(this.approvePreRequestProcessMock.Object);
            this.solicitud.cliente.Nacionalidad = "Espaniola";
        }

        [Test]
        public void Test_CalculatePreRequest_ShouldBeTrue_When_ApprovedRulesTrue()
        {
            //Given
            this.approvePreRequestProcessMock.Setup(a => a.ApprovedRules(solicitud)).Returns(true);
            //When
            bool resultado = this.service.CalculatePreRequest(solicitud);
            //Then
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Test_CalculatePreRequest_ShouldBeFalse_When_ApprovedRulesFalse()
        {
            //Given
            this.approvePreRequestProcessMock.Setup(a => a.ApprovedRules(solicitud)).Returns(false);
            //When
            bool resultado = this.service.CalculatePreRequest(solicitud);
            //Then
            Assert.IsFalse(resultado);
        }
    }
}