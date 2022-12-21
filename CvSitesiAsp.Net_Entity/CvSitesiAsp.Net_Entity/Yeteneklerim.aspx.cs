using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    public partial class Hakkımda : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater1.DataSource = db.TBLYETENEKLER.ToList();
            Repeater1.DataBind();


        }

       

        
    }

    


}