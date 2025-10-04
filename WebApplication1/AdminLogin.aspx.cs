using System;
using System.Linq;

namespace WebApplication1
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        QuizdbEntities db = new QuizdbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check user in AdminUsers table
            var user = db.AdminUsers.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Store session
                Session["AdminUser"] = user.Username;

                // Redirect to Admin Panel (Admin Controller Index)
                Response.Redirect("~/Admin/Index");
            }
            else
            {
                lblMessage.Text = "Invalid Username or Password!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
