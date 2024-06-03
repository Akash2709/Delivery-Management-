<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StatisticsChart.aspx.cs" Inherits="Delivery_Management.StatisticsChart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title></title>
        <script src="
https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.js">
        </script>
    </head>
    <body>
        <img src="../Asset/Login-Page-BgImg.jpg" alt="Background Image" style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; object-fit: cover; opacity: 0.5; z-index: -1;">
        <div class="Chart-Container" id="Charts">
            <asp:Literal ID="BarChart" runat="server"></asp:Literal>
            <asp:Literal ID="BarChart1" runat="server"></asp:Literal>
            <%--<asp:Literal ID="BarChart2" runat="server"></asp:Literal>--%>
        </div>

        <style>
            .Chart-Container {
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
                .Chart-Container *{
                     background-color: #b7a8a866;
                }
        </style>
    </body>
    </html>
</asp:Content>
