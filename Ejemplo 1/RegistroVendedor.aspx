<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroVendedor.aspx.cs" Inherits="Ejemplo_1.RegistroVendedor" %>

<!DOCTYPE html>  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
    <style type="text/css">  
        .auto-style1 {  
            width: 100%;  
        }  
        .auto-style2 {  
            width: 100px;  
        }  
        .auto-style3 {  
            width: 95px;  
        }  
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
        <div>  
            <table class="auto-style1">  
                
                <tr>  
                    <td class="auto-style2">  
                       <asp:Label runat="server" Text="Nombre" ID="nombreVendedor"></asp:Label></td>  
                    <td>  
                       <asp:TextBox ID="txtVendedor" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Dui"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="txtDui" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Sueldo"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="txtSueldo" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>
                    <td>  
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                        <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
                    </td>  
                </tr>  
            </table>  
        </div>  
        <div>
            <asp:Label ID="lblInsercion" runat="server"></asp:Label>
        </div>
    </form>  
    <asp:Table runat="server" id="tbMostrar">  
        <asp:TableRow>  
            <asp:TableCell>  
                <asp:Label ID="lblIdHead" runat="server" Text="Id"></asp:Label></asp:TableCell>  
            <asp:TableCell>   
               <asp:Label ID="lblNombreHead" runat="server" Text="Nombre"></asp:Label></asp:TableCell>  
             <asp:TableCell>  
                <asp:Label ID="lblDuiHead" runat="server" Text="Dui"></asp:Label></asp:TableCell>  
            <asp:TableCell>  
                <asp:Label ID="lblSueldoHead" runat="server" Text="Sueldo"></asp:Label></asp:TableCell>  
        </asp:TableRow>  
        
    </asp:Table>  
    </body>  
</html>  
