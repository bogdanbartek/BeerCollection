
using BeerCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Microsoft.Data.Sqlite;

namespace BeerCollection.Forms 
{
    public partial class FormBrowary : Form
    {
        public FormBrowary()
        {
            InitializeComponent();
        }


        private void ZaladujBrowary()
        {
            try
            {
                using (var context = new BeerContext())
                {

                    var browary = context.Breweries.ToList();


                    dataGridViewBrowary.DataSource = browary;

                    if (dataGridViewBrowary.Columns["Name"] != null)
                        dataGridViewBrowary.Columns["Name"].HeaderText = "Nazwa Browaru";
                    if (dataGridViewBrowary.Columns["Country"] != null)
                        dataGridViewBrowary.Columns["Country"].HeaderText = "Kraj";
                    if (dataGridViewBrowary.Columns["City"] != null)
                        dataGridViewBrowary.Columns["City"].HeaderText = "Miasto";


                    if (dataGridViewBrowary.Columns["Id"] != null)
                        dataGridViewBrowary.Columns["Id"].Visible = false;


                    if (dataGridViewBrowary.Columns["Beers"] != null)
                        dataGridViewBrowary.Columns["Beers"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania browarów: {ex.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormBrowary_Load(object sender, EventArgs e)
        {
            ZaladujBrowary();
        }


        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            ZaladujBrowary();
        }


        private void btnDodajBrowar_Click(object sender, EventArgs e)
        {

            using (FormEdytorBrowaru formEdytor = new FormEdytorBrowaru())
            {

                if (formEdytor.ShowDialog() == DialogResult.OK)
                {

                    Brewery nowyBrowar = formEdytor.EdytowanyBrowar;

                    try
                    {

                        using (var context = new BeerContext())
                        {
                            context.Breweries.Add(nowyBrowar);
                            context.SaveChanges();
                        }


                        ZaladujBrowary();
                        MessageBox.Show("Nowy browar został pomyślnie dodany!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas dodawania nowego browaru: {ex.ToString()}", "Błąd Zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        private void btnEdytujBrowar_Click(object sender, EventArgs e)
        {

            if (dataGridViewBrowary.CurrentRow != null)
            {

                Brewery zaznaczonyBrowar = dataGridViewBrowary.CurrentRow.DataBoundItem as Brewery;

                if (zaznaczonyBrowar != null)
                {

                    using (FormEdytorBrowaru formEdytor = new FormEdytorBrowaru(zaznaczonyBrowar))
                    {
                        if (formEdytor.ShowDialog() == DialogResult.OK)
                        {


                            try
                            {
                                using (var context = new BeerContext())
                                {

                                    context.Breweries.Update(zaznaczonyBrowar);
                                    context.SaveChanges();
                                }
                                ZaladujBrowary();
                                MessageBox.Show("Dane browaru zostały zaktualizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Błąd podczas aktualizacji browaru: {ex.ToString()}", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie udało się pobrać danych zaznaczonego browaru. Upewnij się, że źródło danych tabeli to lista obiektów 'Brewery'.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę najpierw zaznaczyć browar z listy do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUsunBrowar_Click(object sender, EventArgs e)
        {

            if (dataGridViewBrowary.CurrentRow != null)
            {

                Brewery zaznaczonyBrowar = dataGridViewBrowary.CurrentRow.DataBoundItem as Brewery;

                if (zaznaczonyBrowar != null)
                {

                    DialogResult potwierdzenie = MessageBox.Show(
                        $"Czy na pewno chcesz usunąć browar: {zaznaczonyBrowar.Name}?",
                        "Potwierdź Usunięcie",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (potwierdzenie == DialogResult.Yes)
                    {

                        try
                        {
                            using (var context = new BeerContext())
                            {

                                var browarDoUsuniecia = context.Breweries.Find(zaznaczonyBrowar.Id);
                                if (browarDoUsuniecia != null)
                                {
                                    context.Breweries.Remove(browarDoUsuniecia);
                                    context.SaveChanges();

                                    MessageBox.Show("Browar został pomyślnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ZaladujBrowary();
                                }
                                else
                                {
                                    MessageBox.Show("Nie znaleziono browaru w bazie danych. Mógł zostać usunięty wcześniej.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    ZaladujBrowary();
                                }
                            }
                        }

                        catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx)
                        {

                            if (dbEx.InnerException is Microsoft.Data.Sqlite.SqliteException sqliteEx && sqliteEx.SqliteErrorCode == 19)
                            {
                                MessageBox.Show(
                                    "Nie można usunąć tego browaru, ponieważ są z nim powiązane istniejące piwa.\n" +
                                    "Najpierw usuń te piwa lub zmień ich przypisanie do innego browaru.",
                                    "Błąd Usuwania (Ograniczenie Klucza Obcego)",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else
                            {

                                MessageBox.Show($"Wystąpił błąd podczas operacji na bazie danych: {dbEx.Message}\n" +
                                                $"Szczegóły: {(dbEx.InnerException != null ? dbEx.InnerException.Message : "brak dodatkowych szczegółów")}",
                                                "Błąd Bazy Danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Wystąpił nieoczekiwany błąd podczas usuwania browaru: {ex.ToString()}", "Błąd Krytyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie udało się pobrać danych zaznaczonego browaru.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę najpierw zaznaczyć browar z listy do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mainTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}