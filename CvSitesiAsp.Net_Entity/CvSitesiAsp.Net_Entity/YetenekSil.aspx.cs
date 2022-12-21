using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        DbCvEntityEntities db=new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            FormControl.giris(Response);

            int x = Convert.ToInt32(Request.QueryString["ID"]);

            var ytnk = db.TBLYETENEKLER.Find(x);

            db.TBLYETENEKLER.Remove(ytnk);
            db.SaveChanges();

            Response.Redirect("Yeteneklerim.aspx");

        }
    }
}