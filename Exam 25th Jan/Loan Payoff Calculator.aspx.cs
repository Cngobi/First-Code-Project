using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double loan = Convert.ToDouble(TextBox1.Text);
        double interestRate = Convert.ToDouble(TextBox2.Text);
        double MonthlyPayment = Convert.ToDouble(TextBox3.Text); // Converts the value to a double-precision floating-point number
        for (int year = 1; loan >= 0; year++) // Setting the outer loop for the year count 
        {  
            Label1.Text += "<strong>Year: </strong>" + "<strong>" + Convert.ToString(year) + "</strong>" + "<br />"; // This line of code will generate the year count/value
            for (int month = 1; loan >= 0 & month < 13; month++) // Setting the for loop for months up to the 12th month
            {
                double LeftOver = loan * interestRate / 100 + loan;
                loan += loan * interestRate / 100 - MonthlyPayment; // Here are the equations to calculate the loan payoff
                loan = Math.Round(loan, 2);   // Rounding the value to 2 decimal places

                    if (loan <= 0) // This loop generates when the amount reaches £0.00
                    {
                        Label1.Text += "Month " + month.ToString() + " => £ " + "0.00" + "<br />"; // This line of code will be displayed when the amount reaches £0.00 
                        Label1.Text += "Last Payment: £" + LeftOver.ToString("F2"); // This line of code will display the final payment amount

                        break; // This causes the loop to be terminated and will continue onto the next label
                    }

                Label1.Text += "Month " + month.ToString() + " => £ " + loan.ToString("F2") + "<br />"; // If the final value is not <=0, this label will be presented and show the value for each month         
            }
        }
    }
}