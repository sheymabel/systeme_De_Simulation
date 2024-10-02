namespace SystemeDeSimulation.Domain
{
    internal class stock
    {
        internal int idConteneur;
        internal int volumeMax;

        public int volumeCourant { get; internal set; }
        public int VolumeMax { get; internal set; }
        public int VolumeCourant { get; internal set; }
        public int NiveauCritique { get; internal set; }

        //public static bool Stock(conteneur s) { }
       // public List<conteneur> Retrieve(int niveauCriptique, int volumeMax, int volumeCourant);

    }
}
