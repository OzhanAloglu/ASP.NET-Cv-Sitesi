using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    public partial class İletisimSil : System.Web.UI.Page
    { DbCvEntityEntities db= new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            FormControl.giris(Response);

            int x = int.Parse(Request.QueryString["ID"]);

            var ekle=db.TBLILETISIM.Find(x);

            db.TBLILETISIM.Remove(ekle);

            db.SaveChanges();

            Response.Redirect("İletisim.aspx");

        }
    }
}