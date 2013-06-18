using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EloquaFinalResult
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageBox ("Reached the Initial Input :)");
        }

        #region Message Box
        /// <summary>
        /// Generic message box
        /// </summary>
        /// <param name="strMsg">String Message</param>
        public void MessageBox(string strMsg)
        {
            Controls.Add(new LiteralControl("<script language='javascript'> window.alert('" + strMsg.Replace("'", "\\'") + "')</script>"));
        }
        #endregion

    }
}