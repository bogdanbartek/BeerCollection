
using BeerCollection.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeerCollection.Forms
{
    public partial class FormEdytorPiwa : Form
    {
        public Beer EdytowanePiwo { get; private set; }
        private bool _trybEdycji = false;

        public FormEdytorPiwa()
        {
            InitializeComponent();
            this.Text = "Dodaj Nowe Piwo";
            EdytowanePiwo = new Beer();
            ZaladujBrowaryDoComboBoxa();
        }

     
        public FormEdytorPiwa(Beer piwoDoEdycji)
        {
            InitializeComponent();
            this.Text = "Edytuj Piwo";
            _trybEdycji = true;
            EdytowanePiwo = piwoDoEdycji;
            ZaladujBrowaryDoComboBoxa();
            WypelnijPolaDanymi();
        }

        private void ZaladujBrowaryDoComboBoxa()
        {
            try
            {
                using (var context = new BeerContext())
                {
                    var browary = context.Breweries.OrderBy(b => b.Name).ToList();
                    comboBoxBrowar.DataSource = browary;
                    comboBoxBrowar.DisplayMember = "Name";
                    comboBoxBrowar.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania listy browarów: {ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WypelnijPolaDanymi()
        {
            if (EdytowanePiwo != null)
            {
                textBoxNazwaPiwa.Text = EdytowanePiwo.Name;
                if (EdytowanePiwo.BreweryId > 0)
                {
                    comboBoxBrowar.SelectedValue = EdytowanePiwo.BreweryId;
                }
                textBoxTypPiwa.Text = EdytowanePiwo.BeerType;
                numericUpDownAlkohol.Value = EdytowanePiwo.AlcoholContent;
                numericUpDownObjetosc.Value = EdytowanePiwo.Volume;
                numericUpDownCena.Value = EdytowanePiwo.Price;
                textBoxOpisPiwa.Text = EdytowanePiwo.Description;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNazwaPiwa.Text))
            {
                MessageBox.Show("Nazwa piwa jest wymagana.", "Błąd Walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNazwaPiwa.Focus();
                return;
            }
            if (comboBoxBrowar.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać browar.", "Błąd Walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxBrowar.Focus();
                return;
            }

            EdytowanePiwo.Name = textBoxNazwaPiwa.Text.Trim();
            EdytowanePiwo.BreweryId = (int)comboBoxBrowar.SelectedValue;
            EdytowanePiwo.BeerType = textBoxTypPiwa.Text.Trim();
            EdytowanePiwo.AlcoholContent = numericUpDownAlkohol.Value;
            EdytowanePiwo.Volume = (int)numericUpDownObjetosc.Value;
            EdytowanePiwo.Price = numericUpDownCena.Value;
            EdytowanePiwo.Description = string.IsNullOrWhiteSpace(textBoxOpisPiwa.Text) ? null : textBoxOpisPiwa.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormEdytorPiwa_Load(object sender, EventArgs e)
        {
            textBoxNazwaPiwa.Focus();
        }

        private void FormEdytorPiwa_Load_1(object sender, EventArgs e)
        {

        }
    }
}