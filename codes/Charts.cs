using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Delivery_Management.codes
{
    public class Charts
    {
        DataSet ds = new DataSet();
        public Charts() { }

        public string BarCharts(DataTable dt, int count)
        {
            string value1 = "";
            string value2 = "";
            string chart = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i > 0)
                {
                    value1 += ",";
                    value2 += ",";
                }
                value1 += "'" + dt.Rows[i][0].ToString() + "'";
                value2 += "'" + dt.Rows[i][1].ToString() + "'";
            }
            chart = "<canvas id =\"BarChart" + count + "\" style=\"width:100%;max-width:600px\"></canvas>\r\n\r\n<script>\r\nvar xValues = [" + value2 + "];\r\nvar yValues = [" + value1 + "];\r\nvar barColors = [\"#e4bcad\", \"#df979e\",\"#d7658b\",\"orange\",\"brown\"];\r\n\r\nnew Chart(\"BarChart" + count + "\", {\r\n  type: \"pie\",\r\n  data: {\r\n    labels: xValues,\r\n    datasets: [{\r\n      backgroundColor: barColors,\r\n      data: yValues\r\n    }]\r\n  },\r\n  options: {\r\n    legend: {display: false},\r\n    title: {\r\n      display: true,\r\n      text: \"Types Of Deliveries\"\r\n    }\r\n  }\r\n});\r\n</script>";
            return chart;
        }

        public string BarCharts1(DataTable dt, int count)
        {
            string value1 = "";
            string value2 = "";
            string chart = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i > 0)
                {
                    value1 += ",";
                    value2 += ",";
                }
                value1 += "'" + dt.Rows[i][0].ToString() + "'";
                value2 += "'" + dt.Rows[i][1].ToString() + "'";
            }
            chart = "<canvas id =\"BarChart1" + count + "\" style=\"width:100%;max-width:600px\"></canvas>\r\n\r\n<script>\r\nvar xValues = [" + value2 + "];\r\nvar yValues = [" + value1 + "];\r\nvar barColors = [\"#63bff0\", \"#a7d5ed\",\"#e2e2e2\",\"#e1a692\",\"#de6e56\"];\r\n\r\nnew Chart(\"BarChart1" + count + "\", {\r\n  type: \"bar\",\r\n  data: {\r\n    labels: xValues,\r\n    datasets: [{\r\n      backgroundColor: barColors,\r\n      data: yValues\r\n    }]\r\n  },\r\n  options: {\r\n    legend: {display: false},\r\n    title: {\r\n      display: true,\r\n      text: \"Modes Of Payment\"\r\n    }\r\n  }\r\n});\r\n</script>";
            return chart;
        }
        //public string BarCharts2(DataTable dt, int count)
        //{
        //    string value1 = "";
        //    string value2 = "";
        //    string chart = "";

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        if (i > 0)
        //        {
        //            value1 += ",";
        //            value2 += ",";
        //        }
        //        value1 += "'" + dt.Rows[i][0].ToString() + "'";
        //        value2 += "'" + dt.Rows[i][1].ToString() + "'";
        //    }
        //    chart = "<canvas id =\"BarChart" + count + "\" style=\"width:100%;max-width:600px\"></canvas>\r\n\r\n<script>\r\nvar xValues = [" + value1 + "];\r\nvar yValues = [" + value2 + "];\r\nvar barColors = [\"red\", \"green\",\"blue\",\"orange\",\"brown\"];\r\n\r\nnew Chart(\"BarChart" + count + "\", {\r\n  type: \"bar\",\r\n  data: {\r\n    labels: xValues,\r\n    datasets: [{\r\n      backgroundColor: barColors,\r\n      data: yValues\r\n    }]\r\n  },\r\n  options: {\r\n    legend: {display: false},\r\n    title: {\r\n      display: true,\r\n      text: \"World Wine Production 2018\"\r\n    }\r\n  }\r\n});\r\n</script>";
        //    return chart;
        //}
    }
}