using SystemeDeSimulation.Domain;
using SystemeDeSimulation.Infrastructure;

namespace SystemeDeSimulation.Bussins
{
    internal class RemplissageSimulation
    {
        List<conteneur> conteneur;
private stock stock;
        Mutex mutex = new Mutex();

        public RemplissageSimulation( stock s)
        {
            this.conteneur = new List<conteneur>();
            this.stock = stock;
        }
        public void InitialiserConteneur(conteneur c)
        {
            conteneur.Add(c);

        }
        public void demarrerConteneur()
        {

            foreach (conteneur c in conteneur)
            {
                Thread t = new Thread(() => demarrerCont(c));
                t.Start();
            }

        }

        private static void demarrerCont(conteneur c)
        {
            while (true)
            {




                System.Threading.Thread.Sleep(10000);

            }
        }
    }
}
