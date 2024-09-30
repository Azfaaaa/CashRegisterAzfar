using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegisterAzfar
{
    public partial class Form1 : Form
    {
        //product related variables
        double wrapPrice = 5.59;
        double wrapAmount;
        double poutinePrice = 5.99;
        double poutineAmount;
        double friesPrice = 3.39;
        double friesAmount;
        //payment related variables
        double subtotal;
        double total;
        
        double taxAmount;
        double taxRate = 0.13;
        
        double tendered;
        double change;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //catch in case of input error
            try
            {
                //converting input to doubles
                wrapAmount = Convert.ToDouble(wrapInput.Text);
                poutineAmount = Convert.ToDouble(poutineInput.Text);
                friesAmount = Convert.ToDouble(friesInput.Text);
                //calculating costs
                subtotal = (wrapAmount * wrapPrice) + (friesAmount * friesPrice) + (poutineAmount * poutinePrice);
                taxAmount = taxRate * subtotal;
                total = subtotal + taxAmount;
                //outputting amount
                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";

                changeButton.Enabled = true;
            }
            //in case of input error
            catch
            {
                subtotalOutput.Text = "Input error";
                taxOutput.Text = "Try again";
                totalOutput.Text = "but properly this time";
                wrapInput.Text = "";
                poutineInput.Text = "";
                friesInput.Text = "";
                changeButton.Enabled = false;
            }
            }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                if (tendered < total)
                {
                    //in case of there not being enough chage
                    changeOutput.Text = "not enough bozo";
                }
                else
                {
                    //calculating change
                    change = tendered - total;
                    changeOutput.Text = change.ToString("C");
                    receiptButton.Enabled = true;
                }
            }
            catch
            {
                //in case of incorrect input
                changeOutput.Text = "input error\ndo it right this time";
                tenderedInput.Text = "";
                receiptButton.Enabled = false;
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //printing the receipt
            SoundPlayer printsound = new SoundPlayer(Properties.Resources._495891__volpone__supermarket_checkout_cash_register_till_receipt_printout_and_change);
            printsound.Play();
            receiptButton.Enabled = false;
            receiptOutput.Text = "BIG D'S SHAWARMA\n         ----------------          ";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += "\n\nORDER NUMBER XXX";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += "\nNOVEMBER 8, 2008";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n\nWRAP     X{wrapAmount}   ${wrapPrice}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nPOUTINE  X{poutineAmount}   ${poutinePrice}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nFRIES    X{friesAmount}   ${friesPrice}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n\nSUBTOTAL       ${subtotal}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nTAX           {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nTOTAL          {total.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n\nTENDERED        {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nCHANGE         {change.ToString("C")}";
            Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += "\n\nTHANK YOU FOR YOUR PATRONAGE";

        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            wrapInput.Text = "";
            poutineInput.Text = "";
            friesInput.Text = "";
            subtotalOutput.Text = "0";
            taxOutput.Text = "0";
            totalOutput.Text = "0";
            tenderedInput.Text = "";
            changeButton.Enabled = false;
            changeOutput.Text = "0";
            receiptButton.Enabled = false;
            receiptOutput.Text = ".";
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = "woww you found the easter egg";
            Refresh();
            Thread.Sleep(2000);
            receiptOutput.Text = ".";
        }
    }
}
