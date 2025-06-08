// Plik: FormEdytorBrowaru.Designer.cs
// Wersja przerobiona, z poprawnymi nazwami kontrolek i lepszym układem

namespace BeerCollection.Forms
{
    partial class FormEdytorBrowaru
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelNazwa = new System.Windows.Forms.Label();
            this.textBoxNazwaBrowaru = new System.Windows.Forms.TextBox();
            this.labelKraj = new System.Windows.Forms.Label();
            this.textBoxKrajBrowaru = new System.Windows.Forms.TextBox();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.textBoxMiastoBrowaru = new System.Windows.Forms.TextBox();
            this.btnZapiszBrowar = new System.Windows.Forms.Button();
            this.btnAnulujBrowar = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTableLayoutPanel.SuspendLayout();
            this.buttonsFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.labelNazwa, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.textBoxNazwaBrowaru, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.labelKraj, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.textBoxKrajBrowaru, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.labelMiasto, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.textBoxMiastoBrowaru, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.buttonsFlowPanel, 1, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(434, 161);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // labelNazwa
            // 
            this.labelNazwa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.Location = new System.Drawing.Point(13, 17);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Text = "Nazwa browaru:";
            // 
            // textBoxNazwaBrowaru
            // 
            this.textBoxNazwaBrowaru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNazwaBrowaru.Location = new System.Drawing.Point(110, 13);
            this.textBoxNazwaBrowaru.Name = "textBoxNazwaBrowaru";
            this.textBoxNazwaBrowaru.Size = new System.Drawing.Size(311, 23);
            // 
            // labelKraj
            // 
            this.labelKraj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelKraj.AutoSize = true;
            this.labelKraj.Location = new System.Drawing.Point(13, 47);
            this.labelKraj.Name = "labelKraj";
            this.labelKraj.Text = "Kraj:";
            // 
            // textBoxKrajBrowaru
            // 
            this.textBoxKrajBrowaru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKrajBrowaru.Location = new System.Drawing.Point(110, 43);
            this.textBoxKrajBrowaru.Name = "textBoxKrajBrowaru";
            this.textBoxKrajBrowaru.Size = new System.Drawing.Size(311, 23);
            // 
            // labelMiasto
            // 
            this.labelMiasto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.Location = new System.Drawing.Point(13, 77);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Text = "Miasto:";
            // 
            // textBoxMiastoBrowaru
            // 
            this.textBoxMiastoBrowaru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiastoBrowaru.Location = new System.Drawing.Point(110, 73);
            this.textBoxMiastoBrowaru.Name = "textBoxMiastoBrowaru";
            this.textBoxMiastoBrowaru.Size = new System.Drawing.Size(311, 23);
            // 
            // buttonsFlowPanel
            // 
            this.buttonsFlowPanel.Controls.Add(this.btnAnulujBrowar);
            this.buttonsFlowPanel.Controls.Add(this.btnZapiszBrowar);
            this.buttonsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonsFlowPanel.Location = new System.Drawing.Point(110, 103);
            this.buttonsFlowPanel.Name = "buttonsFlowPanel";
            this.buttonsFlowPanel.Size = new System.Drawing.Size(311, 39);
            // 
            // btnZapiszBrowar
            // 
            this.btnZapiszBrowar.Name = "btnZapiszBrowar";
            this.btnZapiszBrowar.Size = new System.Drawing.Size(90, 30);
            this.btnZapiszBrowar.Text = "Zapisz";
            this.btnZapiszBrowar.UseVisualStyleBackColor = true;
            this.btnZapiszBrowar.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnulujBrowar
            // 
            this.btnAnulujBrowar.Name = "btnAnulujBrowar";
            this.btnAnulujBrowar.Size = new System.Drawing.Size(90, 30);
            this.btnAnulujBrowar.Text = "Anuluj";
            this.btnAnulujBrowar.UseVisualStyleBackColor = true;
            this.btnAnulujBrowar.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // FormEdytorBrowaru
            // 
            this.AcceptButton = this.btnZapiszBrowar;
            this.CancelButton = this.btnAnulujBrowar;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEdytorBrowaru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj/Edytuj Browar";
            this.Load += new System.EventHandler(this.FormEdytorBrowaru_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.buttonsFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Deklaracje pól dla kontrolek z poprawnymi nazwami
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.TextBox textBoxNazwaBrowaru;
        private System.Windows.Forms.Label labelKraj;
        private System.Windows.Forms.TextBox textBoxKrajBrowaru;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.TextBox textBoxMiastoBrowaru;
        private System.Windows.Forms.Button btnZapiszBrowar;
        private System.Windows.Forms.Button btnAnulujBrowar;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowPanel;
    }
}