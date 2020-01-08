using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Store storeshop = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public Form1()
        {
            InitializeComponent();
            SetUpData();

            itemsBinding.DataSource = storeshop.item.Where(x => x.sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = storeshop.vendors;
            vendorsListbox.DataSource = vendorsBinding;

            vendorsListbox.DisplayMember = "Display1";
            vendorsListbox.ValueMember = "Display1";
        }
        private void SetUpData()
        {
            storeshop.vendors.Add(new Vendor { firstName = "Mezdrea", lastName = "Daiana"});
            storeshop.vendors.Add(new Vendor { firstName = "Ursu", lastName = "Maria"});

            storeshop.item.Add(new Item
            {
                title = "Rochita",
                descriprion = "Rosie",
                price = 500,
                owner = storeshop.vendors[0]
            });
            storeshop.item.Add(new Item
            {
                title = "Sacou",
                descriprion = "Negru",
                price = 1000,
                owner = storeshop.vendors[1]
            });
            storeshop.item.Add(new Item
            {
                title = "Pantalon",
                descriprion = "Visiniu",
                price = 1500,
                owner = storeshop.vendors[0]
            });
            storeshop.item.Add(new Item
            {
                title = "Camasa",
                descriprion = "Galbena",
                price = 150,
                owner = storeshop.vendors[1]
            });
            storeshop.item.Add(new Item
            {
                title = "Ghete",
                descriprion = "Negre",
                price = 499,
                owner = storeshop.vendors[1]
            });
            storeshop.name = "Be the Flower";


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {

        }

        private void itemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void headerText_Click(object sender, EventArgs e)
        {

        }

        private void addtoCard_Click(object sender, EventArgs e)
        {
           
            //Figure out what is selected from the items list
            //Copy that item to the shopping cart, but that items that you selected will don't be deleted
            Item selectedItem = new Item();
            selectedItem = (Item)itemsListbox.SelectedItem;
            MessageBox.Show(selectedItem.title);

            shoppingCartData.Add(selectedItem);
            //In this moment if you press Run, in the second list you will have nothing, because you need to make a reset with bidingSource
            cartBinding.ResetBindings(false); //it's false because it's not change



        }

        private void shoppingCartListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makePurchase_Click_1(object sender, EventArgs e)
        {
            //Mark each item in the card as sold
            //Clear the cart

            foreach(Item item in shoppingCartData)
            {
                item.sold = true;
                item.owner.paymentDue +=(decimal)  item.owner.commission * item.price;
                storeProfit +=(1 - (decimal)item.owner.commission) * item.price;
            }
            shoppingCartData.Clear();
            itemsBinding.DataSource = storeshop.item.Where(x => x.sold == false).ToList();

            label3.Text = string.Format("${0}", storeProfit);


            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
