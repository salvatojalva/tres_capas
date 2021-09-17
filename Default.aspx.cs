using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using P2.Model;

namespace P2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                this.tryLogin();
            }
        }

        protected void tryLogin()
        {
            string rol = "";
            
            string usuario = userInput.Value.ToString();
            string password = passwordInput.Value.ToString();
            msg.Text = "usuario NO existe";

            Usuario user = Ctrl.UsuarioCtrl.login(usuario, password);

            if (user != null) 
            {

                if (user.CodigoAlumno != "") 
                {
                    rol = "alumno";

                }
                
                if (user.DPI != "") rol = "profesor";
                if (user.Admin) rol = "admin";

                Session["ROL"] = rol;

                msg.Text = user.User;
            }
        }
    }
}