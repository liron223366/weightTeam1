using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace weightTeam1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Submission
        {
            public string Name { get; set; }
            public double Weight { get; set; }
            public double TotalWeight { get; set; }
            public double WeightPercentage { get; set; }
            public string SelectedProducts { get; set; }
        }

        private void LoadProductsTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("ProductWeight", typeof(double));

            // Example products
            table.Rows.Add("זוג ברכיות", 0.51);
            table.Rows.Add("זוג נעליים", 1.8);
            table.Rows.Add("מדים", 1.2);
            table.Rows.Add("חגורה", 0.15);
            table.Rows.Add("ווסט", 1.85);
            table.Rows.Add("קסדה+מצנפת+פנצ+משקפי מגן", 2.05);
            table.Rows.Add("ת.א", 0.05);
            table.Rows.Add("ח.ע", 0.05);
            table.Rows.Add("שעון", 0.07);
            table.Rows.Add("טוש פציעה", 0.005);
            table.Rows.Add("פנטל", 0.005);
            table.Rows.Add("לדרמן", 0.2);
            table.Rows.Add("כפפות", 0.00);
            table.Rows.Add("קרמי", 4.3);
            table.Rows.Add("קרמי צד", 1.0);
            table.Rows.Add("פקל סוללות", 0.3);
            table.Rows.Add("מסכת פנים", 0.05);
            table.Rows.Add("קטר", 0.3);
            table.Rows.Add("מלאק", 0.2);
            table.Rows.Add("סכין קומנדו", 0.25);
            table.Rows.Add("משקפת", 0.7);
            table.Rows.Add("מסכת אבך", 0.9);
            table.Rows.Add("תיק לאו", 2.5);
            table.Rows.Add("מבוקבק(חולצה ומכנס)", 1.2);
            table.Rows.Add("חלפס", 0.8);
            table.Rows.Add("בוקסר", 0.2);
            table.Rows.Add("  זוג גרביים", 0.2);
            table.Rows.Add("ציוד הגיינה", 0.25);
            table.Rows.Add("פלציב", 0.55);
            table.Rows.Add("גורטקס", 0.95);
            table.Rows.Add("סופטשל", 0.9);
            table.Rows.Add(" חולצה טרמית", 0.15);
            table.Rows.Add("שלוקר", 3.0);
            table.Rows.Add("אלונקת 8", 5.0);
            table.Rows.Add("אלונקת בד", 0.35);
            table.Rows.Add("דגל", 0.2);
            table.Rows.Add("m4 קלע", 3.7);
            table.Rows.Add("m4 מקוצרר", 2.75);
            table.Rows.Add("m4 מקוצרר עם מתפסי טרור", 2.95);
            table.Rows.Add("מטול", 4.3);
            table.Rows.Add("פק", 0.2);
            table.Rows.Add("משלש", 0.25);
            table.Rows.Add("יראור", 0.2);
            table.Rows.Add("סטינג", 0.3);
            table.Rows.Add("נגב", 7.4);
            table.Rows.Add("נגב 7", 8.85);
            table.Rows.Add("מכבים", 0.75);
            table.Rows.Add("מכבית", 0.6);
            table.Rows.Add("ידית אחיזה", 0.15);
            table.Rows.Add("ליאור", 1.1);
            table.Rows.Add("דילדו", 0.217);
            //table.Rows.Add("שוטגן", 3.0);
            //table.Rows.Add("עמעם", 3.0);
            table.Rows.Add("מאג", 11.0);
            table.Rows.Add("מתן כוכב", 20.0);
            table.Rows.Add("תבל", 22.5);
            table.Rows.Add("ליל קיץ", 12.0);
            table.Rows.Add("שיח", 31.2);
            table.Rows.Add("אחוד+5 סוללות", 24.2);
            table.Rows.Add("טיל גיל 1", 13.7);
            table.Rows.Add("טיל גיל 2", 14.0);
            table.Rows.Add("מנשא טיל גיל", 4.25);
            table.Rows.Add("סודוקו", 2.5);
            table.Rows.Add("צגון", 2.6);
            table.Rows.Add("מחשבון מחמ", 0.35);
            table.Rows.Add("קלסר משק", 1.25);
            table.Rows.Add("מצפן", 0.08);
            table.Rows.Add("מטל", 0.15);
            table.Rows.Add("סוללת 91", 1.3);
            table.Rows.Add("סוללת אצבע", 0.3);
            table.Rows.Add("סוללת סאפט", 2.75);
            table.Rows.Add("סוללה מבצעית", 1.0);
            table.Rows.Add("סוללה ירוקה", 0.55);
            table.Rows.Add("מטען נייד", 0.15);
            table.Rows.Add("רדיו מילאנו", 1.0);
            table.Rows.Add("סוללת קשר", 0.35);
            table.Rows.Add("אולר", 0.35);
            table.Rows.Add("טלפון אדום", 0.45);
            table.Rows.Add("שוב", 6.35);
            table.Rows.Add("מכשיר קשר 710", 1.0);
            table.Rows.Add("סי אפ", 2.5);
            table.Rows.Add("מעד", 0.52);
            table.Rows.Add("מדונה", 0.25);
            table.Rows.Add("מגבר", 3.0);
            table.Rows.Add("בנכ 1.8", 0.15);
            table.Rows.Add("בנכ 3", 0.2);
            table.Rows.Add("בנכ 9", 0.65);
            table.Rows.Add("אנטנת לונג", 0.55);
            table.Rows.Add("מתאם קשיח", 0.2);
            table.Rows.Add("מתאם גמיש+אנטנה", 0.25);
            table.Rows.Add("אגס", 0.1);
            table.Rows.Add("תפוח", 0.1);
            table.Rows.Add("מפצל וואי", 0.2);
            //table.Rows.Add("חדפס", 3.0);
            //table.Rows.Add("חץ אור", 3.0);
            //table.Rows.Add("זנזיבר", 3.0);
            //table.Rows.Add("קשר 91", 3.0);
            //table.Rows.Add("שלדגון", 3.0);
            //table.Rows.Add("שדלן", 3.0);
            table.Rows.Add("משגיחונים 4 מצלמות", 3.0);
            table.Rows.Add("משגיחונים 4 חצובות", 3.0);
            table.Rows.Add("משגיחונים כבל 15 מטר", 3.0);
            table.Rows.Add("משגיחונים ק.פ", 3.0);
            table.Rows.Add("משגיחונים טאבלט", 3.0);
            table.Rows.Add("סוללה לאדום", 0.15);
            table.Rows.Add("גו פרו", 0.25);
table.Rows.Add("מוט ניצן", 1.25);
table.Rows.Add("טי וי סי", 1.45);
table.Rows.Add("פונצו נועה", 1.6);
table.Rows.Add("פונצו אמטרין", 1.05);
table.Rows.Add("  מוט ספ", 0.15);
table.Rows.Add(" 5 תולעים", 0.1);
table.Rows.Add("עומר", 5.15);
table.Rows.Add("ענבר", 0.8);
table.Rows.Add("פטיש 5", 5.535);
table.Rows.Add("פטיש קטן", 0.65);
table.Rows.Add("מסמרים רגילים 20", 0.1);
table.Rows.Add("15 מסמרים נפיצים", 0.05);
table.Rows.Add("פטיש מסמרים", 0.6);
table.Rows.Add("אריאל גיל", 9.5);
table.Rows.Add("סטיקלייט", 0.005);
table.Rows.Add("אזיקונים", 0.15);
table.Rows.Add("כוורת", 1.2);
table.Rows.Add("מכשפה", 0.45);
table.Rows.Add("יריעת החשכה", 0.95);
table.Rows.Add("רשת לול", 1.25);
table.Rows.Add("את חפירה", 1.55);
table.Rows.Add("שקי פקל10 ", 1.0);
table.Rows.Add("פקל ירך(2 מזמרות ו2 מסורים", 1.6);
table.Rows.Add("מזמרה", 0.25);
table.Rows.Add("ספריי צבע", 0.35);
table.Rows.Add("מסור", 0.25);
table.Rows.Add("תוף נגב", 2.7);
table.Rows.Add("מחסנית ", 0.45);
table.Rows.Add("רימון נפיץ", 0.45);
table.Rows.Add("רימון עשן", 0.45);
table.Rows.Add("תוף נגב 7", 4.5);
table.Rows.Add("תוף מאג", 0.395);
table.Rows.Add("מטול נפיץ", 0.23);
table.Rows.Add("מטול תאורה", 0.23);
table.Rows.Add("לאו", 3.63);
table.Rows.Add("מטאדור", 10.325);
table.Rows.Add(" קנספ נגב", 1.2);
table.Rows.Add("טסטר", 0.005);
table.Rows.Add("קנספ מאג", 2.7);
table.Rows.Add("קנספ נגב 7", 1.7);
table.Rows.Add("שרשיר הסתערות 80", 1.12);
table.Rows.Add("שחם", 0.35);
table.Rows.Add("עדי", 0.75);
table.Rows.Add("עידו", 0.75);
table.Rows.Add("מארז סוללות לעדי", 0.15);
table.Rows.Add("מארז סוללות לעידו", 0.15);
table.Rows.Add("פקל חובש/חובש", 4.0);
table.Rows.Add("מנשא אחד על אחד", 1.0);
table.Rows.Add("דף טריאג", 0.4);
table.Rows.Add("אווטה", 2.9);
table.Rows.Add("טאבלט", 0.95);
table.Rows.Add("טלפון אפור", 0.2);
table.Rows.Add("לבנת חבלה", 0.567);
//table.Rows.Add("מסגרת פריצה", 3.0);
//table.Rows.Add("מוט פריצה", 3.0);
//table.Rows.Add("מטר פתיל רועם", 3.0);
//table.Rows.Add("מטר פתיל השהייה", 3.0);
//table.Rows.Add("נונל 50", 3.0);
//table.Rows.Add("נונל 100", 3.0);
//table.Rows.Add("נונל 300", 3.0);
//table.Rows.Add("מצת קרבי", 3.0);
//table.Rows.Add("איזו", 3.0);
//table.Rows.Add("מצית", 3.0);
//table.Rows.Add("מטען רעם", 3.0);
//table.Rows.Add("נפץ קרבי", 3.0);
//table.Rows.Add("דוגידי", 3.0);
//table.Rows.Add("נפץ חשמלי", 3.0);
//table.Rows.Add("פריצה קרה", 3.0);
table.Rows.Add("פקל נקנש+שפצור", 0.95);
table.Rows.Add("בנדולרת אוכל", 3.0);


            // Store the table in session
            Session["ProductsTable"] = table;
        }

        private List<Tuple<string, double, int>> SelectedProducts
        {
            get
            {
                if (Session["SelectedProducts"] == null)
                {
                    Session["SelectedProducts"] = new List<Tuple<string, double, int>>();
                }
                return (List<Tuple<string, double, int>>)Session["SelectedProducts"];
            }
            set
            {
                Session["SelectedProducts"] = value;
            }
        }

        private List<Submission> Submissions
        {
            get
            {
                if (Session["Submissions"] == null)
                {
                    Session["Submissions"] = new List<Submission>();
                }
                return (List<Submission>)Session["Submissions"];
            }
            set
            {
                Session["Submissions"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProductsTable();
                BindProductsGrid();
                UpdateSummary();
                BindSubmissionsGrid(); // Ensure the submissions grid is bound on first load
            }
        }

        private void BindProductsGrid()
        {
            // Bind the products table to the GridView
            if (Session["ProductsTable"] != null)
            {
                gvProducts.DataSource = Session["ProductsTable"];
                gvProducts.DataBind();
            }
        }

        private void BindSelectedProductsGrid()
        {
            // Bind the selected products list to the GridView
            gvSelectedProducts.DataSource = SelectedProducts.Select(p => new
            {
                ProductName = p.Item1,
                ProductWeight = p.Item2,
                Amount = p.Item3,
                TotalWeight = p.Item2 * p.Item3
            }).ToList();
            gvSelectedProducts.DataBind();
        }

        protected void gvProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddProduct")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataTable products = Session["ProductsTable"] as DataTable;

                if (products != null && index >= 0 && index < products.Rows.Count)
                {
                    string productName = products.Rows[index]["ProductName"].ToString();
                    double productWeight = Convert.ToDouble(products.Rows[index]["ProductWeight"]);
                    GridViewRow row = gvProducts.Rows[index];
                    TextBox txtAmount = (TextBox)row.FindControl("txtAmount");
                    int amount = int.TryParse(txtAmount.Text, out var parsedAmount) ? parsedAmount : 1;

                    SelectedProducts.Add(Tuple.Create(productName, productWeight, amount));
                    BindSelectedProductsGrid();
                    UpdateSummary();
                }
            }
            else if (e.CommandName == "AddCustomProduct")
            {
                // Retrieve the footer row controls
                GridViewRow footerRow = gvProducts.FooterRow;
                TextBox txtNewProductName = (TextBox)footerRow.FindControl("txtNewProductName");
                TextBox txtNewProductWeight = (TextBox)footerRow.FindControl("txtNewProductWeight");
                TextBox txtNewProductAmount = (TextBox)footerRow.FindControl("txtNewProductAmount");

                // Retrieve the values from the footer row
                string customProductName = txtNewProductName.Text.Trim();
                bool isWeightValid = double.TryParse(txtNewProductWeight.Text, out double customProductWeight);
                bool isAmountValid = int.TryParse(txtNewProductAmount.Text, out int customProductAmount);

                // Validate inputs
                if (!string.IsNullOrEmpty(customProductName) && isWeightValid && customProductWeight > 0 && isAmountValid && customProductAmount > 0)
                {
                    // Add the custom product to SelectedProducts
                    SelectedProducts.Add(Tuple.Create(customProductName, customProductWeight, customProductAmount));
                    BindSelectedProductsGrid();
                    UpdateSummary();

                    // Clear the input fields
                    txtNewProductName.Text = "";
                    txtNewProductWeight.Text = "";
                    txtNewProductAmount.Text = "1";
                }
                else
                {
                    // Optionally, show an error message if input is invalid
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter valid product name, weight, and amount.');", true);
                }
            }
        }


        protected void gvSelectedProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "RemoveProduct")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                // Remove the selected product based on the index
                if (index >= 0 && index < SelectedProducts.Count)
                {
                    SelectedProducts.RemoveAt(index);
                    BindSelectedProductsGrid();
                    UpdateSummary();
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the name and weight from the text boxes
            string name = txtName.Text;
            double personWeight;

            // Check if the input values are valid
            if (double.TryParse(txtWeight.Text, out personWeight) && SelectedProducts.Any())
            {
                // Calculate total weight from selected products
                double totalWeight = SelectedProducts.Sum(p => p.Item2 * p.Item3);

                // Create a new submission
                Submission newSubmission = new Submission
                {
                    Name = name,
                    Weight = personWeight,
                    TotalWeight = totalWeight,
                    WeightPercentage = (totalWeight / personWeight) * 100,
                    SelectedProducts = string.Join(", ", SelectedProducts.Select(p => p.Item1 + " (x" + p.Item3 + ")"))
                };

                // Add the new submission to the list
                Submissions.Add(newSubmission);

                // Clear input fields
                txtName.Text = "";
                txtWeight.Text = "";

                // Clear selected products
                SelectedProducts.Clear();
                BindSelectedProductsGrid();

                // Rebind the submissions grid
                BindSubmissionsGrid();
                UpdateSummary();
            }
            else
            {
                // Optionally show an error message if inputs are invalid
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter valid name and weight, and select products.');", true);
            }
        }

        private void BindSubmissionsGrid()
        {
            // Bind the submissions list to the GridView
            gvSubmissions.DataSource = Submissions;
            gvSubmissions.DataBind();
        }

        private void UpdateSummary()
        {
            double totalWeight = SelectedProducts.Sum(p => p.Item2 * p.Item3);
            lblTotalWeight.Text = totalWeight.ToString();

            if (double.TryParse(txtWeight.Text, out double personWeight) && personWeight > 0)
            {
                double percentage = (totalWeight / personWeight) * 100;
                lblPercentage.Text = $"{percentage:F2}%";
            }
            else
            {
                lblPercentage.Text = "0%";
            }
        }

        protected void gvSubmissions_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "RemoveRow")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                // Remove the selected product based on the index
                if (rowIndex >= 0)
                {
                    Submissions.RemoveAt(rowIndex);
                    BindSubmissionsGrid();
                    UpdateSummary();
                }
            }
        }
    }
}
