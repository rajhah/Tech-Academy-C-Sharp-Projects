using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NewsletterSignupDemo.ViewModels
{
    public class SignupVm
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
    }
}
