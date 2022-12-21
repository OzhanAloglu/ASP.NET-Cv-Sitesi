using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvSitesiAsp;

using System.Windows;

namespace CvSitesiAsp.Net_Entity
{
    public partial class YetenekEkle : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            FormControl.giris(Response);
            
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TBLYETENEKLER ekle = new TBLYETENEKLER();

            ekle.Yetenek = TextBox1.Text;
            ekle.Derece =Convert.ToByte(TextBox2.Text);
            
            db.TBLYETENEKLER.Add(ekle);
            db.SaveChanges();

            Response.Redirect("Yeteneklerim.aspx");


        }
    }
}