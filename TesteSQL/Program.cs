using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do usuário:");
            string userInput = Console.ReadLine();

            string connectionString = "Persist Security Info=False;server=localhost:3306;database=aula_seg;uid=professor;pwd=senha";
            string query = $"SELECT * FROM Usuarios WHERE Nome = '{userInput}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nome = reader["Nome"].ToString();
                        Console.WriteLine("Usuário encontrado: " + nome);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
