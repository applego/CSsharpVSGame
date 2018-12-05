<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VSfield.aspx.cs" Inherits="WebApplication_Game.VSfield" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link type="text/css" rel="stylesheet" href="Content/semantic.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="ui container">
            <div class="ui three column grid">
                <div class="column" style="height: 350px; width: 350px;">
                    <p>Player1</p>
                    <p><i class="user icon"></i></p>
                    <div class="ui segment">
                        HP:<asp:Label runat="server" ID="lbl1HP"></asp:Label>
                    </div>
                    <div class="ui inverted segment">
                        <%--<button class="ui inverted red button" onclick="btn1RedClick">Red</button>--%>
                        <asp:Button runat="server" ID="btn1Red" CssClass="ui inverted red button" OnClick="btn1Red_Click" Text="Red" />
                        <asp:Button runat="server" ID="btn1Purple" CssClass="ui inverted purple button" OnClick="btn1Purple_Click" Text="Purple" />
                        <%--<button class="ui inverted purple button" onclick="btn1PurpleClick">Purple</button>--%>
                    </div>
                    <div class="ui message">
                        <asp:Label runat="server" ID="lbl1Message"></asp:Label>
                    </div>
                </div>
                <div class="ui segment">
                    <div class="column" style="height: 340px; width: auto;">
                        <p></p>
                    </div>
                </div>
                <div class="column" style="height: 350px; width: 350px;">
                    <p>Player2</p>
                    <p><i class="user outline icon"></i></p>
                    <div class="ui segment">
                        HP:<asp:Label runat="server" ID="lbl2HP"></asp:Label>
                    </div>
                    <div class="ui inverted segment">
                        <asp:Button runat="server" ID="btn2Red" CssClass="ui inverted red button" OnClick="btn2Red_Click" Text="Red" />
                        <asp:Button runat="server" ID="btn2Purple" CssClass="ui inverted purple button" OnClick="btn2Purple_Click" Text="Purple" />
                    </div>
                    <div class="ui message">
                        <asp:Label runat="server" ID="lbl2Message"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
