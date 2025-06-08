// Plik: MainForm.Designer.cs
// Wersja przerobiona, z poprawnymi nazwami kontrolek i lepszym układem

namespace BeerCollection.Forms
{
    partial class MainForm
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
            dataGridViewPiwa = new DataGridView();
            btnZarzadzajBrowarami = new Button();
            btnUsunPiwo = new Button();
            btnEdytujPiwo = new Button();
            btnDodajPiwo = new Button();
            labelWyszukaj = new Label();
            textBoxWyszukaj = new TextBox();
            btnWyszukaj = new Button();
            btnWyczyscWyszukiwanie = new Button();
            mainTableLayoutPanel = new TableLayoutPanel();
            searchFlowPanel = new FlowLayoutPanel();
            buttonsFlowPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPiwa).BeginInit();
            mainTableLayoutPanel.SuspendLayout();
            searchFlowPanel.SuspendLayout();
            buttonsFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPiwa
            // 
            dataGridViewPiwa.AllowUserToAddRows = false;
            dataGridViewPiwa.AllowUserToDeleteRows = false;
            dataGridViewPiwa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPiwa.Dock = DockStyle.Fill;
            dataGridViewPiwa.Location = new Point(13, 50);
            dataGridViewPiwa.Name = "dataGridViewPiwa";
            dataGridViewPiwa.ReadOnly = true;
            dataGridViewPiwa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPiwa.Size = new Size(958, 554);
            dataGridViewPiwa.TabIndex = 1;
            dataGridViewPiwa.CellDoubleClick += dataGridViewPiwa_CellDoubleClick;
            // 
            // btnZarzadzajBrowarami
            // 
            btnZarzadzajBrowarami.Location = new Point(381, 3);
            btnZarzadzajBrowarami.Name = "btnZarzadzajBrowarami";
            btnZarzadzajBrowarami.Size = new Size(150, 32);
            btnZarzadzajBrowarami.TabIndex = 3;
            btnZarzadzajBrowarami.Text = "Zarządzaj Browarami";
            btnZarzadzajBrowarami.UseVisualStyleBackColor = true;
            btnZarzadzajBrowarami.Click += btnZarzadzajBrowarami_Click;
            // 
            // btnUsunPiwo
            // 
            btnUsunPiwo.Location = new Point(255, 3);
            btnUsunPiwo.Name = "btnUsunPiwo";
            btnUsunPiwo.Size = new Size(120, 32);
            btnUsunPiwo.TabIndex = 2;
            btnUsunPiwo.Text = "Usuń Piwo";
            btnUsunPiwo.UseVisualStyleBackColor = true;
            btnUsunPiwo.Click += btnUsunPiwo_Click;
            // 
            // btnEdytujPiwo
            // 
            btnEdytujPiwo.Location = new Point(129, 3);
            btnEdytujPiwo.Name = "btnEdytujPiwo";
            btnEdytujPiwo.Size = new Size(120, 32);
            btnEdytujPiwo.TabIndex = 1;
            btnEdytujPiwo.Text = "Edytuj Piwo";
            btnEdytujPiwo.UseVisualStyleBackColor = true;
            btnEdytujPiwo.Click += btnEdytujPiwo_Click;
            // 
            // btnDodajPiwo
            // 
            btnDodajPiwo.Location = new Point(3, 3);
            btnDodajPiwo.Name = "btnDodajPiwo";
            btnDodajPiwo.Size = new Size(120, 32);
            btnDodajPiwo.TabIndex = 0;
            btnDodajPiwo.Text = "Dodaj Piwo";
            btnDodajPiwo.UseVisualStyleBackColor = true;
            btnDodajPiwo.Click += btnDodajPiwo_Click;
            // 
            // labelWyszukaj
            // 
            labelWyszukaj.Anchor = AnchorStyles.Left;
            labelWyszukaj.AutoSize = true;
            labelWyszukaj.Location = new Point(3, 8);
            labelWyszukaj.Name = "labelWyszukaj";
            labelWyszukaj.Size = new Size(59, 15);
            labelWyszukaj.TabIndex = 0;
            labelWyszukaj.Text = "Wyszukaj:";
            // 
            // textBoxWyszukaj
            // 
            textBoxWyszukaj.Location = new Point(68, 3);
            textBoxWyszukaj.Name = "textBoxWyszukaj";
            textBoxWyszukaj.Size = new Size(400, 23);
            textBoxWyszukaj.TabIndex = 1;
            // 
            // btnWyszukaj
            // 
            btnWyszukaj.Location = new Point(474, 3);
            btnWyszukaj.Name = "btnWyszukaj";
            btnWyszukaj.Size = new Size(90, 25);
            btnWyszukaj.TabIndex = 2;
            btnWyszukaj.Text = "Wyszukaj";
            btnWyszukaj.UseVisualStyleBackColor = true;
            btnWyszukaj.Click += btnWyszukaj_Click;
            // 
            // btnWyczyscWyszukiwanie
            // 
            btnWyczyscWyszukiwanie.Location = new Point(570, 3);
            btnWyczyscWyszukiwanie.Name = "btnWyczyscWyszukiwanie";
            btnWyczyscWyszukiwanie.Size = new Size(90, 25);
            btnWyczyscWyszukiwanie.TabIndex = 3;
            btnWyczyscWyszukiwanie.Text = "Wyczyść";
            btnWyczyscWyszukiwanie.UseVisualStyleBackColor = true;
            btnWyczyscWyszukiwanie.Click += btnWyczyscWyszukiwanie_Click;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(searchFlowPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(dataGridViewPiwa, 0, 1);
            mainTableLayoutPanel.Controls.Add(buttonsFlowPanel, 0, 2);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(10);
            mainTableLayoutPanel.RowCount = 3;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.Size = new Size(984, 661);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // searchFlowPanel
            // 
            searchFlowPanel.AutoSize = true;
            searchFlowPanel.Controls.Add(labelWyszukaj);
            searchFlowPanel.Controls.Add(textBoxWyszukaj);
            searchFlowPanel.Controls.Add(btnWyszukaj);
            searchFlowPanel.Controls.Add(btnWyczyscWyszukiwanie);
            searchFlowPanel.Dock = DockStyle.Fill;
            searchFlowPanel.Location = new Point(13, 13);
            searchFlowPanel.Name = "searchFlowPanel";
            searchFlowPanel.Size = new Size(958, 31);
            searchFlowPanel.TabIndex = 0;
            searchFlowPanel.Paint += searchFlowPanel_Paint;
            // 
            // buttonsFlowPanel
            // 
            buttonsFlowPanel.AutoSize = true;
            buttonsFlowPanel.Controls.Add(btnDodajPiwo);
            buttonsFlowPanel.Controls.Add(btnEdytujPiwo);
            buttonsFlowPanel.Controls.Add(btnUsunPiwo);
            buttonsFlowPanel.Controls.Add(btnZarzadzajBrowarami);
            buttonsFlowPanel.Dock = DockStyle.Fill;
            buttonsFlowPanel.Location = new Point(13, 610);
            buttonsFlowPanel.Name = "buttonsFlowPanel";
            buttonsFlowPanel.Size = new Size(958, 38);
            buttonsFlowPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(mainTableLayoutPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beer Collection Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPiwa).EndInit();
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            searchFlowPanel.ResumeLayout(false);
            searchFlowPanel.PerformLayout();
            buttonsFlowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Deklaracje pól dla kontrolek z poprawnymi nazwami
        private System.Windows.Forms.DataGridView dataGridViewPiwa;
        private System.Windows.Forms.Button btnZarzadzajBrowarami;
        private System.Windows.Forms.Button btnUsunPiwo;
        private System.Windows.Forms.Button btnEdytujPiwo;
        private System.Windows.Forms.Button btnDodajPiwo;
        private System.Windows.Forms.Label labelWyszukaj;
        private System.Windows.Forms.TextBox textBoxWyszukaj;
        private System.Windows.Forms.Button btnWyszukaj;
        private System.Windows.Forms.Button btnWyczyscWyszukiwanie;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel searchFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowPanel;
    }
}