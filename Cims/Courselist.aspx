<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Courselist.aspx.cs" Inherits="Cims.Courselist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%;" align="center">
        <tr>
            <td style="float:right;">
                <asp:Button ID="btncourse" runat="server" Text="Add New Course" class="gridButton" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvCourse" CssClass="mGrid" runat="server" DataKeyNames="course_id" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="10" OnPageIndexChanging="gvCourse_PageIndexChanging" OnSorting="gvCourse_Sorting" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="gvCourse_RowDeleting" OnPreRender="gvCourse_PreRender">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="shortname" HeaderText="Course Name" SortExpression="shortname" />
                        <asp:BoundField DataField="fullname" HeaderText="Description" SortExpression="fullname" />
                        <asp:HyperLinkField HeaderText="Edit" DataNavigateUrlFields="course_id" ItemStyle-Width="5%" DataNavigateUrlFormatString="Branch.aspx?id={0}" Text="Edit" />
                        <asp:TemplateField HeaderText="Delete"  ItemStyle-Width="5%">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("course_id") %>' OnClientClick="return confirm('Are you sure want to delete?');"></asp:LinkButton>
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
