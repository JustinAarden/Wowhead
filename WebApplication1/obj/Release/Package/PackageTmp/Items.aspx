<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="Wowhead.WebForm1" %>

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
                            <li><a href="Guides.aspx">Guides</a></li>
                            <li class="dropdown">
                                <a class="dropdown-toggle" data-toggle="dropdown" href="#">Database <span class="caret"></span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Items</a></li>
                                    <li><a href="#">Classes</a></li>
                                </ul>
                            </li>

                        </ul>


                    </div>
                </div>

                <div class="inner cover">
                        <form runat="server">
                    <p class="lead">

                        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="5" CellSpacing="3" DataSourceID="Wowheadmysql" ForeColor="White" Height="300px" Width="744px" AllowCustomPaging="True" AllowPaging="True">
                            <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                                <asp:BoundField DataField="Level" HeaderText="Equipment Level" SortExpression="Level" />
                                <asp:BoundField DataField="Reqlevel" HeaderText="Requirement level" SortExpression="Reqlevel" />
                                <asp:BoundField DataField="Omschrijving" HeaderText="Omschrijving" SortExpression="Omschrijving" />
                                <asp:BoundField DataField="Expr1" HeaderText="Quality" SortExpression="Expr1" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="#737373" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#646464" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#646464" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="Wowheadmysql" runat="server" ConnectionString="<%$ ConnectionStrings:wowheadConnectionString %>" ProviderName="<%$ ConnectionStrings:wowheadConnectionString.ProviderName %>" SelectCommand="SELECT Item.Name, Item.Level, Item.Reqlevel, Item.Omschrijving, Quality.Name AS Expr1 FROM Item INNER JOIN Quality ON Item.Quality_ID = Quality.Quality_ID GROUP BY Item.Name, Item.Level, Item.Reqlevel, Item.Omschrijving, Quality.Name"></asp:SqlDataSource>
                            </p>
                    <p class="lead">
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