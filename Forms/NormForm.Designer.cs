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
            buttonEdit = new Button();
            buttonDel = new Button();
            buttonADDNorm = new Button();
            dataGridViewNorm = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNorm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonDel);
            panel1.Controls.Add(buttonADDNorm);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(827, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 450);
            panel1.TabIndex = 0;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(36, 60);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(89, 30);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактровать ";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(36, 110);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(89, 29);
            buttonDel.TabIndex = 1;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonADDNorm
            // 
            buttonADDNorm.Location = new Point(36, 12);
            buttonADDNorm.Name = "buttonADDNorm";
            buttonADDNorm.Size = new Size(89, 29);
            buttonADDNorm.TabIndex = 0;
            buttonADDNorm.Text = "Добавить";
            buttonADDNorm.UseVisualStyleBackColor = true;
            buttonADDNorm.Click += buttonADDNorm_Click;
            // 
            // dataGridViewNorm
            // 
            dataGridViewNorm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNorm.Dock = DockStyle.Fill;
            dataGridViewNorm.Location = new Point(0, 0);
            dataGridViewNorm.Name = "dataGridViewNorm";
            dataGridViewNorm.RowTemplate.Height = 25;
            dataGridViewNorm.Size = new Size(827, 450);
            dataGridViewNorm.TabIndex = 1;
            // 
            // NormForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 450);
            Controls.Add(dataGridViewNorm);
            Controls.Add(panel1);
            Name = "NormForm";
            Text = "Таблица Норм";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNorm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewNorm;
        private Button buttonADDNorm;
        private Button buttonEdit;
        private Button buttonDel;
    }
}