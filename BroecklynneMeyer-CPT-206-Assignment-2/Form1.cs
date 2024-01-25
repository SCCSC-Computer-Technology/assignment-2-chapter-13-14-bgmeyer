using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroecklynneMeyer_CPT_206_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create data context object
            ProductDBDataContext db = new ProductDBDataContext();
            //get all the Product objects from the Products collection
            var results = from product in db.Products
                          select product;
            //assign results of query to DataGridView control
            productDataGridView.DataSource = results;
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            maxPriceLabel.Visible = false;
            minPriceLabel.Visible = false;
            maxPriceTextBox.Visible = false;
            minPriceTextBox.Visible = false;
            moreThanRadioButton.Visible = false;
            lessThanRadioButton.Visible = false;
            moreNumTextBox.Visible = false;
            lessNumTextBox.Visible = false;
            productNumRadioButton.Visible = true;//show product number radio button as product search option
            productDescriptionRadioButton.Visible = true;//show product description radio button as product search option
        }

        private void productNumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productDescriptionTextBox.Visible = false;//remove product desc text box
            productNumTextBox.Visible = true;//make text box for searching products by product number visible

        }

        private void productDescriptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productNumTextBox.Visible = false;//remove product num text box
            productDescriptionTextBox.Visible = true;//make text box for searching products by product description visible

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ProductDBDataContext db = new ProductDBDataContext();//create data context object
            if (productNumRadioButton.Checked)
            {
                string productNum = productNumTextBox.Text;//variable for product num input
                var results = from product in db.Products//query product num from data
                              where product.Product_Number.Contains(productNum)
                              select product;
                productDataGridView.DataSource = results;//display query results in data grid
            }
            else if (productDescriptionRadioButton.Checked)
            {
                string productDesc = productDescriptionTextBox.Text;//variable for product description input
                var results = from product in db.Products//query product desc from data
                              where product.Description.Contains(productDesc)
                              select product;
                productDataGridView.DataSource = results;//display query results in data grid
               
            }
            else if (moreThanRadioButton.Checked)
            {
                int more;
                if(int.TryParse(moreNumTextBox.Text, out more))
                {
                    var results = from product in db.Products//query units on hand
                                  where product.Units_On_Hand > more
                                  orderby product.Units_On_Hand
                                  select product;
                    productDataGridView.DataSource = results;//display query results
                }
                else
                {
                    MessageBox.Show("Error! Please enter whole number.");//error message bad input
                    moreNumTextBox.Text = "";//clear bad input
                }

            }
            else if (lessThanRadioButton.Checked)
            {
                int less;
                if (int.TryParse(lessNumTextBox.Text, out less))
                {
                    var results = from product in db.Products//query units on hand
                                  where product.Units_On_Hand < less
                                  orderby product.Units_On_Hand
                                  select product;
                    productDataGridView.DataSource = results;//display query results
                }
                else
                {
                    MessageBox.Show("Error! Please enter whole number.");//error message bad input
                    lessNumTextBox.Text = "";//clear bad input
                }
            }
            else
            {
                decimal max, min;
                if (decimal.TryParse(maxPriceTextBox.Text, out max))
                {
                    if(decimal.TryParse(minPriceTextBox.Text, out min))
                    {
                        var results = from product in db.Products//query price range
                                      where product.Price < max && product.Price > min
                                      orderby product.Price
                                      select product;
                        productDataGridView.DataSource = results;//display query results

                    }
                    else
                    {
                        MessageBox.Show("Error. Please enter decimal number for min price.");//error message
                        minPriceTextBox.Text = "";//clear bad input
                    }
                }
                else
                {
                    MessageBox.Show("Error. Please enter decimal number for max price.");//error message
                    maxPriceTextBox.Text = "";//clear bad input
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();//close form
        }

        private void unitsButton_Click(object sender, EventArgs e)
        {
            maxPriceLabel.Visible = false;
            minPriceLabel.Visible = false;
            maxPriceTextBox.Visible = false;
            minPriceTextBox.Visible = false;
            productNumRadioButton.Visible = false;
            productDescriptionRadioButton.Visible = false;
            productNumTextBox.Visible = false;
            productDescriptionTextBox.Visible = false;
            moreThanRadioButton.Visible = true;
            lessThanRadioButton.Visible = true;
            ProductDBDataContext db = new ProductDBDataContext();//create data context object
            var results = from product in db.Products//query for units ascending
                          orderby product.Units_On_Hand
                          select product;
            productDataGridView.DataSource = results;//assign results of query to DataGridView control
        }

        private void moreThanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lessNumTextBox.Visible = false;
            moreNumTextBox.Visible = true;
        }

        private void lessThanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            moreNumTextBox.Visible = false;
            lessNumTextBox.Visible = true;
        }

        private void priceRangeButton_Click(object sender, EventArgs e)
        {
            maxPriceLabel.Visible = true;
            minPriceLabel.Visible = true;
            maxPriceTextBox.Visible = true;
            minPriceTextBox.Visible = true;

            productNumRadioButton.Visible = false;
            productDescriptionRadioButton.Visible = false;
            productNumTextBox.Visible = false;
            productDescriptionTextBox.Visible = false;
            moreThanRadioButton.Visible = false;
            moreNumTextBox.Visible = false;
            lessThanRadioButton.Visible = false;
            lessNumTextBox.Visible = false;
            ProductDBDataContext db = new ProductDBDataContext();//create data context object
            var results = from product in db.Products//query for units ascending
                          orderby product.Price
                          select product;
            productDataGridView.DataSource = results;//assign results of query to DataGridView control
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Form1 NewForm1 = new Form1();
            NewForm1.Show();
            this.Dispose(false);
        }
    }
}
