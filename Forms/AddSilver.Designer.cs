
namespace SilverRealtrue
{
    partial class AddSilver
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonAdd = new Button();
            label1 = new Label();
            comboBoxDepart = new ComboBox();
            textBoxNorm = new TextBox();
            comboBoxType = new ComboBox();
            maskedTextBoxCover = new MaskedTextBox();
            numericUpDownAmount = new NumericUpDown();
            comboBoxDecimal = new ComboBox();
            textBoxOrder = new TextBox();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 60);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 2;
            label3.Text = "Норма ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 97);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 3;
            label4.Text = "Тип серебра";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 137);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 4;
            label5.Text = "Площадь покрытия ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 173);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 5;
            label6.Text = "Количество ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 210);
            label7.Name = "label7";
            label7.Size = new Size(164, 21);
            label7.TabIndex = 6;
            label7.Text = "Децимальный Номер";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(23, 249);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 7;
            label8.Text = "Номер заказа ";
            // 
            // buttonAdd
            // 
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(23, 302);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(348, 32);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 21;
            label1.Text = "Номер цеха ";
            // 
            // comboBoxDepart
            // 
            comboBoxDepart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepart.FormattingEnabled = true;
            comboBoxDepart.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            comboBoxDepart.Location = new Point(196, 19);
            comboBoxDepart.Name = "comboBoxDepart";
            comboBoxDepart.Size = new Size(100, 29);
            comboBoxDepart.TabIndex = 22;
            // 
            // textBoxNorm
            // 
            textBoxNorm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNorm.Location = new Point(196, 57);
            textBoxNorm.Name = "textBoxNorm";
            textBoxNorm.Size = new Size(128, 29);
            textBoxNorm.TabIndex = 23;
            textBoxNorm.KeyPress += textBoxNorm_KeyPress;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(196, 94);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(175, 29);
            comboBoxType.TabIndex = 24;
            // 
            // maskedTextBoxCover
            // 
            maskedTextBoxCover.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCover.Location = new Point(196, 134);
            maskedTextBoxCover.Mask = "0.00000";
            maskedTextBoxCover.Name = "maskedTextBoxCover";
            maskedTextBoxCover.Size = new Size(100, 29);
            maskedTextBoxCover.TabIndex = 25;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmount.Location = new Point(196, 171);
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(100, 29);
            numericUpDownAmount.TabIndex = 26;
            // 
            // comboBoxDecimal
            // 
            comboBoxDecimal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDecimal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDecimal.FormattingEnabled = true;
            comboBoxDecimal.Location = new Point(196, 207);
            comboBoxDecimal.Name = "comboBoxDecimal";
            comboBoxDecimal.Size = new Size(175, 29);
            comboBoxDecimal.TabIndex = 27;
            // 
            // textBoxOrder
            // 
            textBoxOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOrder.Location = new Point(196, 246);
            textBoxOrder.Name = "textBoxOrder";
            textBoxOrder.Size = new Size(128, 29);
            textBoxOrder.TabIndex = 28;
            textBoxOrder.KeyPress += textBoxOrder_KeyPress;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(23, 340);
            buttonCancel.MaximumSize = new Size(348, 32);
            buttonCancel.MinimumSize = new Size(348, 32);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(348, 32);
            buttonCancel.TabIndex = 29;
            buttonCancel.Text = "Закрыть";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddSilver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 391);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxOrder);
            Controls.Add(comboBoxDecimal);
            Controls.Add(numericUpDownAmount);
            Controls.Add(maskedTextBoxCover);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxNorm);
            Controls.Add(comboBoxDepart);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "AddSilver";
            Text = "Формирование заказа";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonAdd;
        private Label label1;
        private ComboBox comboBoxDepart;
        private TextBox textBoxNorm;
        private ComboBox comboBoxType;
        private MaskedTextBox maskedTextBoxCover;
        private NumericUpDown numericUpDownAmount;
        private ComboBox comboBoxDecimal;
        private TextBox textBoxOrder;
        private Button buttonCancel;
    }
}