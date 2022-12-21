using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesiAsp.Net_Entity
{
    public partial class İstatistikler : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            FormControl.giris(Response);

            //Toplam Yetenek sayısını bulan linq sorgusu   label1 e yazdırma.

            Label1.Text = db.TBLYETENEKLER.Count().ToString();

            //Toplam mesaj sayısını bulan linq sorgusu   label2 e yazdırma.

            Label2.Text = db.TBLILETISIM.Count().ToString();

            //Derecelerin ortalamasını veren linq sorgusu.

            Label3.Text = db.TBLYETENEKLER.Average(x => x.Derece).ToString();

            //En yüksek derece olanı getir.

            Label4.Text = db.TBLYETENEKLER.Max(x => x.Derece).ToString();

            //En yüksek dereceye sahip yetenek


          
            







        }
    }
}