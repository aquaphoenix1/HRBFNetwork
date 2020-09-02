using System.Collections.Generic;
using System.Linq;

namespace HRBFNetwork.Network
{
    class OutputLayer
    {
        public double Calcaulte(List<double> input)
        {
            return input.Sum();
        }
    }
}
