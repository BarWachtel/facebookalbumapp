namespace FacebookApp
{
    public partial class FacebookAlbumApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookAlbumApp));
            this.label_userName = new System.Windows.Forms.Label();
            this.tabControl_app = new System.Windows.Forms.TabControl();
            this.tabPage_loginPage = new System.Windows.Forms.TabPage();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.linkLabelPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkLabelEvents = new System.Windows.Forms.LinkLabel();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.linkLabelFriends = new System.Windows.Forms.LinkLabel();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.pictureBox_profilePicture = new System.Windows.Forms.PictureBox();
            this.tabPage_albumPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_albumInfo = new System.Windows.Forms.GroupBox();
            this.button_saveAlbums = new System.Windows.Forms.Button();
            this.pictureBox_albumCoverPhoto = new System.Windows.Forms.PictureBox();
            this.label_lastUpdated = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_privacySettings = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_numPhotos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_albumName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayout_albumPhotos = new System.Windows.Forms.FlowLayoutPanel();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            this.tabControl_app.SuspendLayout();
            this.tabPage_loginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profilePicture)).BeginInit();
            this.tabPage_albumPage.SuspendLayout();
            this.groupBox_albumInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_albumCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(327, 246);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 21;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(327, 274);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(327, 297);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(38, 17);
            linkLabel.TabIndex = 27;
            linkLabel.Text = "Link:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(327, 326);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 29;
            nameLabel.Text = "Name:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Location = new System.Drawing.Point(327, 355);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(93, 17);
            updateTimeLabel.TabIndex = 31;
            updateTimeLabel.Text = "Update Time:";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(13, 13);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(0, 17);
            this.label_userName.TabIndex = 0;
            // 
            // tabControl_app
            // 
            this.tabControl_app.Controls.Add(this.tabPage_loginPage);
            this.tabControl_app.Controls.Add(this.tabPage_albumPage);
            this.tabControl_app.Location = new System.Drawing.Point(12, 12);
            this.tabControl_app.Name = "tabControl_app";
            this.tabControl_app.SelectedIndex = 0;
            this.tabControl_app.Size = new System.Drawing.Size(1038, 423);
            this.tabControl_app.TabIndex = 6;
            // 
            // tabPage_loginPage
            // 
            this.tabPage_loginPage.AutoScroll = true;
            this.tabPage_loginPage.Controls.Add(birthdayLabel);
            this.tabPage_loginPage.Controls.Add(this.birthdayTextBox);
            this.tabPage_loginPage.Controls.Add(emailLabel);
            this.tabPage_loginPage.Controls.Add(this.emailTextBox);
            this.tabPage_loginPage.Controls.Add(this.imageNormalPictureBox);
            this.tabPage_loginPage.Controls.Add(linkLabel);
            this.tabPage_loginPage.Controls.Add(this.linkLinkLabel);
            this.tabPage_loginPage.Controls.Add(nameLabel);
            this.tabPage_loginPage.Controls.Add(this.nameTextBox);
            this.tabPage_loginPage.Controls.Add(updateTimeLabel);
            this.tabPage_loginPage.Controls.Add(this.updateTimeDateTimePicker);
            this.tabPage_loginPage.Controls.Add(this.linkLabelPosts);
            this.tabPage_loginPage.Controls.Add(this.listBoxPosts);
            this.tabPage_loginPage.Controls.Add(this.linkLabelEvents);
            this.tabPage_loginPage.Controls.Add(this.listBoxEvents);
            this.tabPage_loginPage.Controls.Add(this.listBoxFriends);
            this.tabPage_loginPage.Controls.Add(this.linkLabelFriends);
            this.tabPage_loginPage.Controls.Add(this.buttonPostStatus);
            this.tabPage_loginPage.Controls.Add(this.textBoxPost);
            this.tabPage_loginPage.Controls.Add(this.label2);
            this.tabPage_loginPage.Controls.Add(this.button_login);
            this.tabPage_loginPage.Controls.Add(this.button_logout);
            this.tabPage_loginPage.Controls.Add(this.pictureBox_profilePicture);
            this.tabPage_loginPage.Location = new System.Drawing.Point(4, 25);
            this.tabPage_loginPage.Name = "tabPage_loginPage";
            this.tabPage_loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_loginPage.Size = new System.Drawing.Size(1030, 394);
            this.tabPage_loginPage.TabIndex = 0;
            this.tabPage_loginPage.Text = "Login & Basic Functions";
            this.tabPage_loginPage.UseVisualStyleBackColor = true;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(432, 243);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(128, 22);
            this.birthdayTextBox.TabIndex = 22;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(432, 271);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(128, 22);
            this.emailTextBox.TabIndex = 24;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(329, 129);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(152, 108);
            this.imageNormalPictureBox.TabIndex = 26;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(432, 297);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(128, 23);
            this.linkLinkLabel.TabIndex = 28;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(432, 323);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(128, 22);
            this.nameTextBox.TabIndex = 30;
            // 
            // updateTimeDateTimePicker
            // 
            this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "UpdateTime", true));
            this.updateTimeDateTimePicker.Location = new System.Drawing.Point(432, 351);
            this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
            this.updateTimeDateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.updateTimeDateTimePicker.TabIndex = 32;
            // 
            // linkLabelPosts
            // 
            this.linkLabelPosts.AutoSize = true;
            this.linkLabelPosts.Location = new System.Drawing.Point(667, 9);
            this.linkLabelPosts.Name = "linkLabelPosts";
            this.linkLabelPosts.Size = new System.Drawing.Size(82, 17);
            this.linkLabelPosts.TabIndex = 21;
            this.linkLabelPosts.TabStop = true;
            this.linkLabelPosts.Text = "Fetch Posts";
            this.linkLabelPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPosts_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(670, 26);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(349, 84);
            this.listBoxPosts.TabIndex = 20;
            // 
            // linkLabelEvents
            // 
            this.linkLabelEvents.AutoSize = true;
            this.linkLabelEvents.Location = new System.Drawing.Point(667, 109);
            this.linkLabelEvents.Name = "linkLabelEvents";
            this.linkLabelEvents.Size = new System.Drawing.Size(90, 17);
            this.linkLabelEvents.TabIndex = 19;
            this.linkLabelEvents.TabStop = true;
            this.linkLabelEvents.Text = "Fetch Events";
            this.linkLabelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEvents_LinkClicked);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(670, 129);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(231, 244);
            this.listBoxEvents.TabIndex = 16;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(203, 129);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(120, 244);
            this.listBoxFriends.TabIndex = 15;
            // 
            // linkLabelFriends
            // 
            this.linkLabelFriends.AutoSize = true;
            this.linkLabelFriends.Location = new System.Drawing.Point(203, 109);
            this.linkLabelFriends.Name = "linkLabelFriends";
            this.linkLabelFriends.Size = new System.Drawing.Size(120, 17);
            this.linkLabelFriends.TabIndex = 14;
            this.linkLabelFriends.TabStop = true;
            this.linkLabelFriends.Text = "Fetch Friends List";
            this.linkLabelFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFriends_LinkClicked);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(201, 31);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(95, 22);
            this.buttonPostStatus.TabIndex = 11;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.AcceptsReturn = true;
            this.textBoxPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPost.Location = new System.Drawing.Point(304, 31);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(335, 22);
            this.textBoxPost.TabIndex = 10;
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxPost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(200, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Post Status:";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(8, 216);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(81, 32);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.login_button_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(6, 216);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(81, 32);
            this.button_logout.TabIndex = 8;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // pictureBox_profilePicture
            // 
            this.pictureBox_profilePicture.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox_profilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_profilePicture.BackgroundImage")));
            this.pictureBox_profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_profilePicture.Location = new System.Drawing.Point(8, 9);
            this.pictureBox_profilePicture.Name = "pictureBox_profilePicture";
            this.pictureBox_profilePicture.Size = new System.Drawing.Size(173, 198);
            this.pictureBox_profilePicture.TabIndex = 6;
            this.pictureBox_profilePicture.TabStop = false;
            // 
            // tabPage_albumPage
            // 
            this.tabPage_albumPage.Controls.Add(this.label4);
            this.tabPage_albumPage.Controls.Add(this.groupBox_albumInfo);
            this.tabPage_albumPage.Controls.Add(this.flowLayout_albumPhotos);
            this.tabPage_albumPage.Location = new System.Drawing.Point(4, 25);
            this.tabPage_albumPage.Name = "tabPage_albumPage";
            this.tabPage_albumPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_albumPage.Size = new System.Drawing.Size(1030, 394);
            this.tabPage_albumPage.TabIndex = 1;
            this.tabPage_albumPage.Text = "Albums";
            this.tabPage_albumPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "(Press On The Album Cover In Order To Select It)";
            // 
            // groupBox_albumInfo
            // 
            this.groupBox_albumInfo.Controls.Add(this.button_saveAlbums);
            this.groupBox_albumInfo.Controls.Add(this.pictureBox_albumCoverPhoto);
            this.groupBox_albumInfo.Controls.Add(this.label_lastUpdated);
            this.groupBox_albumInfo.Controls.Add(this.label9);
            this.groupBox_albumInfo.Controls.Add(this.label_description);
            this.groupBox_albumInfo.Controls.Add(this.label6);
            this.groupBox_albumInfo.Controls.Add(this.label_privacySettings);
            this.groupBox_albumInfo.Controls.Add(this.label5);
            this.groupBox_albumInfo.Controls.Add(this.label_numPhotos);
            this.groupBox_albumInfo.Controls.Add(this.label3);
            this.groupBox_albumInfo.Controls.Add(this.label_albumName);
            this.groupBox_albumInfo.Controls.Add(this.label1);
            this.groupBox_albumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_albumInfo.Location = new System.Drawing.Point(7, 10);
            this.groupBox_albumInfo.Name = "groupBox_albumInfo";
            this.groupBox_albumInfo.Size = new System.Drawing.Size(268, 381);
            this.groupBox_albumInfo.TabIndex = 13;
            this.groupBox_albumInfo.TabStop = false;
            this.groupBox_albumInfo.Text = "Album Info.";
            // 
            // button_saveAlbums
            // 
            this.button_saveAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_saveAlbums.Location = new System.Drawing.Point(165, 347);
            this.button_saveAlbums.Name = "button_saveAlbums";
            this.button_saveAlbums.Size = new System.Drawing.Size(89, 23);
            this.button_saveAlbums.TabIndex = 12;
            this.button_saveAlbums.Text = "Save Album/s";
            this.button_saveAlbums.UseVisualStyleBackColor = true;
            this.button_saveAlbums.Click += new System.EventHandler(this.saveAlbums_Button_Click);
            // 
            // pictureBox_albumCoverPhoto
            // 
            this.pictureBox_albumCoverPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_albumCoverPhoto.BackgroundImage")));
            this.pictureBox_albumCoverPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_albumCoverPhoto.Location = new System.Drawing.Point(9, 28);
            this.pictureBox_albumCoverPhoto.Name = "pictureBox_albumCoverPhoto";
            this.pictureBox_albumCoverPhoto.Size = new System.Drawing.Size(217, 149);
            this.pictureBox_albumCoverPhoto.TabIndex = 14;
            this.pictureBox_albumCoverPhoto.TabStop = false;
            // 
            // label_lastUpdated
            // 
            this.label_lastUpdated.AutoSize = true;
            this.label_lastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_lastUpdated.Location = new System.Drawing.Point(104, 295);
            this.label_lastUpdated.Name = "label_lastUpdated";
            this.label_lastUpdated.Size = new System.Drawing.Size(84, 17);
            this.label_lastUpdated.TabIndex = 9;
            this.label_lastUpdated.Text = "lastUpdated";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(11, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Last Updated:";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_description.Location = new System.Drawing.Point(92, 275);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(77, 17);
            this.label_description.TabIndex = 7;
            this.label_description.Text = "description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(11, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description:";
            // 
            // label_privacySettings
            // 
            this.label_privacySettings.AutoSize = true;
            this.label_privacySettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_privacySettings.Location = new System.Drawing.Point(114, 245);
            this.label_privacySettings.Name = "label_privacySettings";
            this.label_privacySettings.Size = new System.Drawing.Size(104, 17);
            this.label_privacySettings.TabIndex = 5;
            this.label_privacySettings.Text = "privacySettings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(11, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Privacy Setting:";
            // 
            // label_numPhotos
            // 
            this.label_numPhotos.AutoSize = true;
            this.label_numPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_numPhotos.Location = new System.Drawing.Point(129, 226);
            this.label_numPhotos.Name = "label_numPhotos";
            this.label_numPhotos.Size = new System.Drawing.Size(79, 17);
            this.label_numPhotos.TabIndex = 3;
            this.label_numPhotos.Text = "numPhotos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(11, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Photos:";
            // 
            // label_albumName
            // 
            this.label_albumName.AutoSize = true;
            this.label_albumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_albumName.Location = new System.Drawing.Point(99, 190);
            this.label_albumName.Name = "label_albumName";
            this.label_albumName.Size = new System.Drawing.Size(83, 17);
            this.label_albumName.TabIndex = 1;
            this.label_albumName.Text = "albumName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Name:";
            // 
            // flowLayout_albumPhotos
            // 
            this.flowLayout_albumPhotos.AutoScroll = true;
            this.flowLayout_albumPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayout_albumPhotos.Location = new System.Drawing.Point(308, 26);
            this.flowLayout_albumPhotos.Name = "flowLayout_albumPhotos";
            this.flowLayout_albumPhotos.Size = new System.Drawing.Size(716, 365);
            this.flowLayout_albumPhotos.TabIndex = 11;
            // 
            // FacebookAlbumApp
            // 
            this.ClientSize = new System.Drawing.Size(1055, 442);
            this.Controls.Add(this.tabControl_app);
            this.Controls.Add(this.label_userName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacebookAlbumApp";
            this.Text = "Facebook Album App";
            this.tabControl_app.ResumeLayout(false);
            this.tabPage_loginPage.ResumeLayout(false);
            this.tabPage_loginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profilePicture)).EndInit();
            this.tabPage_albumPage.ResumeLayout(false);
            this.tabPage_albumPage.PerformLayout();
            this.groupBox_albumInfo.ResumeLayout(false);
            this.groupBox_albumInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_albumCoverPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TabControl tabControl_app;
        private System.Windows.Forms.TabPage tabPage_loginPage;
        private System.Windows.Forms.TabPage tabPage_albumPage;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.PictureBox pictureBox_profilePicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_albumPhotos;
        private System.Windows.Forms.Button button_saveAlbums;
        private System.Windows.Forms.GroupBox groupBox_albumInfo;
        private System.Windows.Forms.Label label_albumName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_numPhotos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_albumCoverPhoto;
        private System.Windows.Forms.Label label_lastUpdated;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_privacySettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.LinkLabel linkLabelFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelEvents;
        private System.Windows.Forms.LinkLabel linkLabelPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker updateTimeDateTimePicker;
    }
}