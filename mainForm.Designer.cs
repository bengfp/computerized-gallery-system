
namespace CGS_Win
{
    partial class mainForm
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
            this.curators = new System.Windows.Forms.TabPage();
            this.viewCuratorBtn = new System.Windows.Forms.Button();
            this.saveCuratorBtn = new System.Windows.Forms.Button();
            this.addCuratorBtn = new System.Windows.Forms.Button();
            this.CID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CFN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.artists = new System.Windows.Forms.TabPage();
            this.saveArtistBtn = new System.Windows.Forms.Button();
            this.viewArtistBtn = new System.Windows.Forms.Button();
            this.addArtistBtn = new System.Windows.Forms.Button();
            this.ArtistID_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LN_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FN_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.artPieces = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.curID_txtBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.artistID_txtbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.value_txtbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.year_txtbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listPiecesBtn = new System.Windows.Forms.Button();
            this.saveAP_btn = new System.Windows.Forms.Button();
            this.addAP_btn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.curators.SuspendLayout();
            this.artists.SuspendLayout();
            this.artPieces.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.curators);
            this.tabControl1.Controls.Add(this.artists);
            this.tabControl1.Controls.Add(this.artPieces);
            this.tabControl1.Location = new System.Drawing.Point(44, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 723);
            this.tabControl1.TabIndex = 0;
            // 
            // curators
            // 
            this.curators.BackColor = System.Drawing.Color.LightGray;
            this.curators.Controls.Add(this.viewCuratorBtn);
            this.curators.Controls.Add(this.saveCuratorBtn);
            this.curators.Controls.Add(this.addCuratorBtn);
            this.curators.Controls.Add(this.CID);
            this.curators.Controls.Add(this.label4);
            this.curators.Controls.Add(this.CLN);
            this.curators.Controls.Add(this.label3);
            this.curators.Controls.Add(this.CFN);
            this.curators.Controls.Add(this.label2);
            this.curators.Controls.Add(this.label1);
            this.curators.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curators.Location = new System.Drawing.Point(12, 58);
            this.curators.Name = "curators";
            this.curators.Padding = new System.Windows.Forms.Padding(3);
            this.curators.Size = new System.Drawing.Size(1062, 653);
            this.curators.TabIndex = 0;
            this.curators.Text = "Curators";
            // 
            // viewCuratorBtn
            // 
            this.viewCuratorBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCuratorBtn.Location = new System.Drawing.Point(690, 561);
            this.viewCuratorBtn.Name = "viewCuratorBtn";
            this.viewCuratorBtn.Size = new System.Drawing.Size(285, 85);
            this.viewCuratorBtn.TabIndex = 9;
            this.viewCuratorBtn.Text = "View Curator";
            this.viewCuratorBtn.UseVisualStyleBackColor = true;
            this.viewCuratorBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveCuratorBtn
            // 
            this.saveCuratorBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCuratorBtn.Location = new System.Drawing.Point(690, 444);
            this.saveCuratorBtn.Name = "saveCuratorBtn";
            this.saveCuratorBtn.Size = new System.Drawing.Size(285, 85);
            this.saveCuratorBtn.TabIndex = 8;
            this.saveCuratorBtn.Text = "Save Curator";
            this.saveCuratorBtn.UseVisualStyleBackColor = true;
            this.saveCuratorBtn.Click += new System.EventHandler(this.saveCuratorBtn_Click);
            // 
            // addCuratorBtn
            // 
            this.addCuratorBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCuratorBtn.Location = new System.Drawing.Point(690, 350);
            this.addCuratorBtn.Name = "addCuratorBtn";
            this.addCuratorBtn.Size = new System.Drawing.Size(285, 85);
            this.addCuratorBtn.TabIndex = 7;
            this.addCuratorBtn.Text = "Add Curator";
            this.addCuratorBtn.UseVisualStyleBackColor = true;
            this.addCuratorBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CID
            // 
            this.CID.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID.Location = new System.Drawing.Point(282, 327);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(371, 58);
            this.CID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
            // 
            // CLN
            // 
            this.CLN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLN.Location = new System.Drawing.Point(282, 222);
            this.CLN.Name = "CLN";
            this.CLN.Size = new System.Drawing.Size(371, 58);
            this.CLN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name:";
            // 
            // CFN
            // 
            this.CFN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFN.Location = new System.Drawing.Point(282, 131);
            this.CFN.Name = "CFN";
            this.CFN.Size = new System.Drawing.Size(371, 58);
            this.CFN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curator Information:";
            // 
            // artists
            // 
            this.artists.BackColor = System.Drawing.Color.LightGray;
            this.artists.Controls.Add(this.saveArtistBtn);
            this.artists.Controls.Add(this.viewArtistBtn);
            this.artists.Controls.Add(this.addArtistBtn);
            this.artists.Controls.Add(this.ArtistID_textbox);
            this.artists.Controls.Add(this.label6);
            this.artists.Controls.Add(this.LN_textbox);
            this.artists.Controls.Add(this.label7);
            this.artists.Controls.Add(this.FN_textbox);
            this.artists.Controls.Add(this.label8);
            this.artists.Controls.Add(this.label9);
            this.artists.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artists.Location = new System.Drawing.Point(12, 58);
            this.artists.Name = "artists";
            this.artists.Padding = new System.Windows.Forms.Padding(3);
            this.artists.Size = new System.Drawing.Size(1062, 653);
            this.artists.TabIndex = 1;
            this.artists.Text = "Artists";
            // 
            // saveArtistBtn
            // 
            this.saveArtistBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveArtistBtn.Location = new System.Drawing.Point(722, 441);
            this.saveArtistBtn.Name = "saveArtistBtn";
            this.saveArtistBtn.Size = new System.Drawing.Size(285, 85);
            this.saveArtistBtn.TabIndex = 20;
            this.saveArtistBtn.Text = "Save Artist";
            this.saveArtistBtn.UseVisualStyleBackColor = true;
            this.saveArtistBtn.Click += new System.EventHandler(this.saveArtistBtn_Click);
            // 
            // viewArtistBtn
            // 
            this.viewArtistBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewArtistBtn.Location = new System.Drawing.Point(722, 532);
            this.viewArtistBtn.Name = "viewArtistBtn";
            this.viewArtistBtn.Size = new System.Drawing.Size(285, 85);
            this.viewArtistBtn.TabIndex = 19;
            this.viewArtistBtn.Text = "View Artists";
            this.viewArtistBtn.UseVisualStyleBackColor = true;
            this.viewArtistBtn.Click += new System.EventHandler(this.viewArtistBtn_Click);
            // 
            // addArtistBtn
            // 
            this.addArtistBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArtistBtn.Location = new System.Drawing.Point(722, 344);
            this.addArtistBtn.Name = "addArtistBtn";
            this.addArtistBtn.Size = new System.Drawing.Size(285, 85);
            this.addArtistBtn.TabIndex = 17;
            this.addArtistBtn.Text = "Add Artist";
            this.addArtistBtn.UseVisualStyleBackColor = true;
            this.addArtistBtn.Click += new System.EventHandler(this.addArtistBtn_Click);
            // 
            // ArtistID_textbox
            // 
            this.ArtistID_textbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistID_textbox.Location = new System.Drawing.Point(295, 319);
            this.ArtistID_textbox.Name = "ArtistID_textbox";
            this.ArtistID_textbox.Size = new System.Drawing.Size(371, 58);
            this.ArtistID_textbox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 46);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID:";
            // 
            // LN_textbox
            // 
            this.LN_textbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN_textbox.Location = new System.Drawing.Point(295, 216);
            this.LN_textbox.Name = "LN_textbox";
            this.LN_textbox.Size = new System.Drawing.Size(371, 58);
            this.LN_textbox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 46);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last name:";
            // 
            // FN_textbox
            // 
            this.FN_textbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN_textbox.Location = new System.Drawing.Point(295, 125);
            this.FN_textbox.Name = "FN_textbox";
            this.FN_textbox.Size = new System.Drawing.Size(371, 58);
            this.FN_textbox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 46);
            this.label8.TabIndex = 11;
            this.label8.Text = "First name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(349, 45);
            this.label9.TabIndex = 10;
            this.label9.Text = "Artist Information:";
            // 
            // artPieces
            // 
            this.artPieces.BackColor = System.Drawing.Color.LightGray;
            this.artPieces.Controls.Add(this.groupBox1);
            this.artPieces.Controls.Add(this.curID_txtBox);
            this.artPieces.Controls.Add(this.label16);
            this.artPieces.Controls.Add(this.artistID_txtbox);
            this.artPieces.Controls.Add(this.label15);
            this.artPieces.Controls.Add(this.value_txtbox);
            this.artPieces.Controls.Add(this.label14);
            this.artPieces.Controls.Add(this.year_txtbox);
            this.artPieces.Controls.Add(this.label13);
            this.artPieces.Controls.Add(this.title_txtbox);
            this.artPieces.Controls.Add(this.label12);
            this.artPieces.Controls.Add(this.ID_txtbox);
            this.artPieces.Controls.Add(this.label11);
            this.artPieces.Controls.Add(this.label10);
            this.artPieces.Controls.Add(this.listPiecesBtn);
            this.artPieces.Controls.Add(this.saveAP_btn);
            this.artPieces.Controls.Add(this.addAP_btn);
            this.artPieces.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artPieces.Location = new System.Drawing.Point(12, 58);
            this.artPieces.Name = "artPieces";
            this.artPieces.Padding = new System.Windows.Forms.Padding(3);
            this.artPieces.Size = new System.Drawing.Size(1062, 653);
            this.artPieces.TabIndex = 2;
            this.artPieces.Text = "Art Pieces";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(700, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 228);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(51, 137);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(241, 49);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "In Storage";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(254, 49);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "On Display";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // curID_txtBox
            // 
            this.curID_txtBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curID_txtBox.Location = new System.Drawing.Point(285, 575);
            this.curID_txtBox.Name = "curID_txtBox";
            this.curID_txtBox.Size = new System.Drawing.Size(371, 58);
            this.curID_txtBox.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 581);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(204, 46);
            this.label16.TabIndex = 27;
            this.label16.Text = "Curator ID:";
            // 
            // artistID_txtbox
            // 
            this.artistID_txtbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistID_txtbox.Location = new System.Drawing.Point(285, 475);
            this.artistID_txtbox.Name = "artistID_txtbox";
            this.artistID_txtbox.Size = new System.Drawing.Size(371, 58);
            this.artistID_txtbox.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 46);
            this.label15.TabIndex = 25;
            this.label15.Text = "Artist ID:";
            // 
            // value_txtbox
            // 
            this.value_txtbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_txtbox.Location = new System.Drawing.Point(285, 379);
            this.value_txtbox.Name = "value_txtbox";
            this.value_txtbox.Size = new System.Drawing.Size(371, 58);
            this.value_txtbox.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 46);
            this.label14.TabIndex = 23;
            this.label14.Text = "Value:";
            // 
            // year_txtbox
            // 
            this.year_txtbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_txtbox.Location = new System.Drawing.Point(285, 285);
            this.year_txtbox.Name = "year_txtbox";
            this.year_txtbox.Size = new System.Drawing.Size(371, 58);
            this.year_txtbox.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 46);
            this.label13.TabIndex = 21;
            this.label13.Text = "Year:";
            // 
            // title_txtbox
            // 
            this.title_txtbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txtbox.Location = new System.Drawing.Point(285, 191);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(371, 58);
            this.title_txtbox.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 46);
            this.label12.TabIndex = 19;
            this.label12.Text = "Title:";
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txtbox.Location = new System.Drawing.Point(285, 100);
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.Size = new System.Drawing.Size(371, 58);
            this.ID_txtbox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 46);
            this.label11.TabIndex = 17;
            this.label11.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 45);
            this.label10.TabIndex = 13;
            this.label10.Text = "ArtPiece Information:";
            // 
            // listPiecesBtn
            // 
            this.listPiecesBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPiecesBtn.Location = new System.Drawing.Point(751, 546);
            this.listPiecesBtn.Name = "listPiecesBtn";
            this.listPiecesBtn.Size = new System.Drawing.Size(285, 85);
            this.listPiecesBtn.TabIndex = 12;
            this.listPiecesBtn.Text = "List Pieces";
            this.listPiecesBtn.UseVisualStyleBackColor = true;
            // 
            // saveAP_btn
            // 
            this.saveAP_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAP_btn.Location = new System.Drawing.Point(751, 430);
            this.saveAP_btn.Name = "saveAP_btn";
            this.saveAP_btn.Size = new System.Drawing.Size(285, 85);
            this.saveAP_btn.TabIndex = 11;
            this.saveAP_btn.Text = "Save  Art Piece";
            this.saveAP_btn.UseVisualStyleBackColor = true;
            this.saveAP_btn.Click += new System.EventHandler(this.saveAP_btn_Click);
            // 
            // addAP_btn
            // 
            this.addAP_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAP_btn.Location = new System.Drawing.Point(751, 336);
            this.addAP_btn.Name = "addAP_btn";
            this.addAP_btn.Size = new System.Drawing.Size(285, 85);
            this.addAP_btn.TabIndex = 10;
            this.addAP_btn.Text = "Add Art Piece";
            this.addAP_btn.UseVisualStyleBackColor = true;
            this.addAP_btn.Click += new System.EventHandler(this.addAP_btn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1146, 672);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(263, 91);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 808);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1274, 246);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // tabLabel
            // 
            this.tabLabel.AutoSize = true;
            this.tabLabel.Location = new System.Drawing.Point(48, 1064);
            this.tabLabel.Name = "tabLabel";
            this.tabLabel.Size = new System.Drawing.Size(102, 37);
            this.tabLabel.TabIndex = 3;
            this.tabLabel.Text = "label5";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1466, 1153);
            this.Controls.Add(this.tabLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "cgsArt";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.curators.ResumeLayout(false);
            this.curators.PerformLayout();
            this.artists.ResumeLayout(false);
            this.artists.PerformLayout();
            this.artPieces.ResumeLayout(false);
            this.artPieces.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage curators;
        private System.Windows.Forms.Button viewCuratorBtn;
        private System.Windows.Forms.Button saveCuratorBtn;
        private System.Windows.Forms.Button addCuratorBtn;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CFN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage artists;
        private System.Windows.Forms.TabPage artPieces;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label tabLabel;
        private System.Windows.Forms.Button viewArtistBtn;
        private System.Windows.Forms.Button addArtistBtn;
        private System.Windows.Forms.TextBox ArtistID_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LN_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FN_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox curID_txtBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox artistID_txtbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox value_txtbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox year_txtbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ID_txtbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button listPiecesBtn;
        private System.Windows.Forms.Button saveAP_btn;
        private System.Windows.Forms.Button addAP_btn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button saveArtistBtn;
    }
}