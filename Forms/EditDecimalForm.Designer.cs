namespace SilverRealtrue.Forms
{
    partial class EditDecimalForm
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
            textBoxID = new TextBox();
            textBoxDecimalNum = new TextBox();
            label2 = new Label();
            buttonEdit = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Идентификатор";
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(182, 24);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(123, 29);
            textBoxID.TabIndex = 1;
            // 
            // textBoxDecimalNum
            // 
            textBoxDecimalNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDecimalNum.Location = new Point(145, 72);
            textBoxDecimalNum.Name = "textBoxDecimalNum";
            textBoxDecimalNum.Size = new Size(160, 29);
            textBoxDecimalNum.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(112, 42);
            label2.TabIndex = 2;
            label2.Text = "Децимальный\r\nномер\r\n";
            // 
            // buttonEdit
            // 
            buttonEdit.DialogResult = DialogResult.OK;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(32, 135);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(259, 30);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Добавить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(32, 165);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(259, 30);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EditDecimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 201);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxDecimalNum);
            Controls.Add(label2);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Name = "EditDecimalForm";
            Text = "Добавление дец. номера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxID;
        private TextBox textBoxDecimalNum;
        private Label label2;
        private Button buttonEdit;
        private Button buttonCancel;
    }
}