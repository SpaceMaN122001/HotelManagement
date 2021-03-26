namespace HotelManagement.Forms
{
    partial class FormManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridViewAllClientsForDeparturing = new System.Windows.Forms.DataGridView();
            this.ColumnContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHotelRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfDeaprture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePickerClientDeparture = new System.Windows.Forms.DateTimePicker();
            this.ButtonSearchClientsForDeparturing = new System.Windows.Forms.Button();
            this.ComboBoxSelectClientForDeparturing = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDepartureClient = new System.Windows.Forms.Button();
            this.DateTimePickerGenerateReportFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerGenerateReportTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonGenerateReport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllClientsForDeparturing)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonDepartureClient);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ComboBoxSelectClientForDeparturing);
            this.tabPage1.Controls.Add(this.ButtonSearchClientsForDeparturing);
            this.tabPage1.Controls.Add(this.DateTimePickerClientDeparture);
            this.tabPage1.Controls.Add(this.DataGridViewAllClientsForDeparturing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выселения клиентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonGenerateReport);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DateTimePickerGenerateReportTo);
            this.tabPage2.Controls.Add(this.DateTimePickerGenerateReportFrom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Формирование отчета";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGridViewAllClientsForDeparturing
            // 
            this.DataGridViewAllClientsForDeparturing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAllClientsForDeparturing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContractNumber,
            this.ColumnHotelRoomNumber,
            this.ColumnClientFullName,
            this.ColumnDateOfCheckIn,
            this.ColumnDateOfDeaprture});
            this.DataGridViewAllClientsForDeparturing.Location = new System.Drawing.Point(6, 16);
            this.DataGridViewAllClientsForDeparturing.Name = "DataGridViewAllClientsForDeparturing";
            this.DataGridViewAllClientsForDeparturing.Size = new System.Drawing.Size(552, 150);
            this.DataGridViewAllClientsForDeparturing.TabIndex = 0;
            // 
            // ColumnContractNumber
            // 
            this.ColumnContractNumber.HeaderText = "№ Договора";
            this.ColumnContractNumber.Name = "ColumnContractNumber";
            // 
            // ColumnHotelRoomNumber
            // 
            this.ColumnHotelRoomNumber.HeaderText = "№ Комнаты";
            this.ColumnHotelRoomNumber.Name = "ColumnHotelRoomNumber";
            // 
            // ColumnClientFullName
            // 
            this.ColumnClientFullName.HeaderText = "ФИО клиента";
            this.ColumnClientFullName.Name = "ColumnClientFullName";
            // 
            // ColumnDateOfCheckIn
            // 
            this.ColumnDateOfCheckIn.HeaderText = "Дата заезда";
            this.ColumnDateOfCheckIn.Name = "ColumnDateOfCheckIn";
            // 
            // ColumnDateOfDeaprture
            // 
            this.ColumnDateOfDeaprture.HeaderText = "Дата выезда";
            this.ColumnDateOfDeaprture.Name = "ColumnDateOfDeaprture";
            // 
            // DateTimePickerClientDeparture
            // 
            this.DateTimePickerClientDeparture.Location = new System.Drawing.Point(7, 173);
            this.DateTimePickerClientDeparture.Name = "DateTimePickerClientDeparture";
            this.DateTimePickerClientDeparture.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerClientDeparture.TabIndex = 1;
            // 
            // ButtonSearchClientsForDeparturing
            // 
            this.ButtonSearchClientsForDeparturing.Location = new System.Drawing.Point(236, 173);
            this.ButtonSearchClientsForDeparturing.Name = "ButtonSearchClientsForDeparturing";
            this.ButtonSearchClientsForDeparturing.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearchClientsForDeparturing.TabIndex = 2;
            this.ButtonSearchClientsForDeparturing.Text = "Поиск";
            this.ButtonSearchClientsForDeparturing.UseVisualStyleBackColor = true;
            this.ButtonSearchClientsForDeparturing.Click += new System.EventHandler(this.ButtonSearchClientsForDeparturing_Click);
            // 
            // ComboBoxSelectClientForDeparturing
            // 
            this.ComboBoxSelectClientForDeparturing.FormattingEnabled = true;
            this.ComboBoxSelectClientForDeparturing.Location = new System.Drawing.Point(7, 231);
            this.ComboBoxSelectClientForDeparturing.Name = "ComboBoxSelectClientForDeparturing";
            this.ComboBoxSelectClientForDeparturing.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSelectClientForDeparturing.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите клиента";
            // 
            // ButtonDepartureClient
            // 
            this.ButtonDepartureClient.Location = new System.Drawing.Point(134, 231);
            this.ButtonDepartureClient.Name = "ButtonDepartureClient";
            this.ButtonDepartureClient.Size = new System.Drawing.Size(75, 23);
            this.ButtonDepartureClient.TabIndex = 5;
            this.ButtonDepartureClient.Text = "Выселить";
            this.ButtonDepartureClient.UseVisualStyleBackColor = true;
            this.ButtonDepartureClient.Click += new System.EventHandler(this.ButtonDepartureClient_Click);
            // 
            // DateTimePickerGenerateReportFrom
            // 
            this.DateTimePickerGenerateReportFrom.Location = new System.Drawing.Point(6, 29);
            this.DateTimePickerGenerateReportFrom.Name = "DateTimePickerGenerateReportFrom";
            this.DateTimePickerGenerateReportFrom.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerGenerateReportFrom.TabIndex = 0;
            // 
            // DateTimePickerGenerateReportTo
            // 
            this.DateTimePickerGenerateReportTo.Location = new System.Drawing.Point(234, 29);
            this.DateTimePickerGenerateReportTo.Name = "DateTimePickerGenerateReportTo";
            this.DateTimePickerGenerateReportTo.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerGenerateReportTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "выберите дату от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "выберите дату по";
            // 
            // ButtonGenerateReport
            // 
            this.ButtonGenerateReport.Location = new System.Drawing.Point(6, 65);
            this.ButtonGenerateReport.Name = "ButtonGenerateReport";
            this.ButtonGenerateReport.Size = new System.Drawing.Size(142, 23);
            this.ButtonGenerateReport.TabIndex = 4;
            this.ButtonGenerateReport.Text = "Сгенерировать отчет";
            this.ButtonGenerateReport.UseVisualStyleBackColor = true;
            this.ButtonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormManager";
            this.Text = "Управляющий";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllClientsForDeparturing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridViewAllClientsForDeparturing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotelRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfDeaprture;
        private System.Windows.Forms.Button ButtonSearchClientsForDeparturing;
        private System.Windows.Forms.DateTimePicker DateTimePickerClientDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxSelectClientForDeparturing;
        private System.Windows.Forms.Button ButtonDepartureClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePickerGenerateReportTo;
        private System.Windows.Forms.DateTimePicker DateTimePickerGenerateReportFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonGenerateReport;
    }
}