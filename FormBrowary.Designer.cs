
namespace BeerCollection.Forms
{
    partial class FormBrowary
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewBrowary = new DataGridView();
            btnDodajBrowar = new Button();
            btnEdytujBrowar = new Button();
            btnUsunBrowar = new Button();
            btnOdswiez = new Button();
            mainTableLayoutPanel = new TableLayoutPanel();
            buttonsFlowPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrowary).BeginInit();
            mainTableLayoutPanel.SuspendLayout();
            buttonsFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBrowary
            // 
            dataGridViewBrowary.AllowUserToAddRows = false;
            dataGridViewBrowary.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewBrowary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBrowary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBrowary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBrowary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBrowary.Dock = DockStyle.Fill;
            dataGridViewBrowary.Location = new Point(13, 13);
            dataGridViewBrowary.Name = "dataGridViewBrowary";
            dataGridViewBrowary.ReadOnly = true;
            dataGridViewBrowary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBrowary.Size = new Size(758, 491);
            dataGridViewBrowary.TabIndex = 0;
            // 
            // btnDodajBrowar
            // 
            btnDodajBrowar.Location = new Point(3, 3);
            btnDodajBrowar.Name = "btnDodajBrowar";
            btnDodajBrowar.Size = new Size(120, 32);
            btnDodajBrowar.TabIndex = 0;
            btnDodajBrowar.Text = "Dodaj Browar";
            btnDodajBrowar.UseVisualStyleBackColor = true;
            btnDodajBrowar.Click += btnDodajBrowar_Click;
            // 
            // btnEdytujBrowar
            // 
            btnEdytujBrowar.Location = new Point(129, 3);
            btnEdytujBrowar.Name = "btnEdytujBrowar";
            btnEdytujBrowar.Size = new Size(120, 32);
            btnEdytujBrowar.TabIndex = 1;
            btnEdytujBrowar.Text = "Edytuj Browar";
            btnEdytujBrowar.UseVisualStyleBackColor = true;
            btnEdytujBrowar.Click += btnEdytujBrowar_Click;
            // 
            // btnUsunBrowar
            // 
            btnUsunBrowar.Location = new Point(255, 3);
            btnUsunBrowar.Name = "btnUsunBrowar";
            btnUsunBrowar.Size = new Size(120, 32);
            btnUsunBrowar.TabIndex = 2;
            btnUsunBrowar.Text = "Usuń Browar";
            btnUsunBrowar.UseVisualStyleBackColor = true;
            btnUsunBrowar.Click += btnUsunBrowar_Click;
            // 
            // btnOdswiez
            // 
            btnOdswiez.Location = new Point(381, 3);
            btnOdswiez.Name = "btnOdswiez";
            btnOdswiez.Size = new Size(120, 32);
            btnOdswiez.TabIndex = 3;
            btnOdswiez.Text = "Odśwież";
            btnOdswiez.UseVisualStyleBackColor = true;
            btnOdswiez.Click += btnOdswiez_Click;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(dataGridViewBrowary, 0, 0);
            mainTableLayoutPanel.Controls.Add(buttonsFlowPanel, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(10);
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.Size = new Size(784, 561);
            mainTableLayoutPanel.TabIndex = 0;
            mainTableLayoutPanel.Paint += mainTableLayoutPanel_Paint;
            // 
            // buttonsFlowPanel
            // 
            buttonsFlowPanel.AutoSize = true;
            buttonsFlowPanel.Controls.Add(btnDodajBrowar);
            buttonsFlowPanel.Controls.Add(btnEdytujBrowar);
            buttonsFlowPanel.Controls.Add(btnUsunBrowar);
            buttonsFlowPanel.Controls.Add(btnOdswiez);
            buttonsFlowPanel.Dock = DockStyle.Fill;
            buttonsFlowPanel.Location = new Point(13, 510);
            buttonsFlowPanel.Name = "buttonsFlowPanel";
            buttonsFlowPanel.Size = new Size(758, 38);
            buttonsFlowPanel.TabIndex = 1;
            // 
            // FormBrowary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(mainTableLayoutPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MinimumSize = new Size(600, 400);
            Name = "FormBrowary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zarządzanie Browarami";
            Load += FormBrowary_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrowary).EndInit();
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            buttonsFlowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Deklaracje pól dla kontrolek z poprawnymi nazwami
        private System.Windows.Forms.DataGridView dataGridViewBrowary;
        private System.Windows.Forms.Button btnDodajBrowar;
        private System.Windows.Forms.Button btnEdytujBrowar;
        private System.Windows.Forms.Button btnUsunBrowar;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowPanel;
    }
}