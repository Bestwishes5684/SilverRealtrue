namespace SilverRealtrue.Forms
{
    partial class NormForm
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
            panel1 = new Panel();
            panel3 = new Panel();
            buttonEdit = new Button();
            buttonDel = new Button();
            buttonADDNorm = new Button();
            panel2 = new Panel();
            dataGridViewNorm = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNorm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(635, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonEdit);
            panel3.Controls.Add(buttonDel);
            panel3.Controls.Add(buttonADDNorm);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 384);
            panel3.TabIndex = 4;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Top;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(0, 80);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(201, 41);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактровать ";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDel
            // 
            buttonDel.Dock = DockStyle.Top;
            buttonDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDel.Location = new Point(0, 40);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(201, 40);
            buttonDel.TabIndex = 1;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonADDNorm
            // 
            buttonADDNorm.Dock = DockStyle.Top;
            buttonADDNorm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonADDNorm.Location = new Point(0, 0);
            buttonADDNorm.Name = "buttonADDNorm";
            buttonADDNorm.Size = new Size(201, 40);
            buttonADDNorm.TabIndex = 0;
            buttonADDNorm.Text = "Добавить";
            buttonADDNorm.UseVisualStyleBackColor = true;
            buttonADDNorm.Click += buttonADDNorm_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 66);
            panel2.TabIndex = 3;
            // 
            // dataGridViewNorm
            // 
            dataGridViewNorm.BackgroundColor = SystemColors.ControlLight;
            dataGridViewNorm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNorm.Dock = DockStyle.Fill;
            dataGridViewNorm.Location = new Point(0, 0);
            dataGridViewNorm.Name = "dataGridViewNorm";
            dataGridViewNorm.RowTemplate.Height = 25;
            dataGridViewNorm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNorm.Size = new Size(635, 450);
            dataGridViewNorm.TabIndex = 1;
            // 
            // NormForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(dataGridViewNorm);
            Controls.Add(panel1);
            Name = "NormForm";
            Text = "Нормы";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNorm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewNorm;
        private Button buttonADDNorm;
        private Button buttonEdit;
        private Button buttonDel;
        private Panel panel2;
        private Panel panel3;
    }
}