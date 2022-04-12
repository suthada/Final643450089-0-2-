namespace Final643450089_0
{
    public partial class Form1 : Form
    {
        Product STD = new Product();

        SaleManagement saleManagement;
        Product product;
        Bill bill;

        private double sum1;
        private double sum2;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            this.sum1 += sum2;
            string Product = textBoxNameProduct.Text;
            string Price = textBoxPrice.Text;
            string TotalPrice = textBoxTotalPrice.Text;
            string Change = textBoxChange.Text;
            string Coupon = textBoxCoupon.Text;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = Product;
            dataGridView1.Rows[n].Cells[1].Value = Price;
            dataGridView1.Rows[n].Cells[2].Value = TotalPrice;
            dataGridView1.Rows[n].Cells[3].Value = Change;
            dataGridView1.Rows[n].Cells[4].Value = Coupon;

            /*int price = 0, total = 0, getChange = 0;
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.SelectAll();
                return;
            }
            if(textBoxTotalPrice.Text == "")
            {
                textBoxTotalPrice.SelectAll();
                return ;
            }
            price = Convert.ToInt32(textBoxPrice.Text);
            TotalPrice = Convert.ToInt32(textBoxTotalPrice.Text);
            Change = Price - TotalPrice;
            textBoxTotalPrice.Text = Change;*/

        }
        private void displayProduct()
        {
            //this.pictureBoxA02s.Image = 
        }
        
    }
}