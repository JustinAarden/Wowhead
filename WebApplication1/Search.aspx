﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Wowhead.Search" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta http-equiv="content-type" content="text/html; charset=UTF-8">
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">
        <link rel="shortcut icon" href="http://wow.zamimg.com/apple-touch-icon.png">

        <title>WOWHEAD</title>

        <!-- Bootstrap core CSS -->
        <link href="css/bootstrap.css" rel="stylesheet">

        <!-- Custom styles for this template -->
        <link href="css/cover.css" rel="stylesheet">


        <style type="text/css" id="holderjs-style">
            .auto-style1 {
                height: 121px;
                width: 278px;
            }
        </style>
    </head>


    <body>

        <div class="site-wrapper">

            <div class="site-wrapper-inner">

                <div class="cover-container">

                    <div class="masthead clearfix">
                        <div class="inner">
                            <h3 class="masthead-brand">WOWHEAD</h3>
                            <ul class="nav masthead-nav">
                                <li class="active"><a href="Index.aspx">Home</a></li>
                                <li><a href="Guides.aspx">Guides</a></li>
                                <li class="dropdown">
                                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">Database <span class="caret"></span>
                                    </a>
                                    <ul class="dropdown-menu">
                                        <li><a href="Items.aspx">Items</a></li>
                                        <li><a href="#">Classes</a></li>
                                    </ul>
                                </li>

                            </ul>


                        </div>
                    </div>

                    <div class="inner cover">
                        <h1 class="cover-heading">
                            <img alt="" class="auto-style1" src="Content/Images/transparent.png" /></h1>
                        <p class="lead">

                        </p>
                        <form runat="server">
                            <p class="lead">

                                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="944px">
                                    <AlternatingRowStyle BackColor="White" />
                                    <FooterStyle BackColor="#CCCC99" />
                                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                    <RowStyle BackColor="#F7F7DE" />
                                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                    <SortedAscendingHeaderStyle BackColor="#848384" />
                                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                    <SortedDescendingHeaderStyle BackColor="#575357" />
                                </asp:GridView>

                                <br />

                                                    
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