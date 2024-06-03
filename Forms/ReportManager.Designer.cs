namespace SilverRealtrue.Forms
{
    partial class ReportManager
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
            panel2 = new Panel();
            statusStripReport = new StatusStrip();
            toolStripProgressReport = new ToolStripProgressBar();
            buttonCreate = new Button();
            panel3 = new Panel();
            label3 = new Label();
            comboBoxDepartment = new ComboBox();
            label2 = new Label();
            dateTimePickerUntil = new DateTimePicker();
            label1 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            backgroundWorkerLoadReport = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            statusStripReport.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 19);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(statusStripReport);
            panel2.Controls.Add(buttonCreate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 60);
            panel2.TabIndex = 1;
            // 
            // statusStripReport
            // 
            statusStripReport.Items.AddRange(new ToolStripItem[] { toolStripProgressReport });
            statusStripReport.Location = new Point(0, 38);
            statusStripReport.Name = "statusStripReport";
            statusStripReport.Size = new Size(466, 22);
            statusStripReport.TabIndex = 6;
            statusStripReport.Text = "statusStrip1";
            // 
            // toolStripProgressReport
            // 
            toolStripProgressReport.Name = "toolStripProgressReport";
            toolStripProgressReport.Size = new Size(100, 16);
            // 
            // buttonCreate
            // 
            buttonCreate.DialogResult = DialogResult.OK;
            buttonCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(105, 3);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(259, 30);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Сформировать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBoxDepartment);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePickerUntil);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dateTimePickerFrom);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 155);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 119);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "Цех";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(221, 116);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(77, 23);
            comboBoxDepartment.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 73);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 3;
            label2.Text = "Дата окончания периода";
            // 
            // dateTimePickerUntil
            // 
            dateTimePickerUntil.Format = DateTimePickerFormat.Short;
            dateTimePickerUntil.Location = new Point(246, 67);
            dateTimePickerUntil.Name = "dateTimePickerUntil";
            dateTimePickerUntil.Size = new Size(118, 23);
            dateTimePickerUntil.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 33);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Дата начала периода";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new Point(246, 27);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(118, 23);
            dateTimePickerFrom.TabIndex = 0;
            // 
            // backgroundWorkerLoadReport
            // 
            backgroundWorkerLoadReport.DoWork += backgroundWorkerLoadReport_DoWork;
            backgroundWorkerLoadReport.RunWorkerCompleted += backgroundWorkerLoadReport_RunWorkerCompleted;
            // 
            // ReportManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 234);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReportManager";
            Text = "Сгенерировать отчёт";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStripReport.ResumeLayout(false);
            statusStripReport.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private DateTimePicker dateTimePickerFrom;
        private Label label3;
        private ComboBox comboBoxDepartment;
        private Label label2;
        private DateTimePicker dateTimePickerUntil;
        private StatusStrip statusStripReport;
        private ToolStripProgressBar toolStripProgressReport;
        private Button buttonCreate;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadReport;
    }
}