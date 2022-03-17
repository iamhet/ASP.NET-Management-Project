<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="add_user.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" class="form-control form-control-user" placeholder="Enter Full Name..."></asp:TextBox>
    &nbsp;<asp:TextBox ID="TextBox2" runat="server" class="form-control form-control-user" placeholder="Enter Email..."></asp:TextBox>
    &nbsp;<asp:TextBox ID="TextBox3" runat="server" class="form-control form-control-user" placeholder="Enter Password..."></asp:TextBox>
    <br />

    <asp:Button ID="Button1" runat="server" Text="Submit" 
        class="btn btn-success" onclick="Button1_Click" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Width="725px">
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("id") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="FULL NAME">
                <ItemTemplate>
                    <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("fullname") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EMAIL">
                <ItemTemplate>
                    <asp:Literal ID="Literal3" runat="server" Text='<%# Eval("email") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PASSWORD">
                <ItemTemplate>
                    <asp:Literal ID="Literal4" runat="server" Text='<%# Eval("password") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ACTION">
                <ItemTemplate>
                    <asp:Button ID="Button2" runat="server" Text="EDIT" 
                        class="btn btn-primary create-new-button" onclick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="DELETE" 
                        class="btn btn-danger create-new-button" onclick="Button3_Click"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />

</asp:Content>

