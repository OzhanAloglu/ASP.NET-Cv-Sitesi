using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    
    public partial class LoginPaneli : System.Web.UI.Page
    {



        public  string girisadi;
        public  string sifre;


        protected void Page_Load(object sender, EventArgs e)

        {

        }


        DbCvEntityEntities db=new DbCvEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMİN
                        where x.KULLANICIAD == TextBox1.Text &&
                      x.SIFRE == TextBox2.Text
                        select x;

            if (sorgu.Any())
            {
                girisadi = TextBox1.Text;
                sifre = TextBox2.Text;


                Response.Redirect("İletisim.aspx");
            }

            else
            {
                Response.Write("Hatalı Kullanıcı adı yada şifre");
            }

            
                      

        }
    }
}