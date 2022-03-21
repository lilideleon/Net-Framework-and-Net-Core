<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Asignaciones.aspx.cs" Inherits="Web.Asignaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%" align="center">
        <tr>
            <td colspan="3">
                <h1> Productos
                </h1>
            </td>
        </tr>
       
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="PRODUCTO:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="EXISTENCIA:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="BODEGA:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="UBICACION:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="MINIMO:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="MAXIMO:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="PRECIO:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>

            </td>
            <td>
                
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="ASIGNAR" OnClick="Button1_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
