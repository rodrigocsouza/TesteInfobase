<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TerminalSaque.aspx.cs" Inherits="TesteInfobaseCaixaEletronicoWeb.TerminalSaque" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            font-size: large;
            font-family: Verdana;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="style1">
            <strong><span class="style2">Infobase - Teste .NET - Rodrigo Souza</span></strong><br />
        </div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" Font-Names="Verdana" Font-Size="11pt" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="ValorNota" DataFormatString="{0:c}" 
                    HeaderText="Notas Disponíveis" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <br />
        <asp:Label ID="lblValorSaque" runat="server" Text="Valor do Saque:"></asp:Label>
        <br />
        <asp:Label ID="lblValorSaque1" runat="server" Text="R$"></asp:Label>
        <asp:TextBox ID="txbValorSaque" runat="server" CausesValidation="True" 
            Width="102px"  style="text-align:right;"></asp:TextBox>
        <asp:Label ID="lblValorSaque0" runat="server" Text=",00"></asp:Label>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="txbValorSaque" 
            
            ErrorMessage="Forneça somente valores inteiros e maiores ou igual a R$ 10,00" ForeColor="Red" 
            MaximumValue="1000000" MinimumValue="10" Type="Integer">*</asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txbValorSaque" ErrorMessage="Preencha o valor do saque" 
            ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnSacar" runat="server" onclick="btnSacar_Click" 
            Text="Sacar" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" /><br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="gvNotasEntrega" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" Font-Names="Verdana" Font-Size="11pt" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="ValorNota" HeaderText="Notas a serem entregues" 
                    DataFormatString="{0:c}" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
