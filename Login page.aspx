<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login page.aspx.cs" Inherits="Delivery_Management.Login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="banner">
                <h1>DELIVERY MANAGEMENT SYSTEM</h1>
                <h3>Here's the information, about your company, product, I don't know.</h3>
                <h3>Now Taking International Order to Deliver!</h3>
            </div>
            <div class="form">
                <small> <a>LOGIN</a></small>
                <input runat="server" id="txtUsername" type="text" autocomplete="off" placeholder="Username"/>
                <input runat="server" id="txtPassword" type="password" placeholder="Password"/>
                <asp:Button ID="button" CssClass="button" runat="server" OnClick="btnLogin_Click" Text="Login"/>
            </div>
        </div>
    </form>
    <style>
    	@import url("https://fonts.googleapis.com/css2?family=Poppins:wght@400;700&display=swap");

    	* {
    		padding: 0;
    		margin: 0;
    		box-sizing: border-box;
    		font-family: "Poppins", sans-serif;
    		text-decoration: none;
    		font-weight: bold;
    		color: #363636;
    	}

    	::-webkit-scrollbar {
    		display: none;
    	}

    	::selection {
    		background: 0;
    	}

    	body {
    		width: 100%;
    		min-height: 460px;
    		height: 100vh;
    		overflow: scroll;
    		background: url("../Asset/Login-Page-BgImg.jpg") no-repeat center center;
    		background-size: cover;
    		backdrop-filter: blur(7px);
    		display: grid;
    		place-content: center;
    	}

    	.container {
    		width: 100%;
    		min-height: 420px;
    		display: flex;
    		align-items: center;
    		justify-content: center;
    		width: 630px;
    		height: 76vh;
    	}

    	.banner {
    		max-height: 420px;
    		height: 100%;
    		width: 350px;
    		background: rgb(0, 0, 0, 0.4);
    		border-radius: 10px 0 0 10px;
    		transition: .4s;
    	}

    		.banner * {
    			margin: 40px;
    			color: #ccc;
    			cursor: default;
    		}

    	.form {
    		max-height: 420px;
    		height: 100%;
    		width: 280px;
    		background: #fff;
    		display: flex;
    		flex-direction: column;
    		align-items: center;
    		border-radius: 0 10px 10px 0;
    		position: relative;
            justify-content:center;
    	}

    	img {
    		pointer-events: none;
    		margin: 45px 0 20px;
    		height: 70px;
    		border-radius: 50%;
    		box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
    	}

    	.form small:first-of-type {
    		margin-bottom: 20px;
    	}

    	a {
    		font-size: small;
    		color: #1663be;
    		cursor: pointer;
    	}

    	input {
    		margin-bottom: 10px;
    		padding: 8px 15px;
    		width: 212px;
    		border: 2px solid #ccc;
    		color: #000;
    		font-weight: bold;
    		border-radius: 8px;
    	}

    		input:focus {
    			outline: 0;
    			transition: 0.5s;
    			border: 2px solid #646464;
    		}

    	/* ::-ms-reveal {
	filter: invert(100%);
} */

    	 .button{
    		min-width: 215px;
    		min-height: 38px;
    		border: 2px solid #142b54;
    		background: #142b54;
    		color: #fff;
    		cursor: pointer;
    		border-radius: 8px;
    		box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
    		margin: 0 0 50px 0;
    	}

    		button:active {
    			transform: scale(1.05);
    			box-shadow: 3px 2px 22px 1px rgba(0, 0, 0, 0.24);
    		}

    	#forgot {
    		opacity: .6;
    	}

    		#forgot:hover {
    			opacity: 1;
    		}

    	@media (max-width: 720px) {
    		.banner {
    			position: absolute;
    			transform: translatex(10%);
    			opacity: 0;
    		}

    		.content {
    			display: flex;
    			justify-content: center;
    		}

    		.form {
    			border-radius: 10px;
    		}
    	}
    </style>

</body>

</html>
