﻿namespace Esoft_Project
{
    partial class FormRealEstate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealEstate));
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.Address_City_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Street_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_House_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Number_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_latitude_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_longitude_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalArea_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.Address_City_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Street_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_House_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Number_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_latitude_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_longitude_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalArea_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rooms_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Floor_Apartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.Address_City_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Street_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_House_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Number_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_latitude_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_longitude_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalArea_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalFloors_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.labelCoordinate_longitude = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelTotalArea = new System.Windows.Forms.Label();
            this.labelCoordinate_latitude = new System.Windows.Forms.Label();
            this.labelAddress_Number = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.textBoxAddress_Number = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxTotalFloors = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_latitude = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_longitude = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.labelTotalFloors = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_City.Location = new System.Drawing.Point(15, 29);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(131, 24);
            this.textBoxAddress_City.TabIndex = 0;
            this.textBoxAddress_City.TextChanged += new System.EventHandler(this.textBoxAddress_City_TextChanged);
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_City.Location = new System.Drawing.Point(12, 9);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(47, 17);
            this.labelAddress_City.TabIndex = 1;
            this.labelAddress_City.Text = "Город";
            this.labelAddress_City.Click += new System.EventHandler(this.labelAddress_City_Click);
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewRealEstateSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_City_Land,
            this.Address_Street_Land,
            this.Address_House_Land,
            this.Address_Number_Land,
            this.Coordinate_latitude_Land,
            this.Coordinate_longitude_Land,
            this.TotalArea_Land});
            this.listViewRealEstateSet_Land.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_Land.FullRowSelect = true;
            this.listViewRealEstateSet_Land.GridLines = true;
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(15, 154);
            this.listViewRealEstateSet_Land.MultiSelect = false;
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(575, 196);
            this.listViewRealEstateSet_Land.TabIndex = 2;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.Visible = false;
            this.listViewRealEstateSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Land_SelectedIndexChanged);
            // 
            // Address_City_Land
            // 
            this.Address_City_Land.Text = "Город";
            this.Address_City_Land.Width = 86;
            // 
            // Address_Street_Land
            // 
            this.Address_Street_Land.Text = "Улица";
            this.Address_Street_Land.Width = 88;
            // 
            // Address_House_Land
            // 
            this.Address_House_Land.Text = "Номер дома";
            this.Address_House_Land.Width = 78;
            // 
            // Address_Number_Land
            // 
            this.Address_Number_Land.Text = "Номер квартиры";
            this.Address_Number_Land.Width = 102;
            // 
            // Coordinate_latitude_Land
            // 
            this.Coordinate_latitude_Land.DisplayIndex = 6;
            this.Coordinate_latitude_Land.Text = "Широта";
            this.Coordinate_latitude_Land.Width = 66;
            // 
            // Coordinate_longitude_Land
            // 
            this.Coordinate_longitude_Land.DisplayIndex = 4;
            this.Coordinate_longitude_Land.Text = "Долгота";
            // 
            // TotalArea_Land
            // 
            this.TotalArea_Land.DisplayIndex = 5;
            this.TotalArea_Land.Text = "Площадь";
            this.TotalArea_Land.Width = 92;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonDel.Location = new System.Drawing.Point(412, 356);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(178, 46);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(15, 76);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(131, 23);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonAdd.Location = new System.Drawing.Point(15, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(178, 46);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonEdit.Location = new System.Drawing.Point(213, 356);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(178, 46);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewRealEstateSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_City_Apartment,
            this.Address_Street_Apartment,
            this.Address_House_Apartment,
            this.Address_Number_Apartment,
            this.Coordinate_latitude_Apartment,
            this.Coordinate_longitude_Apartment,
            this.TotalArea_Apartment,
            this.Rooms_Apartment,
            this.Floor_Apartment});
            this.listViewRealEstateSet_Apartment.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_Apartment.FullRowSelect = true;
            this.listViewRealEstateSet_Apartment.GridLines = true;
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(15, 154);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(575, 196);
            this.listViewRealEstateSet_Apartment.TabIndex = 7;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Apartment_SelectedIndexChanged);
            // 
            // Address_City_Apartment
            // 
            this.Address_City_Apartment.Text = "Город";
            this.Address_City_Apartment.Width = 42;
            // 
            // Address_Street_Apartment
            // 
            this.Address_Street_Apartment.Text = "Улица";
            this.Address_Street_Apartment.Width = 44;
            // 
            // Address_House_Apartment
            // 
            this.Address_House_Apartment.Text = "Номер дома";
            this.Address_House_Apartment.Width = 75;
            // 
            // Address_Number_Apartment
            // 
            this.Address_Number_Apartment.Text = "Номер квартиры";
            this.Address_Number_Apartment.Width = 98;
            // 
            // Coordinate_latitude_Apartment
            // 
            this.Coordinate_latitude_Apartment.Text = "Широта";
            this.Coordinate_latitude_Apartment.Width = 51;
            // 
            // Coordinate_longitude_Apartment
            // 
            this.Coordinate_longitude_Apartment.Text = "Долгота";
            this.Coordinate_longitude_Apartment.Width = 54;
            // 
            // TotalArea_Apartment
            // 
            this.TotalArea_Apartment.Text = "Площадь";
            this.TotalArea_Apartment.Width = 59;
            // 
            // Rooms_Apartment
            // 
            this.Rooms_Apartment.Text = "Количество комнат";
            this.Rooms_Apartment.Width = 107;
            // 
            // Floor_Apartment
            // 
            this.Floor_Apartment.Text = "Этаж";
            this.Floor_Apartment.Width = 38;
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewRealEstateSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_City_House,
            this.Address_Street_House,
            this.Address_House_House,
            this.Address_Number_House,
            this.Coordinate_latitude_House,
            this.Coordinate_longitude_House,
            this.TotalArea_House,
            this.TotalFloors_House});
            this.listViewRealEstateSet_House.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_House.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(15, 154);
            this.listViewRealEstateSet_House.MultiSelect = false;
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(575, 196);
            this.listViewRealEstateSet_House.TabIndex = 8;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.Visible = false;
            this.listViewRealEstateSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_House_SelectedIndexChanged);
            // 
            // Address_City_House
            // 
            this.Address_City_House.Text = "Город";
            this.Address_City_House.Width = 45;
            // 
            // Address_Street_House
            // 
            this.Address_Street_House.Text = "Улица";
            this.Address_Street_House.Width = 70;
            // 
            // Address_House_House
            // 
            this.Address_House_House.Text = "Номер дома";
            this.Address_House_House.Width = 75;
            // 
            // Address_Number_House
            // 
            this.Address_Number_House.Text = "Номер квартиры";
            this.Address_Number_House.Width = 99;
            // 
            // Coordinate_latitude_House
            // 
            this.Coordinate_latitude_House.Text = "Широта";
            this.Coordinate_latitude_House.Width = 52;
            // 
            // Coordinate_longitude_House
            // 
            this.Coordinate_longitude_House.Text = "Долгота";
            this.Coordinate_longitude_House.Width = 56;
            // 
            // TotalArea_House
            // 
            this.TotalArea_House.Text = "Площадь";
            this.TotalArea_House.Width = 59;
            // 
            // TotalFloors_House
            // 
            this.TotalFloors_House.Text = "Количество этажей";
            this.TotalFloors_House.Width = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCoordinate_longitude
            // 
            this.labelCoordinate_longitude.AutoSize = true;
            this.labelCoordinate_longitude.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate_longitude.Location = new System.Drawing.Point(158, 102);
            this.labelCoordinate_longitude.Name = "labelCoordinate_longitude";
            this.labelCoordinate_longitude.Size = new System.Drawing.Size(63, 17);
            this.labelCoordinate_longitude.TabIndex = 10;
            this.labelCoordinate_longitude.Text = "Долгота";
            this.labelCoordinate_longitude.Click += new System.EventHandler(this.labelCoordinate_longitude_Click);
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRooms.Location = new System.Drawing.Point(307, 56);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(136, 17);
            this.labelRooms.TabIndex = 11;
            this.labelRooms.Text = "Количество комнат";
            this.labelRooms.Visible = false;
            this.labelRooms.Click += new System.EventHandler(this.labelRooms_Click);
            // 
            // labelTotalArea
            // 
            this.labelTotalArea.AutoSize = true;
            this.labelTotalArea.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalArea.Location = new System.Drawing.Point(12, 102);
            this.labelTotalArea.Name = "labelTotalArea";
            this.labelTotalArea.Size = new System.Drawing.Size(69, 17);
            this.labelTotalArea.TabIndex = 12;
            this.labelTotalArea.Text = "Площадь";
            this.labelTotalArea.Click += new System.EventHandler(this.labelTotalArea_Click);
            // 
            // labelCoordinate_latitude
            // 
            this.labelCoordinate_latitude.AutoSize = true;
            this.labelCoordinate_latitude.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate_latitude.Location = new System.Drawing.Point(158, 55);
            this.labelCoordinate_latitude.Name = "labelCoordinate_latitude";
            this.labelCoordinate_latitude.Size = new System.Drawing.Size(60, 17);
            this.labelCoordinate_latitude.TabIndex = 13;
            this.labelCoordinate_latitude.Text = "Широта";
            this.labelCoordinate_latitude.Click += new System.EventHandler(this.labelCoordinate_latitude_Click);
            // 
            // labelAddress_Number
            // 
            this.labelAddress_Number.AutoSize = true;
            this.labelAddress_Number.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_Number.Location = new System.Drawing.Point(456, 9);
            this.labelAddress_Number.Name = "labelAddress_Number";
            this.labelAddress_Number.Size = new System.Drawing.Size(118, 17);
            this.labelAddress_Number.TabIndex = 14;
            this.labelAddress_Number.Text = "Номер квартиры";
            this.labelAddress_Number.Click += new System.EventHandler(this.labelAddress_Number_Click);
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFloor.Location = new System.Drawing.Point(456, 56);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(43, 17);
            this.labelFloor.TabIndex = 15;
            this.labelFloor.Text = "Этаж";
            this.labelFloor.Visible = false;
            this.labelFloor.Click += new System.EventHandler(this.labelFloor_Click);
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_Street.Location = new System.Drawing.Point(158, 9);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(49, 17);
            this.labelAddress_Street.TabIndex = 17;
            this.labelAddress_Street.Text = "Улица";
            this.labelAddress_Street.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_House.Location = new System.Drawing.Point(307, 9);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(88, 17);
            this.labelAddress_House.TabIndex = 18;
            this.labelAddress_House.Text = "Номер дома";
            this.labelAddress_House.Click += new System.EventHandler(this.labelAddress_House_Click);
            // 
            // textBoxAddress_Number
            // 
            this.textBoxAddress_Number.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_Number.Location = new System.Drawing.Point(459, 29);
            this.textBoxAddress_Number.Name = "textBoxAddress_Number";
            this.textBoxAddress_Number.Size = new System.Drawing.Size(131, 24);
            this.textBoxAddress_Number.TabIndex = 19;
            this.textBoxAddress_Number.TextChanged += new System.EventHandler(this.textBoxAddress_Number_TextChanged);
            this.textBoxAddress_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_Street.Location = new System.Drawing.Point(161, 29);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(131, 24);
            this.textBoxAddress_Street.TabIndex = 20;
            this.textBoxAddress_Street.TextChanged += new System.EventHandler(this.textBoxAddress_Street_TextChanged);
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_House.Location = new System.Drawing.Point(310, 29);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(131, 24);
            this.textBoxAddress_House.TabIndex = 21;
            this.textBoxAddress_House.TextChanged += new System.EventHandler(this.textBoxAddress_House_TextChanged);
            this.textBoxAddress_House.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxTotalFloors
            // 
            this.textBoxTotalFloors.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalFloors.Location = new System.Drawing.Point(310, 122);
            this.textBoxTotalFloors.Name = "textBoxTotalFloors";
            this.textBoxTotalFloors.Size = new System.Drawing.Size(132, 24);
            this.textBoxTotalFloors.TabIndex = 22;
            this.textBoxTotalFloors.Visible = false;
            this.textBoxTotalFloors.TextChanged += new System.EventHandler(this.textBoxTotalFloors_TextChanged);
            this.textBoxTotalFloors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFloor.Location = new System.Drawing.Point(459, 76);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(131, 24);
            this.textBoxFloor.TabIndex = 23;
            this.textBoxFloor.Visible = false;
            this.textBoxFloor.TextChanged += new System.EventHandler(this.textBoxFloor_TextChanged);
            this.textBoxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxCoordinate_latitude
            // 
            this.textBoxCoordinate_latitude.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoordinate_latitude.Location = new System.Drawing.Point(161, 75);
            this.textBoxCoordinate_latitude.Name = "textBoxCoordinate_latitude";
            this.textBoxCoordinate_latitude.Size = new System.Drawing.Size(131, 24);
            this.textBoxCoordinate_latitude.TabIndex = 24;
            this.textBoxCoordinate_latitude.TextChanged += new System.EventHandler(this.textBoxCoordinate_latitude_TextChanged);
            this.textBoxCoordinate_latitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxCoordinate_longitude
            // 
            this.textBoxCoordinate_longitude.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoordinate_longitude.Location = new System.Drawing.Point(161, 122);
            this.textBoxCoordinate_longitude.Name = "textBoxCoordinate_longitude";
            this.textBoxCoordinate_longitude.Size = new System.Drawing.Size(131, 24);
            this.textBoxCoordinate_longitude.TabIndex = 25;
            this.textBoxCoordinate_longitude.TextChanged += new System.EventHandler(this.textBoxCoordinate_longitude_TextChanged);
            this.textBoxCoordinate_longitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalArea.Location = new System.Drawing.Point(15, 122);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(132, 24);
            this.textBoxTotalArea.TabIndex = 26;
            this.textBoxTotalArea.TextChanged += new System.EventHandler(this.textBoxTotalArea_TextChanged);
            this.textBoxTotalArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRooms.Location = new System.Drawing.Point(310, 76);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(131, 24);
            this.textBoxRooms.TabIndex = 27;
            this.textBoxRooms.Visible = false;
            this.textBoxRooms.TextChanged += new System.EventHandler(this.textBoxRooms_TextChanged);
            this.textBoxRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // labelTotalFloors
            // 
            this.labelTotalFloors.AutoSize = true;
            this.labelTotalFloors.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalFloors.Location = new System.Drawing.Point(307, 102);
            this.labelTotalFloors.Name = "labelTotalFloors";
            this.labelTotalFloors.Size = new System.Drawing.Size(135, 17);
            this.labelTotalFloors.TabIndex = 29;
            this.labelTotalFloors.Text = "Количество этажей";
            this.labelTotalFloors.Visible = false;
            this.labelTotalFloors.Click += new System.EventHandler(this.labelTotalFloors_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(459, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(604, 406);
            this.Controls.Add(this.labelTotalFloors);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxCoordinate_longitude);
            this.Controls.Add(this.textBoxCoordinate_latitude);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxTotalFloors);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxAddress_Number);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelAddress_Number);
            this.Controls.Add(this.labelCoordinate_latitude);
            this.Controls.Add(this.labelTotalArea);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelCoordinate_longitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.textBoxAddress_City);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRealEstate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты недвижимости";
            this.Load += new System.EventHandler(this.FormRealEstate_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormRealEstate_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCoordinate_longitude;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelTotalArea;
        private System.Windows.Forms.Label labelCoordinate_latitude;
        private System.Windows.Forms.Label labelAddress_Number;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.TextBox textBoxAddress_Number;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxTotalFloors;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxCoordinate_latitude;
        private System.Windows.Forms.TextBox textBoxCoordinate_longitude;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.ColumnHeader Address_City_Land;
        private System.Windows.Forms.ColumnHeader Address_Street_Land;
        private System.Windows.Forms.ColumnHeader Address_House_Land;
        private System.Windows.Forms.ColumnHeader Address_Number_Land;
        private System.Windows.Forms.ColumnHeader Coordinate_longitude_Land;
        private System.Windows.Forms.ColumnHeader TotalArea_Land;
        private System.Windows.Forms.ColumnHeader Address_City_Apartment;
        private System.Windows.Forms.ColumnHeader Address_Street_Apartment;
        private System.Windows.Forms.ColumnHeader Address_House_Apartment;
        private System.Windows.Forms.ColumnHeader Address_Number_Apartment;
        private System.Windows.Forms.ColumnHeader Coordinate_latitude_Apartment;
        private System.Windows.Forms.ColumnHeader Coordinate_longitude_Apartment;
        private System.Windows.Forms.ColumnHeader TotalArea_Apartment;
        private System.Windows.Forms.ColumnHeader Rooms_Apartment;
        private System.Windows.Forms.ColumnHeader Floor_Apartment;
        private System.Windows.Forms.ColumnHeader Address_City_House;
        private System.Windows.Forms.ColumnHeader Address_Street_House;
        private System.Windows.Forms.ColumnHeader Address_House_House;
        private System.Windows.Forms.ColumnHeader Address_Number_House;
        private System.Windows.Forms.ColumnHeader Coordinate_latitude_House;
        private System.Windows.Forms.ColumnHeader Coordinate_longitude_House;
        private System.Windows.Forms.ColumnHeader TotalArea_House;
        private System.Windows.Forms.ColumnHeader TotalFloors_House;
        private System.Windows.Forms.ColumnHeader Coordinate_latitude_Land;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTotalFloors;
    }
}