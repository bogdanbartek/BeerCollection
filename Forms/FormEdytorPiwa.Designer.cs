namespace BeerCollection.Forms
{
    partial class FormEdytorPiwa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxNazwaPiwa = new TextBox();
            label2 = new Label();
            comboBoxBrowar = new ComboBox();
            textBoxTypPiwa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDownAlkohol = new NumericUpDown();
            numericUpDownObjetosc = new NumericUpDown();
            label5 = new Label();
            numericUpDownCena = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            textBoxOpisPiwa = new TextBox();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlkohol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownObjetosc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa Piwa";
            // 
            // textBoxNazwaPiwa
            // 
            textBoxNazwaPiwa.Location = new Point(141, 21);
            textBoxNazwaPiwa.Name = "textBoxNazwaPiwa";
            textBoxNazwaPiwa.Size = new Size(229, 23);
            textBoxNazwaPiwa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Browar";
            // 
            // comboBoxBrowar
            // 
            comboBoxBrowar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrowar.FormattingEnabled = true;
            comboBoxBrowar.Location = new Point(144, 60);
            comboBoxBrowar.Name = "comboBoxBrowar";
            comboBoxBrowar.Size = new Size(229, 23);
            comboBoxBrowar.TabIndex = 3;
            // 
            // textBoxTypPiwa
            // 
            textBoxTypPiwa.Location = new Point(141, 101);
            textBoxTypPiwa.Name = "textBoxTypPiwa";
            textBoxTypPiwa.Size = new Size(229, 23);
            textBoxTypPiwa.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Typ Piwa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 140);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 6;
            label4.Text = "Zaw. alkoholu (%)";
            // 
            // numericUpDownAlkohol
            // 
            numericUpDownAlkohol.DecimalPlaces = 1;
            numericUpDownAlkohol.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownAlkohol.Location = new Point(145, 141);
            numericUpDownAlkohol.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownAlkohol.Name = "numericUpDownAlkohol";
            numericUpDownAlkohol.Size = new Size(94, 23);
            numericUpDownAlkohol.TabIndex = 7;
            // 
            // numericUpDownObjetosc
            // 
            numericUpDownObjetosc.Location = new Point(141, 181);
            numericUpDownObjetosc.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownObjetosc.Name = "numericUpDownObjetosc";
            numericUpDownObjetosc.Size = new Size(94, 23);
            numericUpDownObjetosc.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 180);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "Objętość (ml)";
            // 
            // numericUpDownCena
            // 
            numericUpDownCena.DecimalPlaces = 2;
            numericUpDownCena.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownCena.Location = new Point(141, 220);
            numericUpDownCena.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownCena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCena.Name = "numericUpDownCena";
            numericUpDownCena.Size = new Size(94, 23);
            numericUpDownCena.TabIndex = 11;
            numericUpDownCena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 219);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 10;
            label6.Text = "Cena";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 258);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "Opis";
            // 
            // textBoxOpisPiwa
            // 
            textBoxOpisPiwa.Location = new Point(136, 261);
            textBoxOpisPiwa.Multiline = true;
            textBoxOpisPiwa.Name = "textBoxOpisPiwa";
            textBoxOpisPiwa.ScrollBars = ScrollBars.Vertical;
            textBoxOpisPiwa.Size = new Size(253, 135);
            textBoxOpisPiwa.TabIndex = 13;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(136, 451);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(104, 36);
            btnZapisz.TabIndex = 14;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(266, 451);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(104, 36);
            btnAnuluj.TabIndex = 15;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // FormEdytorPiwa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 517);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(textBoxOpisPiwa);
            Controls.Add(label7);
            Controls.Add(numericUpDownCena);
            Controls.Add(label6);
            Controls.Add(numericUpDownObjetosc);
            Controls.Add(label5);
            Controls.Add(numericUpDownAlkohol);
            Controls.Add(label4);
            Controls.Add(textBoxTypPiwa);
            Controls.Add(label3);
            Controls.Add(comboBoxBrowar);
            Controls.Add(label2);
            Controls.Add(textBoxNazwaPiwa);
            Controls.Add(label1);
            Name = "FormEdytorPiwa";
            Text = "From";
            Load += FormEdytorPiwa_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlkohol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownObjetosc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNazwaPiwa;
        private Label label2;
        private ComboBox comboBoxBrowar;
        private TextBox textBoxTypPiwa;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownAlkohol;
        private NumericUpDown numericUpDownObjetosc;
        private Label label5;
        private NumericUpDown numericUpDownCena;
        private Label label6;
        private Label label7;
        private TextBox textBoxOpisPiwa;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}