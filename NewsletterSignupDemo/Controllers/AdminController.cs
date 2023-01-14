using Microsoft.AspNetCore.Mvc;
using NewsletterSignupDemo.Models;
using NewsletterSignupDemo.ViewModels;
using System.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace NewsletterSignupDemo.Controllers
{
    public class AdminController : Controller
    {
        private readonly string _connectionString = @"Server=PHIL-LAPTOP\SQLEXPRESS;Database=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

        // GET: Admin
        public IActionResult Index()
        {

            using (NewsletterContext db = new NewsletterContext(_connectionString))
            {
                //var contacts = db.contacts.Where(x => x.deleted_on == null).ToList();
                var contacts = (from c in db.contacts where c.deleted_on == null select c).ToList();
                var signupVms = new List<SignupVm>();
                foreach (var signup in contacts)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.id;
                    signupVm.First_name = signup.first_name;
                    signupVm.Last_name = signup.last_name;
                    signupVm.Email = signup.email;

                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
            //string queryString = @"SELECT id, first_name, last_name, email, socialSecurityNumber FROM contacts";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            ////using(SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();

            //    while(reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["id"]);
            //        signup.First_name = reader["first_name"].ToString();
            //        signup.Last_name = reader["last_name"].ToString();
            //        signup.Email = reader["email"].ToString();
            //        signup.SocialSecurityNumber = reader["socialSecurityNumber"].ToString();

            //        signups.Add(signup);
            //    }
            //}


        }

        [HttpPost]
        public IActionResult Unsubscribe(int id)
        {
            using (NewsletterContext db = new NewsletterContext(_connectionString))
            {
                var contact = db.contacts.Find(id);
                contact.deleted_on = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
