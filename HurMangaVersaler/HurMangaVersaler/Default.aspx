<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HurMangaVersaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>RÄKNA VERSALER!</h1>
        <div>
            <asp:TextBox ID="inputTextBox" runat="server" Wrap="true" TextMode="MultiLine" Height="147px" Width="506px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="count" runat="server" Text="Räkna versaler!" OnClick="count_Click" Height="29px" Width="512px" />
    </form>
</body>
</html>
