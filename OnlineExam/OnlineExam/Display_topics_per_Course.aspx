<%@ Page Title="" Language="C#" MasterPageFile="~/instructor.Master" AutoEventWireup="true" CodeBehind="Display_topics_per_Course.aspx.cs" Inherits="OnlineExam.Display_topics_per_Course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <p>
            <br />
        </p>
            <table class="nav-justified">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Enter Course No"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlcourse" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlcourse_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">
                        <asp:GridView ID="gvDisplayTopic" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvDisplayTopic_SelectedIndexChanged" Width="918px">
                            <AlternatingRowStyle BackColor="White" />
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
                        <asp:Label ID="lblresult" runat="server"></asp:Label>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </form>
</asp:Content>

