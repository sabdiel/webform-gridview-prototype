<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridViewPlayground._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="GridView1" EnableViewState="false" runat="server" AutoGenerateColumns="false" DataKeyNames="PromotionId" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="PromotionId" HeaderText="ID" ReadOnly="true" />
            <asp:BoundField DataField="LanguageId" HeaderText="Language ID" ReadOnly="true" />
            <asp:BoundField DataField="PromotionName" HeaderText="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:BoundField DataField="Notes" HeaderText="Notes" />
            <asp:CommandField ShowEditButton="true" />
            <%--<asp:CommandField ShowDeleteButton="true" />--%>
            <%--<asp:CommandField ShowInsertButton="true" />--%>
        </Columns>
    </asp:GridView>


</asp:Content>
