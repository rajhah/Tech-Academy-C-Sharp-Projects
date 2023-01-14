using Microsoft.AspNetCore.Mvc;
using NewsletterSignupDemo.Models;
using NewsletterSignupDemo.ViewModels;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace NewsletterSignupDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _connectionString = @"Server=PHIL-LAPTOP\SQLEXPRESS;Database=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterContext db = new NewsletterContext(_connectionString))
                {
                    var contact = new contact();
                    contact.first_name = firstName;
                    contact.last_name = lastName;
                    contact.email = emailAddress;

                    db.contacts.Add(contact);
                    db.SaveChanges();
                }
                //string queryString = @"INSERT INTO contacts (first_name, last_name, email) VALUES (@FirstName, @LastName, @EmailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command= new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}

                return View("Success");
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

