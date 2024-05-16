namespace SilverRealtrue.Forms
{
    partial class AddNorm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ADDbutton = new Button();
            button2 = new Button();
            comboBoxDecimalNorm = new ComboBox();
            comboBoxSilverNorm = new ComboBox();
            comboBoxDepartamentNorm = new ComboBox();
            maskedTextBoxTitle = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 38);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "DecimalNorm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 75);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "SilverTypeNorm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "TitleNorm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 158);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 3;
            label4.Text = "DepartmentNorm";
            label4.Click += label4_Click;
            // 
            // ADDbutton
            // 
            ADDbutton.Location = new Point(123, 237);
            ADDbutton.Name = "ADDbutton";
            ADDbutton.Size = new Size(92, 40);
            ADDbutton.TabIndex = 4;
            ADDbutton.Text = "Добавить";
            ADDbutton.UseVisualStyleBackColor = true;
            ADDbutton.Click += ADDbutton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(303, 237);
            button2.Name = "button2";
            button2.Size = new Size(92, 40);
            button2.TabIndex = 5;
            button2.Text = "Закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxDecimalNorm
            // 
            comboBoxDecimalNorm.FormattingEnabled = true;
            comboBoxDecimalNorm.Location = new Point(250, 30);
            comboBoxDecimalNorm.Name = "comboBoxDecimalNorm";
            comboBoxDecimalNorm.Size = new Size(121, 23);
            comboBoxDecimalNorm.TabIndex = 6;
            // 
            // comboBoxSilverNorm
            // 
            comboBoxSilverNorm.FormattingEnabled = true;
            comboBoxSilverNorm.Location = new Point(250, 72);
            comboBoxSilverNorm.Name = "comboBoxSilverNorm";
            comboBoxSilverNorm.Size = new Size(121, 23);
            comboBoxSilverNorm.TabIndex = 7;
            // 
            // comboBoxDepartamentNorm
            // 
            comboBoxDepartamentNorm.FormattingEnabled = true;
            comboBoxDepartamentNorm.Location = new Point(250, 150);
            comboBoxDepartamentNorm.Name = "comboBoxDepartamentNorm";
            comboBoxDepartamentNorm.Size = new Size(121, 23);
            comboBoxDepartamentNorm.TabIndex = 8;
            // 
            // maskedTextBoxTitle
            // 
            maskedTextBoxTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxTitle.Location = new Point(250, 115);
            maskedTextBoxTitle.Mask = "0.00000";
            maskedTextBoxTitle.Name = "maskedTextBoxTitle";
            maskedTextBoxTitle.Size = new Size(121, 29);
            maskedTextBoxTitle.TabIndex = 26;
            // 
            // AddNorm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 450);
            Controls.Add(maskedTextBoxTitle);
            Controls.Add(comboBoxDepartamentNorm);
            Controls.Add(comboBoxSilverNorm);
            Controls.Add(comboBoxDecimalNorm);
            Controls.Add(button2);
            Controls.Add(ADDbutton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNorm";
            Text = "Добовление нормы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ADDbutton;
        private Button button2;
        private ComboBox comboBoxDecimalNorm;
        private ComboBox comboBoxSilverNorm;
        private ComboBox comboBoxDepartamentNorm;
        private MaskedTextBox maskedTextBoxTitle;
    }
}