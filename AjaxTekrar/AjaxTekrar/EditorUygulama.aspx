<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditorUygulama.aspx.cs" Inherits="AjaxTekrar.EditorUygulama" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        
        Başlık :<asp:TextBox ID="txtBaslik" runat="server"></asp:TextBox>
        <cc1:Editor ID="Editor1" runat="server" Width="500px"/>
        <asp:Button ID="btnEkle" runat="server" Text="Ekle"  OnClick="btnEkle_Click"/>
    </div>
    </form>
</body>
</html>
