using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atnd0
{
    public partial class diag : System.Web.UI.Page
    {
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            var connectionSetting = System.Configuration.ConfigurationManager.ConnectionStrings["AtndDB"];
            var connectionString = new SqlConnectionStringBuilder(connectionSetting.ConnectionString);
            this.Label1.Text = connectionString.DataSource;
        }
    }
}