<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uygulama2.aspx.cs" Inherits="AjaxDBUygulama.Uygulama2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="script/jquery-3.1.0.min.js"></script>
    <script>
        $(document).ready(function () {

            
           
            $('#btnSiparis').click(function () {
                
                var customerId = $('#combo').val();
                $.ajax({
                    url: 'Uygulama2.aspx/SiparisDetayList',
                    type: 'post',
                    contentType: 'application/json',
                    data: '{customerID:' + JSON.stringify(customerId) + '}',
                    success: function (result) {
                        var data = JSON.parse(result.d);
                        TableCreate(data);

                    }, error: function (error) {
                        alert(error);
                    }

                })
            });


        });

        function TableCreate(data) {
            var mytable = "<table border=1><tr><td>UnitPrice</td><td>Quantity</td></tr>";
            for (var i = 0; i < data.length; i++) {

                //document.getElementById('FirstName').innerHTML += data[i].FirstName;

                //document.getElementById('LastName').innerHTML += data[i].LastName+'<br>';
                mytable += "<tr><td>" + data[i].UnitPrice + "</td><td>" + data[i].Quantity + "</td></tr>";

            }
            mytable += "</table>";
            $("#myTable").append(mytable);
        }


        function comboDoldur() {
             PageMethods.Musteriler(SonucAl);
        }
        function SonucAl(result) {
            var combom = document.getElementById("combo");
            for (var i = 0; i < result.length; i++) {
                combom.innerHTML += "<option>" + result[i] + "</option>";
            }
        }
    </script>
</head>
<body onload="comboDoldur()">
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"  ID="scriptManager" EnablePageMethods="true"/>
    <div>
        <select id="combo">
           
        </select>
        <input type="button" id="btnSiparis"  value="getir"/>
        <br />
        <div id="myTable"></div>
    </div>
    </form>
</body>
</html>
