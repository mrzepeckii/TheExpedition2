﻿namespace TheExpedition2
{
    partial class Form1
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
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.pictureBat = new System.Windows.Forms.PictureBox();
            this.pictureGhost = new System.Windows.Forms.PictureBox();
            this.pictureGhul = new System.Windows.Forms.PictureBox();
            this.pictureBluePot = new System.Windows.Forms.PictureBox();
            this.pictureRedPot = new System.Windows.Forms.PictureBox();
            this.pictureSword = new System.Windows.Forms.PictureBox();
            this.pictureBow = new System.Windows.Forms.PictureBox();
            this.pictureMace = new System.Windows.Forms.PictureBox();
            this.pictureEqupSword = new System.Windows.Forms.PictureBox();
            this.pictureEqupBow = new System.Windows.Forms.PictureBox();
            this.pictureEqupMace = new System.Windows.Forms.PictureBox();
            this.pictureExupBP = new System.Windows.Forms.PictureBox();
            this.pictureExupRP = new System.Windows.Forms.PictureBox();
            this.tableStatistic = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.labelGhul = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.labelGhost = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.labelBat = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.tableMove = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.labelMove = new System.Windows.Forms.Label();
            this.tableAttack = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAttackDown = new System.Windows.Forms.Button();
            this.buttonAttackUp = new System.Windows.Forms.Button();
            this.buttonAttackLeft = new System.Windows.Forms.Button();
            this.buttonAttackRight = new System.Windows.Forms.Button();
            this.labelAttack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGhul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBluePot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRedPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEqupSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEqupBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEqupMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExupBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExupRP)).BeginInit();
            this.tableStatistic.SuspendLayout();
            this.tableMove.SuspendLayout();
            this.tableAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePlayer
            // 
            this.picturePlayer.BackColor = System.Drawing.Color.Transparent;
            this.picturePlayer.BackgroundImage = global::TheExpedition2.Properties.Resources.player;
            this.picturePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayer.Location = new System.Drawing.Point(94, 64);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(39, 38);
            this.picturePlayer.TabIndex = 0;
            this.picturePlayer.TabStop = false;
            // 
            // pictureBat
            // 
            this.pictureBat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBat.BackgroundImage = global::TheExpedition2.Properties.Resources.bat;
            this.pictureBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBat.Location = new System.Drawing.Point(139, 64);
            this.pictureBat.Name = "pictureBat";
            this.pictureBat.Size = new System.Drawing.Size(39, 38);
            this.pictureBat.TabIndex = 1;
            this.pictureBat.TabStop = false;
            this.pictureBat.Visible = false;
            // 
            // pictureGhost
            // 
            this.pictureGhost.BackColor = System.Drawing.Color.Transparent;
            this.pictureGhost.BackgroundImage = global::TheExpedition2.Properties.Resources.ghost;
            this.pictureGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureGhost.Location = new System.Drawing.Point(184, 64);
            this.pictureGhost.Name = "pictureGhost";
            this.pictureGhost.Size = new System.Drawing.Size(39, 38);
            this.pictureGhost.TabIndex = 2;
            this.pictureGhost.TabStop = false;
            this.pictureGhost.Visible = false;
            // 
            // pictureGhul
            // 
            this.pictureGhul.BackColor = System.Drawing.Color.Transparent;
            this.pictureGhul.BackgroundImage = global::TheExpedition2.Properties.Resources.ghoul;
            this.pictureGhul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureGhul.Location = new System.Drawing.Point(229, 64);
            this.pictureGhul.Name = "pictureGhul";
            this.pictureGhul.Size = new System.Drawing.Size(39, 38);
            this.pictureGhul.TabIndex = 3;
            this.pictureGhul.TabStop = false;
            this.pictureGhul.Visible = false;
            // 
            // pictureBluePot
            // 
            this.pictureBluePot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBluePot.BackgroundImage = global::TheExpedition2.Properties.Resources.potion_blue;
            this.pictureBluePot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBluePot.Location = new System.Drawing.Point(274, 64);
            this.pictureBluePot.Name = "pictureBluePot";
            this.pictureBluePot.Size = new System.Drawing.Size(39, 38);
            this.pictureBluePot.TabIndex = 4;
            this.pictureBluePot.TabStop = false;
            this.pictureBluePot.Visible = false;
            // 
            // pictureRedPot
            // 
            this.pictureRedPot.BackColor = System.Drawing.Color.Transparent;
            this.pictureRedPot.BackgroundImage = global::TheExpedition2.Properties.Resources.potion_red;
            this.pictureRedPot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRedPot.Location = new System.Drawing.Point(319, 64);
            this.pictureRedPot.Name = "pictureRedPot";
            this.pictureRedPot.Size = new System.Drawing.Size(39, 38);
            this.pictureRedPot.TabIndex = 5;
            this.pictureRedPot.TabStop = false;
            this.pictureRedPot.Visible = false;
            // 
            // pictureSword
            // 
            this.pictureSword.BackColor = System.Drawing.Color.Transparent;
            this.pictureSword.BackgroundImage = global::TheExpedition2.Properties.Resources.sword;
            this.pictureSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSword.Location = new System.Drawing.Point(364, 64);
            this.pictureSword.Name = "pictureSword";
            this.pictureSword.Size = new System.Drawing.Size(39, 38);
            this.pictureSword.TabIndex = 6;
            this.pictureSword.TabStop = false;
            this.pictureSword.Visible = false;
            // 
            // pictureBow
            // 
            this.pictureBow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBow.BackgroundImage = global::TheExpedition2.Properties.Resources.bow;
            this.pictureBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBow.Location = new System.Drawing.Point(409, 64);
            this.pictureBow.Name = "pictureBow";
            this.pictureBow.Size = new System.Drawing.Size(39, 38);
            this.pictureBow.TabIndex = 7;
            this.pictureBow.TabStop = false;
            this.pictureBow.Visible = false;
            // 
            // pictureMace
            // 
            this.pictureMace.BackColor = System.Drawing.Color.Transparent;
            this.pictureMace.BackgroundImage = global::TheExpedition2.Properties.Resources.mace;
            this.pictureMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureMace.Location = new System.Drawing.Point(454, 64);
            this.pictureMace.Name = "pictureMace";
            this.pictureMace.Size = new System.Drawing.Size(39, 38);
            this.pictureMace.TabIndex = 8;
            this.pictureMace.TabStop = false;
            this.pictureMace.Visible = false;
            // 
            // pictureEqupSword
            // 
            this.pictureEqupSword.BackColor = System.Drawing.Color.Transparent;
            this.pictureEqupSword.Image = global::TheExpedition2.Properties.Resources.sword;
            this.pictureEqupSword.Location = new System.Drawing.Point(94, 373);
            this.pictureEqupSword.Name = "pictureEqupSword";
            this.pictureEqupSword.Size = new System.Drawing.Size(50, 50);
            this.pictureEqupSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEqupSword.TabIndex = 9;
            this.pictureEqupSword.TabStop = false;
            this.pictureEqupSword.Visible = false;
            this.pictureEqupSword.Click += new System.EventHandler(this.pictureEqupSword_Click);
            // 
            // pictureEqupBow
            // 
            this.pictureEqupBow.BackColor = System.Drawing.Color.Transparent;
            this.pictureEqupBow.Image = global::TheExpedition2.Properties.Resources.bow;
            this.pictureEqupBow.Location = new System.Drawing.Point(150, 373);
            this.pictureEqupBow.Name = "pictureEqupBow";
            this.pictureEqupBow.Size = new System.Drawing.Size(50, 50);
            this.pictureEqupBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEqupBow.TabIndex = 10;
            this.pictureEqupBow.TabStop = false;
            this.pictureEqupBow.Visible = false;
            this.pictureEqupBow.Click += new System.EventHandler(this.pictureEqupBow_Click);
            // 
            // pictureEqupMace
            // 
            this.pictureEqupMace.BackColor = System.Drawing.Color.Transparent;
            this.pictureEqupMace.Image = global::TheExpedition2.Properties.Resources.mace;
            this.pictureEqupMace.Location = new System.Drawing.Point(206, 373);
            this.pictureEqupMace.Name = "pictureEqupMace";
            this.pictureEqupMace.Size = new System.Drawing.Size(50, 50);
            this.pictureEqupMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEqupMace.TabIndex = 11;
            this.pictureEqupMace.TabStop = false;
            this.pictureEqupMace.Visible = false;
            this.pictureEqupMace.Click += new System.EventHandler(this.pictureEqupMace_Click);
            // 
            // pictureExupBP
            // 
            this.pictureExupBP.BackColor = System.Drawing.Color.Transparent;
            this.pictureExupBP.Image = global::TheExpedition2.Properties.Resources.potion_blue;
            this.pictureExupBP.Location = new System.Drawing.Point(263, 373);
            this.pictureExupBP.Name = "pictureExupBP";
            this.pictureExupBP.Size = new System.Drawing.Size(50, 50);
            this.pictureExupBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExupBP.TabIndex = 12;
            this.pictureExupBP.TabStop = false;
            this.pictureExupBP.Visible = false;
            this.pictureExupBP.Click += new System.EventHandler(this.pictureExupBP_Click);
            // 
            // pictureExupRP
            // 
            this.pictureExupRP.BackColor = System.Drawing.Color.Transparent;
            this.pictureExupRP.Image = global::TheExpedition2.Properties.Resources.potion_red;
            this.pictureExupRP.Location = new System.Drawing.Point(319, 373);
            this.pictureExupRP.Name = "pictureExupRP";
            this.pictureExupRP.Size = new System.Drawing.Size(50, 50);
            this.pictureExupRP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExupRP.TabIndex = 13;
            this.pictureExupRP.TabStop = false;
            this.pictureExupRP.Visible = false;
            this.pictureExupRP.Click += new System.EventHandler(this.pictureExupRP_Click);
            // 
            // tableStatistic
            // 
            this.tableStatistic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableStatistic.BackColor = System.Drawing.Color.Transparent;
            this.tableStatistic.ColumnCount = 2;
            this.tableStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableStatistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableStatistic.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableStatistic.Controls.Add(this.labelGhul, 0, 3);
            this.tableStatistic.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableStatistic.Controls.Add(this.labelGhost, 0, 2);
            this.tableStatistic.Controls.Add(this.batHitPoints, 1, 1);
            this.tableStatistic.Controls.Add(this.labelBat, 0, 1);
            this.tableStatistic.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableStatistic.Controls.Add(this.labelPlayer, 0, 0);
            this.tableStatistic.Location = new System.Drawing.Point(523, 252);
            this.tableStatistic.Name = "tableStatistic";
            this.tableStatistic.RowCount = 4;
            this.tableStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStatistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStatistic.Size = new System.Drawing.Size(202, 84);
            this.tableStatistic.TabIndex = 14;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghoulHitPoints.Location = new System.Drawing.Point(85, 64);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(94, 16);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // labelGhul
            // 
            this.labelGhul.AutoSize = true;
            this.labelGhul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGhul.Location = new System.Drawing.Point(3, 64);
            this.labelGhul.Name = "labelGhul";
            this.labelGhul.Size = new System.Drawing.Size(46, 16);
            this.labelGhul.TabIndex = 6;
            this.labelGhul.Text = "Upior";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghostHitPoints.Location = new System.Drawing.Point(85, 44);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(94, 16);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // labelGhost
            // 
            this.labelGhost.AutoSize = true;
            this.labelGhost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGhost.Location = new System.Drawing.Point(3, 44);
            this.labelGhost.Name = "labelGhost";
            this.labelGhost.Size = new System.Drawing.Size(43, 16);
            this.labelGhost.TabIndex = 4;
            this.labelGhost.Text = "Duch";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.batHitPoints.Location = new System.Drawing.Point(85, 22);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(80, 16);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // labelBat
            // 
            this.labelBat.AutoSize = true;
            this.labelBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBat.Location = new System.Drawing.Point(3, 22);
            this.labelBat.Name = "labelBat";
            this.labelBat.Size = new System.Drawing.Size(75, 16);
            this.labelBat.TabIndex = 2;
            this.labelBat.Text = "Nietoperz";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerHitPoints.Location = new System.Drawing.Point(85, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(99, 16);
            this.playerHitPoints.TabIndex = 1;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayer.Location = new System.Drawing.Point(3, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(48, 16);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Gracz";
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMoveUp.Location = new System.Drawing.Point(44, 20);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(35, 28);
            this.buttonMoveUp.TabIndex = 0;
            this.buttonMoveUp.Text = "↑";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // tableMove
            // 
            this.tableMove.BackColor = System.Drawing.Color.Transparent;
            this.tableMove.ColumnCount = 3;
            this.tableMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableMove.Controls.Add(this.buttonMoveDown, 1, 2);
            this.tableMove.Controls.Add(this.buttonMoveUp, 1, 1);
            this.tableMove.Controls.Add(this.buttonMoveLeft, 0, 2);
            this.tableMove.Controls.Add(this.buttonMoveRight, 2, 2);
            this.tableMove.Controls.Add(this.labelMove, 0, 0);
            this.tableMove.Location = new System.Drawing.Point(381, 353);
            this.tableMove.Name = "tableMove";
            this.tableMove.RowCount = 3;
            this.tableMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableMove.Size = new System.Drawing.Size(124, 86);
            this.tableMove.TabIndex = 17;
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMoveDown.Location = new System.Drawing.Point(44, 54);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(35, 29);
            this.buttonMoveDown.TabIndex = 2;
            this.buttonMoveDown.Text = "↓";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMoveLeft.Location = new System.Drawing.Point(3, 54);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(35, 29);
            this.buttonMoveLeft.TabIndex = 1;
            this.buttonMoveLeft.Text = "←";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMoveRight.Location = new System.Drawing.Point(85, 54);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(36, 29);
            this.buttonMoveRight.TabIndex = 3;
            this.buttonMoveRight.Text = "→";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.tableMove.SetColumnSpan(this.labelMove, 2);
            this.labelMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMove.Location = new System.Drawing.Point(3, 0);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(46, 16);
            this.labelMove.TabIndex = 4;
            this.labelMove.Text = "Move";
            // 
            // tableAttack
            // 
            this.tableAttack.BackColor = System.Drawing.Color.Transparent;
            this.tableAttack.ColumnCount = 3;
            this.tableAttack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableAttack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableAttack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableAttack.Controls.Add(this.buttonAttackDown, 1, 2);
            this.tableAttack.Controls.Add(this.buttonAttackUp, 1, 1);
            this.tableAttack.Controls.Add(this.buttonAttackLeft, 0, 2);
            this.tableAttack.Controls.Add(this.buttonAttackRight, 2, 2);
            this.tableAttack.Controls.Add(this.labelAttack, 0, 0);
            this.tableAttack.Location = new System.Drawing.Point(529, 353);
            this.tableAttack.Name = "tableAttack";
            this.tableAttack.RowCount = 3;
            this.tableAttack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableAttack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableAttack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableAttack.Size = new System.Drawing.Size(124, 86);
            this.tableAttack.TabIndex = 18;
            // 
            // buttonAttackDown
            // 
            this.buttonAttackDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAttackDown.Location = new System.Drawing.Point(44, 54);
            this.buttonAttackDown.Name = "buttonAttackDown";
            this.buttonAttackDown.Size = new System.Drawing.Size(35, 29);
            this.buttonAttackDown.TabIndex = 2;
            this.buttonAttackDown.Text = "↓";
            this.buttonAttackDown.UseVisualStyleBackColor = true;
            this.buttonAttackDown.Click += new System.EventHandler(this.buttonAttackDown_Click);
            // 
            // buttonAttackUp
            // 
            this.buttonAttackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAttackUp.Location = new System.Drawing.Point(44, 20);
            this.buttonAttackUp.Name = "buttonAttackUp";
            this.buttonAttackUp.Size = new System.Drawing.Size(35, 28);
            this.buttonAttackUp.TabIndex = 0;
            this.buttonAttackUp.Text = "↑";
            this.buttonAttackUp.UseVisualStyleBackColor = true;
            this.buttonAttackUp.Click += new System.EventHandler(this.buttonAttackUp_Click);
            // 
            // buttonAttackLeft
            // 
            this.buttonAttackLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAttackLeft.Location = new System.Drawing.Point(3, 54);
            this.buttonAttackLeft.Name = "buttonAttackLeft";
            this.buttonAttackLeft.Size = new System.Drawing.Size(35, 29);
            this.buttonAttackLeft.TabIndex = 1;
            this.buttonAttackLeft.Text = "←";
            this.buttonAttackLeft.UseVisualStyleBackColor = true;
            this.buttonAttackLeft.Click += new System.EventHandler(this.buttonAttackLeft_Click);
            // 
            // buttonAttackRight
            // 
            this.buttonAttackRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAttackRight.Location = new System.Drawing.Point(85, 54);
            this.buttonAttackRight.Name = "buttonAttackRight";
            this.buttonAttackRight.Size = new System.Drawing.Size(36, 29);
            this.buttonAttackRight.TabIndex = 3;
            this.buttonAttackRight.Text = "→";
            this.buttonAttackRight.UseVisualStyleBackColor = true;
            this.buttonAttackRight.Click += new System.EventHandler(this.buttonAttackRight_Click);
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.tableAttack.SetColumnSpan(this.labelAttack, 2);
            this.labelAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAttack.Location = new System.Drawing.Point(3, 0);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(51, 16);
            this.labelAttack.TabIndex = 4;
            this.labelAttack.Text = "Attack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheExpedition2.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 461);
            this.Controls.Add(this.tableAttack);
            this.Controls.Add(this.tableMove);
            this.Controls.Add(this.picturePlayer);
            this.Controls.Add(this.tableStatistic);
            this.Controls.Add(this.pictureExupRP);
            this.Controls.Add(this.pictureExupBP);
            this.Controls.Add(this.pictureEqupMace);
            this.Controls.Add(this.pictureEqupBow);
            this.Controls.Add(this.pictureEqupSword);
            this.Controls.Add(this.pictureRedPot);
            this.Controls.Add(this.pictureBluePot);
            this.Controls.Add(this.pictureGhul);
            this.Controls.Add(this.pictureGhost);
            this.Controls.Add(this.pictureBat);
            this.Controls.Add(this.pictureMace);
            this.Controls.Add(this.pictureBow);
            this.Controls.Add(this.pictureSword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGhul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBluePot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRedPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEqupSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEqupBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEqupMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExupBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExupRP)).EndInit();
            this.tableStatistic.ResumeLayout(false);
            this.tableStatistic.PerformLayout();
            this.tableMove.ResumeLayout(false);
            this.tableMove.PerformLayout();
            this.tableAttack.ResumeLayout(false);
            this.tableAttack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.PictureBox pictureBat;
        private System.Windows.Forms.PictureBox pictureGhost;
        private System.Windows.Forms.PictureBox pictureGhul;
        private System.Windows.Forms.PictureBox pictureBluePot;
        private System.Windows.Forms.PictureBox pictureRedPot;
        private System.Windows.Forms.PictureBox pictureSword;
        private System.Windows.Forms.PictureBox pictureBow;
        private System.Windows.Forms.PictureBox pictureMace;
        private System.Windows.Forms.PictureBox pictureEqupSword;
        private System.Windows.Forms.PictureBox pictureEqupBow;
        private System.Windows.Forms.PictureBox pictureEqupMace;
        private System.Windows.Forms.PictureBox pictureExupBP;
        private System.Windows.Forms.PictureBox pictureExupRP;
        private System.Windows.Forms.TableLayoutPanel tableStatistic;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label labelGhul;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label labelGhost;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label labelBat;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.TableLayoutPanel tableMove;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.TableLayoutPanel tableAttack;
        private System.Windows.Forms.Button buttonAttackDown;
        private System.Windows.Forms.Button buttonAttackUp;
        private System.Windows.Forms.Button buttonAttackLeft;
        private System.Windows.Forms.Button buttonAttackRight;
        private System.Windows.Forms.Label labelAttack;
    }
}

