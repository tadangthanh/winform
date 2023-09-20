﻿namespace QuanLyKhachSan.Views
{
    partial class Booking
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtAmen = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCustomerId = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dpCheckout = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbUrlImg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbAmenities = new System.Windows.Forms.Label();
            this.cbbTypeRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgListReservation = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbbSortReservation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearchReservation = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.picRoomUrl = new System.Windows.Forms.PictureBox();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListReservation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtAmen);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbUrlImg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.lbNote);
            this.groupBox1.Controls.Add(this.lbAmenities);
            this.groupBox1.Controls.Add(this.cbbTypeRoom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picRoomUrl);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(430, 287);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(171, 68);
            this.txtDesc.TabIndex = 7;
            // 
            // txtAmen
            // 
            this.txtAmen.Location = new System.Drawing.Point(426, 98);
            this.txtAmen.Multiline = true;
            this.txtAmen.Name = "txtAmen";
            this.txtAmen.ReadOnly = true;
            this.txtAmen.Size = new System.Drawing.Size(175, 68);
            this.txtAmen.TabIndex = 7;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(426, 62);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(98, 22);
            this.lbPrice.TabIndex = 16;
            this.lbPrice.Text = "Đây lag giá:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dpCheckIn);
            this.groupBox2.Controls.Add(this.lbCustomerId);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dpCheckout);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnDatPhong);
            this.groupBox2.Controls.Add(this.txtNumberPhone);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(652, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 335);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách:";
            // 
            // lbCustomerId
            // 
            this.lbCustomerId.AutoSize = true;
            this.lbCustomerId.Location = new System.Drawing.Point(239, 16);
            this.lbCustomerId.Name = "lbCustomerId";
            this.lbCustomerId.Size = new System.Drawing.Size(0, 22);
            this.lbCustomerId.TabIndex = 14;
            this.lbCustomerId.Visible = false;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.Location = new System.Drawing.Point(169, 49);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(287, 29);
            this.txtCCCD.TabIndex = 13;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(20, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 22);
            this.label13.TabIndex = 12;
            this.label13.Text = "Số CCCD:*";
            // 
            // dpCheckout
            // 
            this.dpCheckout.CustomFormat = "dd/MM/yyyy";
            this.dpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpCheckout.Location = new System.Drawing.Point(169, 302);
            this.dpCheckout.Name = "dpCheckout";
            this.dpCheckout.Size = new System.Drawing.Size(287, 29);
            this.dpCheckout.TabIndex = 11;
            this.dpCheckout.ValueChanged += new System.EventHandler(this.dpCheckout_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(18, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ngày đến:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(18, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ngày đi (dự kiến):";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.Lime;
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatPhong.Enabled = false;
            this.btnDatPhong.Location = new System.Drawing.Point(509, 36);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(110, 40);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Tag = "";
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(169, 202);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(287, 29);
            this.txtNumberPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(169, 146);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(287, 29);
            this.txtAddress.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(169, 93);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(287, 29);
            this.txtFullName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(19, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(20, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Họ tên:";
            // 
            // lbUrlImg
            // 
            this.lbUrlImg.AutoSize = true;
            this.lbUrlImg.Location = new System.Drawing.Point(426, 251);
            this.lbUrlImg.Name = "lbUrlImg";
            this.lbUrlImg.Size = new System.Drawing.Size(78, 22);
            this.lbUrlImg.TabIndex = 14;
            this.lbUrlImg.Text = "day la url";
            this.lbUrlImg.Click += new System.EventHandler(this.lbUrlImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đường dẫn ảnh:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(426, 212);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(132, 22);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "day la trang thai";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(426, 169);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(114, 22);
            this.lbNote.TabIndex = 9;
            this.lbNote.Text = "day la ghi chu";
            // 
            // lbAmenities
            // 
            this.lbAmenities.AutoSize = true;
            this.lbAmenities.Location = new System.Drawing.Point(426, 125);
            this.lbAmenities.Name = "lbAmenities";
            this.lbAmenities.Size = new System.Drawing.Size(0, 22);
            this.lbAmenities.TabIndex = 8;
            // 
            // cbbTypeRoom
            // 
            this.cbbTypeRoom.FormattingEnabled = true;
            this.cbbTypeRoom.Location = new System.Drawing.Point(426, 26);
            this.cbbTypeRoom.Name = "cbbTypeRoom";
            this.cbbTypeRoom.Size = new System.Drawing.Size(175, 30);
            this.cbbTypeRoom.TabIndex = 6;
            this.cbbTypeRoom.SelectedIndexChanged += new System.EventHandler(this.cbbTypeRoom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiện nghi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phòng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgListReservation);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1303, 305);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đặt phòng";
            // 
            // dtgListReservation
            // 
            this.dtgListReservation.AllowUserToAddRows = false;
            this.dtgListReservation.AllowUserToDeleteRows = false;
            this.dtgListReservation.BackgroundColor = System.Drawing.Color.White;
            this.dtgListReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgListReservation.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgListReservation.Location = new System.Drawing.Point(3, 25);
            this.dtgListReservation.Name = "dtgListReservation";
            this.dtgListReservation.RowHeadersWidth = 45;
            this.dtgListReservation.Size = new System.Drawing.Size(1297, 277);
            this.dtgListReservation.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1333, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cbbSortReservation
            // 
            this.cbbSortReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortReservation.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbSortReservation.FormattingEnabled = true;
            this.cbbSortReservation.Items.AddRange(new object[] {
            "Ngày rời khỏi giảm dần",
            "Ngày rời khỏi tăng dần"});
            this.cbbSortReservation.Location = new System.Drawing.Point(856, 415);
            this.cbbSortReservation.Name = "cbbSortReservation";
            this.cbbSortReservation.Size = new System.Drawing.Size(144, 30);
            this.cbbSortReservation.Sorted = true;
            this.cbbSortReservation.TabIndex = 4;
            this.cbbSortReservation.SelectedIndexChanged += new System.EventHandler(this.cbbSortReservation_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(735, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 22);
            this.label14.TabIndex = 5;
            this.label14.Text = "Xắp xếp theo:";
            // 
            // txtSearchReservation
            // 
            this.txtSearchReservation.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchReservation.Location = new System.Drawing.Point(1097, 418);
            this.txtSearchReservation.Name = "txtSearchReservation";
            this.txtSearchReservation.Size = new System.Drawing.Size(194, 29);
            this.txtSearchReservation.TabIndex = 7;
            this.txtSearchReservation.Text = "Tìm kiếm theo tên";
            this.txtSearchReservation.TextChanged += new System.EventHandler(this.txtSearchReservation_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(1006, 423);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 22);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tìm kiếm:";
            // 
            // picRoomUrl
            // 
            this.picRoomUrl.Image = global::QuanLyKhachSan.Properties.Resources.home;
            this.picRoomUrl.Location = new System.Drawing.Point(6, 26);
            this.picRoomUrl.Name = "picRoomUrl";
            this.picRoomUrl.Size = new System.Drawing.Size(229, 212);
            this.picRoomUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoomUrl.TabIndex = 0;
            this.picRoomUrl.TabStop = false;
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListBooking,
            this.btnListCustomer});
            this.danhMụcToolStripMenuItem.Image = global::QuanLyKhachSan.Properties.Resources.options;
            this.danhMụcToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.danhMụcToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // btnListBooking
            // 
            this.btnListBooking.Image = global::QuanLyKhachSan.Properties.Resources.to_do_list;
            this.btnListBooking.Name = "btnListBooking";
            this.btnListBooking.Size = new System.Drawing.Size(212, 24);
            this.btnListBooking.Text = "Danh sách đặt phòng";
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.Image = global::QuanLyKhachSan.Properties.Resources.customer;
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Size = new System.Drawing.Size(212, 24);
            this.btnListCustomer.Text = "Danh sách khách hàng";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quảnLýPhòngToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = global::QuanLyKhachSan.Properties.Resources.management_3429694;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 24);
            this.toolStripMenuItem1.Text = "Đặt phòng";
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiPhòngToolStripMenuItem});
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.quảnLýPhòngToolStripMenuItem.Text = "Phòng";
            // 
            // loạiPhòngToolStripMenuItem
            // 
            this.loạiPhòngToolStripMenuItem.Name = "loạiPhòngToolStripMenuItem";
            this.loạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.loạiPhòngToolStripMenuItem.Text = "Loại phòng";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửĐặtPhòngToolStripMenuItem,
            this.lịchSửThanhToánToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Image = global::QuanLyKhachSan.Properties.Resources.bar_graph_151855;
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // lịchSửĐặtPhòngToolStripMenuItem
            // 
            this.lịchSửĐặtPhòngToolStripMenuItem.Name = "lịchSửĐặtPhòngToolStripMenuItem";
            this.lịchSửĐặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.lịchSửĐặtPhòngToolStripMenuItem.Text = "Lịch sử đặt phòng";
            // 
            // lịchSửThanhToánToolStripMenuItem
            // 
            this.lịchSửThanhToánToolStripMenuItem.Name = "lịchSửThanhToánToolStripMenuItem";
            this.lịchSửThanhToánToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.lịchSửThanhToánToolStripMenuItem.Text = "Lịch sử thanh toán";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Image = global::QuanLyKhachSan.Properties.Resources.operation_3080541;
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = global::QuanLyKhachSan.Properties.Resources.settings_3067451;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::QuanLyKhachSan.Properties.Resources.logout_3889524;
            this.đăngXuấtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // dpCheckIn
            // 
            this.dpCheckIn.CustomFormat = "dd/MM/yyyy";
            this.dpCheckIn.Enabled = false;
            this.dpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpCheckIn.Location = new System.Drawing.Point(169, 251);
            this.dpCheckIn.Name = "dpCheckIn";
            this.dpCheckIn.Size = new System.Drawing.Size(287, 29);
            this.dpCheckIn.TabIndex = 15;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1333, 762);
            this.Controls.Add(this.txtSearchReservation);
            this.Controls.Add(this.cbbSortReservation);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListReservation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picRoomUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTypeRoom;
        private System.Windows.Forms.Label lbAmenities;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUrlImg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtAmen;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dpCheckout;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCustomerId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgListReservation;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnListBooking;
        private System.Windows.Forms.ToolStripMenuItem btnListCustomer;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửĐặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửThanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbbSortReservation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchReservation;
        private System.Windows.Forms.DateTimePicker dpCheckIn;
    }
}