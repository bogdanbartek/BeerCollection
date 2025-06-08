// Plik: FormEdytorPiwa.Designer.cs
// Wersja przerobiona, z poprawnymi nazwami kontrolek i lepszym układem

namespace BeerCollection.Forms
{
    partial class FormEdytorPiwa
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
            label1 = new Label();
            textBoxNazwaPiwa = new TextBox();
            label2 = new Label();
            comboBoxBrowar = new ComboBox();
            label3 = new Label();
            textBoxTypPiwa = new TextBox();
            label4 = new Label();
            numericUpDownAlkohol = new NumericUpDown();
            label5 = new Label();
            numericUpDownObjetosc = new NumericUpDown();
            label6 = new Label();
            numericUpDownCena = new NumericUpDown();
            label7 = new Label();
            textBoxOpisPiwa = new TextBox();
            btnZapiszPiwo = new Button();
            btnAnulujPiwo = new Button();
            mainTableLayoutPanel = new TableLayoutPanel();
            buttonsFlowPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlkohol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownObjetosc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).BeginInit();
            mainTableLayoutPanel.SuspendLayout();
            buttonsFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa piwa:";
            // 
            // textBoxNazwaPiwa
            // 
            textBoxNazwaPiwa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxNazwaPiwa.Location = new Point(124, 13);
            textBoxNazwaPiwa.Name = "textBoxNazwaPiwa";
            textBoxNazwaPiwa.Size = new Size(421, 23);
            textBoxNazwaPiwa.TabIndex = 1;
            textBoxNazwaPiwa.TextChanged += textBoxNazwaPiwa_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(13, 47);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Browar:";
            // 
            // comboBoxBrowar
            // 
            comboBoxBrowar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxBrowar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrowar.FormattingEnabled = true;
            comboBoxBrowar.Location = new Point(124, 43);
            comboBoxBrowar.Name = "comboBoxBrowar";
            comboBoxBrowar.Size = new Size(421, 23);
            comboBoxBrowar.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(13, 77);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Typ piwa:";
            // 
            // textBoxTypPiwa
            // 
            textBoxTypPiwa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTypPiwa.Location = new Point(124, 73);
            textBoxTypPiwa.Name = "textBoxTypPiwa";
            textBoxTypPiwa.Size = new Size(421, 23);
            textBoxTypPiwa.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(13, 107);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 6;
            label4.Text = "Zaw. alkoholu (%):";
            // 
            // numericUpDownAlkohol
            // 
            numericUpDownAlkohol.Anchor = AnchorStyles.Left;
            numericUpDownAlkohol.DecimalPlaces = 1;
            numericUpDownAlkohol.Location = new Point(124, 103);
            numericUpDownAlkohol.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownAlkohol.Name = "numericUpDownAlkohol";
            numericUpDownAlkohol.Size = new Size(120, 23);
            numericUpDownAlkohol.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(13, 137);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 8;
            label5.Text = "Objętość (ml):";
            // 
            // numericUpDownObjetosc
            // 
            numericUpDownObjetosc.Anchor = AnchorStyles.Left;
            numericUpDownObjetosc.Location = new Point(124, 133);
            numericUpDownObjetosc.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownObjetosc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownObjetosc.Name = "numericUpDownObjetosc";
            numericUpDownObjetosc.Size = new Size(120, 23);
            numericUpDownObjetosc.TabIndex = 9;
            numericUpDownObjetosc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(13, 167);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 10;
            label6.Text = "Cena (zł):";
            // 
            // numericUpDownCena
            // 
            numericUpDownCena.Anchor = AnchorStyles.Left;
            numericUpDownCena.DecimalPlaces = 2;
            numericUpDownCena.Location = new Point(124, 163);
            numericUpDownCena.Maximum = new decimal(new int[] { 999, 99, 0, 131072 });
            numericUpDownCena.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownCena.Name = "numericUpDownCena";
            numericUpDownCena.Size = new Size(120, 23);
            numericUpDownCena.TabIndex = 11;
            numericUpDownCena.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(13, 265);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 12;
            label7.Text = "Opis:";
            // 
            // textBoxOpisPiwa
            // 
            textBoxOpisPiwa.Dock = DockStyle.Fill;
            textBoxOpisPiwa.Location = new Point(124, 193);
            textBoxOpisPiwa.Multiline = true;
            textBoxOpisPiwa.Name = "textBoxOpisPiwa";
            textBoxOpisPiwa.ScrollBars = ScrollBars.Vertical;
            textBoxOpisPiwa.Size = new Size(421, 160);
            textBoxOpisPiwa.TabIndex = 13;
            // 
            // btnZapiszPiwo
            // 
            btnZapiszPiwo.Location = new Point(232, 3);
            btnZapiszPiwo.Name = "btnZapiszPiwo";
            btnZapiszPiwo.Size = new Size(90, 30);
            btnZapiszPiwo.TabIndex = 1;
            btnZapiszPiwo.Text = "Zapisz";
            btnZapiszPiwo.UseVisualStyleBackColor = true;
            btnZapiszPiwo.Click += btnZapisz_Click;
            // 
            // btnAnulujPiwo
            // 
            btnAnulujPiwo.Location = new Point(328, 3);
            btnAnulujPiwo.Name = "btnAnulujPiwo";
            btnAnulujPiwo.Size = new Size(90, 30);
            btnAnulujPiwo.TabIndex = 0;
            btnAnulujPiwo.Text = "Anuluj";
            btnAnulujPiwo.UseVisualStyleBackColor = true;
            btnAnulujPiwo.Click += btnAnuluj_Click;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(label1, 0, 0);
            mainTableLayoutPanel.Controls.Add(textBoxNazwaPiwa, 1, 0);
            mainTableLayoutPanel.Controls.Add(label2, 0, 1);
            mainTableLayoutPanel.Controls.Add(comboBoxBrowar, 1, 1);
            mainTableLayoutPanel.Controls.Add(label3, 0, 2);
            mainTableLayoutPanel.Controls.Add(textBoxTypPiwa, 1, 2);
            mainTableLayoutPanel.Controls.Add(label4, 0, 3);
            mainTableLayoutPanel.Controls.Add(numericUpDownAlkohol, 1, 3);
            mainTableLayoutPanel.Controls.Add(label5, 0, 4);
            mainTableLayoutPanel.Controls.Add(numericUpDownObjetosc, 1, 4);
            mainTableLayoutPanel.Controls.Add(label6, 0, 5);
            mainTableLayoutPanel.Controls.Add(numericUpDownCena, 1, 5);
            mainTableLayoutPanel.Controls.Add(label7, 0, 6);
            mainTableLayoutPanel.Controls.Add(textBoxOpisPiwa, 1, 6);
            mainTableLayoutPanel.Controls.Add(buttonsFlowPanel, 1, 7);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(10);
            mainTableLayoutPanel.RowCount = 8;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            mainTableLayoutPanel.Size = new Size(558, 411);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // buttonsFlowPanel
            // 
            buttonsFlowPanel.Controls.Add(btnAnulujPiwo);
            buttonsFlowPanel.Controls.Add(btnZapiszPiwo);
            buttonsFlowPanel.Dock = DockStyle.Fill;
            buttonsFlowPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonsFlowPanel.Location = new Point(124, 359);
            buttonsFlowPanel.Name = "buttonsFlowPanel";
            buttonsFlowPanel.Size = new Size(421, 39);
            buttonsFlowPanel.TabIndex = 14;
            // 
            // FormEdytorPiwa
            // 
            AcceptButton = btnZapiszPiwo;
            CancelButton = btnAnulujPiwo;
            ClientSize = new Size(558, 411);
            Controls.Add(mainTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormEdytorPiwa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj/Edytuj Piwo";
            Load += FormEdytorPiwa_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlkohol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownObjetosc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).EndInit();
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            buttonsFlowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Deklaracje pól dla kontrolek z poprawnymi nazwami
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazwaPiwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBrowar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTypPiwa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAlkohol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownObjetosc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownCena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOpisPiwa;
        private System.Windows.Forms.Button btnZapiszPiwo; // Zmieniona nazwa
        private System.Windows.Forms.Button btnAnulujPiwo; // Zmieniona nazwa
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowPanel;
    }
}