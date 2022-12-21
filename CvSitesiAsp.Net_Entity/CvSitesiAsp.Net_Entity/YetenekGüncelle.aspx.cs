using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {
        DbCvEntityEntities db=new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack==false)
            {
                var deger = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = deger.Yetenek;
            }
          
            




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //GÜNCELLEME KODLARI

            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLER.Find(x);

            deger.Yetenek = TextBox1.Text;
            deger.Derece = Convert.ToByte(TextBox2.Text);
            db.SaveChanges();

            Response.Redirect("Yeteneklerim.aspx");



        }
    }
}