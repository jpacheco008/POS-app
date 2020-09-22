using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_app.Models;

using System.Data.SqlClient;

namespace POS_app
{
    public partial class Form1 : Form
    {
      
        List<Product> ProductList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Product goyza = new Product();
            goyza.ProductId = 1;
            goyza.ProductName = "Goyza";
            goyza.Price = 5.00M;
            MessageBox.Show(ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product ninja = new Product();
            ninja.ProductId = 2;
            ninja.ProductName = "Ninja Roll";
            ninja.Price = 8.00M;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product dragon = new Product();
            dragon.ProductId = 3;
            dragon.ProductName = "Dragon Roll";
            dragon.Price = 8.00M;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product bocao = new Product();
            bocao.ProductId = 4;
            bocao.ProductName = "Bocao Sushi Roll";
            bocao.Price = 10.00M;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product tres = new Product();
            tres.ProductId = 5;
            tres.ProductName = "Tres Leches Cake";
            tres.Price = 6.00M;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Product lava = new Product();
            lava.ProductId = 6;
            lava.ProductName = "Lava Cake";
            lava.Price = 6.00M;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Product water = new Product();
            water.ProductId = 7;
            water.ProductName = "Water";
            water.Price = 0.00M;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Product soda = new Product();
            soda.ProductId = 8;
            soda.ProductName = "Soft Drink";
            soda.Price = 1.00M;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Product beer = new Product();
            beer.ProductId = 9;
            beer.ProductName = "Beer";
            beer.Price = 3.00M;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Product wine = new Product();
            wine.ProductId = 10;
            wine.ProductName = "Wine";
            wine.Price = 3.00M;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Product cocktail = new Product();
            cocktail.ProductId = 11;
            cocktail.ProductName = "Cocktail";
            cocktail.Price = 5.00M;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Product shot = new Product();
            shot.ProductId = 1;
            shot.ProductName = "Shot";
            shot.Price = 5.00M;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string orderName = textBox1.ToString();
        }

        //
    }
}

