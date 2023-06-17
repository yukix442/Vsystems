<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="avgrank.aspx.cs" Inherits="Valorantsystems.avgrank" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    

    
    
    <form id="form1" runat="server">
            
        
        <asp:Label ID="Label2" runat="server" Text="平均ランク計算ツールV" Font-Name="MS Gothic" Font-Size="20pt"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="5人分のランクを選択し、計算ボタンを押すと平均ランクを計算します。"></asp:Label>

            <center><div>
                <asp:DropDownList ID="dropdownlist1" runat="server" OnSelectedIndexChanged="dropdownlist1_SelectedIndexChanged" AutoPostBack="true" Height="50px"></asp:DropDownList>
            
        
                <asp:DropDownList ID="dropdownlist2" runat="server" OnSelectedIndexChanged="dropdownlist1_SelectedIndexChanged" AutoPostBack="true" Height="50px"></asp:DropDownList>
            
        
                <asp:DropDownList ID="dropdownlist3" runat="server" OnSelectedIndexChanged="dropdownlist1_SelectedIndexChanged" AutoPostBack="true" Height="50px"></asp:DropDownList>
            
       
                <asp:DropDownList ID="dropdownlist4" runat="server" OnSelectedIndexChanged="dropdownlist1_SelectedIndexChanged" AutoPostBack="true" Height="50px"></asp:DropDownList>
            
        
                <asp:DropDownList ID="dropdownlist5" runat="server" OnSelectedIndexChanged="dropdownlist1_SelectedIndexChanged" AutoPostBack="true" Height="50px"></asp:DropDownList>
            
        </div></center><br />
        <div>
            <center>
                <asp:Button runat="server" Text="計算" OnClick="Unnamed1_Click" Width="50px" Height="50px"></asp:Button></center></div>
            <center><div><asp:Label ID="Label1" runat="server" Text=""></asp:Label></div></center>
    </form>
</body>
</html>
