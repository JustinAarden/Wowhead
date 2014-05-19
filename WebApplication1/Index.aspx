<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Wowhead.WebForm1" %>

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
                                <asp:CheckBox ID="cbItem" runat="server" Text="Item" onClick="javascript:item(this)" />
                                <asp:CheckBox ID="cbGuide" runat="server" Text="Guide" onClick="javascript:guide(this)" />
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
                                

                                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" Text="Search" style="text-align: center" onFocus="this.value=''"></asp:TextBox>
                                <br />
                                <asp:Button ID="btSearch" runat="server" CssClass="btn btn-lg btn-default" Text="Search" OnClick="btSearch_Click"/>
                                                    
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