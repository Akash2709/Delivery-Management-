using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Delivery_Management.codes;

namespace Delivery_Management
{
    public partial class Login_page : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        // Check if the user is already logged in
        //        if (Session["ID"] != null)
        //        {
        //            // Redirect the user to the home page or any other page after login
        //            Response.Redirect("Home.aspx");
        //        }
        //    }
        //}

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    // Retrieve the username and password from the input fields
        //    string username = txtUsername.Value.Trim();
        //    string password = txtPassword.Value.Trim();

        //    // Perform authentication by calling the stored procedure
        //    bool isAuthenticated = AuthenticateUser(username, password);

        //    if (isAuthenticated)
        //    {
        //        // Set a session variable to indicate that the user is logged in
        //        Session["ID"] = username;

        //        // Redirect the user to the home page or any other page after successful login
        //        Response.Redirect("Default.aspx");
        //    }
        //}

        //// Method to authenticate users against the database using the stored procedure
        //private bool AuthenticateUser(string username, string password)
        //{
        //    // Connection string to your database
        //    dbcalling db = new dbcalling();
        //    DataTable dt = db.GetData("AuthenticateUser", true);

        //    // Flag to indicate if the user is authenticated
        //    bool isAuthenticated = false;

        //    // Create and open a connection


        //        // Create a command to call the stored procedure
        //        using (SqlCommand command = new SqlCommand("AuthenticateUser"))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            // Add parameters for username and password
        //            command.Parameters.AddWithValue("@Username", username);
        //            command.Parameters.AddWithValue("@Password", password);

        //            // Execute the command
        //            int result = (int)command.ExecuteScalar();

        //            // Check the result to determine if authentication was successful
        //            isAuthenticated = (result == 1);
        //        }


        //    return isAuthenticated;
        //}

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //parameters _cParams = new parameters();
            //_cParams.UserName = txtUsername.Value;
            //_cParams.Password = txtPassword.Value;
            //dbcalling bg = new dbcalling();
            //bg.LoginDetails(_cParams);
            Response.Redirect("Default.aspx");


            //string username = txtUsername.Value.Trim();
            //string password = txtPassword.Value.Trim();

            //bool isAuthenticated = AuthenticateUser(username, password);

            //if (isAuthenticated)
            //{
            //    // Redirect the user to the home page or any other page after successful login
            //    Response.Redirect("Default.aspx");
            //}

        }

        //private bool AuthenticateUser(string username, string password)
        //{
        //    // Call the GetData method to retrieve user credentials from the database
        //    string storedPassword = GetData(username);

        //    // Compare the retrieved password with the provided password
        //    return password.Equals(storedPassword);
        //}

        //// Method to retrieve user credentials from the database
        //private string GetData(string username)
        //{
        //    // Connection string to your database
        //    string connectionString = "Alex";

        //    // Query to retrieve the password associated with the username
        //    string query = "SELECT Password FROM Users WHERE Username = @Username";

        //    string password = "";

        //    // Create and open a connection
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            // Add parameter for username
        //            command.Parameters.AddWithValue("@Username", username);

        //            connection.Open();

        //            // Execute the command and retrieve the password
        //            object result = command.ExecuteScalar();
        //            if (result != null)
        //            {
        //                password = result.ToString();
        //            }
        //        }
        //    }

        //    return password;
        //}
    }
}
