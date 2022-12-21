using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities db=new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater1.DataSource=db.TBLHAKKIMDA.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource=db.TBLHAKKIMDA.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource=db.TBLYETENEKLER.ToList();
            Repeater4.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();

            t.AdSoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Konu = TextBox3.Text;
            t.Mesaj= TextBox4.Text;

            db.TBLILETISIM.Add(t);
            db.SaveChanges();

         

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}