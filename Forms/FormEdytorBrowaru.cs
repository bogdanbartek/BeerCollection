
using BeerCollection.Models; 
using System;
using System.Windows.Forms;

namespace BeerCollection.Forms 
{
    public partial class FormEdytorBrowaru : Form
    {
     
        public Brewery EdytowanyBrowar { get; private set; }

        
        private Brewery _oryginalnyBrowarDoEdycji;

        
        public FormEdytorBrowaru()
        {
            InitializeComponent();
            this.Text = "Dodaj Nowy Browar";
            EdytowanyBrowar = new Brewery(); 
        }

        
        public FormEdytorBrowaru(Brewery browarDoEdycji)
        {
            InitializeComponent();
            this.Text = "Edytuj Browar"; 
            _oryginalnyBrowarDoEdycji = browarDoEdycji; 

            
            textBoxNazwaBrowaru.Text = browarDoEdycji.Name;
            textBoxKrajBrowaru.Text = browarDoEdycji.Country;
            textBoxMiastoBrowaru.Text = browarDoEdycji.City;        

         
            EdytowanyBrowar = browarDoEdycji;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
     
            if (string.IsNullOrWhiteSpace(textBoxNazwaBrowaru.Text))
            {
                MessageBox.Show("Nazwa browaru nie może być pusta!", "Błąd Walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNazwaBrowaru.Focus(); 
                return; 
            }

           
            EdytowanyBrowar.Name = textBoxNazwaBrowaru.Text;
            EdytowanyBrowar.Country = textBoxKrajBrowaru.Text;
            EdytowanyBrowar.City = textBoxMiastoBrowaru.Text;
           

            this.DialogResult = DialogResult.OK; 
            this.Close(); 
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close(); 
        }

        private void FormEdytorBrowaru_Load(object sender, EventArgs e)
        {

        }
    }
}