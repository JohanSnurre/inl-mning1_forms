using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlämningsuppgift1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_answer.Text = "Lägg in både pris och betalning \n i textlådorna till vänster";
        }



        private static int[] currencies = new int[7] { 500, 100, 50, 20, 10, 5, 1 };    //An array containing the currencies in a decreasing order
        private static string[] nameOfValuesPlur = new string[7] { "femhundralappar", "hundralappar", "femtiolappar", "tjugolappar", "tiokronor", "femkronor", "enkronor" };     //Names for the currencies in plural
        private static string[] nameOfValuesSing = new string[7] { "femhundralapp", "hundralapp", "femtiolapp", "tjugolapp", "tiokrona", "femkrona", "enkrona" };          //Names for the currencies in singular
        
        private void txtBox_price_TextChanged(object sender, EventArgs e)
        {
            
            int price;                                              //max size for price is 2^31 -1
            try
            {                                                   //Testing that the user actually gives some amount of money
                price = Int32.Parse(txtBox_price.Text);                      //Converting the input string to an int
            }
            catch (Exception err)
            {
                if (txtBox_price.Text.Equals(""))
                {
                    lbl_answer.Text = "Vänligen skriv in en summa pengar i respektive ruta";
                    return;
                }
                lbl_answer.Text = "Någon av rutorna har en ogiltig summa med pengar";
                return; 
            }

            if (price == 0)                                         //If the item is free, they  shouldn't have to pay anything
            {
                lbl_answer.Text = "Ta det, det är gratis";
                return;
            }
            else if (price < 0)                                     //If the item has a negative cost, the buyer receives money for taking it
            {
                lbl_answer.Text = "Ta det, det är gratis. Och ta också " + -price + " kr";
                return;
            }
            procedure();                                          //Returns the price

        }

        private void txtBox_paid_TextChanged(object sender, EventArgs e)
        {
            

            int paid;                                           //max size for paid is 2^31 -1
            try
            {                                                   //Checks that the input is valid
                paid = Int32.Parse(txtBox_paid.Text);
            }
            catch (Exception err)
            {
                if (txtBox_paid.Text.Equals(""))
                {
                    lbl_answer.Text = "Vänligen skriv in en summa pengar i respektive ruta";
                    return;
                }
                lbl_answer.Text = "Någon av rutorna har en ogiltig summa med pengar";
               
            }

            procedure();                                      //Returns the payment

        }

        private void procedure()                             //I know that this is a bad name for the function, but i couldn't come up with a better one
        {
            lbl_answer.Text = "";
            int price = Int32.Parse(txtBox_price.Text);
            if (price == 0 || price < 0) return;                    //The program shouldn't continue if the item is free of charge
            int paid = Int32.Parse(txtBox_paid.Text);
            if (paid < price)                                        //If the given payment is too low, tell customer that
            {
                lbl_answer.Text = "Ledsen, men du har inte tillräckligt med pengar";
                return;
            }

            int difference = paid - price;
            int[] resultingAmount = new int[7];                     //store the amount of each value in a new array
            lbl_answer.Text = "Växel tillbaka: \n";
            for (int i = 0; i < resultingAmount.Length; i++)        //Loop through each of the currencies and remove as many as possible of those from the difference
            {                                                       //Add the amount of removed currencies to the resultingAmount array
                
                while (difference - currencies[i] >= 0)
                {
                    resultingAmount[i]++;
                    difference -= currencies[i];
                }
                if (resultingAmount[i] == 0) continue;              //If the amount of a certain value is 0, it is not printed out

                //Print out the resulting amount of currencies with the correct grammar
                if (resultingAmount[i] > 1) lbl_answer.Text += resultingAmount[i] + " " + nameOfValuesPlur[i] + "\n";
                else lbl_answer.Text += resultingAmount[i] + " " + nameOfValuesSing[i] + "\n";

            }




        }

        private void lbl_answer_Click(object sender, EventArgs e)
        {

        }
    }
}
