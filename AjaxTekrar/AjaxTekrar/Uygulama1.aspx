<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uygulama1.aspx.cs" Inherits="AjaxTekrar.Uygulama1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">

        function faktoriyel() {
           
            var sayi = document.getElementById('txtSayi').value;
            alert(sayi);
            PageMethods.faktHesapla(sayi,sonucGoster);
        }

        function sonucGoster(result){
            document.getElementById('lblSonuc').innerHTML = result;
        }


    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
        <input id="txtSayi" type="text" />
        <input id="btnIslem" type="button" value="Faktöriyel" onclick="faktoriyel()"/>
        <div id="lblSonuc"></div>
       <%-- <asp:TextBox ID="txtSayi" runat="server"></asp:TextBox>
        <asp:Button ID="btn" runat="server" Text="faktöriyel" OnClick="btn_Click"/>
        <asp:Label ID="lblSonuc" runat="server" Text=""></asp:Label>--%>

    </div>
    </form>
</body>
</html>
