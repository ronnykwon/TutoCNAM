using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReparationPhone.Metier
{
    
    class ReparationAccess
    {
        private static MySqlConnection connection;

        

        static ReparationAccess()
        {
            String connString = "Server=localhost;Database=telephones;userid=rkwon;Pwd=";
            connection = new MySqlConnection(connString);
            //connection.Open();
        }



        public static void GetAllReparation()
        {
            
            // on prepare la requête
            String sql = "SELECT * FROM reparation";
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Connection.Open();
                // On exécute la requête
                using (DbDataReader dbReader = command.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        int idRep = dbReader.GetInt32(0);
                        string nom = dbReader.GetString(1);
                        string prenom = dbReader.GetString(2);
                        string contact = dbReader.GetString(4);
                        string email = dbReader.GetString(3);
                        string modelPhone = dbReader.GetString(5);
                        string description = dbReader.GetString(8);
                        Business.Reparations.Add(new Reparation(nom, prenom, contact, email, modelPhone, description) { IdReparation = idRep });
                    }
                }

                command.Connection.Close();
            }
        }

        public static bool InsertReparation(Reparation r)
        {
            string sql = "INSERT INTO reparation(idReparation, Nom, Prenom, Email, Contact, ModelPhone, ReceivedDate, ExpectedFinishDate, Description, Prix) " +
                "VALUES(@idReparation, @nom, @prenom, @email, @contact,@modelPhone, @receivedDate, @expectedFinishDate, @description, @prix)";
            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@idReparation", null);
                cmd.Parameters.AddWithValue("@nom", r.Nom);
                cmd.Parameters.AddWithValue("@prenom", r.Prenom);
                cmd.Parameters.AddWithValue("@email", r.Email);
                cmd.Parameters.AddWithValue("@contact", r.Contact);
                cmd.Parameters.AddWithValue("@modelPhone", r.ModelPhone);
                cmd.Parameters.AddWithValue("@receivedDate", r.ReceivedDate);
                cmd.Parameters.AddWithValue("@expectedFinishDate", r.ExpectedFinishDate);
                cmd.Parameters.AddWithValue("@description", r.Description);
                cmd.Parameters.AddWithValue("@prix", r.Prix);
                
                bool result = cmd.ExecuteNonQuery() == 1;
                cmd.Connection.Close();
                return result;
            }

        }

        public static bool UpdateReparation(Reparation r)
        {
            string sql = "UPDATE reparation SET Nom=@nom, Prenom=@prenom, Email=@email, Contact=@contact, ModelPhone=@modelPhone, ReceivedDate=@receivedDate, ExpectedFinishDate=@expectedFinishDate,Description=@description,Prix=@prix " +
                "Where idReparation=@idReparation";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@idReparation", r.IdReparation);
                cmd.Parameters.AddWithValue("@nom", r.Nom);
                cmd.Parameters.AddWithValue("@prenom", r.Prenom);
                cmd.Parameters.AddWithValue("@email", r.Email);
                cmd.Parameters.AddWithValue("@contact", r.Contact);
                cmd.Parameters.AddWithValue("@modelPhone", r.ModelPhone);
                cmd.Parameters.AddWithValue("@receivedDate", r.ReceivedDate);
                cmd.Parameters.AddWithValue("@expectedFinishDate", r.ExpectedFinishDate);
                cmd.Parameters.AddWithValue("@description", r.Description);
                cmd.Parameters.AddWithValue("@prix", r.Prix);

                bool result = cmd.ExecuteNonQuery() == 1;
                cmd.Connection.Close();
                return result;
            }
        }

    }
}
