using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    public partial class MesajGöster : System.Web.UI.Page
    {DbCvEntityEntities db=new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Burada ID e göre mesajı textboxa yazdıran ifade.
            FormControl.giris(Response);

            int x = int.Parse(Request.QueryString["ID"]);

            var deger = db.TBLILETISIM.Find(x);

            TextBox1.Text = deger.Mesaj;

            db.SaveChanges();

        }
    }
}