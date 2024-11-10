<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="weightTeam1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Selection</title>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap" rel="stylesheet">
    <style>
        /* General Body Style */
        body {
            font-family: 'Roboto', sans-serif;
            background-color: #1a1a1a;
            color: #f0f0f0;
            margin: 0;
            padding: 15px;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
        }

        .container {
            max-width: 700px;
            padding: 20px;
            background-color: #121212;
            border-radius: 10px;
            box-shadow: 0 0 15px rgba(255, 105, 180, 0.7);
            text-align: center;
        }

        /* Centered and Small Input Fields */
        .input-group {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin-bottom: 15px;
        }

        label {
            font-weight: bold;
            color: #ff69b4;
            margin-bottom: 3px;
        }

        input[type="text"] {
            width: 50%;
            padding: 5px;
            border: 1px solid #ff69b4;
            border-radius: 5px;
            background-color: #2a2a2a;
            color: #ffffff;
            text-align: center;
            transition: 0.3s;
        }

        input[type="text"]:focus {
            border: 2px solid #fuchsia;
            outline: none;
        }

        /* GridView Styling without Lines */
        .grid-view {
            width: 100%;
            border-collapse: collapse;
            margin-top: 15px;
            color: #fff;
        }

        .grid-view th {
            background: linear-gradient(135deg, #800080, #ff69b4);
            color: #ffffff;
            padding: 10px;
            font-size: 14px;
            text-transform: uppercase;
            border-radius: 8px;
            text-shadow: 0 0 5px #ff69b4;
        }

        .grid-view td {
            padding: 8px;
            background: #333;
        }

        /* No borders on cells */
        .grid-view td, .grid-view th {
            border: none;
        }

        .grid-view tr:hover td {
            background: #4a4a4a;
        }

        /* Button Styling */
        .btn {
            background-color: #ff69b4;
            color: #fff;
            border: none;
            padding: 8px 15px;
            text-align: center;
            font-size: 12px;
            cursor: pointer;
            border-radius: 5px;
            transition: background-color 0.3s, transform 0.3s;
            box-shadow: 0px 5px 15px rgba(255, 105, 180, 0.4);
        }

        .btn:hover {
            background-color: #ff1493;
            transform: scale(1.1);
        }

        /* Summary Section */
        .summary {
            font-weight: bold;
            margin-top: 15px;
            color: #00ffcc;
            text-shadow: 0 0 5px #00ffcc, 0 0 10px #00ffcc;
        }

        /* Footer with Neon Effect */
        .footer {
            background: #000000;
            color: #fuchsia;
            padding: 15px;
            text-align: center;
            font-size: 14px;
            border-radius: 8px;
            margin-top: 20px;
            box-shadow: 0 -4px 15px rgba(255, 105, 180, 0.5);
            text-shadow: 0 0 10px #ff69b4, 0 0 20px #ff69b4;
        }

        /* Submit Button Container */
        .submit-button-container {
            text-align: center;
            margin: 15px 0;
        }

        /* Footer Row Styled to Match Product Rows */
.footer-row {
    background-color: #2a2a2a; /* Background color to match other rows */
    padding: 10px; /* Add padding for spacing */
    text-align: center; /* Center the text */
}

/* Style for footer cells to ensure they span correctly */
.footer-row td {
    padding: 10px; /* Add padding for spacing */
    border:solid; /* No border for the footer cells */
    text-align: center; /* Center text */
}

/* Input Fields Styling for Footer */
.input-product {
    width: 80%; /* Make the input fields take a good amount of space */
    padding: 5px;
    box-sizing: border-box; /* Include padding in width */
    border-radius: 4px; /* Rounded corners */
    border: 1px solid #ccc; /* Border color */
    font-size: 14px; /* Font size */
    text-align: center; /* Center text in inputs */
}

/* Add Button Styling */
.btn-add-product {
            background-color: #ff69b4;
            color: #fff;
            border: none;
            padding: 8px 15px;
            text-align: center;
            font-size: 12px;
            cursor: pointer;
            border-radius: 5px;
            transition: background-color 0.3s, transform 0.3s;
            box-shadow: 0px 5px 15px rgba(255, 105, 180, 0.4);
}

.btn-add-product:hover {
                background-color: #ff1493;
            transform: scale(1.1);
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        
        <div class="container">
            <h2>טבלת כלכלן</h2>
            <!-- Input Fields -->
            <div class="input-group">
                <label for="txtName">Name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="input-field" />
            </div>
            <div class="input-group">
                <label for="txtWeight">Weight:</label>
                <asp:TextBox ID="txtWeight" runat="server" CssClass="input-field" />
            </div>

            <h3>פריטים</h3>
            <asp:UpdatePanel ID="upProducts" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvProducts" runat="server" CssClass="grid-view" ShowFooter="true" AutoGenerateColumns="false" OnRowCommand="gvProducts_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                            <asp:BoundField DataField="ProductWeight" HeaderText="Weight" />
                            <asp:TemplateField HeaderText="Amount">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtAmount" runat="server" Text="1" CssClass="input-field" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" CommandName="AddProduct" CommandArgument="<%# Container.DataItemIndex %>" Text="Add" CssClass="btn" />
                                </ItemTemplate>
                            </asp:TemplateField>
<asp:TemplateField>
    <FooterTemplate>
        <tr class="footer-row">
            <td>
                <asp:TextBox ID="txtNewProductName" runat="server" CssClass="input-product" Placeholder="Product Name"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtNewProductWeight" runat="server" CssClass="input-product" Placeholder="Weight"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtNewProductAmount" runat="server" CssClass="input-product" Placeholder="Amount" Text="1"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnAddCustomProduct" runat="server" Text="Add" CommandName="AddCustomProduct" CssClass="btn btn-add-product" />
            </td>
        </tr>
    </FooterTemplate>
</asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>

            <div class="summary">
                <p class="label">משקל פריטים: <asp:Label ID="lblTotalWeight" runat="server" Text="0" CssClass="label" /></p>
                <p class="label">אחוזי משקל גוף: <asp:Label ID="lblPercentage" runat="server" Text="0%" CssClass="label" /></p>
            </div>

            <h3>פריטים שנבחרו</h3>
            <asp:UpdatePanel ID="upSelectedProducts" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvSelectedProducts" runat="server" CssClass="grid-view" AutoGenerateColumns="false" OnRowCommand="gvSelectedProducts_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                            <asp:BoundField DataField="ProductWeight" HeaderText="Weight" />
                            <asp:BoundField DataField="Amount" HeaderText="Amount" />
                            <asp:BoundField DataField="TotalWeight" HeaderText="Total Weight" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" CommandName="RemoveProduct" CommandArgument="<%# Container.DataItemIndex %>" Text="Remove" CssClass="btn" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>

            <div class="submit-button-container">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn" />
            </div>

            <h3>טבלת הצוות</h3>
            <asp:GridView ID="gvSubmissions" runat="server" CssClass="grid-view" AutoGenerateColumns="false" OnRowCommand="gvSubmissions_RowCommand1" >
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Weight" HeaderText="Weight" />
                    <asp:BoundField DataField="TotalWeight" HeaderText="Total Weight" />
                    <asp:BoundField DataField="WeightPercentage" HeaderText="Weight Percentage" />
                    <asp:BoundField DataField="SelectedProducts" HeaderText="Selected Products" />
                                                <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" CommandName="RemoveRow" CommandArgument="<%# Container.DataItemIndex %>" Text="Remove" CssClass="btn" />
                                </ItemTemplate>
                            </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        
        <div class="footer">
            © All rights reserved to Liron Tzipori, 2024
        </div>
    </form>
</body>
</html>
