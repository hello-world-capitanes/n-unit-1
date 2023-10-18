using Scoring.Core.Interfaces.CalculatePreScoring;

namespace Scoring.Core.Services.CalculatePreScoring
{
    public class DenyPreRequestProcess : IDenyRules
    {
        public bool DenniedRules()
        {
            return true;
        }
    }
}