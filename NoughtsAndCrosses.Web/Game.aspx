<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="NoughtsAndCrosses.Web.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="TableBoard" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button1" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button2" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button3" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button4" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button5" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button6" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button7" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button8" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button9" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Label ID="LabelOut" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
