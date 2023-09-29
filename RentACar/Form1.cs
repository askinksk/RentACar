namespace RentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> araclar;
        private void Form1_Load(object sender, EventArgs e)
        {
            araclar = new List<string>() { "BMW", "Mercedes", "Ford" };

            foreach (string arac in araclar)
            {
                lbxCarList.Items.Add(arac);
            }
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            if (lbxCarList.SelectedItem != null)
            {
                araclar.Remove(lbxCarList.SelectedItem.ToString());

                lbxCarList.Items.Clear();

                foreach (var arac in araclar)
                {
                    lbxCarList.Items.Add(arac);
                }
            }
            else
            {
                MessageBox.Show("Öncelikle Silinecek Aracý Þeçiniz...");
            }
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            if (tbxNewCar.Text.Length > 1)
            {
                araclar.Add(tbxNewCar.Text);

                lbxCarList.Items.Clear();

                foreach (var arac in araclar)
                {
                    lbxCarList.Items.Add(arac);
                }

            }
            else
            {
                MessageBox.Show("Öncelikle Araç Markasý giriniz...");
            }
        }
    }
}