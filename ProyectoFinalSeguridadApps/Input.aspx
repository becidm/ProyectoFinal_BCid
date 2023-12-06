<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="ProyectoFinalSeguridadApps.Input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es-mx" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .textbox {
            width: 90%;
            height: 100px;
        }

        .Title {
            font-size: larger;
            color: darkblue;
            border-bottom-style: dashed;
            border-bottom-color: goldenrod;
            border-bottom-width: 2px;
            font-family: Calibri text-align: center;
        }

        .Labels {
            font-weight: bold;
            font-style: normal;
            color: darkslategrey;
            font-size: 14px;
            font-family: Calibri;
        }

        .Footer {
            font-weight: normal;
            color: darkred;
            font-size: 12px;
            font-family: Calibri
        }

        .Message {
            font-family: Calibri;
            font-weight: bolder;
            color: mediumvioletred;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server">
                <asp:TableHeaderRow ID="MainTable" TableSection="TableHeader">
                    <asp:TableHeaderCell Width="10%"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Wrap="true" Width="60%">
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label runat="server" ID="lblTitle" CssClass="Title" Text="<%$ Resources:Labels, lblTitle %>"></asp:Label><hr />

                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>

                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell Width="20%"></asp:TableHeaderCell>

                </asp:TableHeaderRow>
                <asp:TableRow Height="100px">
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblInputText" CssClass="Labels" Text="<%$ Resources:Labels, lblInputText %>"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txbInputText" CssClass="textbox"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center">
                        <asp:Button runat="server" ID="btnValidateInput" OnClick="btnValidateInput_Click" Text="<% $Resources:Labels,lblValidate %>" />
                   &nbsp;&nbsp;
                        <asp:Button runat="server" ID="btnClean" OnClick="btnClean_Click" Text="<% $Resources:Labels,lblClean %>" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell CssClass="Labels" BorderStyle="Dashed" BorderWidth="2px" BorderColor="Green">
                        <br />
                        <asp:Literal runat="server" ID="ltrCleaningText" Mode="Encode"></asp:Literal>
                        <br />
                        <br />
                        <asp:Label runat="server" ID="lblCCMasked"></asp:Label>
                        <br />
                        <br />
                        <asp:Label runat="server" ID="lblSHA256"></asp:Label>
                        <br />
                        <br />
                        <asp:Label runat="server" ID="lblEncrypted"></asp:Label>
                        <br />
                        <br />
                        <asp:Label runat="server" ID="lblDecrypt"></asp:Label>
                        <br /> 
                        <br />
                        <asp:Label runat="server" ID="lblMessage" CssClass="Message"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow TableSection="TableFooter">
                    <asp:TableCell> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Right">
                        <hr />
                        <asp:Label runat="server" ID="lblElaborado" CssClass="Footer" Text="<%$ Resources:Labels, lblNombre %>"></asp:Label>
                    </asp:TableCell>
                </asp:TableFooterRow>
            </asp:Table>

        </div>
    </form>
</body>
</html>
