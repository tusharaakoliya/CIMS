<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ClgBranchList.aspx.cs" Inherits="Cims.ClgBranchList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <table style="width: 100%;" align="center">

         <tr>
            <td style="float: left;">
                <asp:TextBox runat="server" ID="txtSearch"></asp:TextBox>
                <asp:Button ID="btnSearch" CssClass="gridButton" runat="server" ClientIDMode="Static" Text="Search" />
            </td>
            <td style="float: right;">
                <asp:Button ID="btnclgbranch" CssClass="gridButton" runat="server" Text="Add Collage Branch" OnClick="btnclgbranch_Click"/>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:GridView ID="gvclgbranch" CssClass="mGrid" runat="server" DataKeyNames="id" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="10" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="id" SortExpression="ID" Visible="false"/>
                        <asp:BoundField DataField="CollageName" HeaderText="CollageName" SortExpression="CollageName" />
                          <asp:BoundField DataField="BranchName" HeaderText="CollageName" SortExpression="BranchName" />
                          <asp:BoundField DataField="seat" HeaderText="Seat" SortExpression="seat" />

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
