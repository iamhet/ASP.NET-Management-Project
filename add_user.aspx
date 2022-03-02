<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="add_user.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Button ID="Button1" runat="server" Text="ADD USER" 
        class="btn btn-success create-new-button" onclick="Button1_Click" />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Width="725px" onselectedindexchanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField HeaderText="ID"></asp:TemplateField>
            <asp:BoundField AccessibleHeaderText="FULL NAME" />
            <asp:TemplateField HeaderText="FULL NAME"></asp:TemplateField>
            <asp:TemplateField HeaderText="EMAIL"></asp:TemplateField>
            <asp:TemplateField HeaderText="PASSWORD"></asp:TemplateField>
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

