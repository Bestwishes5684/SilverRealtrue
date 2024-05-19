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
            dataGridDecimal = new DataGridView();
            textBoxSearch = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDecimal).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 171);
            panel1.TabIndex = 0;
            // 
            // dataGridDecimal
            // 
            dataGridDecimal.BackgroundColor = SystemColors.ControlLight;
            dataGridDecimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDecimal.Dock = DockStyle.Fill;
            dataGridDecimal.Location = new Point(0, 0);
            dataGridDecimal.Name = "dataGridDecimal";
            dataGridDecimal.RowTemplate.Height = 25;
            dataGridDecimal.Size = new Size(287, 300);
            dataGridDecimal.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Top;
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(0, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(287, 29);
            textBoxSearch.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBoxSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 66);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonDelete);
            panel3.Controls.Add(buttonEdit);
            panel3.Controls.Add(buttonAdd);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(287, 105);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 29);
            button1.Name = "button1";
            button1.Size = new Size(287, 34);
            button1.TabIndex = 1;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Top;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(287, 34);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Top;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(0, 34);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(287, 34);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Top;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(0, 68);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(287, 34);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // DecimalDictForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 471);
            Controls.Add(dataGridDecimal);
            Controls.Add(panel1);
            Name = "DecimalDictForm";
            Text = "Справочник дец номеров";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDecimal).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridDecimal;
        private TextBox textBoxSearch;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
    }
}