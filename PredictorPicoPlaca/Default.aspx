<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PredictorPicoPlaca._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Predictor Pico y Placa</h1>
        <p>
            <asp:Label ID="label" runat="server" Text="Placa (ABC-1234): "></asp:Label>
            <asp:TextBox ID="txtPlaca" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Fecha: "></asp:Label>
            <asp:TextBox ID="txtFecha" CssClass="form-control" type="date" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Hora( hh:mm ): "></asp:Label>
            <asp:TextBox ID="txtHora" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
        </p>
        <p>
            <asp:Button runat="server" CssClass="btn btn-primary btn-lg" Text="Clacular &raquo;" ID="btnCalcular" OnClick="btnCalcular_Click" />
        </p>

        <div id="divError" runat="server" visible="false" class="alert alert-danger" role="alert">
            Ingrese correctamente los valores
        </div>

        <div id="divRespuesta" runat="server" visible="false" class="alert alert-info"></div>
    </div>
</asp:Content>
