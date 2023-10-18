using Scoring.Core.Interfaces.CalculatePreScoring;
using Scoring.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring.Core.Services.CalculatePreScoring.ApproveRules
{
    public class ValidarInversionIngreso : IAproveRule
    {
        public bool IsApproved(Solicitud solicitud)
        {            
            if (solicitud.Inversion <= solicitud.cliente.IngresosNetosAnuales)
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
