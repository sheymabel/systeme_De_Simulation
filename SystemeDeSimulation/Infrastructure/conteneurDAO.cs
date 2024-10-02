using MySqlConnector;
using SystemeDeSimulation.Domain;

namespace SystemeDeSimulation.Infrastructure
{
    internal class ConteneurDAO 
    {
        private MySqlConnection _connection;
        private string _connectionString = "server=localhost;port=3306;user=root;database=simulation;Uid=root;";

        public ConteneurDAO()
        {
            _connection = ConnectionManager.GetInstance(_connectionString).GetConnection();
        }

        public bool Stock(stock s)
        {

            string query = "INSERT INTO simulation (idConteneur, volumeMax, niveauCritique, volumeCourant) VALUES (@idConteneur, @volumeMax, @niveauCritique, @volumeCourant)";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = _connection;
            cmd.Parameters.AddWithValue("@idConteneur", s.idConteneur);
            cmd.Parameters.AddWithValue("@volumeMax", s.VolumeMax);
            cmd.Parameters.AddWithValue("@niveauCritique", s.volumeMax);
            cmd.Parameters.AddWithValue("@volumeCourant", s.VolumeCourant);
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
        public List<stock> retrieve(int idConteneur, int volumeMax, int NiveauCritique, int volumeCourant)
        {
            string query = "SELECT * FROM simulation ";
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@idConteneur", idConteneur);
            cmd.Parameters.AddWithValue("@volumeMax", volumeMax);
            cmd.Parameters.AddWithValue("@volumeCourant", volumeCourant);

            List<stock> vehiculePositions = new List<stock>();

            stock positionV = null;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                positionV = new stock
                {
                    idConteneur = (int)reader["idConteneur"],
                    NiveauCritique = (int)reader["NiveauCritique"],
                    volumeCourant = (int)reader["volumeCourant"],
                    volumeMax = (int)reader["volumeMax"],
                };
                vehiculePositions.Add(positionV);

            }


            return vehiculePositions;
        }

    }
}




