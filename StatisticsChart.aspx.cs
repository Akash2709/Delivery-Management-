using Delivery_Management.codes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Delivery_Management
{
    public partial class StatisticsChart : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        dbcalling db = new dbcalling();
        Charts charts = new Charts();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ds = db.GetCharts("ChartSp");
                dt = ds.Tables[0];
                BarChart.Text = charts.BarCharts(dt, 0);
                dt = ds.Tables[1];
                BarChart1.Text = charts.BarCharts1(dt, 1);
                //dt = ds.Tables[2];
                //BarChart2.Text = charts.BarCharts2(dt, 2);

            }
        }
    }
}