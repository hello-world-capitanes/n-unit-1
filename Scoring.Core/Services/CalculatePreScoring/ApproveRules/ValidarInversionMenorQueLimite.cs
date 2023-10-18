using Scoring.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring.Core.Services.CalculatePreScoring.ApproveRules
{
    public class ValidarInversionMenorQueLimite
    {
        public bool IsApproved(Solicitud solicitud, double limite)
        {           
            if (solicitud.Inversion <= limite)
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
