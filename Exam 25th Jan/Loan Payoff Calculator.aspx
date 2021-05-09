<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Loan Payoff Calculator.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Loan Payoff Calculator</title>
    <style type="text/css">
        .newStyle1 {
            text-align: right;<a href="Loan%20Payoff%20Calculator.aspx">Loan Payoff Calculator.aspx</a>
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Loan, £<br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="newStyle1"></asp:TextBox>
            <br />
            <br />
            Monthly Interest Rate<br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="newStyle1"></asp:TextBox>
            %<br />
            <br />
            Monthly Payment, £<br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="newStyle1"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="newStyle1" OnClick="Button1_Click" Text="Evaluate Debt" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
