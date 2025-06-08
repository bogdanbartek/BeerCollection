// Plik: FormRecenzje.Designer.cs
// Wersja przerobiona, z lepszym układem i spójnym stylem

namespace BeerCollection.Forms
{
    partial class FormRecenzje
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
            // Deklaracje kontrolek
            this.labelNazwaPiwa = new System.Windows.Forms.Label();
            this.dataGridViewRecenzje = new System.Windows.Forms.DataGridView();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDodajRecenzje = new System.Windows.Forms.Button(); // Placeholder na przyszłość
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzje)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.buttonsFlowPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // mainTableLayoutPanel 
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.labelNazwaPiwa, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.dataGridViewRecenzje, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.buttonsFlowPanel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 561);
            this.mainTableLayoutPanel.TabIndex = 0;

            // 
            // labelNazwaPiwa 
            // 
            this.labelNazwaPiwa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNazwaPiwa.AutoSize = true;
            this.labelNazwaPiwa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaPiwa.Location = new System.Drawing.Point(344, 10);
            this.labelNazwaPiwa.Name = "labelNazwaPiwa";
            this.labelNazwaPiwa.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.labelNazwaPiwa.Size = new System.Drawing.Size(96, 40);
            this.labelNazwaPiwa.TabIndex = 0;
            this.labelNazwaPiwa.Text = "(Nazwa Piwa)";
            this.labelNazwaPiwa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // dataGridViewRecenzje 
            // 
            this.dataGridViewRecenzje.AllowUserToAddRows = false;
            this.dataGridViewRecenzje.AllowUserToDeleteRows = false;
     
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.DimGray;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            headerStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRecenzje.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridViewRecenzje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Stylizacja "pasków zebry"
            System.Windows.Forms.DataGridViewCellStyle alternatingStyle = new System.Windows.Forms.DataGridViewCellStyle();
            alternatingStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRecenzje.AlternatingRowsDefaultCellStyle = alternatingStyle;
            this.dataGridViewRecenzje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecenzje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecenzje.Location = new System.Drawing.Point(13, 53);
            this.dataGridViewRecenzje.Name = "dataGridViewRecenzje";
            this.dataGridViewRecenzje.ReadOnly = true;
            this.dataGridViewRecenzje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecenzje.Size = new System.Drawing.Size(758, 457);
            this.dataGridViewRecenzje.TabIndex = 1;

            // 
            // buttonsFlowPanel (Panel na przyciski)
            // 
            this.buttonsFlowPanel.AutoSize = true;
            this.buttonsFlowPanel.Controls.Add(this.btnDodajRecenzje);
            this.buttonsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonsFlowPanel.Location = new System.Drawing.Point(13, 516);
            this.buttonsFlowPanel.Name = "buttonsFlowPanel";
            this.buttonsFlowPanel.Size = new System.Drawing.Size(758, 32);
            this.buttonsFlowPanel.TabIndex = 2;

         

            // 
            // FormRecenzje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormRecenzje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recenzje";
            this.Load += new System.EventHandler(this.FormRecenzje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzje)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.buttonsFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Deklaracje pól dla kontrolek
        private System.Windows.Forms.Label labelNazwaPiwa;
        private System.Windows.Forms.DataGridView dataGridViewRecenzje;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowPanel;
        private System.Windows.Forms.Button btnDodajRecenzje;
    }
}