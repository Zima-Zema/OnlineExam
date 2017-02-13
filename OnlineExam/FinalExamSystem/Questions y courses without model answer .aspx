<%@ Page Title="" Language="C#" MasterPageFile="~/instructor.master" AutoEventWireup="true" CodeFile="Questions y courses without model answer .aspx.cs" Inherits="Questions_y_courses_without_model_answer_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 219px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <p>
            <br />
            <table class="nav-justified">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Enter Course No"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCourse" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">
                        <asp:GridView ID="gvcourseWithoutQques" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="522px">
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <br />
                        <asp:Label ID="lblresult" runat="server"></asp:Label>
                        <br />
                    </td>
                </tr>
            </table>
        </p>
    </form>
</asp:Content>

