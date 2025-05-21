using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System;

namespace Productie_deel2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    {
        private List<Product> producten = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            VoegToe();
        }

        private void VoegToe()
        {
            //controle of veld ingevuld is
            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("Gelieve een productnaam in te vullen.", "Fout", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            //controle of product al bestaat
            foreach (Product p in producten)
            {
                if (p.Naam.ToLower() == txtProduct.Text.ToLower())
                {
                    MessageBox.Show("Dit product bestaat al.", "Fout", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }


            //nieuw product aanmaken
            Product nieuwProduct = new Product(txtProduct.Text);
            producten.Add(nieuwProduct);


            //tonen listbox
            lstProducten.Items.Add(nieuwProduct.Gegevens());


            txtProduct.Clear();
        }
    }
}