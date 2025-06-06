namespace BeerCollection.Forms
{
    partial class MainForm
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
            dataGridViewPiwa = new DataGridView();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            label1 = new Label();
            textBoxWyszukaj = new TextBox();
            btnWyszukaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPiwa).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPiwa
            // 
            dataGridViewPiwa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPiwa.Location = new Point(29, 199);
            dataGridViewPiwa.Name = "dataGridViewPiwa";
            dataGridViewPiwa.Size = new Size(758, 442);
            dataGridViewPiwa.TabIndex = 0;
            dataGridViewPiwa.CellDoubleClick += dataGridViewPiwa_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(833, 199);
            button1.Name = "button1";
            button1.Size = new Size(190, 72);
            button1.TabIndex = 1;
            button1.Text = "Browary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnZarzadzajBrowarami_Click;
            // 
            // button4
            // 
            button4.Location = new Point(491, 125);
            button4.Name = "button4";
            button4.Size = new Size(134, 42);
            button4.TabIndex = 8;
            button4.Text = "Odśwież";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(341, 125);
            button3.Name = "button3";
            button3.Size = new Size(134, 42);
            button3.TabIndex = 7;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnUsunPiwo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(184, 125);
            button2.Name = "button2";
            button2.Size = new Size(134, 42);
            button2.TabIndex = 6;
            button2.Text = "Edytuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEdytujPiwo_Click;
            // 
            // button5
            // 
            button5.Location = new Point(31, 125);
            button5.Name = "button5";
            button5.Size = new Size(134, 42);
            button5.TabIndex = 5;
            button5.Text = "Dodaj";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnDodajPiwo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 64);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 9;
            label1.Text = "Wyszukaj";
            // 
            // textBoxWyszukaj
            // 
            textBoxWyszukaj.Location = new Point(120, 61);
            textBoxWyszukaj.Name = "textBoxWyszukaj";
            textBoxWyszukaj.Size = new Size(430, 23);
            textBoxWyszukaj.TabIndex = 10;
            // 
            // btnWyszukaj
            // 
            btnWyszukaj.Location = new Point(565, 61);
            btnWyszukaj.Name = "btnWyszukaj";
            btnWyszukaj.Size = new Size(119, 25);
            btnWyszukaj.TabIndex = 11;
            btnWyszukaj.Text = "Szukaj";
            btnWyszukaj.UseVisualStyleBackColor = true;
            btnWyszukaj.Click += btnWyszukaj_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 680);
            Controls.Add(btnWyszukaj);
            Controls.Add(textBoxWyszukaj);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(dataGridViewPiwa);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPiwa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPiwa;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Label label1;
        private TextBox textBoxWyszukaj;
        private Button btnWyszukaj;
    }
}