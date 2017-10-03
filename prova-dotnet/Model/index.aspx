<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prova_dotnet.Model.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        EasyBlog</div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="541px">Titulo</asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server">Post</asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar Post" />
        </p>
    </form>
</body>
</html>
