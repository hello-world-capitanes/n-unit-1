
using Scoring.Core.Interfaces.CalculatePreScoring;
using Scoring.Model.Entities;

namespace Scoring.Core.Services.CalculatePreScoring
{
    public class ApprovePreRequestProcess : IApprovePreRequestProcess
    {
        private IAproveRule _validarNacionalidadRule;
        public ApprovePreRequestProcess(IAproveRule validarNacionalidadRule)
        {
            _validarNacionalidadRule = validarNacionalidadRule;
        }

        public bool ApprovedRules(Solicitud solicitud)
        {
            if (_validarNacionalidadRule.IsApproved(solicitud))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
