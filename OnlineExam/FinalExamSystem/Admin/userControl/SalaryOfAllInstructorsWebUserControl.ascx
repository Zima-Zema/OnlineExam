<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalaryOfAllInstructorsWebUserControl.ascx.cs" Inherits="WebApplication1.SalaryOfAllInstructorsWebUserControl" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 241px;
    }
    .auto-style3 {
        direction: ltr;
    }
</style>

<table class="auto-style1" style="width: 670px">
    <tr>
        <td class="auto-style2">Select Instructor To get His Salary</td>
        <td>
            <asp:DropDownList ID="ddl_GetSalary" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_GetSalary_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:GridView ID="gv_Salary" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
    </tr>
</table>

<p class="auto-style3">
    &nbsp;</p>


