using HurMangaVersaler.Model; // masdasdhuidash
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HurMangaVersaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        TextAnalyzer textAnalyze = new TextAnalyzer();
        protected void count_Click(object sender, EventArgs e)
        {
            if (count.Text != "rensa")
            {
                int numberOfCapitals = textAnalyze.GetNumberOfCapitals(inputTextBox.Text);
                resultLabel.Text = string.Format("Texten innehåller {0} versaler!", numberOfCapitals);
                count.Text = "rensa";
                inputTextBox.Enabled = false;
            }
            else
            {
                count.Text = "Räkna versaler!";
                resultLabel.Text = "";
                inputTextBox.Text = "";
                inputTextBox.Enabled = true;
            }
        }
    }
}