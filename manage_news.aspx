<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="manage_news.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

&nbsp;<asp:Literal ID="Literal5" runat="server" Text="Enter Tag Name :" ></asp:Literal>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" class="form-control form-control-user" placeholder="Enter Tag..."></asp:TextBox>
    &nbsp;<asp:Literal ID="Literal6" runat="server" Text="Enter Title :"></asp:Literal>
    <asp:TextBox ID="TextBox5" class="form-control form-control-user" placeholder="Enter Title..." runat="server"></asp:TextBox>
    <asp:Literal ID="Literal10" runat="server" Text="Enter Writer Name:"></asp:Literal>
    &nbsp;<br />
    <asp:TextBox ID="TextBox6" runat="server" class="form-control form-control-user" placeholder="Enter Writer Name..." ></asp:TextBox>
    <asp:Literal ID="Literal11" runat="server" Text="Add Writer Image:"></asp:Literal>
    <br />
    <asp:FileUpload ID="FileUpload2" class="form-control form-control-user" runat="server" />
    <asp:Image ID="Image5" runat="server" Height="92px" Width="96px"/>
    <br />
    <asp:Literal ID="Literal7" runat="server" Text="Add News Image :"></asp:Literal>
    <br />
    <asp:FileUpload ID="FileUpload1" class="form-control form-control-user"  runat="server" />
    <asp:Image ID="Image2" runat="server" Height="92px" Width="96px" />
    <br />
    <asp:Literal ID="Literal8" runat="server" Text="Status :"></asp:Literal>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
        RepeatDirection="Horizontal">
        <asp:ListItem Value="1">Active</asp:ListItem>
        <asp:ListItem Value="0">Deactive</asp:ListItem>
    </asp:RadioButtonList>
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
            <asp:TemplateField HeaderText="TAG ">
                <ItemTemplate>
                    <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("tag") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NEWS_TITLE">
                <ItemTemplate>
                    <asp:Literal ID="Literal3" runat="server" Text='<%# Eval("title") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="WRITER_NAME">
                <ItemTemplate>
                    <asp:Literal ID="Literal12" runat="server" Text='<%# Eval("writer_name") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NEWS_IMAGE">
                <ItemTemplate>
                    <asp:Image ID="Image3" runat="server" Height="81px" Width="78px" 
                        ImageUrl='<%# Eval("writer_image", "~/news_images/{0}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="WRITER_IMAGE">
                <ItemTemplate>
                    <asp:Image ID="Image4" runat="server" Height="81px" Width="78px"  
                        ImageUrl='<%# Eval("news_image", "~/news_images/{0}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ACTION">
                <ItemTemplate>
                    <asp:Button ID="Button2" runat="server" Text="EDIT" 
                        class="btn btn-primary create-new-button" onclick="Button2_Click" 
                        CommandArgument='<%# Eval("id") %>' />
                    <asp:Button ID="Button3" runat="server" Text="DELETE" 
                        class="btn btn-danger create-new-button" onclick="Button3_Click" 
                        CommandArgument='<%# Eval("id") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <br />

</asp:Content>

