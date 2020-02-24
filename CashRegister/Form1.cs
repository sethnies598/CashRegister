using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //global variables
        int numberofSwords;
        int numberofShields;
        int numberofSoA;
        int billPressed = 0;
        int changePressed = 0;

        const double taxPercent = 0.13;
        const double priceS = 55.00;
        const double priceSH = 40.00;
        const double priceSoA = 100.00;

        double totalPrice, subTotal, tax, Tendered, Change;
        //double subTotal;
        //double tax;
        //double Tendered;
        //double Change;


        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //changing background colour
            this.BackColor = Color.AntiqueWhite;

            //changing what the labels say
            ShopName.Text = "Ye Olde BlackSmith Shoppe";
            swordLabel.Text = "The sharpest swords in the world!";
            shieldLabel.Text = "The strongest shields in the land!";
            SoALabel.Text = "The shiniest suits in the universe!";

            //changing what the other labels say
            amountS.Text = "Number of Items Ordered:";
            amountSH.Text = "Number of Items Ordered:";
            amountSoA.Text = "Number of Items Ordered:";

            //changing the text on the buttons
            totalCost.Text = "Scribe Bill";
            changeButton.Text = "Shillings Due";
            printReciept.Text = "Scribe Reciept";

            bill.Text = " ";

            newOrder.Hide();
        }

        private void TotalCost_Click(object sender, EventArgs e)
        {
            //if all the amounts are blank, you will be asked to enter an amount
            if (numberS.Text == "" && numberSH.Text == "" && numberSoA.Text == "")
            {
                bill.Font = new Font("Lydian Csv BT", 12, FontStyle.Bold);
                bill.Text = "Please Enter an Amount";
            }
            else
            {
                //if all info is entered, the bill will be written
                try
                {
                    //if there is nothing enetered, the amount will be zero
                    if (numberS.Text == "")
                    {
                        numberS.Text = "0";
                    }
                    if (numberSH.Text == "")
                    {
                        numberSH.Text = "0";
                    }
                    if (numberSoA.Text == "")
                    {
                        numberSoA.Text = "0";
                    }


                    //increasing the number of times the button was pressed
                    billPressed++;

                    //converting the text box to an integer variable
                    numberofShields = Convert.ToInt16(numberSH.Text);
                    numberofSwords = Convert.ToInt16(numberS.Text);
                    numberofSoA = Convert.ToInt16(numberSoA.Text);


                    //doing the calculations
                    subTotal = numberofShields * priceSH + numberofSwords * priceS + numberofSoA * priceSoA;

                    tax = taxPercent * subTotal;

                    totalPrice = subTotal + tax;

                    //printing the bill
                    bill.Font = new Font("Lydian Csv BT", 8, FontStyle.Regular);
                    bill.Text = "Number of Swords Ordered: " + numberofSwords + "    " + "at " + priceS.ToString("C");
                    bill.Text += "\nNumber of Shields Ordered: " + numberofShields + "    " + "at " + priceSH.ToString("C");
                    bill.Text += "\nNumber of Suits Ordered: " + numberofSoA + "    " + "at " + priceSoA.ToString("C");
                    bill.Text += "\n\nSub Total:   " + subTotal.ToString("C");
                    bill.Text += "\nTax:   " + tax.ToString("C");
                    bill.Text += "\n\nTotal:   " + totalPrice.ToString("C");


                //if one thing is entered wrong, the bill label will have this message
                catch
                {
                    bill.Font = new Font("Lydian Csv BT", 12, FontStyle.Bold);
                    bill.Text = "Please Enter Correct Info";

                }

            }
            if (totalPrice < 0)
            {
                bill.Font = new Font("Lydian Csv BT", 12, FontStyle.Bold);
                bill.Text = "Cannot Buy Negative Amounts";
            }

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //converting text box to integer
                Tendered = Convert.ToDouble(tenderedAmount.Text);

                //if all info is entered right, the change label will be written
                if (billPressed > 0 && Tendered > totalPrice)
                {
                    try
                    {
                        //increasing the number of times the button was pressed
                        changePressed++;


                        //doing the math
                        Change = Tendered - totalPrice;

                        //changing the text in the change label
                        changeLabel.Font = new Font("Lydian Csv BT", 8, FontStyle.Regular);
                        changeLabel.Text = "Amount Tendered:   " + Tendered.ToString("C");
                        changeLabel.Text += "\nChange Due:   " + Change.ToString("C");
                    }

                    //error message will be diplayed if the info is wrong
                    catch
                    {
                        changeLabel.Font = new Font("Lydian Csv BT", 12, FontStyle.Bold);
                        changeLabel.Text = "Please Enter an Available Amount";
                    }
                }

                else
                {
                    changeLabel.Font = new Font("Lydian Csv BT", 12, FontStyle.Bold);
                    changeLabel.Text = "Please Enter Correct Amounts";
                }
            }

            catch
            {
                changeLabel.Font = new Font("Lydian Csv BT", 12, FontStyle.Bold);
                changeLabel.Text = "Please Enter Correct Amounts";
            }
        }

        private void SwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrintReciept_Click(object sender, EventArgs e)
        {
            SoundPlayer print = new SoundPlayer(Properties.Resources.print);

            //if both the previous buttons have been pressed. then the reciept will print
            //delay between each line to simulate printing
            if (billPressed > 0 && changePressed > 0 && changeLabel.Text != "Please Enter Above Amounts" &&
                bill.Text != "Please Enter Correct Info" && bill.Text != "Please Enter Correct Info")
            {
                reciept.Text = "Number of Swords Ordered: " + numberofSwords + "    " + "at " + priceS.ToString("C");
                print.Play();
                reciept.Refresh();
                Thread.Sleep(300);

                reciept.Text += "\nNumber of Shields Ordered: " + numberofShields + "    " + "at " + priceSH.ToString("C");
                reciept.Refresh();
                Thread.Sleep(300);

                reciept.Text += "\nNumber of Suits Ordered: " + numberofSoA + "    " + "at " + priceSoA.ToString("C");
                reciept.Refresh();
                Thread.Sleep(600);

                reciept.Text += "\n\nSub Total:   " + subTotal.ToString("C");
                print.Play();
                reciept.Refresh();
                Thread.Sleep(300);

                reciept.Text += "\nTax:   " + tax.ToString("C");
                reciept.Refresh();
                Thread.Sleep(600);

                reciept.Text += "\n\nTotal:   " + totalPrice.ToString("C");
                print.Play();
                reciept.Refresh();
                Thread.Sleep(600);

                reciept.Text += "\n\nAmount Tendered:   " + Tendered.ToString("C");
                reciept.Refresh();
                Thread.Sleep(300);

                reciept.Text += "\nChange Due:   " + Change.ToString("C");
                print.Play();
                reciept.Refresh();
                Thread.Sleep(600);

                reciept.Text += "\n\nHave a Pleasent Battle! ;)";
                reciept.Refresh();
                Thread.Sleep(600);

                reciept.Text += "\n\nSponsored by Potion Seller's Potions";
                print.Play();
                reciept.Refresh();
                Thread.Sleep(600);

                reciept.Text += "\n\nP.S If you win, you owe me";

                newOrder.Show();

            }

            //if the previous buttons haven't been pressed, the reciept will ask you to enter info and press the buttons
            else
            {
                reciept.Text = "Please Enter the Information Required";
            }
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            //changing all the labels back to saying nothing
            reciept.Text = " ";
            changeLabel.Text = " ";
            bill.Text = " ";

            numberS.Text = " ";
            numberSH.Text = " ";
            numberSoA.Text = " ";
            tenderedAmount.Text = " ";

            //changing all the amounts back to the original no value
            Tendered = 0;
            Change = 0;
            numberofSwords = 0;
            numberofShields = 0;
            numberofSoA = 0;
            subTotal = 0;
            tax = 0;
            totalPrice = 0;
            billPressed = 0;
            changePressed = 0;

            newOrder.Hide();
        }
    }
}
