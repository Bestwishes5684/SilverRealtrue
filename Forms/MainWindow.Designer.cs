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
            panel1.Location = new Point(939, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
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
            dataGridSilver.Size = new Size(939, 450);
            dataGridSilver.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 450);
            Controls.Add(dataGridSilver);
            Controls.Add(panel1);
            MaximumSize = new Size(1154, 1000);
            MinimumSize = new Size(1000, 400);
            Name = "MainWindow";
            Text = "Отчёты по серебру";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
    }
}
