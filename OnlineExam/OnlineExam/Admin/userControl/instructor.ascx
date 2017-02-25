<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="instructor.ascx.cs" Inherits="WebApplication1.instructor" %>
<style type="text/css">
    .auto-style1 {
        height: 34px;
        width: 194px;
    }
    .auto-style6 {
        width: 194px;
    }
    .auto-style7 {
        width: 74px;
    }
    .auto-style8 {
        height: 34px;
        width: 74px;
    }
    .auto-style9 {
        width: 300px;
    }
    .auto-style10 {
        height: 34px;
        width: 300px;
    }
    .auto-style11 {
        width: 127px;
    }
    .auto-style12 {
        width: 87px;
    }
</style>
<table style="width:100%;">
    <tr>
        <td class="auto-style7">Select Instructor</td>
        <td class="auto-style9" colspan="2">
            <asp:DropDownList ID="ddl_selectInst" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_selectInst_SelectedIndexChanged" CssClass="form-control">
            </asp:DropDownList>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">
            <asp:Label ID="lbl_insID" runat="server" AssociatedControlID="txt_instId" Text="Instructor_ID" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style10" colspan="2">
            <asp:TextBox ID="txt_instId" runat="server" Enabled="False" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;<asp:Label ID="lbl_insuser" runat="server" AssociatedControlID="txt_userName" Text="Username" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_userName" runat="server" CssClass="form-control" Width="200px" style="margin-left: 0px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_inspass" runat="server" AssociatedControlID="txt_password" Text="Password" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_password" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_insname" runat="server" AssociatedControlID="txt_InsName" Text="Instructor_Name" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_InsName" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_InsName" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_insdegree" runat="server" AssociatedControlID="txt_InsDegree" Text="Instructor_Degree" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_InsDegree" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_inssalary" runat="server" AssociatedControlID="txt_InsSalary" Text="Instructor_Salary" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_InsSalary" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Only Money" ValidationExpression="\d+" ControlToValidate="txt_InsSalary"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_insdepart" runat="server" AssociatedControlID="ddl_Dept" Text="Department" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:DropDownList ID="ddl_Dept" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddl_Dept_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddl_Dept" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Button ID="btn_InsertIns" runat="server" Text="Insert" OnClick="btn_InsertIns_Click" CssClass="btn btn-primary" Width="150px" />
        </td>
        <td class="auto-style11">
            <asp:Button ID="btn_Update" runat="server" Text="Update" OnClick="btn_Update_Click" CssClass="btn btn-primary" Width="150px" />
        </td>
        <td class="auto-style12">
            <asp:Button ID="btn_Delete" runat="server" Text="Delete" OnClick="btn_Delete_Click" OnClientClick="return confirm('Are you sure you want to delete this Instructor?');" CssClass="btn btn-danger" Width="150px" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="btn_NewINs" runat="server" Text="New Instructor" OnClick="btn_NewINs_Click" CssClass="btn btn-default" Width="150px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style9" colspan="2">
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style9" colspan="2">
            <asp:Button ID="btn_assigntocourse" runat="server" Text="Add To Course" OnClick="btn_assigntocourse_Click" CssClass="btn btn-primary" Width="150px" Height="29px" />
        </td>
        <td class="auto-style6">
            <asp:DropDownList ID="ddl_allIns" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddl_Dept_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_course" runat="server" CssClass="form-control" AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:Panel ID="Panel1" runat="server" ValidateRequestMode="Disabled">
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:GridView ID="gv_lastchance" runat="server" ValidationGroup="Edit" EnableModelValidation="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="gv_lastchance_RowCancelingEdit" OnRowDeleting="gv_lastchance_RowDeleting" OnRowEditing="gv_lastchance_RowEditing" OnRowUpdating="gv_lastchance_RowUpdating" ValidateRequestMode="Disabled" OnRowCommand="gv_lastchance_RowCommand" OnRowCreated="gv_lastchance_RowCreated">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Instructor">
                                        <EditItemTemplate>
                                            <asp:DropDownList ID="ddl_lastchanceI" runat="server" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("[Ins-Name]") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Course">
                                        <EditItemTemplate>
                                            <asp:DropDownList ID="dd_lastchaneC" runat="server" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("[Crs-Name]") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowEditButton="True" CausesValidation="false" ValidationGroup="edit" />
                                    <asp:CommandField ShowDeleteButton="True" CausesValidation="false" ValidationGroup="delete" />
                                </Columns>
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
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
        </td>
    </tr>
</table>

