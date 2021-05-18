<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Collagelist.aspx.cs" Inherits="Cims.Collagelist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 100%;" align="center">
        <tr>
            <td style="float: left;">
                <asp:TextBox runat="server" ID="txtSearch"></asp:TextBox>
                <asp:Button ID="btnSearch" CssClass="gridButton" runat="server" ClientIDMode="Static" Text="Search" OnClick="btnSearch_Click" />
            </td>
            <td style="float: right;">
                <asp:Button ID="btnclg" CssClass="gridButton" runat="server" Text="Add New Collages" OnClick="btnclg_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvCollages" CssClass="mGrid" runat="server" DataKeyNames="id" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="10" OnPageIndexChanging="gvCollages_PageIndexChanging" OnSorting="gvCollages_Sorting" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="gvCollages_RowDeleting" OnPreRender="gvCollages_PreRender">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" Visible="false" />
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="city" HeaderText="City" SortExpression="City" />
                        <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                        <asp:BoundField DataField="fax" HeaderText="FAX" SortExpression="fax" Visible="false"/>
                        <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                        <asp:HyperLinkField HeaderText="Edit" DataNavigateUrlFields="Id" ItemStyle-Width="5%" DataNavigateUrlFormatString="Collages.aspx?id={0}" Text="Edit" />
                        <asp:TemplateField HeaderText="Delete" ItemStyle-Width="5%">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("id") %>' OnClientClick="return confirm('Are you sure want to delete?');"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
        </tr>

    </table>
</asp:Content>
