using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace WebAdo2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello World");
            Response.Write("<br/>");

            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            Response.Write(s);
        }
    }

}