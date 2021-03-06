﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Guides.aspx.cs" Inherits="Wowhead.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="shortcut icon" href="http://getbootstrap.com/assets/ico/favicon.ico">

    <title>WOWHEAD</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="css/cover.css" rel="stylesheet">

    <!-- Just for debugging purposes. Don't actually copy this line! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
    </head>

<body>

        <div class="site-wrapper">

        <div class="site-wrapper-inner">

            <div class="cover-container">

                <div class="masthead clearfix">
                    <div class="inner">
                        <h3 class="masthead-brand">WOWHEAD</h3>
                        <ul class="nav masthead-nav">
                            <li><a href="Index.aspx">Home</a></li>
                            <li class="active"><a href="Guides.aspx">Guides</a></li>
                            <li class="dropdown">
                                <a class="dropdown-toggle" data-toggle="dropdown" href="#">Database <span class="caret"></span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Items</a></li>
                                    <li><a href="#">Guides</a></li>
                                </ul>
                            </li>

                        </ul>


                    </div>
                </div>

                <div class="inner cover">
                        <form runat="server">
                    <h1 class="cover-heading">
                        <asp:Label ID="Label1" runat="server" Text="Guides"></asp:Label>
                            </h1>
                    <p class="lead">

                    </p>
                    <p class="lead">
                        <asp:TextBox ID="txtSe2arch2" runat="server" CssClass="form-control" Text="Search"></asp:TextBox>
                        <br />
                        <asp:Button ID="btS2earch2" runat="server" CssClass="btn btn-lg btn-default" Text="Search" OnClick="btSearch_Click"/>
                            <asp:Button ID="btDatabas2e" runat="server" CssClass="btn btn-default btn-lg dropdown-toggle" Text="Database" />
                        
                         </p>
                        </form>
                </div>

                <div class="mastfoot">
                    <div class="inner">
                        <p>Ontwikkelopdracht WOWHEAD <br /> Justin Aarden</p>
                    </div>
                </div>

            </div>

        </div>

    </div>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="Scripts/jquery.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/docs.js"></script>


</body>
</html>