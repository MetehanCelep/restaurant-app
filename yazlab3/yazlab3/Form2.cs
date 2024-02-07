using System;
using System.Windows.Forms;

namespace yazlab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxToplamSure.Text, out int totalTime) &&
                int.TryParse(textBoxSaniye.Text, out int customersPerSecond) &&
                int.TryParse(textBoxMusteri.Text, out int givenCustomers))
            {
                int totalTimeInSeconds = totalTime * 60;
                double customerArrivalRate = (double)givenCustomers / customersPerSecond;
                double totalCustomers = customerArrivalRate * totalTimeInSeconds;

                int seatedCustomerCount = (int)totalCustomers;

                
                int tableCount = seatedCustomerCount; // Her masaya 1 müşteri

               
                int waiterCount = (int)Math.Ceiling((double)(totalCustomers ) / 2);// Her 2 saniyede bir garson sipariş


                int chefCount = (int)Math.Ceiling((double)(totalCustomers * 3) / 2);  // Her 3 saniyede bir aşçı 2 yemek

                
                double revenuePerCustomer = 5 * totalCustomers; //Müşteri başına kazancı 1 yaptığımda kar hep negatif çıkıyordu.Ben de 5 kazanç yaptım.

                
                int totalCost = tableCount + waiterCount + chefCount;// Toplam maliyet

               
                double profit = revenuePerCustomer - totalCost; // Kar

                MessageBox.Show($"Masa Sayısı: {tableCount}\nGarson Sayısı: {waiterCount}\nAşçı Sayısı: {chefCount}\nKazanç: {profit}\nToplam Müşteri: {totalCustomers}");
            }
            else
            {
                MessageBox.Show("Lütfen sayısal değerleri geçerli bir şekilde giriniz!");
            }
        }
    }
}
