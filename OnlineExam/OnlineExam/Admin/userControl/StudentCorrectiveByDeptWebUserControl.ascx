<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudentCorrectiveByDeptWebUserControl.ascx.cs" Inherits="WebApplication1.StudentCorrectiveByDeptWebUserControl" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
    }
    .auto-style3 {
        width: 38px;
    }
    .auto-style4 {
    }
    .auto-style5 {
        width: 153px;
    }
</style>

<table class="auto-style1" style="width: 600px">
    <tr>
        <td class="auto-style4" colspan="2">Select Department</td>
        <td>
            <asp:DropDownList ID="ddl_department" runat="server" OnSelectedIndexChanged="ddl_department_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            &nbsp; &nbsp;</td>
        <td class="auto-style2" colspan="2">
            <asp:GridView ID="gv_corrective" runat="server" CellPadding="4" style="margin-left: 0px" Width="378px" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td>
            <asp:Label ID="lbl_status" runat="server" CssClass="col-md-2 control-label"></asp:Label>
        </td>
    </tr>
</table>

