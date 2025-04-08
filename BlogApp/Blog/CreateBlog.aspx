<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Common.Master" AutoEventWireup="true" CodeBehind="CreateBlog.aspx.cs" Inherits="BlogApp.Blog.CreateBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container d-flex justify-content-center align-items-center" style="min-height: 100vh;">
    <div class="text-center">
        <h1>Create Blog</h1>

        <div class="mb-3">
            <label class="form-label">Select Category:</label>
            <asp:DropDownList runat="server" CssClass="form-select">
                <asp:ListItem Text="Food" />
                <asp:ListItem Text="Movie" />
                <asp:ListItem Text="Sports" />
                <asp:ListItem Text="Education" />
            </asp:DropDownList>
        </div>

        <div class="mb-3">
            <label" class="form-label">Author:</label>
            <asp:TextBox ID="txtAuthor" runat="server" CssClass="form-control rounded"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">Title:</label>
            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control rounded"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">Content:</label>
            <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" CssClass="form-control rounded" Rows="5"></asp:TextBox>
        </div>

        <asp:Button ID="btnCreate" runat="server" Text="Create Blog" CssClass="btn btn-primary"/>
    </div>
</div>
</asp:Content>
