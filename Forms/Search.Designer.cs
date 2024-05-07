namespace SilverRealtrue
{
    partial class Search
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
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(31, 60);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(269, 31);
            textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.DialogResult = DialogResult.OK;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(31, 130);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(99, 30);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += button1_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(201, 130);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(99, 30);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Отмена";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 3;
            label1.Text = "Поиск по номеру чека";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 191);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Name = "Search";
            Text = "Поиск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonClose;
        private Label label1;
    }
}