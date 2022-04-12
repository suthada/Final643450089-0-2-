namespace Final643450089_0
{
    public partial class Form1 : Form
    {
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
            double Price = 0;
            double TotalPrice = 0;
            double Change = 0;
            bool Coupon = false;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = Product;
            dataGridView1.Rows[n].Cells[1].Value = Price;
            dataGridView1.Rows[n].Cells[2].Value = TotalPrice;
            dataGridView1.Rows[n].Cells[3].Value = Change;
            dataGridView1.Rows[n].Cells[4].Value = Coupon;

            
        }
        private void displayProduct()
        {
            //this.pictureBoxA02s.Image = 
        }
        //this.sum1 += sum2;

        //    string User_or_Id = textBoxUserorId.Text;
        //string Password = textBoxPassword.Text;

        //int n = dataGridView1.Rows.Add();
        //dataGridView1.Rows[n].Cells[0].Value = "Staff";
        //    dataGridView1.Rows[n].Cells[1].Value = sum1;
        //    dataGridView1.Rows[n].Cells[2].Value = User_or_Id;
        //    dataGridView1.Rows[n].Cells[3].Value = Password;

        //    textBoxUserorId.Text = "";
        //    textBoxPassword.Text = "";
    }
}