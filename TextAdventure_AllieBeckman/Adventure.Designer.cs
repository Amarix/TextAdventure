namespace TextAdventure_AllieBeckman
{
    partial class Adventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adventure));
            this.statsPanel = new System.Windows.Forms.Panel();
            this.lblCurrentExp = new System.Windows.Forms.Label();
            this.lblCrntExp = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.discriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.battlePanel = new System.Windows.Forms.Panel();
            this.manaPotCnt = new System.Windows.Forms.Label();
            this.healthPotCnt = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.equipsPanel = new System.Windows.Forms.Panel();
            this.buyHealthBtn = new System.Windows.Forms.Button();
            this.buyManaBtn = new System.Windows.Forms.Button();
            this.steelSwordBtn = new System.Windows.Forms.Button();
            this.axeBtn = new System.Windows.Forms.Button();
            this.swordBtn = new System.Windows.Forms.Button();
            this.rockSpellBtn = new System.Windows.Forms.Button();
            this.lightningSpellBtn = new System.Windows.Forms.Button();
            this.iceSpellBtn = new System.Windows.Forms.Button();
            this.fireSpellBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.directionsBtn = new System.Windows.Forms.Button();
            this.monstAttlbl = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.manaPotBtn = new System.Windows.Forms.Button();
            this.spellIcon = new System.Windows.Forms.PictureBox();
            this.weaponIcon = new System.Windows.Forms.PictureBox();
            this.healthPotBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundPicture = new System.Windows.Forms.PictureBox();
            this.monsterPictureBox = new System.Windows.Forms.PictureBox();
            this.playerSelectionPanel = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.lblNameChose = new System.Windows.Forms.Label();
            this.choicePicBox = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblChoseHealth = new System.Windows.Forms.Label();
            this.lblChoseStr = new System.Windows.Forms.Label();
            this.lblChoseMana = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.statsPanel.SuspendLayout();
            this.battlePanel.SuspendLayout();
            this.equipsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spellIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterPictureBox)).BeginInit();
            this.playerSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choicePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsPanel.Controls.Add(this.lblCurrentExp);
            this.statsPanel.Controls.Add(this.lblCrntExp);
            this.statsPanel.Controls.Add(this.playerPictureBox);
            this.statsPanel.Controls.Add(this.lblExp);
            this.statsPanel.Controls.Add(this.lblWeapon);
            this.statsPanel.Controls.Add(this.lblLevel);
            this.statsPanel.Controls.Add(this.lblMana);
            this.statsPanel.Controls.Add(this.lblHealth);
            this.statsPanel.Controls.Add(this.label5);
            this.statsPanel.Controls.Add(this.label4);
            this.statsPanel.Controls.Add(this.label3);
            this.statsPanel.Controls.Add(this.label2);
            this.statsPanel.Controls.Add(this.label1);
            this.statsPanel.Location = new System.Drawing.Point(13, 13);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(187, 145);
            this.statsPanel.TabIndex = 0;
            // 
            // lblCurrentExp
            // 
            this.lblCurrentExp.AutoSize = true;
            this.lblCurrentExp.Location = new System.Drawing.Point(72, 100);
            this.lblCurrentExp.Name = "lblCurrentExp";
            this.lblCurrentExp.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentExp.TabIndex = 12;
            this.lblCurrentExp.Text = "Exp: ";
            // 
            // lblCrntExp
            // 
            this.lblCrntExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrntExp.Location = new System.Drawing.Point(109, 100);
            this.lblCrntExp.Name = "lblCrntExp";
            this.lblCrntExp.Size = new System.Drawing.Size(65, 13);
            this.lblCrntExp.TabIndex = 11;
            // 
            // lblExp
            // 
            this.lblExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExp.Location = new System.Drawing.Point(109, 119);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(65, 13);
            this.lblExp.TabIndex = 9;
            // 
            // lblWeapon
            // 
            this.lblWeapon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeapon.Location = new System.Drawing.Point(109, 78);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(65, 13);
            this.lblWeapon.TabIndex = 8;
            this.lblWeapon.Text = "None";
            // 
            // lblLevel
            // 
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLevel.Location = new System.Drawing.Point(109, 53);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(65, 13);
            this.lblLevel.TabIndex = 7;
            // 
            // lblMana
            // 
            this.lblMana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMana.Location = new System.Drawing.Point(109, 32);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(65, 13);
            this.lblMana.TabIndex = 6;
            // 
            // lblHealth
            // 
            this.lblHealth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHealth.Location = new System.Drawing.Point(109, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(65, 13);
            this.lblHealth.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weapon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exp to next level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Command:";
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(76, 538);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(209, 20);
            this.commandTextBox.TabIndex = 1;
            this.commandTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.commandTextBox_MouseClick);
            this.commandTextBox.TextChanged += new System.EventHandler(this.commandTextBox_TextChanged);
            this.commandTextBox.Enter += new System.EventHandler(this.commandTextBox_Enter);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(291, 538);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 20);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(473, 538);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 20);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // discriptionLabel
            // 
            this.discriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriptionLabel.Location = new System.Drawing.Point(395, 46);
            this.discriptionLabel.Name = "discriptionLabel";
            this.discriptionLabel.Size = new System.Drawing.Size(156, 59);
            this.discriptionLabel.TabIndex = 6;
            this.discriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(395, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(156, 34);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.warningLabel.Location = new System.Drawing.Point(12, 431);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(399, 87);
            this.warningLabel.TabIndex = 8;
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // battlePanel
            // 
            this.battlePanel.Controls.Add(this.manaPotBtn);
            this.battlePanel.Controls.Add(this.manaPotCnt);
            this.battlePanel.Controls.Add(this.spellIcon);
            this.battlePanel.Controls.Add(this.weaponIcon);
            this.battlePanel.Controls.Add(this.healthPotCnt);
            this.battlePanel.Controls.Add(this.magicButton);
            this.battlePanel.Controls.Add(this.healthPotBtn);
            this.battlePanel.Controls.Add(this.attackButton);
            this.battlePanel.Enabled = false;
            this.battlePanel.Location = new System.Drawing.Point(395, 421);
            this.battlePanel.Name = "battlePanel";
            this.battlePanel.Size = new System.Drawing.Size(153, 97);
            this.battlePanel.TabIndex = 9;
            // 
            // manaPotCnt
            // 
            this.manaPotCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manaPotCnt.Location = new System.Drawing.Point(115, 30);
            this.manaPotCnt.Name = "manaPotCnt";
            this.manaPotCnt.Size = new System.Drawing.Size(29, 23);
            this.manaPotCnt.TabIndex = 6;
            this.manaPotCnt.Text = "0";
            this.manaPotCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthPotCnt
            // 
            this.healthPotCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthPotCnt.Location = new System.Drawing.Point(46, 30);
            this.healthPotCnt.Name = "healthPotCnt";
            this.healthPotCnt.Size = new System.Drawing.Size(29, 23);
            this.healthPotCnt.TabIndex = 3;
            this.healthPotCnt.Text = "0";
            this.healthPotCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(5, 61);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(113, 23);
            this.magicButton.TabIndex = 4;
            this.magicButton.Text = "Magic";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(5, 0);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(113, 23);
            this.attackButton.TabIndex = 7;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // equipsPanel
            // 
            this.equipsPanel.Controls.Add(this.buyHealthBtn);
            this.equipsPanel.Controls.Add(this.buyManaBtn);
            this.equipsPanel.Controls.Add(this.steelSwordBtn);
            this.equipsPanel.Controls.Add(this.axeBtn);
            this.equipsPanel.Controls.Add(this.swordBtn);
            this.equipsPanel.Controls.Add(this.rockSpellBtn);
            this.equipsPanel.Controls.Add(this.lightningSpellBtn);
            this.equipsPanel.Controls.Add(this.iceSpellBtn);
            this.equipsPanel.Controls.Add(this.fireSpellBtn);
            this.equipsPanel.Controls.Add(this.label7);
            this.equipsPanel.Controls.Add(this.pictureBox3);
            this.equipsPanel.Location = new System.Drawing.Point(12, 282);
            this.equipsPanel.Name = "equipsPanel";
            this.equipsPanel.Size = new System.Drawing.Size(539, 223);
            this.equipsPanel.TabIndex = 10;
            this.equipsPanel.Visible = false;
            // 
            // buyHealthBtn
            // 
            this.buyHealthBtn.BackColor = System.Drawing.Color.Tomato;
            this.buyHealthBtn.Location = new System.Drawing.Point(297, 158);
            this.buyHealthBtn.Name = "buyHealthBtn";
            this.buyHealthBtn.Size = new System.Drawing.Size(80, 61);
            this.buyHealthBtn.TabIndex = 15;
            this.buyHealthBtn.Text = "Buy Health Potion\r\n(Cost: 2 exp)";
            this.buyHealthBtn.UseVisualStyleBackColor = false;
            this.buyHealthBtn.Click += new System.EventHandler(this.buyHealthBtn_Click);
            // 
            // buyManaBtn
            // 
            this.buyManaBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buyManaBtn.Location = new System.Drawing.Point(409, 72);
            this.buyManaBtn.Name = "buyManaBtn";
            this.buyManaBtn.Size = new System.Drawing.Size(80, 61);
            this.buyManaBtn.TabIndex = 16;
            this.buyManaBtn.Text = "Buy Mana Potion\r\n(Cost: 2 exp)";
            this.buyManaBtn.UseVisualStyleBackColor = false;
            this.buyManaBtn.Click += new System.EventHandler(this.buyManaBtn_Click);
            // 
            // steelSwordBtn
            // 
            this.steelSwordBtn.Enabled = false;
            this.steelSwordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.steelSwordBtn.Location = new System.Drawing.Point(203, 158);
            this.steelSwordBtn.Name = "steelSwordBtn";
            this.steelSwordBtn.Size = new System.Drawing.Size(85, 61);
            this.steelSwordBtn.TabIndex = 13;
            this.steelSwordBtn.Text = "Steel Sword\r\nDamage: 5";
            this.steelSwordBtn.UseVisualStyleBackColor = true;
            this.steelSwordBtn.Click += new System.EventHandler(this.steelSwordBtn_Click);
            // 
            // axeBtn
            // 
            this.axeBtn.Enabled = false;
            this.axeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.axeBtn.Location = new System.Drawing.Point(103, 158);
            this.axeBtn.Name = "axeBtn";
            this.axeBtn.Size = new System.Drawing.Size(85, 61);
            this.axeBtn.TabIndex = 11;
            this.axeBtn.Text = "Axe\r\nDamage: 3";
            this.axeBtn.UseVisualStyleBackColor = true;
            this.axeBtn.Click += new System.EventHandler(this.axeBtn_Click);
            // 
            // swordBtn
            // 
            this.swordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swordBtn.Location = new System.Drawing.Point(6, 158);
            this.swordBtn.Name = "swordBtn";
            this.swordBtn.Size = new System.Drawing.Size(85, 61);
            this.swordBtn.TabIndex = 9;
            this.swordBtn.Text = "Wood\r\n Sword\r\nDamage: 2";
            this.swordBtn.UseVisualStyleBackColor = true;
            this.swordBtn.Click += new System.EventHandler(this.swordBtn_Click);
            // 
            // rockSpellBtn
            // 
            this.rockSpellBtn.Enabled = false;
            this.rockSpellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rockSpellBtn.Location = new System.Drawing.Point(305, 72);
            this.rockSpellBtn.Name = "rockSpellBtn";
            this.rockSpellBtn.Size = new System.Drawing.Size(85, 61);
            this.rockSpellBtn.TabIndex = 14;
            this.rockSpellBtn.Text = "Rock Spell\r\nMana cost: 5\r\nDamage: 10";
            this.rockSpellBtn.UseVisualStyleBackColor = true;
            this.rockSpellBtn.Click += new System.EventHandler(this.rockSpellBtn_Click);
            // 
            // lightningSpellBtn
            // 
            this.lightningSpellBtn.Enabled = false;
            this.lightningSpellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightningSpellBtn.Location = new System.Drawing.Point(203, 72);
            this.lightningSpellBtn.Name = "lightningSpellBtn";
            this.lightningSpellBtn.Size = new System.Drawing.Size(85, 61);
            this.lightningSpellBtn.TabIndex = 12;
            this.lightningSpellBtn.Text = "Light Spell\r\nMana cost: 2\r\nDamage: 4";
            this.lightningSpellBtn.UseVisualStyleBackColor = true;
            this.lightningSpellBtn.Click += new System.EventHandler(this.lightningSpellBtn_Click);
            // 
            // iceSpellBtn
            // 
            this.iceSpellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iceSpellBtn.Location = new System.Drawing.Point(103, 72);
            this.iceSpellBtn.Name = "iceSpellBtn";
            this.iceSpellBtn.Size = new System.Drawing.Size(85, 61);
            this.iceSpellBtn.TabIndex = 10;
            this.iceSpellBtn.Text = "Ice Spell\r\nMana cost: 1\r\nDamage: 2";
            this.iceSpellBtn.UseVisualStyleBackColor = true;
            this.iceSpellBtn.Click += new System.EventHandler(this.iceSpellBtn_Click);
            // 
            // fireSpellBtn
            // 
            this.fireSpellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fireSpellBtn.Location = new System.Drawing.Point(6, 72);
            this.fireSpellBtn.Name = "fireSpellBtn";
            this.fireSpellBtn.Size = new System.Drawing.Size(85, 61);
            this.fireSpellBtn.TabIndex = 8;
            this.fireSpellBtn.Text = "Fire Spell\r\nMana cost: 3\r\nDamage: 5";
            this.fireSpellBtn.UseVisualStyleBackColor = true;
            this.fireSpellBtn.Click += new System.EventHandler(this.fireSpellBtn_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(7, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(532, 49);
            this.label7.TabIndex = 0;
            this.label7.Text = "Equipment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directionsBtn
            // 
            this.directionsBtn.Location = new System.Drawing.Point(395, 537);
            this.directionsBtn.Name = "directionsBtn";
            this.directionsBtn.Size = new System.Drawing.Size(75, 21);
            this.directionsBtn.TabIndex = 2;
            this.directionsBtn.Text = "Directions";
            this.directionsBtn.UseVisualStyleBackColor = true;
            this.directionsBtn.Click += new System.EventHandler(this.directionsBtn_Click);
            // 
            // monstAttlbl
            // 
            this.monstAttlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monstAttlbl.ForeColor = System.Drawing.Color.Maroon;
            this.monstAttlbl.Location = new System.Drawing.Point(13, 395);
            this.monstAttlbl.Name = "monstAttlbl";
            this.monstAttlbl.Size = new System.Drawing.Size(539, 27);
            this.monstAttlbl.TabIndex = 11;
            this.monstAttlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesBtn
            // 
            this.yesBtn.Enabled = false;
            this.yesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.Location = new System.Drawing.Point(184, 223);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(101, 59);
            this.yesBtn.TabIndex = 17;
            this.yesBtn.Text = "YES";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Visible = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Enabled = false;
            this.noBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.Location = new System.Drawing.Point(301, 223);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(101, 59);
            this.noBtn.TabIndex = 18;
            this.noBtn.Text = "NO";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Visible = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // manaPotBtn
            // 
            this.manaPotBtn.BackgroundImage = global::TextAdventure_AllieBeckman.Properties.Resources.bluePotIcon;
            this.manaPotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manaPotBtn.Location = new System.Drawing.Point(77, 25);
            this.manaPotBtn.Name = "manaPotBtn";
            this.manaPotBtn.Size = new System.Drawing.Size(41, 33);
            this.manaPotBtn.TabIndex = 5;
            this.manaPotBtn.UseVisualStyleBackColor = true;
            this.manaPotBtn.Click += new System.EventHandler(this.manaPotBtn_Click);
            // 
            // spellIcon
            // 
            this.spellIcon.BackgroundImage = global::TextAdventure_AllieBeckman.Properties.Resources.fire;
            this.spellIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spellIcon.Location = new System.Drawing.Point(115, 61);
            this.spellIcon.Name = "spellIcon";
            this.spellIcon.Size = new System.Drawing.Size(29, 23);
            this.spellIcon.TabIndex = 5;
            this.spellIcon.TabStop = false;
            // 
            // weaponIcon
            // 
            this.weaponIcon.BackgroundImage = global::TextAdventure_AllieBeckman.Properties.Resources.sword;
            this.weaponIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weaponIcon.Location = new System.Drawing.Point(115, 0);
            this.weaponIcon.Name = "weaponIcon";
            this.weaponIcon.Size = new System.Drawing.Size(29, 23);
            this.weaponIcon.TabIndex = 4;
            this.weaponIcon.TabStop = false;
            // 
            // healthPotBtn
            // 
            this.healthPotBtn.BackgroundImage = global::TextAdventure_AllieBeckman.Properties.Resources.redPotIcon;
            this.healthPotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.healthPotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPotBtn.Location = new System.Drawing.Point(5, 25);
            this.healthPotBtn.Name = "healthPotBtn";
            this.healthPotBtn.Size = new System.Drawing.Size(41, 33);
            this.healthPotBtn.TabIndex = 6;
            this.healthPotBtn.UseVisualStyleBackColor = true;
            this.healthPotBtn.Click += new System.EventHandler(this.healthPotBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TextAdventure_AllieBeckman.Properties.Resources.insideShed;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-10, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(549, 237);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerPictureBox.BackgroundImage = global::TextAdventure_AllieBeckman.Properties.Resources.wizard;
            this.playerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerPictureBox.Location = new System.Drawing.Point(4, 9);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(56, 58);
            this.playerPictureBox.TabIndex = 10;
            this.playerPictureBox.TabStop = false;
            // 
            // backgroundPicture
            // 
            this.backgroundPicture.BackgroundImage = global::TextAdventure_AllieBeckman.Properties.Resources.roomTwo;
            this.backgroundPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPicture.Location = new System.Drawing.Point(12, 12);
            this.backgroundPicture.Name = "backgroundPicture";
            this.backgroundPicture.Size = new System.Drawing.Size(539, 370);
            this.backgroundPicture.TabIndex = 2;
            this.backgroundPicture.TabStop = false;
            this.backgroundPicture.Click += new System.EventHandler(this.backgroundPicture_Click);
            // 
            // monsterPictureBox
            // 
            this.monsterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monsterPictureBox.Location = new System.Drawing.Point(19, 201);
            this.monsterPictureBox.Name = "monsterPictureBox";
            this.monsterPictureBox.Size = new System.Drawing.Size(110, 99);
            this.monsterPictureBox.TabIndex = 19;
            this.monsterPictureBox.TabStop = false;
            this.monsterPictureBox.Visible = false;
            // 
            // playerSelectionPanel
            // 
            this.playerSelectionPanel.Controls.Add(this.label12);
            this.playerSelectionPanel.Controls.Add(this.lblChoseMana);
            this.playerSelectionPanel.Controls.Add(this.lblChoseStr);
            this.playerSelectionPanel.Controls.Add(this.lblChoseHealth);
            this.playerSelectionPanel.Controls.Add(this.label10);
            this.playerSelectionPanel.Controls.Add(this.label9);
            this.playerSelectionPanel.Controls.Add(this.label8);
            this.playerSelectionPanel.Controls.Add(this.startBtn);
            this.playerSelectionPanel.Controls.Add(this.choicePicBox);
            this.playerSelectionPanel.Controls.Add(this.lblNameChose);
            this.playerSelectionPanel.Controls.Add(this.nextBtn);
            this.playerSelectionPanel.Location = new System.Drawing.Point(12, 12);
            this.playerSelectionPanel.Name = "playerSelectionPanel";
            this.playerSelectionPanel.Size = new System.Drawing.Size(540, 546);
            this.playerSelectionPanel.TabIndex = 20;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(7, 483);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(146, 60);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lblNameChose
            // 
            this.lblNameChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameChose.Location = new System.Drawing.Point(5, 304);
            this.lblNameChose.Name = "lblNameChose";
            this.lblNameChose.Size = new System.Drawing.Size(148, 23);
            this.lblNameChose.TabIndex = 2;
            this.lblNameChose.Text = "Name";
            this.lblNameChose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choicePicBox
            // 
            this.choicePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.choicePicBox.Location = new System.Drawing.Point(7, 330);
            this.choicePicBox.Name = "choicePicBox";
            this.choicePicBox.Size = new System.Drawing.Size(146, 147);
            this.choicePicBox.TabIndex = 3;
            this.choicePicBox.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(387, 482);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(146, 60);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Health";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(192, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Strength";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Mana";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoseHealth
            // 
            this.lblChoseHealth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChoseHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoseHealth.Location = new System.Drawing.Point(289, 360);
            this.lblChoseHealth.Name = "lblChoseHealth";
            this.lblChoseHealth.Size = new System.Drawing.Size(65, 23);
            this.lblChoseHealth.TabIndex = 9;
            this.lblChoseHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoseStr
            // 
            this.lblChoseStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChoseStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoseStr.Location = new System.Drawing.Point(289, 402);
            this.lblChoseStr.Name = "lblChoseStr";
            this.lblChoseStr.Size = new System.Drawing.Size(65, 23);
            this.lblChoseStr.TabIndex = 10;
            this.lblChoseStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoseMana
            // 
            this.lblChoseMana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChoseMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoseMana.Location = new System.Drawing.Point(289, 446);
            this.lblChoseMana.Name = "lblChoseMana";
            this.lblChoseMana.Size = new System.Drawing.Size(65, 23);
            this.lblChoseMana.TabIndex = 11;
            this.lblChoseMana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(539, 304);
            this.label12.TabIndex = 13;
            this.label12.Text = resources.GetString("label12.Text");
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(563, 570);
            this.Controls.Add(this.playerSelectionPanel);
            this.Controls.Add(this.monsterPictureBox);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.battlePanel);
            this.Controls.Add(this.equipsPanel);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.directionsBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.discriptionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.backgroundPicture);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.monstAttlbl);
            this.MaximizeBox = false;
            this.Name = "Adventure";
            this.Text = "Adventure";
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.battlePanel.ResumeLayout(false);
            this.equipsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spellIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterPictureBox)).EndInit();
            this.playerSelectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.choicePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox backgroundPicture;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label discriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Panel battlePanel;
        private System.Windows.Forms.PictureBox spellIcon;
        private System.Windows.Forms.PictureBox weaponIcon;
        private System.Windows.Forms.Label healthPotCnt;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Panel equipsPanel;
        private System.Windows.Forms.Button steelSwordBtn;
        private System.Windows.Forms.Button axeBtn;
        private System.Windows.Forms.Button swordBtn;
        private System.Windows.Forms.Button rockSpellBtn;
        private System.Windows.Forms.Button lightningSpellBtn;
        private System.Windows.Forms.Button iceSpellBtn;
        private System.Windows.Forms.Button fireSpellBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buyHealthBtn;
        private System.Windows.Forms.Button buyManaBtn;
        private System.Windows.Forms.Button healthPotBtn;
        private System.Windows.Forms.Button manaPotBtn;
        private System.Windows.Forms.Label manaPotCnt;
        private System.Windows.Forms.Label lblCurrentExp;
        private System.Windows.Forms.Label lblCrntExp;
        private System.Windows.Forms.Button directionsBtn;
        private System.Windows.Forms.Label monstAttlbl;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.PictureBox monsterPictureBox;
        private System.Windows.Forms.Panel playerSelectionPanel;
        private System.Windows.Forms.Label lblChoseMana;
        private System.Windows.Forms.Label lblChoseStr;
        private System.Windows.Forms.Label lblChoseHealth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox choicePicBox;
        private System.Windows.Forms.Label lblNameChose;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label12;
    }
}

