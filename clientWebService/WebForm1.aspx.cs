using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clientWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReferenceOne.ServiceOneClient _service = new ServiceReferenceOne.ServiceOneClient();
            //ServiceReferenceOne.
            var _mensaje = _service.getMessage("Ronald");
            lblMessage.Text = _mensaje.ToString();
        }
    }
}