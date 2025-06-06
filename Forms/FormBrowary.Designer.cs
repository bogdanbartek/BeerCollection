namespace BeerCollection.Forms
{
    partial class FormBrowary
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
            dataGridViewBrowary = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrowary).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBrowary
            // 
            dataGridViewBrowary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBrowary.Location = new Point(62, 241);
            dataGridViewBrowary.Name = "dataGridViewBrowary";
            dataGridViewBrowary.Size = new Size(422, 341);
            dataGridViewBrowary.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(64, 153);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 1;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDodajBrowar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 153);
            button2.Name = "button2";
            button2.Size = new Size(134, 42);
            button2.TabIndex = 2;
            button2.Text = "Edytuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEdytujBrowar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(374, 153);
            button3.Name = "button3";
            button3.Size = new Size(134, 42);
            button3.TabIndex = 3;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnUsunBrowar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(524, 153);
            button4.Name = "button4";
            button4.Size = new Size(134, 42);
            button4.TabIndex = 4;
            button4.Text = "Odśwież";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnOdswiez_Click;
            // 
            // FormBrowary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 647);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewBrowary);
            Name = "FormBrowary";
            Text = "FormBrowary";
            Load += FormBrowary_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrowary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBrowary;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}