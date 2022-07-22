using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cataloghi_EnduroBike : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEnduroPark_Click(object sender, EventArgs e)
    {
        Response.Redirect("1Enduro.aspx");
    }
    protected void btnMountainPark_Click(object sender, EventArgs e)
    {
        Response.Redirect("3MoutainBike.aspx");

    }

    protected void btnRacePark_Click(object sender, EventArgs e)
    {
        Response.Redirect("2RaceBike.aspx");

    }
}