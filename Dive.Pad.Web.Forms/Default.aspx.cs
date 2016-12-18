using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sicred.Data.BaseModel.UnitOfWorks;

namespace Dive.Pad.Web.Forms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UnitOfWork unit = new UnitOfWork();

            var pontosdeMergulho = unit.PontodeMergulho.ToList();

            var pm = pontosdeMergulho.FirstOrDefault();



        }
    }
}