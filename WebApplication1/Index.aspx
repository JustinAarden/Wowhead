<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Wowhead.WebForm1" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>

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
                height: 147px;
                width: 364px;
                margin-left: 1px;
            }
            .auto-style2 {
                width: 174px;
                height: 47px;
            }
        </style>
        <script src="Scripts/jquery.js"></script>
        <script src="Scripts/bootstrap.js"></script>
        <script src="Scripts/docs.js"></script>
        <script src="Scripts/wowhead.js"></script>

    </head>


    <body>

        <div class="site-wrapper">

            <div class="site-wrapper-inner">

                <div class="cover-container">

                    <div class="masthead clearfix">
                        <div class="inner">
                            <h3 class="masthead-brand">
                                <img class="auto-style2" src="Content/Images/Header.png" /></h3>
                            <ul class="nav masthead-nav">
                                <li class="active"><a href="Index.aspx">Home</a></li>
                                <li class="dropdown">
                                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">Database <span class="caret"></span>
                                    </a>
                                    <ul class="dropdown-menu">
                                        <li><a href="Items.aspx">Items</a></li>
                                    </ul>
                                </li>

                            </ul>


                        </div>
                    </div>

                    <div class="inner cover">
                        <form runat="server">
                            <h1 class="cover-heading">
                            <img alt="" class="auto-style1" src="Content/Images/transparent.png" /><br/>
                            </h1>
                            <p class="cover-heading">
                            </p>
                        <p class="lead">

                            <asp:Label ID="lbAlert" runat="server" class="alert alert-danger" Text="Label" Font-Size="Medium" Visible="False"></asp:Label>

                        </p>
                            <p class="lead">
                                <asp:CheckBox ID="cbItem" runat="server" Text="Item" onClick="javascript:item(this)" />
                                &nbsp;&nbsp;
                                <asp:CheckBox ID="cbGuide" runat="server" Text="Guide" onClick="javascript:guide(this)" />
                                &nbsp;&nbsp;
                                <asp:CheckBox ID="cbClass" runat="server" Text="Class" onClick="javascript:classes(this)"/>
                                <script type="text/javascript">
                                    function item(itemobject) {
                                        if (itemobject.checked == true) {
                                            document.getElementById("cbGuide").checked = false;
                                            document.getElementById("cbClass").checked = false;
                                        }
                                    }
                                </script>
                                <script type="text/javascript">
                                    function guide(guideobject) {
                                        if (guideobject.checked == true) {
                                            document.getElementById("cbItem").checked = false;
                                            document.getElementById("cbClass").checked = false;
                                        }
                                    }
                                </script>
                                <script type="text/javascript">
                                    function classes(classobject) {
                                        if (classobject.checked == true) {
                                            document.getElementById("cbItem").checked = false;
                                            document.getElementById("cbGuide").checked = false;
                                        }
                                    }
                                </script>
                                
                                <asp:TextBox type='text' ID="txtSearch" runat="server" CssClass="form-control" Text="Search" style="text-align: center" autocomplete="off" onFocus="this.value=''"></asp:TextBox>                
                                    <div id="results"></div>
                                <br />
                                <asp:Button ID="btSearch" runat="server" CssClass="btn btn-lg btn-default" Text="Search" OnClick="BtSearchClick"/>
                                
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



    </body>
</html>