<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Common.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BlogApp.Blog.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="row justify-content-center">
            <asp:Repeater ID="repeaterData" runat="server">
                <ItemTemplate>
                    <div class="col-md-8 mb-4">
                        <div class="card p-3 text-center">
                            <h2 class="card-title"><%# Eval("Title") %></h2>
                            <h3 class="card-subtitle mb-2 text-muted"><%# Eval("Author") %></h3>
                            <div class="text-center">
                                <asp:Image runat="server" ID="image" ImageUrl='<%# "~/images/" + Eval("Image") %>' Width="250px" Height="150px" class="img-fluid" />
                            </div>
                            <p class="card-text"><%# Eval("Content") %></p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>