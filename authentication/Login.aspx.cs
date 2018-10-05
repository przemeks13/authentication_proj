using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Diagnostics;

namespace authentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Membership.CreateUser("root", "root@D1");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(tbxLogin.Text, tbxPassword.Text))
            {
                System.Diagnostics.Trace.WriteLine("Zalogowano" + tbxLogin.Text);
            }
                //FormsAuthentication.RedirectFromLoginPage(tbxLogin.Text, true);
            else
                System.Diagnostics.Trace.WriteLine("Nie zalogowano" + tbxLogin.Text);
        }
    }
}