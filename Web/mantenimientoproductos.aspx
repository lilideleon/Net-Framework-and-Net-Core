<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="mantenimientoproductos.aspx.cs" Inherits="Web.mantenimientoproductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 100%" align="center">
        <tr>
            <td colspan="3">
                <h1> Productos
                </h1>
            </td>
        </tr>
        <tr>
            <td rowspan="4" style="width: 323px">
                
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcliente" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Tipo:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Descripcion:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>

            </td>
            <td>
                
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="NUEVO" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="GUARDAR" Enabled="false" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="ACTUALIZAR" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="ELIMINAR" OnClick="Button4_Click"/>
                <asp:Button ID="Button5" runat="server" Text="CANCELAR" OnClick="Button5_Click" />
                <asp:Button ID="Button6" runat="server" Text="BUSCAR" OnClick="Button6_Click" />
            </td>
        </tr>
    </table>


    <center>LISTADO DE REPUESTOS</center>

        <div>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                </Columns>
            </asp:GridView>
         </div>

</asp:Content>
