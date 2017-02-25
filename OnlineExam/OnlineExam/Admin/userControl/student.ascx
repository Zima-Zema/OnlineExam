<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="student.ascx.cs" Inherits="WebApplication1.student" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 308px;
    }
    </style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2">Select Student</td>
        <td>
            <asp:DropDownList ID="ddl_student" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">Student Id</td>
        <td>
            <asp:TextBox ID="txt_stdID" runat="server" Enabled="False" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Username</td>
        <td>
            <asp:TextBox ID="txt_username" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Password</td>
        <td>
            <asp:TextBox ID="txt_password" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">First Name </td>
        <td>
            <asp:TextBox ID="txt_fname" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_fname" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Last Name</td>
        <td>
            <asp:TextBox ID="txt_lname" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Department Id</td>
        <td>
            <asp:DropDownList ID="ddl_dept" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Active</td>
        <td>
            <asp:CheckBox ID="cb_active" runat="server" CssClass="form-control" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_insert" runat="server" Text="Insert" OnClick="Insert_Click" CssClass="btn btn-primary" />
        </td>
        <td>
            <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="Update_Click" CssClass="btn btn-primary" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_delete" runat="server" OnClick="Delete_Click" OnClientClick="return confirm('Are you sure you want to delete this Student?');" Text="Delete" CssClass="btn btn-danger" />
        </td>
        <td>
            <asp:Button ID="btn_create" runat="server" OnClick="Create_Click" Text="Create New Student" CssClass="btn btn-default" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_assigntocourse" CausesValidation="false" runat="server" Text="Add To Course" OnClick="btn_assigntocourse_Click" CssClass="btn btn-primary" Width="150px" Height="29px" />
        </td>
        <td>
            <asp:DropDownList ID="ddl_allstd" runat="server" CssClass="form-control" AutoPostBack="True">
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_course" runat="server" CssClass="form-control" AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
                            <asp:GridView ID="gv_lastchance" runat="server" ValidationGroup="Edit" EnableModelValidation="False" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="gv_lastchance_RowCancelingEdit" OnRowDeleting="gv_lastchance_RowDeleting" OnRowEditing="gv_lastchance_RowEditing" OnRowUpdating="gv_lastchance_RowUpdating" ValidateRequestMode="Disabled">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Student">
                                        <EditItemTemplate>
                                            <asp:DropDownList ID="ddl_lastchanceI" runat="server" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
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
        <td>
            &nbsp;</td>
    </tr>
</table>

