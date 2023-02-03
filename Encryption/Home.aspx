<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Encryption.Home" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript">
        function onlyNumbers() {
            var regex = /^[0-9]*$/;
            if (regex.test(document.getElementById("Number1").value) && regex.test(document.getElementById("Number2").value)) {
                return true;
            } else {
                alert("Numbers Only Please.");
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <%--<table>
            <asp:Label runat="server" Text="Cypher Text"></asp:Label>
            <asp:TextBox runat="server" ID="CyberTextKey" Text="7061737323313233"></asp:TextBox>
        </table>--%>
        <table>
            <asp:Label runat="server" Text="Input1"></asp:Label>
            <asp:TextBox runat="server" ID="Number1" BorderStyle="Solid"></asp:TextBox>
         </table>
        <table>
            <asp:Label runat="server" Text="Input2"></asp:Label>
            <asp:TextBox runat="server" ID="Number2" BorderStyle="Solid" ></asp:TextBox>
            
            <%--<asp:TextBox runat="server" ID="PlainText" AutoPostBack="true" OnTextChanged="PlainText_TextChanged" ></asp:TextBox>--%>
            </table>
        <table>
            <asp:Button runat="server"  Text="Compute" ID="btnCompute" OnClientClick="javascript:return onlyNumbers();" OnClick="btnCompute_Click" />
            <%--<asp:Label runat="server" ID="lblencrpttext"></asp:Label>--%>
        </table>
        <%--<table>
            <asp:Label runat="server" Text="Encrypted Text"></asp:Label>
            <asp:TextBox runat="server" ID="EncryptedText"  AutoPostBack="true"  OnTextChanged="EncryptedText_TextChanged" ></asp:TextBox>
            <asp:Label runat="server" ID="lblpalaintext"></asp:Label>
        </table>--%>
    </form>
</body>
</html>
