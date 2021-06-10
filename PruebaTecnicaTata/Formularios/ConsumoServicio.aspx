<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumoServicio.aspx.cs" Inherits="PruebaTecnicaTata.Formularios.ConsumoServicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
            <div class="form-group">
            <label for="exampleFormControlTextarea1">Ingrese texto</label>
            <textarea class="form-control" id="texto" rows="3" runat="server"></textarea>
        </div>
        <asp:Button type="button" class="btn btn-primary" runat="server" id="btnprocesos" Text="Realizar Proceso" OnClick="btnprocesos_Click"/>   
        <br />
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" Width="80%"></asp:GridView>
        </div>
    </form>
</body>
</html>
