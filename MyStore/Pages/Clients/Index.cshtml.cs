using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=NAHIYEAN-ALIF;Initial Catalog=mystore;Integrated Security=True";

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM clients";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                       using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = "" + reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                                clientInfo.email =  reader.GetString(2);
                                clientInfo.phone =  reader.GetString(3);
                                clientInfo.address =  reader.GetString(4);
                                clientInfo.created_at =  reader.GetDateTime(5).ToString();

                                listClients.Add(clientInfo);
                           }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    public class ClientInfo
    {
        public string id;
        public string name;
        public string email;
        public string phone;
        public string address;
        public string created_at;
    }
}
