using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerOrder
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ClickOrderButtonClicked(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show(this);
            //_orderButton.Enabled = false;
        }

        private void ClickInventoryButton(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show(this);
            //_inventoryButton.Enabled = false; 
        }

        private void ExitButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
