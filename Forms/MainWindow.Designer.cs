namespace SilverRealtrue
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            buttonDecimalDict = new Button();
            buttonNormTB = new Button();
            checkBoxDelete = new CheckBox();
            buttonDelete = new Button();
            buttonIncorrect = new Button();
            buttonEdit = new Button();
            buttonClear = new Button();
            SearchButton = new Button();
            button2 = new Button();
            panel2 = new Panel();
            dataGridSilver = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSilver).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1035, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 441);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonDecimalDict);
            panel3.Controls.Add(buttonNormTB);
            panel3.Controls.Add(checkBoxDelete);
            panel3.Controls.Add(buttonDelete);
            panel3.Controls.Add(buttonIncorrect);
            panel3.Controls.Add(buttonEdit);
            panel3.Controls.Add(buttonClear);
            panel3.Controls.Add(SearchButton);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 380);
            panel3.TabIndex = 6;
            // 
            // buttonDecimalDict
            // 
            buttonDecimalDict.Dock = DockStyle.Top;
            buttonDecimalDict.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimalDict.Location = new Point(0, 172);
            buttonDecimalDict.Name = "buttonDecimalDict";
            buttonDecimalDict.Size = new Size(199, 51);
            buttonDecimalDict.TabIndex = 11;
            buttonDecimalDict.Text = "Справочник дец номеров";
            buttonDecimalDict.UseVisualStyleBackColor = true;
            buttonDecimalDict.Click += buttonDecimalDict_Click;
            // 
            // buttonNormTB
            // 
            buttonNormTB.Dock = DockStyle.Top;
            buttonNormTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNormTB.Location = new Point(0, 129);
            buttonNormTB.Name = "buttonNormTB";
            buttonNormTB.Size = new Size(199, 43);
            buttonNormTB.TabIndex = 10;
            buttonNormTB.Text = "Таблица с нормами";
            buttonNormTB.UseVisualStyleBackColor = true;
            buttonNormTB.Click += buttonNormTB_Click;
            // 
            // checkBoxDelete
            // 
            checkBoxDelete.AutoSize = true;
            checkBoxDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxDelete.Location = new Point(6, 135);
            checkBoxDelete.Name = "checkBoxDelete";
            checkBoxDelete.Size = new Size(187, 23);
            checkBoxDelete.TabIndex = 9;
            checkBoxDelete.Text = "Сообщение об удалении";
            checkBoxDelete.UseVisualStyleBackColor = true;
            checkBoxDelete.CheckedChanged += checkBoxDelete_CheckedChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Top;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(0, 86);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(199, 43);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonIncorrect
            // 
            buttonIncorrect.Dock = DockStyle.Bottom;
            buttonIncorrect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIncorrect.Location = new Point(0, 255);
            buttonIncorrect.Name = "buttonIncorrect";
            buttonIncorrect.Size = new Size(199, 43);
            buttonIncorrect.TabIndex = 7;
            buttonIncorrect.Text = "Некорректные нормы";
            buttonIncorrect.UseVisualStyleBackColor = true;
            buttonIncorrect.Click += buttonIncorrect_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Top;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(0, 43);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(199, 43);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonClear
            // 
            buttonClear.Dock = DockStyle.Bottom;
            buttonClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(0, 298);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(199, 41);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Очистить поиск";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // SearchButton
            // 
            SearchButton.Dock = DockStyle.Bottom;
            SearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(0, 339);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(199, 41);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(199, 43);
            button2.TabIndex = 4;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 58);
            panel2.TabIndex = 5;
            // 
            // dataGridSilver
            // 
            dataGridSilver.AllowUserToAddRows = false;
            dataGridSilver.AllowUserToDeleteRows = false;
            dataGridSilver.BackgroundColor = SystemColors.ControlLight;
            dataGridSilver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSilver.Dock = DockStyle.Fill;
            dataGridSilver.Location = new Point(0, 0);
            dataGridSilver.MultiSelect = false;
            dataGridSilver.Name = "dataGridSilver";
            dataGridSilver.ReadOnly = true;
            dataGridSilver.RowTemplate.Height = 25;
            dataGridSilver.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSilver.Size = new Size(1035, 441);
            dataGridSilver.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 441);
            Controls.Add(dataGridSilver);
            Controls.Add(panel1);
            MaximumSize = new Size(1300, 1000);
            MinimumSize = new Size(1200, 400);
            Name = "MainWindow";
            Text = "Отчёты по серебру";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSilver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SearchButton;

        private DataGridView dataGridSilver;
        private Button button2;
        private Panel panel3;
        private Panel panel2;
        private Button buttonClear;
        private Button buttonIncorrect;
        private Button buttonEdit;
        private Button buttonDelete;
        private CheckBox checkBoxDelete;
        private Button buttonNormTB;
        private Button buttonDecimalDict;
    }
}
