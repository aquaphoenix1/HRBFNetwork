namespace HRBFNetwork.Network
{
    class ActivationNeuron
    {
        public double W { get; set; }

        public ActivationNeuron()
        {
            W = Tools.GetRandom();
        }

        internal double Calculate()
        {
            return W;
        }
    }
}
