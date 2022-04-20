<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetailsWithRDLC.aspx.cs" Inherits="RDLC.EmployeeDetailsWithRDLC" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=B03F5F7F11D50A3A" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="sm1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Table ID="tblEmployeeDetails" runat="server" HorizontalAlign="Center">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell Font-Bold="true" ForeColor="Blue" HorizontalAlign="Center" Font-Size="X-Large">
                        Employee Details<hr />
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <rsweb:ReportViewer ID="rvEmployeeReport" runat="server" Font-Names="Verdana" Font-Size="Medium" Width="100%" Height="50%">
                            <LocalReport ReportPath="EmployeeDetails.rdlc"></LocalReport>
                        </rsweb:ReportViewer>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow>
                    <asp:TableCell>
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableFooterRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
