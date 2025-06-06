namespace BeerCollection.Forms
{
    partial class FormRecenzje
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
            labelNazwaPiwa = new Label();
            dataGridViewRecenzje = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecenzje).BeginInit();
            SuspendLayout();
            // 
            // labelNazwaPiwa
            // 
            labelNazwaPiwa.AutoSize = true;
            labelNazwaPiwa.Location = new Point(10, 17);
            labelNazwaPiwa.Name = "labelNazwaPiwa";
            labelNazwaPiwa.Size = new Size(0, 15);
            labelNazwaPiwa.TabIndex = 0;
            // 
            // dataGridViewRecenzje
            // 
            dataGridViewRecenzje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecenzje.Location = new Point(15, 67);
            dataGridViewRecenzje.Name = "dataGridViewRecenzje";
            dataGridViewRecenzje.Size = new Size(614, 356);
            dataGridViewRecenzje.TabIndex = 1;
            // 
            // FormRecenzje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewRecenzje);
            Controls.Add(labelNazwaPiwa);
            Name = "FormRecenzje";
            Text = "FormRecenzje";
            Load += FormRecenzje_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecenzje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNazwaPiwa;
        private DataGridView dataGridViewRecenzje;
    }
}