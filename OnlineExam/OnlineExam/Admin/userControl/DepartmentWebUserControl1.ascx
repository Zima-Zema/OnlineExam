<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DepartmentWebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 150px;
    }
    .auto-style3 {
        width: 300px;
    }
    .auto-style4 {
        width: 131px;
    }
    .auto-style6 {
        width: 150px;
        height: 32px;
    }
    .auto-style7 {
        width: 300px;
        height: 32px;
    }
    .auto-style8 {
        width: 131px;
        height: 32px;
    }
    .auto-style10 {
        height: 32px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_dept" runat="server" Text="Select Department"></asp:Label>
        </td>
        <td class="auto-style3" colspan="2">
            <asp:DropDownList ID="ddl_selectDept" runat="server" OnSelectedIndexChanged="ddl_selectDept_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
            </asp:DropDownList>
            </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_id" runat="server" AssociatedControlID="txt_Deptid" Text="Dept_ID"></asp:Label>
        </td>
        <td class="auto-style3" colspan="2">
            <asp:TextBox ID="txt_Deptid" runat="server" Enabled="False" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_name" runat="server" AssociatedControlID="txt_Deptname" Text="Dept_Name"></asp:Label>
        </td>
        <td class="auto-style3" colspan="2">
            <asp:TextBox ID="txt_Deptname" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_Deptname" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_desc" runat="server" AssociatedControlID="txt_DeptDecs" Text="Dept_Desc"></asp:Label>
        </td>
        <td class="auto-style3" colspan="2">
            <asp:TextBox ID="txt_DeptDecs" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="lbl_loc" runat="server" AssociatedControlID="txt_Deptloc" Text="Dept_Location"></asp:Label>
        </td>
        <td class="auto-style7" colspan="2">
            <asp:TextBox ID="txt_Deptloc" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style8"></td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_manager" runat="server" AssociatedControlID="ddl_manager" Text="Dept_Manager"></asp:Label>
        </td>
        <td class="auto-style3" colspan="2">
            <asp:DropDownList ID="ddl_manager" runat="server" CssClass="form-control">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddl_manager" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_hdate" runat="server" Text="Manager_Hiredate"></asp:Label>
        </td>
        <td class="auto-style3" colspan="2">
            <asp:TextBox ID="txt_hireDate" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style3" colspan="2">
            <asp:Calendar ID="cl_hireDate" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" CssClass="form-control" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="302px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_insert" runat="server" OnClick="btn_insert_Click" Text="Insert" Width="150px" CssClass="btn btn-primary" />
        </td>
        <td class="auto-style2">
            <asp:Button ID="btn_Update" runat="server" OnClick="btn_Update_Click" Text="Update" Width="150px" CssClass="btn btn-primary" />
        </td>
        <td class="auto-style2">
            <asp:Button ID="btn_Delete" runat="server" Text="Delete" Width="150px" OnClientClick="return confirm('Are you sure you want to delete this Department?');" OnClick="btn_Delete_Click" CssClass="btn btn_danger" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="btn_NewDept" runat="server" OnClick="btn_NewDept_Click" Text="New Department" Width="150px" CssClass="btn btn-default" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3" colspan="2">
            &nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
