using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_coursewk_
{




    public partial class VendingMachine : Form


    {


        public VendingMachine()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            listBoxitems.AllowDrop = true;

            pictureBox1.AllowDrop = true; // Allow the listboxproducts to be dropped in the picture
            
            PaymentSystem.Visible = false; // this is so the paysystem part odf the program doesn't show up when starting the program

            Coinslot.AllowDrop = true;//this Allows stuff to be dropped into the picture

            Tenpence.AllowDrop = true;// this allow the tenpence button to be dragged and dropped

           
        }



        // these are the prices of the products
        // i used double , so they can accept decimal number 

        double chocolatePrice = 0.75;
        double sweetsPrice = 0.5;
        double drinksPrice = 1.0;
        double CrispsPrice = 0.65;
        double OrderTotal = 0.0;






        private void buttonchocolate_Click(object sender, EventArgs e)
        {

   // this is where the chocolate button adds to the listbox once clicked

            listBoxitems.Items.Add(buttonchocolate.Text);

            //this is where the addition price of the chocolate will be added once clicked
            OrderTotal += chocolatePrice;
            OrderTotallabel.Text = " Order Total £ " + OrderTotal.ToString("0.00");
        }


        private void buttonsweets_Click(object sender, EventArgs e)
        {
            // this is where the sweet button adds to the listbox once clicked
            listBoxitems.Items.Add(buttonsweets.Text);
            //this is where the addition price of the sweets will be added once clicked
            OrderTotal += sweetsPrice;
            OrderTotallabel.Text = " Order Total £ " + OrderTotal.ToString("0.00");

        }


        private void buttondrinks_Click(object sender, EventArgs e)
        {
            // this is where the drinks button adds to the listbox once clicked
            listBoxitems.Items.Add(buttondrinks.Text);

            //this is where the addition price of the drinks will be added once clicked
            OrderTotal += drinksPrice;
            OrderTotallabel.Text = " Order Total £ " + OrderTotal.ToString("0.00");
        }


        private void buttoncrisps_Click(object sender, EventArgs e)
        {
            // this is where the crisps button adds to the listbox once clicked
            listBoxitems.Items.Add(buttoncrisps.Text);

            //this is where the addition price of the crisps will be added once clicked
            OrderTotal += CrispsPrice;
            OrderTotallabel.Text = " Order Total £ " + OrderTotal.ToString("0.00");
        }

        private void OrderTotallabel_Click(object sender, EventArgs e)
        {

        }

        // this allows the user to clear all the products in the list box or continue 
        private void ListBoxCancel_Click(object sender, EventArgs e)
        {
            DialogResult Keypressed;

            Keypressed = MessageBox.Show("Are you sure you would like to clear these items !", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Keypressed == DialogResult.Yes)
            {

                listBoxitems.Items.Clear();

                OrderTotallabel.Text = " Order Total £ ";
                OrderTotal = 0.00;

            }
            if (Keypressed == DialogResult.No)
            {
                return;
            }




        }




        private void listBoxitems_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        


            private void pictureBox1_Click(object sender, EventArgs e)
                    {

                    }



        // this is the drag or drop part of the program for the rubbish bin phtoto
        private void listBoxitems_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(listBoxitems, DragDropEffects.Copy);
        }




        private void pictureBox1DragEnter(object seinder, DragEventArgs e)
        { 

             if (listBoxitems.Items.Count >= 0)
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }



        }

        private void pictureBox1DragDrop(object sender, DragEventArgs e)
        {

            DialogResult Keypressed3;

            listBoxitems.Items.Remove(listBoxitems.Text);

            Keypressed3 = MessageBox.Show("you removed a item!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (Keypressed3 == DialogResult.OK)
            {
                OrderTotal -= listBoxitems.Items.Count;
                    OrderTotallabel.Text = " Order Total £ " + OrderTotal.ToString("0.00");




                //if ( == buttonchocolate.Text) {OrderTotal -= chocolatePrice;
                //    OrderTotallabel.Text = " Order Total £ " + OrderTotal.ToString("0.00"); }





            }



        }



        // this is the continue button in the first part of the programm.
        //this will allow the user to continue to the payemtsystem or stay in the first part and add more items 

        private void ContinueButton_Click(object sender, EventArgs e)
        {

            DialogResult Keypressed1;

            Keypressed1 = MessageBox.Show("Are you sure you would like to continue to the payment  !", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Keypressed1 == DialogResult.Yes)// here show the option if the user picks yes on the mussage box

            {
               

                PaymentSystem.Show();
                PaymentSystem.BringToFront();
                // if yes is picked, it will the disable everything button in the firstpart and the carry on to the payment system
                buttonchocolate.Enabled = false;
                buttoncrisps.Enabled = false;
                buttonsweets.Enabled = false;
                buttondrinks.Enabled = false;
                ListBoxCancel.Enabled = false;
                ContinueButton.Enabled = false;
                Checkout.Enabled = false;

                // here shows how much the user has spent before going on to the payment system
                MessageBox.Show("You spent £ " + Math.Round(OrderTotal, 2) + " on the vending machine , press any button to continue ! " , "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            {
                // if the user presses no , the  program will allow the user to return and add more products
                if (Keypressed1 == DialogResult.No)

                    return;
            }


        }
        
        
        
        
        
                   

        // here is just the price of the coins , so it can be allocated to a button
                                double tenprice = 0.1;
                                double twentyprice = 0.2;
                                double fiftyprice = 0.5;
                                double poundprice = 1.0;
                                double twopoundprice = 2.0;
                                double fivepoundprice = 5.0;
                         
             


        private void PaymentSystem_Enter(object sender, EventArgs e)
                          {



                         }


                        
        // here is the drag and drop of the 10 pence coin 

          private void Tenpence_Click(object sender, EventArgs e)

          { 
                           

         }

        private void Tenpence_MouseDown(object sender, MouseEventArgs e)
        {
            Coinslot.DoDragDrop(Tenpence, DragDropEffects.Copy);
        }




        private void CoinslotDragEnter(object seinder, DragEventArgs e)
        {
            
            if (Tenpence.Visible) 
            { 
                e.Effect = DragDropEffects.Copy;

            }
            else
            {// this is so that the drag and drop can only be dropped in a certain place
                e.Effect = DragDropEffects.None;
            }



        }

        private void CoinslotDragDrop(object sender, DragEventArgs e)
        {
            // once the coin in dropped in the picture , this is the action that tit should carry out
            OrderTotal -= tenprice;

            FinalTotallabel.Text = "To Pay £ " + OrderTotal.ToString("0.00");

            if (OrderTotal <= 0.0)
            {
                //this is a alert showing that the order has been paid and how much change you'll get afer the money you have put in
                MessageBox.Show("Your order has been paid.You have £ " + Math.Round(OrderTotal, 2) + " to be returned back to you ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                Tenpence.Enabled = false;
                twentypence.Enabled = false;
                fiftypence.Enabled = false;
                pound.Enabled = false;
                Twopound.Enabled = false;
                fivepound.Enabled = false;
                Checkout.Enabled = true;

            }
        }





                private void Coinslot_Click(object sender, EventArgs e)
               {

                     }















        private void twentypence_Click(object sender, EventArgs e)
        {
            OrderTotal -= twentyprice;

            FinalTotallabel.Text = "To Pay £ " + OrderTotal.ToString("0.00");

            if (OrderTotal <= 0.0)
            {
                MessageBox.Show("Your order has been paid.You have £ " + Math.Round(OrderTotal, 2) + " to be returned back to you ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                Tenpence.Enabled = false;
                twentypence.Enabled = false;
                fiftypence.Enabled = false;
                pound.Enabled = false;
                Twopound.Enabled = false;
                fivepound.Enabled = false;
                Checkout.Enabled = true;

            }





          }






        private void fiftypence_Click(object sender, EventArgs e)
                        {// this is where the the coins decrease from the total price 
                            OrderTotal -= fiftyprice;

                            FinalTotallabel.Text = "To Pay £ " + OrderTotal.ToString("0.00");

                             

                            if (OrderTotal <= 0.0)
                            {
                                MessageBox.Show("Your order has been paid.You have £ " + Math.Round(OrderTotal, 2) + " to be returned back to you ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Tenpence.Enabled = false;
                                twentypence.Enabled = false;
                                fiftypence.Enabled = false;
                                pound.Enabled = false;
                                Twopound.Enabled = false;
                                fivepound.Enabled = false;
                                Checkout.Enabled = true;
                            }

                        }




                        private void pound_Click(object sender, EventArgs e)

                        {   OrderTotal -= poundprice;

                            FinalTotallabel.Text = "To Pay £ " + OrderTotal.ToString("0.00");

                         
                            if (OrderTotal <= 0.00)
                            {
                                MessageBox.Show("Your order has been paid.You have £ " + Math.Round(OrderTotal, 2) + " to be returned back to you ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Tenpence.Enabled = false;
                                twentypence.Enabled = false;
                                fiftypence.Enabled = false;
                                pound.Enabled = false;
                                Twopound.Enabled = false;
                                fivepound.Enabled = false;
                                Checkout.Enabled = true;
                            }
                        }

                        private void Twopound_Click(object sender, EventArgs e)
                        {
                            OrderTotal -= twopoundprice;
                            FinalTotallabel.Text = "To Pay £ " + OrderTotal.ToString();


                            if (OrderTotal <= 0.00)
                            {
                                MessageBox.Show("Your order has been paid.You have £ " + Math.Round(OrderTotal, 2) + " to be returned back to you ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Tenpence.Enabled = false;
                                twentypence.Enabled = false;
                                fiftypence.Enabled = false;
                                pound.Enabled = false;
                                Twopound.Enabled = false;
                                fivepound.Enabled = false;
                                Checkout.Enabled = true;
                            }

                        }

                        private void fivepound_Click(object sender, EventArgs e)
                        { 
            
                              OrderTotal -= fivepoundprice;

                            FinalTotallabel.Text = "To Pay £ " + OrderTotal.ToString("0.00");

                            

                            if (OrderTotal <= 0.00)
                            {
                                MessageBox.Show("Your order has been paid.You have £ " + Math.Round(OrderTotal, 2) + " to be returned back to you ", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Tenpence.Enabled = false;
                                twentypence.Enabled = false;
                                fiftypence.Enabled = false;
                                pound.Enabled = false;
                                Twopound.Enabled = false;
                                fivepound.Enabled = false;
                                Checkout.Enabled = true;
                            }



                        }  
        
        
     











































        private void FinalTotallabel_Click(object sender, EventArgs e)
                                        {
                      


                                        }


        // this is the check out part of the paymentsystem , this only shows up once the order has been paid for
        private void Checkout_Click(object sender, EventArgs e)
        {
            // here is where where all the button at the start of the program are now getting enabled again ,as the programm is getting resetted
            MessageBox.Show("Thankyou for shopping , please collect your order at the bottom! ", "GOODBYE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            buttonchocolate.Enabled = true;
            buttoncrisps.Enabled = true;
            buttonsweets.Enabled = true;
            buttondrinks.Enabled = true;
            ListBoxCancel.Enabled = true;
            ContinueButton.Enabled = true;
            {// this helps reset everything back to 0 so the next user can use the product 
                listBoxitems.Items.Clear();
                FinalTotallabel.Text = "To Pay £ ";
                OrderTotallabel.Text = " Order Total £ ";
                OrderTotal = 0.00;
            }


            {
                Tenpence.Enabled = true;
                twentypence.Enabled = true;
                fiftypence.Enabled = true;
                pound.Enabled = true;
                Twopound.Enabled = true;
                fivepound.Enabled = true;

                Checkout.Enabled = true;

             
              


                PaymentSystem.Visible = false;

                
            
            }
            
        }


    }

     
}
