﻿using Scoring.Core.Interfaces.CalculatePreScoring;
using Scoring.Model.Entities;

namespace Scoring.Core.Services.CalculatePreScoring.AproveRules
{
    public class ValidarNacionalidad : IAproveRule
    {
        public bool IsApproved(Solicitud solicitud)
        {
            if (solicitud.cliente.Nacionalidad != null && solicitud.cliente.Nacionalidad == "Espaniola")
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