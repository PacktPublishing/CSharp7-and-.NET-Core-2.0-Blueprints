<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cricketScoreTrack._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row page-header">
        <h1>Everybody loves cricket <small>Cricket Score Tracker</small></h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Ball-by-Ball</h2>
            <div class="alert alert-success" role="alert">Over 1</div>
            <div class="list-group">
                <a href="#" class="list-group-item list-group-item-info">0.2 S Meaker to J Trott 1 RUNS<span class="badge">1</span></a>
                <a href="#" class="list-group-item list-group-item-info">0.1 S Meaker to J Trott 6 RUNS<span class="badge">6</span></a>
            </div>

        </div>
        <div class="col-md-8">
            <h2>Game On!</h2>
            <div class="row">
                <div class="col-lg-4 col-md-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-trophy fa-5x" aria-hidden="true"></i>
                                </div>
                                <div class="col-xs-9">
                                    <div class="row">
                                        <div class="score pull-right">26/0</div>
                                    </div>
                                    <div class="row">
                                        <div class="team pull-right">South Africa </div>
                                    </div>
                                    <div class="row">
                                        <div class="team pull-right">India </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <span class="pull-left">View Details</span>
                            <span class="pull-right">
                                <i class="fa fa-arrow-circle-right"></i>
                            </span>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="text-center">
                                        <img class="img-fluid img-rounded" alt="Player 1" src="images/player-placeholder.jpg" />
                                    </div>
                                    <div class="text-center player">Player Name</div>
                                </div>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <span class="pull-left">View Player Details</span>
                            <span class="pull-right">
                                <i class="fa fa-arrow-circle-right"></i>
                            </span>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="text-center">
                                        <img class="img-fluid img-rounded" alt="Player 2" src="images/player-placeholder.jpg" />
                                    </div>
                                    <div class="text-center player">Player Name</div>
                                </div>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <span class="pull-left">View Player Details</span>
                            <span class="pull-right">
                                <i class="fa fa-arrow-circle-right"></i>
                            </span>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-12 pull-left info">
                    299 balls remaining (Current rpo: 36.00)
                </div>
            </div>

            <div class="row">
                <div class="col-md-12">

                    <%--<div class="panel"> 
                        <!-- Default panel contents -->
                        <div class="panel-heading">Panel heading</div>
                        <div class="panel-body">
                            <p>This is the panel body section</p>
                        </div>--%>
                    <div class="text-centre">1st Innings</div>
                    <!-- Table -->
                    <table class="table">
                        <tbody>
                            <tr class="success">
                                <td>Batters</td>
                                <td>R</td>
                                <td>B</td>
                                <td>4's</td>
                                <td>6's</td>
                                <td>SR</td>
                            </tr>
                            <tr>
                                <td>
                                    <%--<button type="button" class="btn btn-default btn-round-xs btn-xs">J Trott</button>--%>
                                    <asp:Button runat="server" ID="btnBatsman1" class="btn btn-default btn-round-xs btn-xs" Text="Select Player" OnClick="btnBatsman1_Click"></asp:Button>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman1Runs" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman1Balls" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman1Fours" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman1Sixes" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman1StrikeRate" Text="0"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <%--<button type="button" class="btn btn-primary btn-round-xs btn-xs">I Bell</button></td>--%>
                                    <asp:Button runat="server" ID="btnBatsman2" class="btn btn-primary btn-round-xs btn-xs" Text="Select Player" OnClick="btnBatsman2_Click"></asp:Button>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman2Runs" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman2Balls" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman2Fours" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman2Sixes" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBatsman2StrikeRate" Text="0"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>Extras nb 0, wd 0, b 0, lb 0 Partnership</td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr class="success">
                                <td>Bowler</td>
                                <td>O</td>
                                <td>M</td>
                                <td>R</td>
                                <td>W</td>
                                <td>Econ</td>
                            </tr>
                            <tr>
                                <td>
                                    <%--<button type="button" class="btn btn-primary btn-round-xs btn-xs">S Meaker</button></td>--%>
                                    <asp:Button runat="server" ID="btnBowler" class="btn btn-primary btn-round-xs btn-xs" Text="Select Bowler" OnClick="btnBowler_Click"></asp:Button>
                                <td>
                                    <asp:Label runat="server" ID="lblBowlerOvers" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBowlerMaidens" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBowlerRuns" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBowlerWickets" Text="0"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="lblBowlerEconomy" Text="0"></asp:Label></td>
                            </tr>
                        </tbody>
                    </table>

                    <%-- <div class="panel-footer">Panel footer</div>
                    </div>--%>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="panel panel-success">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="text-center">
                                        <asp:Button runat="server" ID="btnRun_0" class="btn btn-default btn-round" Text="0" OnClick="btnRun_0_Click"></asp:Button>
                                        <asp:Button runat="server" ID="btnRun_1" class="btn btn-default btn-round" Text="1" OnClick="btnRun_1_Click"></asp:Button>
                                        <asp:Button runat="server" ID="btnRun_2" class="btn btn-default btn-round" Text="2" OnClick="btnRun_2_Click"></asp:Button>
                                        <asp:Button runat="server" ID="btnRun_3" class="btn btn-default btn-round" Text="3" OnClick="btnRun_3_Click"></asp:Button>
                                        <asp:Button runat="server" ID="btnRun_4" class="btn btn-default btn-round" Text="4" OnClick="btnRun_4_Click"></asp:Button>
                                        <asp:Button runat="server" ID="btnRun_6" class="btn btn-default btn-round" Text="6" OnClick="btnRun_6_Click"></asp:Button>
                                        <asp:Button runat="server" ID="btnRun_5plus" class="btn btn-default btn-round" Text="5+" OnClick="btnRun_5plus_Click"></asp:Button>
                                        <asp:Button runat="server" ID="btnRun_Undo" class="btn btn-default btn-round" Text="undo" OnClick="btnRun_Undo_Click"></asp:Button>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <div class="pull-left">
                                <asp:Button runat="server" ID="btnAction_Wide" class="btn btn-default btn-round" Text="wide" OnClick="btnAction_Wide_Click"></asp:Button>
                                <asp:Button runat="server" ID="btnAction_NoBall" class="btn btn-default btn-round" Text="no ball" OnClick="btnAction_NoBall_Click"></asp:Button>
                                <asp:Button runat="server" ID="btnAction_Bye" class="btn btn-default btn-round" Text="bye" OnClick="btnAction_Bye_Click"></asp:Button>
                                <asp:Button runat="server" ID="btnAction_LegBye" class="btn btn-default btn-round" Text="leg bye" OnClick="btnAction_LegBye_Click"></asp:Button>
                                <asp:Button runat="server" ID="btnAction_Wicket" class="btn btn-danger btn-round" Text="wicket" OnClick="btnAction_Wicket_Click"></asp:Button>
                                <asp:Button runat="server" ID="btnAction_EndOver" class="btn btn-default btn-round" Text="end over" OnClick="btnAction_EndOver_Click"></asp:Button>
                                <div class="btn-group">
                                    <button type="button" class="btn btn-default btn-round dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Action <span class="caret"></span></button>
                                    <ul class="dropdown-menu">
                                        <li><a href="#">Close Innings</a></li>
                                        <li><a href="#">End Match</a></li>
                                    </ul>
                                </div>
                            </div>

                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <%--<div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>--%>
    </div>

    <div class="modal fade" id="playerModal" tabindex="-1" role="dialog"
        aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close"
                        data-dismiss="modal" aria-hidden="true">
                        &times;
                    </button>
                    <h4 class="modal-title" id="myModalLabel">Select your player
                    </h4>
                </div>
                <div class="modal-body">
                    <%--<asp:Literal ID="ddlPlayerSelect" runat="server"></asp:Literal>--%>      
                    <asp:DropDownList runat="server" ID="ddlPlayersSelect" class="btn btn-default dropdown-toggle" data-toggle="dropdown" OnSelectedIndexChanged="ddlPlayersSelect_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">
                        close
                    </button>                    
                    <asp:Button runat="server" ID="btnSelectPlayer1" class="btn btn-primary" Text="Select" OnClick="btnSelectPlayer1_Click" CommandArgument="none"></asp:Button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal -->
    </div>

</asp:Content>
