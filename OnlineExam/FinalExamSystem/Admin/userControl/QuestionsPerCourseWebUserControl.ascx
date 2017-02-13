<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionsPerCourseWebUserControl.ascx.cs" Inherits="WebApplication1.QuestionsPerCourseWebUserControl" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
    }
    .auto-style3 {
        width: 65px;
    }
    .auto-style4 {
        direction: ltr;
    }
</style>

<table class="auto-style1" style="width: 670px">
    <tr>
        <td class="auto-style2" colspan="2">Select Course Name To get Its Questions&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddl_selectCrsName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_selectCrsName_SelectedIndexChanged1">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="2">
            <asp:DetailsView ID="gv_QuestionPerCrs" runat="server" AllowPaging="True" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging1" Width="567px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                <EditRowStyle BackColor="#2461BF" />
                <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
    </tr>
    </table>

<p class="auto-style4">
    &nbsp;</p>


