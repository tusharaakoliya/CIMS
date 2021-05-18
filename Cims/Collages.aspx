<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Collages.aspx.cs" Inherits="Cims.Collages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        $(function () {
            $("#txtphoneno").keydown(function (e) {
                //if the letter is not digit then display error and don't type anything
                if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                    //display error message
                    return false;
                }
            });
        });
    </script>
    <div>
        <fieldset id="Fieldset1">
            <legend style="background-color: #787878; padding: 10px;">
                <label id="legendAddCollage" class="lblfieldSet" runat="server"> Add New Collage </label>
            </legend>
            <table style="width: 100%" cellspacing="10" align="center" class="tblAll">
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Collage Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" MaxLength="50" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" ControlToValidate="txtName" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="Name is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td colspan="5">
                        <asp:TextBox ID="txtAddress" Rows="4" Columns="57" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblfax" runat="server" Text="Fax"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtfax" MaxLength="10" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" MaxLength="50" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvemail" ControlToValidate="txtEmail" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="Email is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblphoneno" runat="server" Text="Phone No"></asp:Label>
                    </td>
                    <td>
                        <%--<input type="text" id="txtphoneno"/>--%>
                        <asp:TextBox ID="txtphoneno" MaxLength="10" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcity" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcity" MaxLength="10" runat="server"></asp:TextBox>
                    </td>
                </tr>
              <tr>
                    <td>
                        <asp:Label ID="lblMerit" runat="server" Text="Merit"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMerit" MaxLength="2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="rvfMerit" ControlToValidate="txtMerit" ErrorMessage="*" ToolTip="Merit is required"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSeat" ControlToValidate="txtMerit" runat="server" ErrorMessage="*" ToolTip="Only Number is allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                       
                        
                    </td>
                    <td>
                         <asp:Button ID="btnsave" CssClass="clsSave" runat="server" Text="Save" OnClick="btnsave_Click" />
                        <asp:Button ID="btncancel" CssClass="clsSave" runat="server" Text="Cancel" CausesValidation="false" />
                    </td>
                </tr>
                 
            </table>
        </fieldset>
    </div>

</asp:Content>

