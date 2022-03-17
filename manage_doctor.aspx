<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="manage_doctor.aspx.cs" Inherits="Default2" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    &nbsp;<asp:Literal ID="Literal5" runat="server" Text="Enter Doctor Name :" ></asp:Literal>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" class="form-control form-control-user" placeholder="Enter Doctor Name..."></asp:TextBox>
    &nbsp;<asp:Literal ID="Literal6" runat="server" Text="Enter Speciality :"></asp:Literal>
    <asp:TextBox ID="TextBox5" class="form-control form-control-user" placeholder="Enter Speciality..." runat="server"></asp:TextBox>
    &nbsp;<asp:Literal ID="Literal7" runat="server" Text="Add Doctor Photo :"></asp:Literal>
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
            <asp:TemplateField HeaderText="DOCTOR NAME">
                <ItemTemplate>
                    <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("doctor_name") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SPECIALITY">
                <ItemTemplate>
                    <asp:Literal ID="Literal3" runat="server" Text='<%# Eval("speciality") %>'></asp:Literal>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="IMAGE">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="81px" Width="78px"
                        ImageUrl='<%# Eval("image", "~/uploads/{0}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="STATUS">
                <ItemTemplate>
                    <asp:Literal ID="Literal9" runat="server" Text='<%# Eval("status") %>'></asp:Literal>
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

