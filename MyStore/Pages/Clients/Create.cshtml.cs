using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace MyStore.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public String errorMessage = "";
        public String successMessage = "";
		public void OnGet()
        {
        }
        public void OnPost() 
        {
            clientInfo.name = Request.Form["name"];
            clientInfo.name = Request.Form["email"];
            clientInfo.name = Request.Form["phone"];
            clientInfo.name = Request.Form["address"];

            if(clientInfo.name.Length == 0 || clientInfo.email.Length == 0 || clientInfo.phone.Length == 0 || clientInfo.address.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            //Save the new client into the database

            try
            {
                String connectionString = "Data Source=NAHIYEAN-ALIF;Initial Catalog=mystore;Integrated Security=True";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO clients" + "(name, email, phone, address) VALUES" + "(@name, @email, @phone, @address);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", clientInfo.name);
                        command.Parameters.AddWithValue("@email", clientInfo.email);
                        command.Parameters.AddWithValue("@phoe", clientInfo.phone);
                        command.Parameters.AddWithValue("@address", clientInfo.address);

                        command.ExecuteNonQuery();
					}
                }

			}
            catch(Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            clientInfo.name = ""; clientInfo.email = ""; clientInfo.phone = ""; clientInfo.address = "";
            successMessage = "New Client Added Correctly";

            Response.Redirect("/Clients/Index");
		}
    }
}
