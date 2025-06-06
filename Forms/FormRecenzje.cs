using BeerCollection.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeerCollection.Forms
{
    public partial class FormRecenzje : Form
    {
        private readonly int _beerId;

        public FormRecenzje(int beerId)
        {
            InitializeComponent(); 
            _beerId = beerId;
        }

        private void FormRecenzje_Load(object sender, EventArgs e)
        {
            ZaladujDane();
        }

        private void ZaladujDane()
        {
            try
            {
                using (var context = new BeerContext())
                {
                    var piwo = context.Beers.Find(_beerId);
                    if (piwo != null)
                    {
                        this.Text = $"Recenzje dla: {piwo.Name}";
                        labelNazwaPiwa.Text = piwo.Name; 
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono piwa o podanym ID.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    var listaRecenzji = context.Reviews
                                               .Where(r => r.BeerId == _beerId)
                                               .OrderByDescending(r => r.ReviewDate)
                                               .ToList();

                    dataGridViewRecenzje.DataSource = listaRecenzji; 

                  
                    if (dataGridViewRecenzje.Columns["Id"] != null)
                        dataGridViewRecenzje.Columns["Id"].Visible = false;
                    if (dataGridViewRecenzje.Columns["BeerId"] != null)
                        dataGridViewRecenzje.Columns["BeerId"].Visible = false;
                    if (dataGridViewRecenzje.Columns["Beer"] != null)
                        dataGridViewRecenzje.Columns["Beer"].Visible = false;

                    if (dataGridViewRecenzje.Columns["ReviewerName"] != null)
                        dataGridViewRecenzje.Columns["ReviewerName"].HeaderText = "Recenzent";
                    if (dataGridViewRecenzje.Columns["Rating"] != null)
                        dataGridViewRecenzje.Columns["Rating"].HeaderText = "Ocena (1-5)";
                    if (dataGridViewRecenzje.Columns["Comment"] != null)
                    {
                        dataGridViewRecenzje.Columns["Comment"].HeaderText = "Komentarz";
                        dataGridViewRecenzje.Columns["Comment"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridViewRecenzje.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dataGridViewRecenzje.Columns["Comment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    if (dataGridViewRecenzje.Columns["ReviewDate"] != null)
                        dataGridViewRecenzje.Columns["ReviewDate"].HeaderText = "Data Recenzji";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania recenzji: {ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}