namespace BeerCollection.Forms
{
    partial class FormEdytorBrowaru
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
            label2 = new Label();
            label3 = new Label();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            textBoxNazwaBrowaru = new TextBox();
            textBoxKrajBrowaru = new TextBox();
            textBoxMiastoBrowaru = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 195);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa browaru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 238);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Kraj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 280);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Miasto";
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(475, 368);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(81, 32);
            btnZapisz.TabIndex = 3;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(583, 368);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(81, 32);
            btnAnuluj.TabIndex = 4;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // textBoxNazwaBrowaru
            // 
            textBoxNazwaBrowaru.Location = new Point(149, 189);
            textBoxNazwaBrowaru.Name = "textBoxNazwaBrowaru";
            textBoxNazwaBrowaru.Size = new Size(250, 23);
            textBoxNazwaBrowaru.TabIndex = 5;
            // 
            // textBoxKrajBrowaru
            // 
            textBoxKrajBrowaru.Location = new Point(149, 235);
            textBoxKrajBrowaru.Name = "textBoxKrajBrowaru";
            textBoxKrajBrowaru.Size = new Size(250, 23);
            textBoxKrajBrowaru.TabIndex = 6;
            // 
            // textBoxMiastoBrowaru
            // 
            textBoxMiastoBrowaru.Location = new Point(149, 277);
            textBoxMiastoBrowaru.Name = "textBoxMiastoBrowaru";
            textBoxMiastoBrowaru.Size = new Size(250, 23);
            textBoxMiastoBrowaru.TabIndex = 7;
            // 
            // FormEdytorBrowaru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxMiastoBrowaru);
            Controls.Add(textBoxKrajBrowaru);
            Controls.Add(textBoxNazwaBrowaru);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEdytorBrowaru";
            Text = "Dodaj/Edytuj Browar";
            Load += FormEdytorBrowaru_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnZapisz;
        private Button btnAnuluj;
        private TextBox textBoxNazwaBrowaru;
        private TextBox textBoxKrajBrowaru;
        private TextBox textBoxMiastoBrowaru;
    }
}