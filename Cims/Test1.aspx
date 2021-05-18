<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="Cims.Test1" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <fieldset id="Fieldset1">
            <legend style="background-color: ButtonShadow; padding: 10px;">
                <label id="lblcont" class="lblfieldSet">
                    &nbsp;Register&nbsp;</label>
            </legend>
            <table style="border: 1px solid black" cellspacing="10" align="center" class="tblAll">
                <tr>
                    <td>
                        <asp:Label ID="lblFName" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" MaxLength="50" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFirstName" ControlToValidate="txtFirstName" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="First Name is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMiddleName" MaxLength="10" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" MaxLength="50" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLastName" ControlToValidate="txtLastName" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="Last Name is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" MaxLength="100" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ID="rfvEmail" ErrorMessage="*" ForeColor="Red" ToolTip="Email is required"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ForeColor="Red" ToolTip="InvalidEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="radioGender" RepeatDirection="Horizontal">
                            <asp:ListItem Value="true" Selected="True">Male</asp:ListItem>
                            <asp:ListItem Value="false">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDob" runat="server" Text="Dob"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDob" ID="rfvDob" ErrorMessage="*" ForeColor="Red" ToolTip="dob is requred"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlState" runat="server">
                            <asp:ListItem Text="-- Select State --" Value=""></asp:ListItem>
                            <asp:ListItem Text="Gujarat" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Mp" Value="2"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" MaxLength="50" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMNo" runat="server" Text="Mobile No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMno" MaxLength="10" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="txtMno" ErrorMessage="*" ForeColor="Red" ToolTip="Enetr 10 digit mo number"
                            ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPno" runat="server" Text="Phone No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPno" MaxLength="15" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" Rows="3" Columns="22" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false" OnClick="btnCancel_Click" />
                    </td>
                </tr>

            </table>
        </fieldset>
    </div>
</asp:Content>

