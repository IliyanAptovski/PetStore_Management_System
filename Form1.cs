using PetStore.Business;
using PetStore.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore
{
    public partial class PetStore : Form
    {
        List<Product> items = new List<Product>();
        public PetStore()
        {
            InitializeComponent();
        }

        // Change color on mouse hover
        private void homePageBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeMouseOnHoverColor(homePageBtn);
        }

        private void homePageBtn_MouseLeave(object sender, EventArgs e)
        {
            ReturnDefaultColor(homePageBtn);
        }

        private void catsPageBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeMouseOnHoverColor(catsPageBtn);
        }

        private void catsPageBtn_MouseLeave(object sender, EventArgs e)
        {
            ReturnDefaultColor(catsPageBtn);
        }

        private void dogsPageBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeMouseOnHoverColor(dogsPageBtn);
        }

        private void dogsPageBtn_MouseLeave(object sender, EventArgs e)
        {
            ReturnDefaultColor(dogsPageBtn);
        }

        private void parrotPageBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeMouseOnHoverColor(parrotPageBtn);
        }

        private void parrotPageBtn_MouseLeave(object sender, EventArgs e)
        {
            ReturnDefaultColor(parrotPageBtn);
        }

        private void ducksPageBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeMouseOnHoverColor(ducksPageBtn);
        }

        private void ducksPageBtn_MouseLeave(object sender, EventArgs e)
        {
            ReturnDefaultColor(ducksPageBtn);
        }

        // Category info
        private void homePageBtn_Click(object sender, EventArgs e)
        {
            categorylbl.Text = "Home";

            // Hide all elements
            TurnVisibleOff();
        }

        private void catsPageBtn_Click(object sender, EventArgs e)
        {
            // Initial pet info
            categorylbl.Text = "Cats";

            animalNameLbl.Text = "Bengal Cat";
            priceLbl.Text = "$6000.00";
            
            firstAnimalPlaceholderPB.Image = catsImageList.Images[0];
            secondAnimalPlaceholderPB.Image = catsImageList.Images[1];

            // Show all elements
            TurnVisibleOn();
        }

        private void dogsPageBtn_Click(object sender, EventArgs e)
        {
            // Initial pet info
            categorylbl.Text = "Dogs";

            animalNameLbl.Text = "Chihuahua";
            priceLbl.Text = "$800.00";

            firstAnimalPlaceholderPB.Image = dogsImageList.Images[0];
            secondAnimalPlaceholderPB.Image = dogsImageList.Images[1];

            // Show all elements
            TurnVisibleOn();
        }

        private void parrotPageBtn_Click(object sender, EventArgs e)
        {
            // Initial pet info
            categorylbl.Text = "Parrots";

            animalNameLbl.Text = "Black Headed \nAique";
            priceLbl.Text = "$800.00";

            firstAnimalPlaceholderPB.Image = parrotsImageList.Images[0];
            secondAnimalPlaceholderPB.Image = parrotsImageList.Images[1];

            // Show all elements
            TurnVisibleOn();
        }

        private void ducksPageBtn_Click(object sender, EventArgs e)
        {
            // Initial pet info
            categorylbl.Text = "Ducks";

            animalNameLbl.Text = "Bali Duck";
            priceLbl.Text = "$200.00";

            firstAnimalPlaceholderPB.Image = ducksImageList.Images[0];
            secondAnimalPlaceholderPB.Image = ducksImageList.Images[1];

            // Show all elements
            TurnVisibleOn();
        }

        private void PetStore_Load(object sender, EventArgs e)
        {
            // Drawing ellipse type picture box

            System.Drawing.Drawing2D.GraphicsPath obj1 = new System.Drawing.Drawing2D.GraphicsPath();
            obj1.AddEllipse(0, 0, firstAnimalPlaceholderPB.Width - 10, firstAnimalPlaceholderPB.Height);
            Region rg1 = new Region(obj1);
            firstAnimalPlaceholderPB.Region = rg1;

            // Drawing second ellipse type picture box
            System.Drawing.Drawing2D.GraphicsPath obj2 = new System.Drawing.Drawing2D.GraphicsPath();
            obj2.AddEllipse(0, 0, secondAnimalPlaceholderPB.Width - 10, secondAnimalPlaceholderPB.Height);
            Region rg2 = new Region(obj2);
            secondAnimalPlaceholderPB.Region = rg2;
        }

        // Change color on mouse hover
        private void nextPetBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeMouseOnHoverColor(nextPetBtn);
        }

        private void nextPetBtn_MouseLeave(object sender, EventArgs e)
        {
            ReturnDefaultColor(nextPetBtn);
        }

        //Image and pet info change
        int imageIndex = 0;
        private void nextPetBtn_Click(object sender, EventArgs e)
        {
            if (imageIndex < 2)
            {
                imageIndex++;
                if (categorylbl.Text == "Cats")
                {

                    firstAnimalPlaceholderPB.Image = catsImageList.Images[imageIndex];
                    if (imageIndex == 0)
                    {
                        animalNameLbl.Text = "Bengal Cat";
                        priceLbl.Text = "$6000.00";
                    }
                    if (imageIndex == 1)
                    {
                        animalNameLbl.Text = "Persian Cat";
                        priceLbl.Text = "$1300.00";
                    }
                    if (imageIndex == 2)
                    {
                        animalNameLbl.Text = "Abyssinian Cat";
                        priceLbl.Text = "$300.00";
                    }

                    //Index Check
                    if (imageIndex == 2)
                    {
                        imageIndex = -1;
                    }
                    secondAnimalPlaceholderPB.Image = catsImageList.Images[imageIndex + 1];
                }

                if (categorylbl.Text == "Dogs")
                {
                    firstAnimalPlaceholderPB.Image = dogsImageList.Images[imageIndex];
                    if (imageIndex == 0)
                    {
                        animalNameLbl.Text = "Chihuahua";
                        priceLbl.Text = "$800.00";
                    }
                    if (imageIndex == 1)
                    {
                        animalNameLbl.Text = "Golden Retriever";
                        priceLbl.Text = "$2500.00";
                    }
                    if (imageIndex == 2)
                    {
                        animalNameLbl.Text = "Staffordshire Bull\nTerrier";
                        priceLbl.Text = "$2000.00";
                    }

                    //Index Check
                    if (imageIndex == 2)
                    {
                        imageIndex = -1;
                    }
                    secondAnimalPlaceholderPB.Image = dogsImageList.Images[imageIndex + 1];
                }

                if (categorylbl.Text == "Parrots")
                {
                    firstAnimalPlaceholderPB.Image = parrotsImageList.Images[imageIndex];
                    if (imageIndex == 0)
                    {
                        animalNameLbl.Text = "Black Headed \nAique";
                        priceLbl.Text = "$800.00";
                    }
                    if (imageIndex == 1)
                    {
                        animalNameLbl.Text = "Blue Amazon \nParrot";
                        priceLbl.Text = "$4000.00";
                    }
                    if (imageIndex == 2)
                    {
                        animalNameLbl.Text = "Conure Parrot";
                        priceLbl.Text = "$3000.00";
                    }

                    //Index Check
                    if (imageIndex == 2)
                    {
                        imageIndex = -1;
                    }
                    secondAnimalPlaceholderPB.Image = parrotsImageList.Images[imageIndex + 1];
                }

                if (categorylbl.Text == "Ducks")
                {
                    firstAnimalPlaceholderPB.Image = ducksImageList.Images[imageIndex];
                    if (imageIndex == 0)
                    {
                        animalNameLbl.Text = "Bali Duck";
                        priceLbl.Text = "$200.00";
                    }
                    if (imageIndex == 1)
                    {
                        animalNameLbl.Text = "Khaki Campbell \nDuck";
                        priceLbl.Text = "$30.00";
                    }
                    if (imageIndex == 2)
                    {
                        animalNameLbl.Text = "Silver Bantam \nDuck";
                        priceLbl.Text = "$80.00";
                    }

                    //Index Check
                    if (imageIndex == 2)
                    {
                        imageIndex = -1;
                    }
                    secondAnimalPlaceholderPB.Image = ducksImageList.Images[imageIndex + 1];
                }

            }

            
        }

        // Change order amount
        private void increaseBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(amountLbl.Text) < 9)
            {
                amountLbl.Text = (int.Parse(amountLbl.Text) + 1).ToString();
            } 
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(amountLbl.Text) > 1)
            {
                amountLbl.Text = (int.Parse(amountLbl.Text) - 1).ToString();
            }  
        }

        
        private void shoppingBagBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of ShoppingCart form
            ShoppingCart shoppingCart = new ShoppingCart();

            // Transfer pet data
            shoppingCart.GetProducts = items;
            shoppingCart.ShowDialog();

            items.Clear();
        }

        // Add product to list
        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            // Trim price text
            decimal price = decimal.Parse(priceLbl.Text.Substring(1, priceLbl.Text.IndexOf(".", StringComparison.Ordinal) - 1));

            // Create new product
            Product product = new Product(animalNameLbl.Text, price, int.Parse(amountLbl.Text));

            items.Add(product);
        }

        // Show all elements
        private void TurnVisibleOn()
        {
            backgroundPictureBox.Visible = false;
            homePageTextLbl.Visible = false;
            homePageLineLbl.Visible = false;
            firstAnimalPlaceholderPB.Visible = true;
            secondAnimalPlaceholderPB.Visible = true;
            priceLbl.Visible = true;
            addToCartBtn.Visible = true;
            nextPetBtn.Visible = true;
            lineLbl.Visible = true;
            animalNameLbl.Visible = true;
            increaseBtn.Visible = true;
            decreaseBtn.Visible = true;
            amountLbl.Visible = true;
        }

        // Methods

        // Hide all elements
        private void TurnVisibleOff()
        {
            backgroundPictureBox.Visible = true;
            homePageTextLbl.Visible = true;
            homePageLineLbl.Visible = true;
            firstAnimalPlaceholderPB.Visible = false;
            secondAnimalPlaceholderPB.Visible = false;
            priceLbl.Visible = false;
            addToCartBtn.Visible = false;
            nextPetBtn.Visible = false;
            lineLbl.Visible = false;
            animalNameLbl.Visible = false;
            increaseBtn.Visible = false;
            decreaseBtn.Visible = false;
            amountLbl.Visible = false;
        }

        private void ChangeMouseOnHoverColor(Button button)
        {
            button.BackColor = Color.FromArgb(200, 157, 57);
            button.ForeColor = Color.White;
        }

        private void ReturnDefaultColor(Button button) 
        {
            button.BackColor = Color.FromArgb(27, 29, 43);
            button.ForeColor = Color.FromArgb(200, 157, 57);
        }
    }
}
