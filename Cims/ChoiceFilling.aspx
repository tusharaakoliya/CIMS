<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="ChoiceFilling.aspx.cs" Inherits="Cims.ChoiceFilling" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>--%>
    <script type="text/javascript">
        $(function () {

            $("#<%=gvchoicefilling.ClientID%> input[id*='chkAll']:checkbox").click(function () {
                $("#<%=gvchoicefilling.ClientID%> input[id*='chkSelect']:checkbox").attr('checked', $(this).is(':checked'));
            });

            $("#<%=gvchoicefilling.ClientID%> input[id*='chkSelect']:checkbox").click(function () {
                //Get number of checkboxes in list either checked or not checked
                var totalCheckboxes = $("#<%=gvchoicefilling.ClientID%> input[id*='chkSelect']:checkbox").size();
                //Get number of checked checkboxes in list
                var checkedCheckboxes = $("#<%=gvchoicefilling.ClientID%> input[id*='chkSelect']:checkbox:checked").size();
                //Check / Uncheck top checkbox if all the checked boxes in list are checked
                $("#<%=gvchoicefilling.ClientID%> input[id*='chkAll']:checkbox").attr('checked', totalCheckboxes == checkedCheckboxes);
            });

        });

    </script>
    <table style="width: 100%;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblResultDate" runat="server" Text="" Visible="false" ForeColor="Black"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="float: left;">
                <asp:TextBox runat="server" ID="txtSearch"></asp:TextBox>
                <asp:Button ID="btnSearch" CssClass="gridButton" runat="server" ClientIDMode="Static" Text="Search" OnClick="btnSearch_Click" />
            </td>
            <td style="float: right;">
                <asp:Button ID="btnBranch" CssClass="gridButton" runat="server" Text="Add Selected Choice" OnClick="btnBranch_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvchoicefilling" OnRowDataBound="gvchoicefilling_RowDataBound" ShowHeaderWhenEmpty="true" emptydatatext="No record found."  CssClass="mGrid" runat="server" DataKeyNames="id" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="10" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSorting="gvchoicefilling_Sorting" OnPageIndexChanging="gvchoicefilling_PageIndexChanging">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblCollageId" runat="server" Visible="false" Text='<%#Eval("collageid")%>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblbranchid" runat="server" Visible="false" Text='<%#Eval("branchid")%>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblCourseId" runat="server" Visible="false" Text='<%#Eval("courseid")%>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>


                        <asp:BoundField DataField="BranchName" HeaderText="Branch Name" />
                        <asp:BoundField DataField="CollageName" HeaderText="Collage Name" />
                        <asp:BoundField DataField="seat" HeaderText="Seat" />

                        <asp:TemplateField ItemStyle-CssClass="algnCenter">
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkAll" runat="server" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkSelect" runat="server" />
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


    <table style="width: 100%" align="center">
        <%--<tr>
            <td style="float: left;">
                <asp:TextBox runat="server" ID="selectedgv"></asp:TextBox>
                <asp:Button ID="selectedsearch" CssClass="gridbutton" runat="server" ClientIDMode="static" Text="search" OnClick="selectedsearch_click" />
            </td>

        </tr>--%>
        <tr>
            <td>
                <asp:GridView ID="gvselecctedchoicefilling" CssClass="mGrid" ShowHeaderWhenEmpty="true" emptydatatext="No record found." runat="server" DataKeyNames="id" AllowPaging="true" Width="100%" AllowSorting="true" PageSize="50" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvselecctedchoicefilling_PageIndexChanging" OnRowDataBound="gvselecctedchoicefilling_RowDataBound" OnRowDeleting="gvselecctedchoicefilling_RowDeleting">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblCollageId" runat="server" Visible="false" Text='<%#Eval("collageid")%>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblbranchid" runat="server" Visible="false" Text='<%#Eval("branchid")%>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="lblCourseId" runat="server" Visible="false" Text='<%#Eval("courseid")%>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>


                        <asp:BoundField DataField="BranchName" HeaderText="Branch Name" />
                        <asp:BoundField DataField="CollageName" HeaderText="Collage Name" />
                        <asp:BoundField DataField="seat" HeaderText="Seat" />

                        <asp:TemplateField ItemStyle-CssClass="algnCenter" HeaderText="Delete">

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
