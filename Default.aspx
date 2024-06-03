<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Delivery_Management._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>


        <%--LOGIN PAGE --%>
        <div>
            <%--<asp:Panel runat="server" ID="panelLoginPage" Visible="true">
                <container>
                    <center>
                        <h2>ADMIN LOGIN 
                        </h2>

                        <br />
                        <br />

                        <table style="width: 30%; background: gainsboro; padding: 50px; align-content: center; display: block;">
                            <tr>
                                <td>
                                    <label>User Name</label>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox runat="server" ID="txtUserNAme" AutoComplete="off"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <label>Password</label>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" MaxLength="8" AutoComplete="off"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Button runat="server" ID="btnLogin" Text="LOGIN" OnClick="btnLogin_Click" />
                                </td>
                            </tr>
                        </table>
                    </center>
                </container>
            </asp:Panel>--%>
            <%--LOGIN PAGE ENDS HERE--%>

            <%--ADD DETAILS PAGE --%>
            <asp:Panel runat="server" ID="panelAddDetails" Visible="false">
                <container>
                    <div>
                        <center>
                            <div>
                                <h2>ADD DELIVERY DETAILS</h2>
                            </div>
                            <br />
                            <table style="width: 40%; background-color: seashell; backface-visibility: inherit; padding: 50px; align-content: center; display: block; box-shadow: 0 0 10px rgba(0, 0, 0, 0.5); background: rgb(183,168,168,0.4); padding-top: 10px; padding-bottom: 10px;">
                                <img alt="Background Image" src="../Asset/Login-Page-BgImg.jpg" style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; object-fit: cover; opacity: 0.5; z-index: -1;">
                                <tr>
                                    <td style="width: 30%">
                                        <label>
                                            First Name</label>
                                        <asp:TextBox ID="txtFirstName" runat="server" AutoComplete="off" Style="float: right"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                                            ControlToValidate="txtFirstName" ErrorMessage="* Only characters allowed in First name."
                                            ForeColor="Red" ValidationExpression="^[a-zA-Z]+$" Display="Dynamic" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Last Name</label>
                                        <asp:TextBox ID="txtLastName" runat="server" AutoComplete="off" Style="float: right"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                            ControlToValidate="txtLastName" ErrorMessage="* Only characters allowed in Last name."
                                            ForeColor="Red" ValidationExpression="^[a-zA-Z]+$" Display="Dynamic" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Mobile Number</label>
                                        <asp:TextBox ID="txtMobileNumber" runat="server" AutoComplete="off" MaxLength="10" Style="float: right" TextMode="Phone"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="regexMobileNumber" runat="server" ControlToValidate="txtMobileNumber" ErrorMessage="Invalid mobile number" ValidationExpression="^(?:\+\d{1,3})?(?:\s|\()?\d{3}(?:\s|\))?-?\d{3}-?\d{4}$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Email</label>
                                        <asp:TextBox ID="txtEmail" runat="server" AutoComplete="off" Style="float: right" TextMode="Email"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="emailvalidator" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email id" ForeColor="Red"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Address</label>
                                        <asp:TextBox ID="txtAddress" runat="server" AutoComplete="off" Style="float: right"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Country</label>
                                        <asp:DropDownList ID="ddlCountry" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" Style="float: right" Width="190">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            State</label>
                                        <asp:DropDownList ID="ddlState" runat="server" Style="float: right" Width="190">
                                            <asp:ListItem Text="--Select State--" Value="NULL" />
                                            <asp:ListItem Text="Karnataka" Value="Karnataka" />
                                            <asp:ListItem Text="Chhattisgarh" Value="Chhattisgarh" />
                                            <asp:ListItem Text="Nagaland" Value="Nagaland" />
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Pin Code</label>
                                        <asp:TextBox ID="txtPinCode" runat="server" AutoComplete="off" Style="float: right" TextMode="Phone"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="regexPincode" runat="server" ControlToValidate="txtPincode" ForeColor="Red"
                                            ErrorMessage="Pincode must be 6 or 7 digits" ValidationExpression="^\d{6,7}$" Display="Dynamic"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>Delivery Date</label>
                                        <asp:TextBox ID="txtDate" runat="server" Style="float: right; width: 190px" AutoComplete="off" onkeypress="return false;"></asp:TextBox>
                                        <ajaxToolkit:CalendarExtender runat="server" Format="yyyy/MM/dd" TargetControlID="txtDate" />
                                        <asp:RegularExpressionValidator ID="regexDate" runat="server" ControlToValidate="txtDate" ErrorMessage="Invalid date format"
                                            ValidationExpression="^\d{4}\/(0?[1-9]|1[012])\/(0?[1-9]|[12][0-9]|3[01])$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                        <script type="text/javascript">
                                            function restrictDateInput(event) {
                                                // Allow numbers, backspace, delete, and arrow keys
                                                if (!(event.key.match(/[0-9]/) || event.key === "Backspace" || event.key === "Delete" || event.key === "ArrowLeft" || event.key === "ArrowRight")) {
                                                    event.preventDefault();
                                                }

                                                // Get the input element by ID
                                                var inputElement = document.getElementById("txtDate");

                                                // Restrict total length to 10 characters (mm/dd/yyyy)
                                                if (inputElement.value.length >= 10 && event.key !== "Backspace" && event.key !== "Delete") {
                                                    event.preventDefault();
                                                }

                                                // Restrict year to maximum of 4 digits
                                                if ((inputElement.selectionStart === 7 || inputElement.selectionStart === 8) && event.key !== "Backspace" && event.key !== "Delete") {
                                                    event.preventDefault();
                                                }
                                            }
                                        </script>

                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Delivery Type</label>
                                        <asp:DropDownList ID="DdlDeliveryType" runat="server" Style="float: right; width: 190px">
                                            <asp:ListItem Selected="True" Text="Regular" Value="Regular"></asp:ListItem>
                                            <asp:ListItem Text="Express Delivery" Value="Expres"></asp:ListItem>
                                            <asp:ListItem Text="Same Day Delivery" Value="Same Day"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server">Payment Method</asp:Label>
                                        <asp:DropDownList ID="ddlPayment" runat="server" Style="float: right; width: 190px">
                                            <asp:ListItem Text="Credit Card" Value="Credit Card"></asp:ListItem>
                                            <asp:ListItem Text="Debit Card" Value="Debit Card"></asp:ListItem>
                                            <asp:ListItem Text="UPI" Value="UPI"></asp:ListItem>
                                            <asp:ListItem Text="Cash On Delivery" Value="COD"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
                                        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
                                    </td>
                                </tr>

                            </table>
                        </center>
                    </div>
                </container>
            </asp:Panel>
            <%--ADD DETAILS END HERE--%>

            <%--GRIDVIEW DETAILS--%>
            <asp:Panel runat="server" ID="GvDelivery" Visible="false">
                <div class="button">
                    <img src="../Asset/Login-Page-BgImg.jpg" alt="Background Image" style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; object-fit: cover; opacity: 0.5; z-index: -1;">
                    <asp:Button runat="server" Text="Add Details" OnClick="Unnamed_Click1" />
                    <asp:Button runat="server" Text="Download" OnClick="Unnamed_Click" />
                    <asp:Button runat="server" Text="Back" OnClick="Unnamed_Click2" />
                </div>
                <br />
                <div style="display: flex; flex-direction: column; justify-items: center; justify-content: space-around; align-content: center; align-items: center; box-shadow: 0 20px 40px 0 rgba(0, 0, 0, 0.2);">
                    <asp:GridView runat="server" ID="GvEmployee" DataSourceID="" AutoGenerateColumns="false" EmptyDataText="No Data is Available"
                        OnPageIndexChanged="GvEmployee_PageIndexChanged" CellPadding="4" OnRowCommand="GvEmployee_RowCommand"
                        BorderStyle="Solid" CellSpacing="100" HeaderStyle-BackColor="Gray" HeaderStyle-ForeColor="White" HeaderStyle-HorizontalAlign="Center"
                        RowStyle-BackColor="SeaShell" AlternatingRowStyle-BackColor="WhiteSmoke" AlternatingRowStyle-ForeColor="#000" GridLines="Both">
                    </asp:GridView>
                    <ajaxToolkit:ModalPopupExtender ID="popupDelete" runat="server" BackgroundCssClass="modalBackground" PopupControlID="panelPopUpId" CancelControlID="cancelpopup" TargetControlID="linkButton"></ajaxToolkit:ModalPopupExtender>
                    <asp:Panel ID="panelPopUpId" runat="server" CssClass="modelPopup">
                        <h1>Do you want to delete?</h1>
                        <div class="buttons" style="display: inline">
                            <span>
                                <asp:Button ID="yespopup" runat="server" Text="Yes" OnClick="yespopup_Click" />
                            </span>
                            <span>
                                <asp:Button ID="cancelpopup" runat="server" Text="Cancel" />
                            </span>
                        </div>
                    </asp:Panel>
                </div>
            </asp:Panel>
            <asp:LinkButton runat="server" ID="LinkButton"></asp:LinkButton>
            <style>
                .modalBackground {
                    background-color: black;
                    filter: alpha(opacity=90);
                    opacity: 0.8;
                }

                .modelPopup {
                    background-color: seashell;
                    border-width: 3px;
                    border-style: solid;
                    border-color: black;
                    padding-top: 10px;
                    padding-bottom: 10px;
                    width: 30%;
                    height: auto;
                    max-height: 99%;
                    border-radius: 25px;
                    display: flex;
                    flex-direction: column;
                    align-content: center;
                    align-items: center;
                    justify-content: center;
                    justify-items: center
                }

                .buttons {
                    display: flex;
                    justify-content: space-around;
                }

                .button {
                    display: flex;
                    align-content: center;
                    align-items: center;
                    justify-content: space-around;
                    justify-items: center;
                    box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
                    background: rgb(183,168,168,0.4);
                    padding-top: 10px;
                    padding-bottom: 10px;
                }

                    .button * {
                        background-color: #b7a8a866;
                    }
            </style>
            <%--GRIDVIEW ENDS HERE--%>

            <%--DASHBOARD CARDS AND CHARTS--%>
            <asp:Panel runat="server" ID="Dashboard" Visible="true">
                <div class="container">
                    <img src="../Asset/Login-Page-BgImg.jpg" alt="Background Image" style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; object-fit: cover; opacity: 0.5; z-index: -1;">
                    <div class="card">
                        <h3>Types of Deliveries</h3>
                        <p>
                            Regular Delivery<br />
                            Same Day Delivery<br />
                            Express Delivery
                        </p>
                    </div>
                    <asp:Repeater ID="rptCards" runat="server">
                        <ItemTemplate>
                            <div class="card">
                                <h3><%# Eval("Title") %></h3>
                                <p><%# Eval("Description") %></p>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div>
                    <asp:Button runat="server" ID="GridView" Text="View GridView" OnClick="GridView_Click" />
                </div>
                <div class="image-container">
                    <img src="../Asset/truck-delivery-photo.jpeg" alt="Image 1">
                    <img src="../Asset/Godwn-img.jpg" alt="Image 2">
                    <img src="../Asset/drone-delivery.jpg" alt="Image 3">
                    <%--<img src="image4.jpg" alt="Image 4">--%>
                </div>
                <%--<div class="image-container">
                <div class="flip-card">
                    <div class="flip-card-inner">
                        <div class="flip-card-front">
                            <img src="../Asset/truck-delivery-photo.jpeg" alt="Image 1" style="width: 200px; height: 200px;">
                        </div>
                        <div class="flip-card-back">
                            <h1>Delivery Service </h1>
                            <p>We provide Delivery Serivces in</p>
                            <p>India, USA and Now in UAE also.</p>
                        </div>
                        <div class="flip-card-front">
                            <img src="../Asset/Godwn-img.jpg" alt="Image 2" style="width: 200px; height: 200px;">
                        </div>
                        <div class="flip-card-back">
                            <h1>PickUp Houses</h1>
                            <p>Our Pickup Houses are</p>
                            <p>In every Major Cities.</p>
                        </div>
                        <div class="flip-card-front">
                            <img src="../Asset/drone-delivery.jpg" alt="Image 3" style="width: 200px; height: 200px;">
                        </div>
                        <div class="flip-card-back">
                            <h1>Introducing New Technology</h1>
                            <p>We are starting Drone Delivery</p>
                            <p> in UAE and USA.</p>
                        </div>
                    </div>
                </div>
                    </div>--%>
                <style>
                    .card {
                        /*border: 1px solid #ddd;*/
                        border-radius: 5px;
                        padding: 10px;
                        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
                        transition: 0.3s;
                        width: 200px;
                        margin: 10px;
                        float: left;
                        background: linear-gradient(to right, #654321, #8B4513); /* Brown background */
                        border: 1px solid #A52A2A;
                        margin-bottom: 15px; /* Spacing between cards */
                        color: #fff; /* Text color */
                        display: flex;
                        justify-content: center;
                        align-content: center;
                        align-items: center;
                    }

                        .card:hover {
                            box-shadow: 0 8px 16px 0 rgba(0, 0, 0, 0.2);
                        }

                    .image-container {
                        display: flex;
                        flex-direction: row;
                        justify-content: space-around; /* Center horizontally */
                        align-items: center; /* Center vertically */
                        margin-top: 20%; /* Adjust as needed */
                        /*height: 150px ;*/
                        box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
                        background: rgb(183,168,168,0.4);
                        padding-top: 30px;
                        padding-bottom: 30px;
                    }

                        .image-container img {
                            width: 150px; /* Adjust width as needed */
                            height: 150px; /* Maintain aspect ratio */
                            margin: 0 10px; /* Adjust spacing between images */
                        }

                        .image-container * {
                            background-color: #b7a8a866;
                        }

                    .flip-card {
                        background-color: transparent;
                        width: 300px;
                        height: 200px;
                        border: 1px solid #f1f1f1;
                        perspective: 1000px; /* 3D effect */
                    }

                    /* This container is needed to position the front and back side */
                    .flip-card-inner {
                        position: relative;
                        width: 100%;
                        height: 100%;
                        text-align: center;
                        transition: transform 0.8s;
                        transform-style: preserve-3d;
                    }

                    /* Do an horizontal flip when you move the mouse over the flip box container */
                    .flip-card:hover .flip-card-inner {
                        transform: rotateY(180deg);
                    }

                    /* Position the front and back side */
                    .flip-card-front, .flip-card-back {
                        position: absolute;
                        width: 100%;
                        height: 100%;
                        -webkit-backface-visibility: hidden; /* Safari */
                        backface-visibility: hidden;
                    }

                    /* Style the front side (fallback if image is missing) */
                    .flip-card-front {
                        background-color: #bbb;
                        color: black;
                    }

                    /* Style the back side */
                    .flip-card-back {
                        background-color: dodgerblue;
                        color: white;
                        transform: rotateY(180deg);
                    }
                </style>

            </asp:Panel>
            <%--DASHBOAED CARDS AND CHARTS END HERE--%>
        </div>
    </main>

</asp:Content>
