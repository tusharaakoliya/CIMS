<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="Cims.Result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblResultDate" runat="server" Text="" Visible="false" ForeColor="Black"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Panel runat="server" ID="panelResult">
        <table style="width: 100%" align="center">
            <tr>
                <td style="float: right">
                    <asp:Button ID="btnExportPdf" runat="server" OnClick="btnExportPdf_Click" Text="Export to Pdf" CssClass="gridButton"></asp:Button>
                </td>
            </tr>
            <tr>

                <td style="width: 100%">
                    <asp:GridView ID="gvresult" ShowHeaderWhenEmpty="true" EmptyDataText="No result found." CssClass="mGrid" runat="server" DataKeyNames="id" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="10" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="BranchName" HeaderText="Branch Name" />
                            <asp:BoundField DataField="CollageName" HeaderText="Collage Name" />
                            <asp:BoundField DataField="seat" HeaderText="Seat" />
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
    </asp:Panel>

    <asp:Panel runat="server" ID="panelResult2" Visible="false">
        <table style="width: 100%" align="center">
            <tr>

                <td style="width: 100%">
                    <asp:GridView ID="GridView1" ShowHeaderWhenEmpty="true" EmptyDataText="No result found." runat="server" DataKeyNames="id" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="10" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="BranchName" HeaderText="Branch Name" />
                            <asp:BoundField DataField="CollageName" HeaderText="Collage Name" />
                            <asp:BoundField DataField="seat" HeaderText="Seat" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" />
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
    </asp:Panel>
</asp:Content>
