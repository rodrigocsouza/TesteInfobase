<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TerminalForaDoAr.aspx.cs" Inherits="TesteInfobaseCaixaEletronicoWeb.TerminalForaDoAr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            color: #FF0000;
            font-size: xx-large;
            font-family: Verdana;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
        <strong>Terminal fora do ar. Desculpe o transtorno.
        <br />
        </strong>
        <asp:Label ID="lblMsgErro" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
