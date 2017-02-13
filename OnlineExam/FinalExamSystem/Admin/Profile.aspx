<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="OnlineExam.Admin.Profile" %>
<%@ Register src="userControl/adminprofile.ascx" tagname="adminprofile" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="server">
    <uc1:adminprofile ID="adminprofile1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
