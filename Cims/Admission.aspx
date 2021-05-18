<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Admission.aspx.cs" Inherits="Cims.admission" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="css/admin.css" />
    <table width="100%">
        <tr>
          <%--  <td style="width: 13%" valign="top" id="tdadminmenu" runat="server">
                <div id="navigation">

                    <ul class="top-level">
                        <li id="Marks"><a href="BranchList.aspx">Marks</a></li>
                    </ul>

                </div>
            </td>--%>

            <td style="width: 77%" id="tdConent" runat="server">
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Your Merit Marks : " ForeColor="Black"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblTotalMarks" Text="" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Your Merit(%) : " ForeColor="Black"></asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblMeritPercentage" Text="" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                </table>
                <table style="width: 100%">
                    <tr>
                        <td>
                            <asp:GridView ID="gvmarks" CssClass="mGrid" runat="server" DataKeyNames="StudentId" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="10" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvmarks_PageIndexChanging" OnSorting="gvmarks_Sorting">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="StudentId" HeaderText="ID" SortExpression="StudentId" Visible="false" />
                                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                                    <asp:BoundField DataField="Marks" HeaderText="Marks" SortExpression="Marks" />
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
            </td>

        </tr>

    </table>
</asp:Content>
