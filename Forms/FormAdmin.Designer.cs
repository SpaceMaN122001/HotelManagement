namespace HotelManagement.Forms
{
    partial class FormAdmin
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
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxSelectGender = new System.Windows.Forms.ComboBox();
            this.DateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPassportData = new System.Windows.Forms.TextBox();
            this.ComboBoxSelectBonusCard = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.ListBoxAllClients = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxSearchClientSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ListBoxAllClientsForSearching = new System.Windows.Forms.ListBox();
            this.ButtonContractForm = new System.Windows.Forms.Button();
            this.DataGridViewHotelRooms = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ColumnHotelRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHotelRoomCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHotelRoomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHotelRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHotelRoomSeatsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxSelectCategoryForSearching = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxHotelToomPriceForSearching = new System.Windows.Forms.TextBox();
            this.TextBoxSeatsCountForSearching = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ButtonSearchHotelRoom = new System.Windows.Forms.Button();
            this.ButtonFillAllHotelRooms = new System.Windows.Forms.Button();
            this.CheckBoxEnableSearchingByCategory = new System.Windows.Forms.CheckBox();
            this.CheckBoxEnableSearchingByPrice = new System.Windows.Forms.CheckBox();
            this.CheckBoxEnableSearchingBySeatsCount = new System.Windows.Forms.CheckBox();
            this.TextBoxSelectedHotelRoomNumberFromDataGridView = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DateTimePickerDateOfCheckIn = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerDateOfDeparture = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHotelRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ListBoxAllClients);
            this.tabPage1.Controls.Add(this.ButtonAddClient);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ComboBoxSelectBonusCard);
            this.tabPage1.Controls.Add(this.TextBoxPassportData);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DateTimePickerDateOfBirth);
            this.tabPage1.Controls.Add(this.ComboBoxSelectGender);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextBoxFullName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление клиентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.DateTimePickerDateOfDeparture);
            this.tabPage2.Controls.Add(this.DateTimePickerDateOfCheckIn);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TextBoxSelectedHotelRoomNumberFromDataGridView);
            this.tabPage2.Controls.Add(this.CheckBoxEnableSearchingBySeatsCount);
            this.tabPage2.Controls.Add(this.CheckBoxEnableSearchingByPrice);
            this.tabPage2.Controls.Add(this.CheckBoxEnableSearchingByCategory);
            this.tabPage2.Controls.Add(this.ButtonFillAllHotelRooms);
            this.tabPage2.Controls.Add(this.ButtonSearchHotelRoom);
            this.tabPage2.Controls.Add(this.TextBoxSeatsCountForSearching);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.TextBoxHotelToomPriceForSearching);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ComboBoxSelectCategoryForSearching);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.DataGridViewHotelRooms);
            this.tabPage2.Controls.Add(this.ButtonContractForm);
            this.tabPage2.Controls.Add(this.ListBoxAllClientsForSearching);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TextBoxSearchClientSurname);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оформление договора";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.Location = new System.Drawing.Point(3, 31);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(234, 20);
            this.TextBoxFullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пол";
            // 
            // ComboBoxSelectGender
            // 
            this.ComboBoxSelectGender.FormattingEnabled = true;
            this.ComboBoxSelectGender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.ComboBoxSelectGender.Location = new System.Drawing.Point(6, 79);
            this.ComboBoxSelectGender.Name = "ComboBoxSelectGender";
            this.ComboBoxSelectGender.Size = new System.Drawing.Size(231, 21);
            this.ComboBoxSelectGender.TabIndex = 4;
            // 
            // DateTimePickerDateOfBirth
            // 
            this.DateTimePickerDateOfBirth.Location = new System.Drawing.Point(9, 132);
            this.DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            this.DateTimePickerDateOfBirth.Size = new System.Drawing.Size(228, 20);
            this.DateTimePickerDateOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Паспортные данные(Кем выдан, дата выдачи  и тд)";
            // 
            // TextBoxPassportData
            // 
            this.TextBoxPassportData.Location = new System.Drawing.Point(9, 187);
            this.TextBoxPassportData.Name = "TextBoxPassportData";
            this.TextBoxPassportData.Size = new System.Drawing.Size(228, 20);
            this.TextBoxPassportData.TabIndex = 8;
            // 
            // ComboBoxSelectBonusCard
            // 
            this.ComboBoxSelectBonusCard.FormattingEnabled = true;
            this.ComboBoxSelectBonusCard.Items.AddRange(new object[] {
            "Обычная",
            "Золотая",
            "Платиновая"});
            this.ComboBoxSelectBonusCard.Location = new System.Drawing.Point(9, 239);
            this.ComboBoxSelectBonusCard.Name = "ComboBoxSelectBonusCard";
            this.ComboBoxSelectBonusCard.Size = new System.Drawing.Size(228, 21);
            this.ComboBoxSelectBonusCard.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Бонусная карта";
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Location = new System.Drawing.Point(9, 279);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddClient.TabIndex = 11;
            this.ButtonAddClient.Text = "Добавить";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // ListBoxAllClients
            // 
            this.ListBoxAllClients.FormattingEnabled = true;
            this.ListBoxAllClients.Location = new System.Drawing.Point(319, 49);
            this.ListBoxAllClients.Name = "ListBoxAllClients";
            this.ListBoxAllClients.Size = new System.Drawing.Size(393, 147);
            this.ListBoxAllClients.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Все клиенты";
            // 
            // TextBoxSearchClientSurname
            // 
            this.TextBoxSearchClientSurname.Location = new System.Drawing.Point(6, 39);
            this.TextBoxSearchClientSurname.Name = "TextBoxSearchClientSurname";
            this.TextBoxSearchClientSurname.Size = new System.Drawing.Size(183, 20);
            this.TextBoxSearchClientSurname.TabIndex = 0;
            this.TextBoxSearchClientSurname.TextChanged += new System.EventHandler(this.TextBoxSearchClientSurname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Введите ФИО клиента";
            // 
            // ListBoxAllClientsForSearching
            // 
            this.ListBoxAllClientsForSearching.FormattingEnabled = true;
            this.ListBoxAllClientsForSearching.Location = new System.Drawing.Point(6, 65);
            this.ListBoxAllClientsForSearching.Name = "ListBoxAllClientsForSearching";
            this.ListBoxAllClientsForSearching.Size = new System.Drawing.Size(183, 121);
            this.ListBoxAllClientsForSearching.TabIndex = 2;
            // 
            // ButtonContractForm
            // 
            this.ButtonContractForm.Location = new System.Drawing.Point(131, 359);
            this.ButtonContractForm.Name = "ButtonContractForm";
            this.ButtonContractForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonContractForm.TabIndex = 3;
            this.ButtonContractForm.Text = "Оформить";
            this.ButtonContractForm.UseVisualStyleBackColor = true;
            this.ButtonContractForm.Click += new System.EventHandler(this.ButtonContractForm_Click);
            // 
            // DataGridViewHotelRooms
            // 
            this.DataGridViewHotelRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewHotelRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHotelRoomNumber,
            this.ColumnHotelRoomCategory,
            this.ColumnHotelRoomDescription,
            this.ColumnHotelRoomPrice,
            this.ColumnHotelRoomSeatsCount});
            this.DataGridViewHotelRooms.Location = new System.Drawing.Point(207, 33);
            this.DataGridViewHotelRooms.Name = "DataGridViewHotelRooms";
            this.DataGridViewHotelRooms.ReadOnly = true;
            this.DataGridViewHotelRooms.Size = new System.Drawing.Size(547, 153);
            this.DataGridViewHotelRooms.TabIndex = 4;
            this.DataGridViewHotelRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewHotelRooms_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Гостиничные номера";
            // 
            // ColumnHotelRoomNumber
            // 
            this.ColumnHotelRoomNumber.HeaderText = "Номер комнаты";
            this.ColumnHotelRoomNumber.Name = "ColumnHotelRoomNumber";
            this.ColumnHotelRoomNumber.ReadOnly = true;
            // 
            // ColumnHotelRoomCategory
            // 
            this.ColumnHotelRoomCategory.HeaderText = "Категория";
            this.ColumnHotelRoomCategory.Name = "ColumnHotelRoomCategory";
            this.ColumnHotelRoomCategory.ReadOnly = true;
            // 
            // ColumnHotelRoomDescription
            // 
            this.ColumnHotelRoomDescription.HeaderText = "Описание";
            this.ColumnHotelRoomDescription.Name = "ColumnHotelRoomDescription";
            this.ColumnHotelRoomDescription.ReadOnly = true;
            // 
            // ColumnHotelRoomPrice
            // 
            this.ColumnHotelRoomPrice.HeaderText = "Цена";
            this.ColumnHotelRoomPrice.Name = "ColumnHotelRoomPrice";
            this.ColumnHotelRoomPrice.ReadOnly = true;
            // 
            // ColumnHotelRoomSeatsCount
            // 
            this.ColumnHotelRoomSeatsCount.HeaderText = "Кол-во мест";
            this.ColumnHotelRoomSeatsCount.Name = "ColumnHotelRoomSeatsCount";
            this.ColumnHotelRoomSeatsCount.ReadOnly = true;
            // 
            // ComboBoxSelectCategoryForSearching
            // 
            this.ComboBoxSelectCategoryForSearching.FormattingEnabled = true;
            this.ComboBoxSelectCategoryForSearching.Location = new System.Drawing.Point(207, 216);
            this.ComboBoxSelectCategoryForSearching.Name = "ComboBoxSelectCategoryForSearching";
            this.ComboBoxSelectCategoryForSearching.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSelectCategoryForSearching.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Категория";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Цена";
            // 
            // TextBoxHotelToomPriceForSearching
            // 
            this.TextBoxHotelToomPriceForSearching.Location = new System.Drawing.Point(348, 218);
            this.TextBoxHotelToomPriceForSearching.Name = "TextBoxHotelToomPriceForSearching";
            this.TextBoxHotelToomPriceForSearching.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHotelToomPriceForSearching.TabIndex = 9;
            // 
            // TextBoxSeatsCountForSearching
            // 
            this.TextBoxSeatsCountForSearching.Location = new System.Drawing.Point(464, 219);
            this.TextBoxSeatsCountForSearching.Name = "TextBoxSeatsCountForSearching";
            this.TextBoxSeatsCountForSearching.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSeatsCountForSearching.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Количество мест";
            // 
            // ButtonSearchHotelRoom
            // 
            this.ButtonSearchHotelRoom.Location = new System.Drawing.Point(590, 217);
            this.ButtonSearchHotelRoom.Name = "ButtonSearchHotelRoom";
            this.ButtonSearchHotelRoom.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearchHotelRoom.TabIndex = 12;
            this.ButtonSearchHotelRoom.Text = "Поиск";
            this.ButtonSearchHotelRoom.UseVisualStyleBackColor = true;
            this.ButtonSearchHotelRoom.Click += new System.EventHandler(this.ButtonSearchHotelRoom_Click);
            // 
            // ButtonFillAllHotelRooms
            // 
            this.ButtonFillAllHotelRooms.Location = new System.Drawing.Point(679, 218);
            this.ButtonFillAllHotelRooms.Name = "ButtonFillAllHotelRooms";
            this.ButtonFillAllHotelRooms.Size = new System.Drawing.Size(75, 23);
            this.ButtonFillAllHotelRooms.TabIndex = 13;
            this.ButtonFillAllHotelRooms.Text = "Сброс";
            this.ButtonFillAllHotelRooms.UseVisualStyleBackColor = true;
            this.ButtonFillAllHotelRooms.Click += new System.EventHandler(this.ButtonFillAllHotelRooms_Click);
            // 
            // CheckBoxEnableSearchingByCategory
            // 
            this.CheckBoxEnableSearchingByCategory.AutoSize = true;
            this.CheckBoxEnableSearchingByCategory.Checked = true;
            this.CheckBoxEnableSearchingByCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEnableSearchingByCategory.Location = new System.Drawing.Point(207, 243);
            this.CheckBoxEnableSearchingByCategory.Name = "CheckBoxEnableSearchingByCategory";
            this.CheckBoxEnableSearchingByCategory.Size = new System.Drawing.Size(45, 17);
            this.CheckBoxEnableSearchingByCategory.TabIndex = 14;
            this.CheckBoxEnableSearchingByCategory.Text = "Вкл";
            this.CheckBoxEnableSearchingByCategory.UseVisualStyleBackColor = true;
            this.CheckBoxEnableSearchingByCategory.CheckStateChanged += new System.EventHandler(this.CheckBoxEnableSearchingByCategory_CheckStateChanged);
            // 
            // CheckBoxEnableSearchingByPrice
            // 
            this.CheckBoxEnableSearchingByPrice.AutoSize = true;
            this.CheckBoxEnableSearchingByPrice.Checked = true;
            this.CheckBoxEnableSearchingByPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEnableSearchingByPrice.Location = new System.Drawing.Point(348, 244);
            this.CheckBoxEnableSearchingByPrice.Name = "CheckBoxEnableSearchingByPrice";
            this.CheckBoxEnableSearchingByPrice.Size = new System.Drawing.Size(45, 17);
            this.CheckBoxEnableSearchingByPrice.TabIndex = 15;
            this.CheckBoxEnableSearchingByPrice.Text = "Вкл";
            this.CheckBoxEnableSearchingByPrice.UseVisualStyleBackColor = true;
            this.CheckBoxEnableSearchingByPrice.CheckStateChanged += new System.EventHandler(this.CheckBoxEnableSearchingByPrice_CheckStateChanged);
            // 
            // CheckBoxEnableSearchingBySeatsCount
            // 
            this.CheckBoxEnableSearchingBySeatsCount.AutoSize = true;
            this.CheckBoxEnableSearchingBySeatsCount.Checked = true;
            this.CheckBoxEnableSearchingBySeatsCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEnableSearchingBySeatsCount.Location = new System.Drawing.Point(464, 245);
            this.CheckBoxEnableSearchingBySeatsCount.Name = "CheckBoxEnableSearchingBySeatsCount";
            this.CheckBoxEnableSearchingBySeatsCount.Size = new System.Drawing.Size(45, 17);
            this.CheckBoxEnableSearchingBySeatsCount.TabIndex = 16;
            this.CheckBoxEnableSearchingBySeatsCount.Text = "Вкл";
            this.CheckBoxEnableSearchingBySeatsCount.UseVisualStyleBackColor = true;
            this.CheckBoxEnableSearchingBySeatsCount.CheckStateChanged += new System.EventHandler(this.CheckBoxEnableSearchingBySeatsCount_CheckStateChanged);
            // 
            // TextBoxSelectedHotelRoomNumberFromDataGridView
            // 
            this.TextBoxSelectedHotelRoomNumberFromDataGridView.Location = new System.Drawing.Point(6, 220);
            this.TextBoxSelectedHotelRoomNumberFromDataGridView.Name = "TextBoxSelectedHotelRoomNumberFromDataGridView";
            this.TextBoxSelectedHotelRoomNumberFromDataGridView.ReadOnly = true;
            this.TextBoxSelectedHotelRoomNumberFromDataGridView.Size = new System.Drawing.Size(183, 20);
            this.TextBoxSelectedHotelRoomNumberFromDataGridView.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Выбранная комната";
            // 
            // DateTimePickerDateOfCheckIn
            // 
            this.DateTimePickerDateOfCheckIn.Location = new System.Drawing.Point(6, 267);
            this.DateTimePickerDateOfCheckIn.Name = "DateTimePickerDateOfCheckIn";
            this.DateTimePickerDateOfCheckIn.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerDateOfCheckIn.TabIndex = 19;
            // 
            // DateTimePickerDateOfDeparture
            // 
            this.DateTimePickerDateOfDeparture.Location = new System.Drawing.Point(6, 325);
            this.DateTimePickerDateOfDeparture.Name = "DateTimePickerDateOfDeparture";
            this.DateTimePickerDateOfDeparture.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerDateOfDeparture.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Дата выезда";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Дата заезда";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "Администратор";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHotelRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TextBoxFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxSelectGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateOfBirth;
        private System.Windows.Forms.TextBox TextBoxPassportData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxSelectBonusCard;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListBoxAllClients;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxSearchClientSurname;
        private System.Windows.Forms.ListBox ListBoxAllClientsForSearching;
        private System.Windows.Forms.Button ButtonContractForm;
        private System.Windows.Forms.DataGridView DataGridViewHotelRooms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotelRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotelRoomCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotelRoomDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotelRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotelRoomSeatsCount;
        private System.Windows.Forms.TextBox TextBoxSeatsCountForSearching;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxHotelToomPriceForSearching;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboBoxSelectCategoryForSearching;
        private System.Windows.Forms.Button ButtonFillAllHotelRooms;
        private System.Windows.Forms.Button ButtonSearchHotelRoom;
        private System.Windows.Forms.CheckBox CheckBoxEnableSearchingBySeatsCount;
        private System.Windows.Forms.CheckBox CheckBoxEnableSearchingByPrice;
        private System.Windows.Forms.CheckBox CheckBoxEnableSearchingByCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextBoxSelectedHotelRoomNumberFromDataGridView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateOfDeparture;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateOfCheckIn;
    }
}