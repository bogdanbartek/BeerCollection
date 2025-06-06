
using BeerCollection.Forms;
using BeerCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeerCollection.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            ZaladujPiwaDoTabeli();
            dataGridViewPiwa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

       
        public void ZaladujPiwaDoTabeli(string frazaWyszukiwania = null)
        {
            try
            {
                using (var context = new BeerContext())
                {
                    var zapytanie = context.Beers.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(frazaWyszukiwania))
                    {
                        string frazaMalymiLiterami = frazaWyszukiwania.ToLower();
                        zapytanie = zapytanie.Where(b =>
                            b.Name.ToLower().Contains(frazaMalymiLiterami) ||
                            b.Brewery.Name.ToLower().Contains(frazaMalymiLiterami) ||
                            b.BeerType.ToLower().Contains(frazaMalymiLiterami)
                        );
                    }

                    var piwaDoWyswietlenia = zapytanie
                        .Select(b => new
                        {
                            Id = b.Id,
                            NazwaPiwa = b.Name,
                            NazwaBrowaru = b.Brewery.Name,
                            TypPiwa = b.BeerType,
                            ZawartoscAlkoholu = b.AlcoholContent,
                            Objetosc = b.Volume,
                            Cena = b.Price,
                            Opis = b.Description
                        })
                        .ToList();

                    dataGridViewPiwa.DataSource = piwaDoWyswietlenia;

                  
                    if (dataGridViewPiwa.Columns["Id"] != null)
                        dataGridViewPiwa.Columns["Id"].Visible = false;
                    if (dataGridViewPiwa.Columns["NazwaPiwa"] != null)
                        dataGridViewPiwa.Columns["NazwaPiwa"].HeaderText = "Nazwa Piwa";
                    if (dataGridViewPiwa.Columns["NazwaBrowaru"] != null)
                        dataGridViewPiwa.Columns["NazwaBrowaru"].HeaderText = "Browar";
                    if (dataGridViewPiwa.Columns["TypPiwa"] != null)
                        dataGridViewPiwa.Columns["TypPiwa"].HeaderText = "Typ Piwa";
                    if (dataGridViewPiwa.Columns["ZawartoscAlkoholu"] != null)
                        dataGridViewPiwa.Columns["ZawartoscAlkoholu"].HeaderText = "Alk. (%)";
                    if (dataGridViewPiwa.Columns["Objetosc"] != null)
                        dataGridViewPiwa.Columns["Objetosc"].HeaderText = "Objętość (ml)";
                    if (dataGridViewPiwa.Columns["Cena"] != null)
                        dataGridViewPiwa.Columns["Cena"].HeaderText = "Cena (zł)";
                    if (dataGridViewPiwa.Columns["Opis"] != null)
                    {
                        dataGridViewPiwa.Columns["Opis"].HeaderText = "Opis";
                        dataGridViewPiwa.Columns["Opis"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridViewPiwa.Columns["Opis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania piw: {ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void btnWyszukaj_Click(object sender, EventArgs e)
        {
            ZaladujPiwaDoTabeli(textBoxWyszukaj.Text);
        }

        private void btnWyczyscWyszukiwanie_Click(object sender, EventArgs e)
        {
            textBoxWyszukaj.Text = "";
            ZaladujPiwaDoTabeli();
        }

       
        private void btnZarzadzajBrowarami_Click(object sender, EventArgs e)
        {
            using (FormBrowary formBrowary = new FormBrowary())
            {
                formBrowary.ShowDialog(this);
               
                ZaladujPiwaDoTabeli(textBoxWyszukaj.Text);
            }
        }

        private void btnDodajPiwo_Click(object sender, EventArgs e)
        {
            using (FormEdytorPiwa formEdytor = new FormEdytorPiwa())
            {
                if (formEdytor.ShowDialog(this) == DialogResult.OK)
                {
                    Beer nowePiwo = formEdytor.EdytowanePiwo;
                    try
                    {
                        using (var context = new BeerContext())
                        {
                            context.Beers.Add(nowePiwo);
                            context.SaveChanges();
                        }
                        ZaladujPiwaDoTabeli();
                        MessageBox.Show("Nowe piwo zostało pomyślnie dodane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas dodawania nowego piwa: {ex.ToString()}", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdytujPiwo_Click(object sender, EventArgs e)
        {
            if (dataGridViewPiwa.CurrentRow != null)
            {
                int piwoId = (int)dataGridViewPiwa.CurrentRow.Cells["Id"].Value;
                try
                {
                    Beer piwoDoEdycji;
                    using (var context = new BeerContext())
                    {
                        piwoDoEdycji = context.Beers.Include(b => b.Brewery).FirstOrDefault(b => b.Id == piwoId);
                    }

                    if (piwoDoEdycji != null)
                    {
                        using (FormEdytorPiwa formEdytor = new FormEdytorPiwa(piwoDoEdycji))
                        {
                            if (formEdytor.ShowDialog(this) == DialogResult.OK)
                            {
                                using (var context = new BeerContext())
                                {
                                    context.Beers.Update(piwoDoEdycji);
                                    context.SaveChanges();
                                }
                                ZaladujPiwaDoTabeli(textBoxWyszukaj.Text);
                                MessageBox.Show("Dane piwa zostały zaktualizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas przygotowywania do edycji: {ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę najpierw zaznaczyć piwo z listy do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUsunPiwo_Click(object sender, EventArgs e)
        {
            if (dataGridViewPiwa.CurrentRow != null)
            {
                int piwoId = (int)dataGridViewPiwa.CurrentRow.Cells["Id"].Value;
                string nazwaPiwa = dataGridViewPiwa.CurrentRow.Cells["NazwaPiwa"].Value.ToString();

                DialogResult potwierdzenie = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć piwo: {nazwaPiwa}?\nSpowoduje to również usunięcie wszystkich jego recenzji!",
                    "Potwierdź Usunięcie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (potwierdzenie == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new BeerContext())
                        {
                            var piwoDoUsuniecia = context.Beers.Find(piwoId);
                            if (piwoDoUsuniecia != null)
                            {
                                context.Beers.Remove(piwoDoUsuniecia);
                                context.SaveChanges();
                                MessageBox.Show("Piwo zostało pomyślnie usunięte.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        ZaladujPiwaDoTabeli(textBoxWyszukaj.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania piwa: {ex.ToString()}", "Błąd Krytyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę najpierw zaznaczyć piwo z listy do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void dataGridViewPiwa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int piwoId = (int)dataGridViewPiwa.Rows[e.RowIndex].Cells["Id"].Value;
                using (FormRecenzje formRecenzje = new FormRecenzje(piwoId))
                {
                    formRecenzje.ShowDialog(this);
                }
                
            }
        }
    }
}
