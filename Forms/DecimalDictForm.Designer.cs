namespace SilverRealtrue.Forms
{
    partial class DecimalDictForm
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
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            panel2 = new Panel();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridDecimal = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDecimal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 171);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonDelete);
            panel3.Controls.Add(buttonEdit);
            panel3.Controls.Add(buttonAdd);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 105);
            panel3.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Top;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(0, 68);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(259, 34);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Top;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(0, 34);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(259, 34);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Top;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(259, 34);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonSearch);
            panel2.Controls.Add(textBoxSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 66);
            panel2.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Top;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(0, 29);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(259, 34);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Top;
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(0, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(259, 29);
            textBoxSearch.TabIndex = 0;
            // 
            // dataGridDecimal
            // 
            dataGridDecimal.BackgroundColor = SystemColors.ControlLight;
            dataGridDecimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDecimal.Dock = DockStyle.Fill;
            dataGridDecimal.Location = new Point(0, 0);
            dataGridDecimal.Name = "dataGridDecimal";
            dataGridDecimal.RowTemplate.Height = 25;
            dataGridDecimal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDecimal.Size = new Size(259, 300);
            dataGridDecimal.TabIndex = 1;
            // 
            // DecimalDictForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 471);
            Controls.Add(dataGridDecimal);
            Controls.Add(panel1);
            MaximumSize = new Size(400, 600);
            MinimumSize = new Size(275, 400);
            Name = "DecimalDictForm";
            Text = "Справочник дец номеров";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDecimal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridDecimal;
        private TextBox textBoxSearch;
        private Panel panel2;
        private Panel panel3;
        private Button buttonSearch;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
    }
}