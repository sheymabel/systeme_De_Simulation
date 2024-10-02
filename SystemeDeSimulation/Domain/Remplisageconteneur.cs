namespace SystemeDeSimulation.Domain
{
    internal class Remplisageconteneur
    {
        private int idConteneur;
        private int niveauCriptique;
        private int volumeMax;
        private int volumeCourant;

        Random random = new Random();

        public int IdConteneur { get => idConteneur; set => idConteneur = value; }
        public int NiveauCriptique { get => random.Next(1, 10); }
        public int VolumeCourant { get => random.Next(1, 10); }
        public int VolumeMax { get => volumeMax; }




    }
}
