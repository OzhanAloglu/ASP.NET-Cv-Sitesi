using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Web;

namespace CvSitesiAsp.Net_Entity
{
    public class FormControl
    {
        public static LoginPaneli login = new LoginPaneli();


        public static void giris(HttpResponse Response)

        {
            if (FormControl.login.girisadi == "aloglu" && FormControl.login.sifre == "oa123")
            {

            }

            else
            {
                
                Response.Redirect("LoginPaneli.aspx");

            }

        }



    }
}