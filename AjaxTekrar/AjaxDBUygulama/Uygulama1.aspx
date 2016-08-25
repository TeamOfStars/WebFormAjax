<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uygulama1.aspx.cs" Inherits="AjaxDBUygulama.Uygulama1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="script/jquery-3.1.0.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
           
            $('#btnGetir').click(function () {
                var mytable = "<table border=1><tr><td>FirstName</td><td>LastName</td></tr>";
                $.ajax({
                    url: 'Uygulama1.aspx/employeesList',
                    type: 'post',
                    contentType: 'application/json',
                    dataType: 'json',
                    success: function (result) {
                        var data = JSON.parse(result.d);
                        for (var i = 0; i < data.length; i++) {

                            //document.getElementById('FirstName').innerHTML += data[i].FirstName;

                            //document.getElementById('LastName').innerHTML += data[i].LastName+'<br>';
                            mytable+="<tr><td>"+data[i].FirstName+"</td><td>"+data[i].LastName+"</td></tr>";

                        }
                        mytable+="</table>";
                        $("#myTable").append(mytable);
                    },
                    error: function (error) {
                        alert(error);
                    }


                });
            });
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="btnGetir" type="button" value="Employees" />
          <%--  <div id="LastName"></div>
            <div id="FirstName"></div>--%>

            <div id="myTable"></div>
           
        </div>
    </form>
</body>
</html>
