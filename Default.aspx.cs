using Delivery_Management.codes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Delivery_Management
{
    public partial class _Default : Page
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt ;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewData();
                Bind_ddlCountry();
                Cards();
                
            }
        }

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    panelAddDetails.Visible = false;
        //    panelLoginPage.Visible = false;
        //    GvDelivery.Visible = false ;
        //    Dashboard.Visible = true ;
        //    parameters _cParams = new parameters();
        //    _cParams.UserName = txtUserNAme.Text;
        //    _cParams.Password = txtPassword.Text;
        //    dbcalling bg = new dbcalling();
        //    bg.LoginDetails(_cParams);
        //}
        //public bool loginvalidation()
        //{
        //    parameters _cParams = new parameters();
        //    _cParams.UserName = txtUserNAme.Text;
        //    _cParams.Password = txtPassword.Text;
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        string user = dt.Rows[i][0].ToString();
        //        string password = dt.Rows[i][1].ToString();
        //        if (user.Equals(_cParams.UserName) && password.Equals(_cParams.Password))
        //        {
        //            return true;
        //        }

        //    }
        //    return false;
        //}
        protected void GvEmployee_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "upd")
            {
                GvDelivery.Visible=false ;
                panelAddDetails.Visible=true ;
                btnSubmit.Text = "Update";
                int rowindex = int.Parse(e.CommandArgument.ToString());
                ViewState["ID"] = GvEmployee.Rows[rowindex].Cells[0].Text.ToString();
                //ID = Convert.ToInt32(GvEmployee.Rows[rowindex].Cells[0].Text.ToString());
                txtFirstName.Text = GvEmployee.Rows[rowindex].Cells[1].Text.ToString();
                txtLastName.Text = GvEmployee.Rows[rowindex].Cells[2].Text.ToString();
                txtMobileNumber.Text = GvEmployee.Rows[rowindex].Cells[3].Text.ToString();
                txtEmail.Text = GvEmployee.Rows[rowindex].Cells[4].Text.ToString();
                txtAddress.Text = GvEmployee.Rows[rowindex].Cells[5].Text.ToString();
                ddlState.SelectedValue = GvEmployee.Rows[rowindex].Cells[6].Text.ToString();
                ddlCountry.SelectedValue = GvEmployee.Rows[rowindex].Cells[7].Text.ToString();
                txtPinCode.Text = GvEmployee.Rows[rowindex].Cells[8].Text.ToString();
            }
            else if (e.CommandName == "del")
            {
                ViewState["DT1"] = e.CommandArgument.ToString();
                popupDelete.Show();
               // yespopup_Click(sender,e);
            }
        }

        protected void GvEmployee_PageIndexChanged(object sender, EventArgs e)
        {

        }

        void GridViewData()
        {
            dbcalling ds = new dbcalling();
            DataTable dt = ds.GetData("getDetails");

            if (dt != null && dt.Rows.Count > 0)
            {
                if (GvEmployee.Columns.Count == 0)
                {
                    FnBindGridviewColumns(dt);
                }
                GvEmployee.DataSource = dt;
                GvEmployee.DataBind();
                ViewState["dt"] = dt;
            }
        }

        void FnBindGridviewColumns(DataTable dt)
        {
            try
            {
                int columnsCount = dt.Columns.Count;
                for (int i = 0; i < columnsCount; i++)
                {
                    BoundField boundField = new BoundField();
                    boundField.DataField = dt.Columns[i].ColumnName;
                    boundField.HeaderText = dt.Columns[i].ColumnName;
                    GvEmployee.Columns.Add(boundField);
                }
                ButtonField buttonField = new ButtonField();
                buttonField.ButtonType = ButtonType.Image;
                buttonField.Text = "Edit";
                buttonField.ImageUrl = "~/Asset/edit.png";
                buttonField.ControlStyle.Width = 20;
                buttonField.ControlStyle.Height = 20;
                buttonField.CommandName = "upd";
                GvEmployee.Columns.Add(buttonField);

                buttonField = new ButtonField();
                buttonField.ButtonType = ButtonType.Image;
                buttonField.Text = "delete";
                buttonField.ImageUrl = "~/Asset/delete.png";
                buttonField.ControlStyle.Height = 20;
                buttonField.ControlStyle.Width = 20;
                buttonField.CommandName = "del";
                GvEmployee.Columns.Add(buttonField);
            }
            catch (Exception ex)
            { }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!txtValidation())
            {
                parameters _cParams = new parameters();
                _cParams.FirstName = txtFirstName.Text;
                _cParams.LastName = txtLastName.Text;
                _cParams.MobileNumber = txtMobileNumber.Text;
                _cParams.Email = txtEmail.Text;
                _cParams.Address = txtAddress.Text;
                _cParams.State = ddlState.Text;
                _cParams.Country = ddlCountry.Text;
                _cParams.Pincode = txtPinCode.Text;
                _cParams.DeliveryDate = txtDate.Text;
                _cParams.DeliveryType = DdlDeliveryType.Text;
                _cParams.PaymentMethod = ddlPayment.Text;


                if (btnSubmit.Text == "Submit")
                {
                    GvDelivery.Visible = true;
                    panelAddDetails.Visible = false;
                    dbcalling bg = new dbcalling();
                    bg.AddDelivery(_cParams);
                }
                else if (btnSubmit.Text == "Update")
                {
                    GvDelivery.Visible = true;
                    panelAddDetails.Visible = false;
                    _cParams.ID = ViewState["ID"].ToString();
                    dbcalling bg = new dbcalling();
                    bg.UpdateDetails(_cParams);
                }
                btnSubmit.Text = "Submit";
            }
            else
            {
                throw new Exception("Validation Error");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPinCode.Text = string.Empty;
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            GvDelivery.Visible = false;
            panelAddDetails.Visible = true;
        }

        public void Bind_ddlCountry()
        {
            
            try
            {
                dbcalling db = new dbcalling();
                DataTable dt = db.GetData("getCountry", true);
                ddlCountry.DataSource = dt;
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryID";
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, new ListItem("--Select Country--", "0"));
            }
            catch (Exception ex)
            {
            }
        }

        //public void Bind_ddlState()
        //{
        //    dbcalling db = new dbcalling();
        //    int CountryId = Convert.ToInt32(ddlCountry.SelectedIndex);
        //    DataTable dt = db.GetStates("getStates",CountryId);
        //    ddlState.DataSource = dt;
        //    ddlState.DataTextField = "StateName";
        //    ddlState.DataValueField = "StateID";
        //    ddlState.DataBind();
        //}

        void Cards()
        {
            List<parameters> cards = new List<parameters>
                {
                    new parameters { Title = "Offering Services", Description = " In India<br/> UAE<br/> USA" },
                    new parameters { Title = "Payment Modes", Description = "Credit Card<br/> Debit Card <br/>UPI" },
                    new parameters { Title = "Cash On Delivery", Description = "Now we have started accepting Cash On Delivery in UAE and USA" }
                };

            rptCards.DataSource = cards;
            rptCards.DataBind();
        }

        protected void yespopup_Click(object sender, EventArgs e)
        {
            dbcalling dB = new dbcalling();
            
            int rowIdex = Convert.ToInt32(ViewState["DT1"]);
            int i = Convert.ToInt32(GvEmployee.Rows[rowIdex].Cells[0].Text);
            dB.DeleteEmolyee("delete", i);
            GridViewData();

        }

        protected void GridView_Click(object sender, EventArgs e)
        {
            GvDelivery.Visible =true;
            Dashboard.Visible =false;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            GvDelivery.Visible=true;
            panelAddDetails.Visible=false;
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            GvDelivery.Visible=false ;
            Dashboard.Visible=true ;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
                // Prepare the CSV content
                StringBuilder csvContent = new StringBuilder();

                // Add column headers
                foreach (TableCell headerCell in GvEmployee.HeaderRow.Cells)
                {
                    csvContent.Append(headerCell.Text + ",");
                }
                csvContent.AppendLine();

                // Add data rows
                foreach (GridViewRow row in GvEmployee.Rows)
                {
                    foreach (TableCell cell in row.Cells)
                    {
                        csvContent.Append(cell.Text + ",");
                    }
                    csvContent.AppendLine();
                }

                // Write content to a file
                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment;filename=GridViewData.csv");
                Response.Charset = "";
                Response.ContentType = "text/csv";
                Response.Output.Write(csvContent.ToString());
                Response.Flush();
                Response.End();
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Bind_ddlState();
            dbcalling db = new dbcalling();
            int CountryId = Convert.ToInt32(ddlCountry.SelectedIndex);
           // DataTable dt = db.GetStates("getStates", CountryId);
            ddlState.DataSource = dt;
            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateID";
            ddlState.DataBind();
        }

        //public void state()
        //{

        //    .Columns.Add("statename");
        //    statetable.Columns.Add("stateid");

        //    dbcalling dBcalling = new DBcalling();
        //    statetable = dBcalling.getData($"select * from states where countryid={ddlCountries.SelectedValue}", false);
        //    ddlStates.DataSource = statetable;
        //    ddlStates.DataTextField = "statename";
        //    ddlStates.DataValueField = "stateid";
        //    ddlStates.DataBind();



        //}
        //void  LoginAutentication()
        //{
        //    try
        //    {
        //        dbcalling ds = new dbcalling();
        //        DataTable dt = ds.GetData("");



        //        if (dt != null)
        //        {
        //            isAuthenticated = true;
        //        }
        //        else
        //        {
        //            throw new Exception("Enter valid Username and Password");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public bool txtValidation()
        {
            if (txtFirstName.Text == null)
            {
                
                return true;
            }
            else if (txtLastName.Text == null)
            {
                return true;
            }
            else if (txtMobileNumber.Text.Length > 10)
            {
                return true;
            }
            else if (txtEmail.Text == null)
            {
                return true;
            }
            else if (txtAddress.Text == null)
            {
                return true;
            }
            else if (ddlCountry.SelectedIndex == 0)
            {
                return true;
            }
            else if (ddlState.SelectedIndex == 0)
            {
                return true;
            }
            else if (txtPinCode.Text.Length > 6)
            {
                return true;
            }
            else if (txtDate.Text == null)
            {
                return true;
            }
            else if (DdlDeliveryType.SelectedIndex == 0)
            {
                return true;
            }
            else if (ddlPayment.SelectedIndex == 0)
            {
                return true;
            }

            return false;
        }
    }
}