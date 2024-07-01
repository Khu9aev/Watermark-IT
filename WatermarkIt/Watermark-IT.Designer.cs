namespace watermarkit {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.contextMenuPreview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnSourceImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.SaveBnt = new System.Windows.Forms.Button();
            this.groupFiles = new System.Windows.Forms.GroupBox();
            this.checkReset = new System.Windows.Forms.CheckBox();
            this.btnResetImage = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.textTextToAdd = new System.Windows.Forms.TextBox();
            this.btnWatermark = new System.Windows.Forms.Button();
            this.textWatermark = new System.Windows.Forms.TextBox();
            this.textSourceImage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.contextMenuPreview.SuspendLayout();
            this.groupPreview.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupOptions.SuspendLayout();
            this.groupFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePreview
            // 
            this.picturePreview.ContextMenuStrip = this.contextMenuPreview;
            this.picturePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePreview.Location = new System.Drawing.Point(8, 16);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(545, 677);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 2;
            this.picturePreview.TabStop = false;
            // 
            // contextMenuPreview
            // 
            this.contextMenuPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.stretchToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.contextMenuPreview.Name = "contextMenuPreview";
            this.contextMenuPreview.Size = new System.Drawing.Size(115, 70);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.NormalToolStripMenuItem_Click);
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.StretchToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.ZoomToolStripMenuItem_Click);
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.picturePreview);
            this.groupPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPreview.Location = new System.Drawing.Point(0, 0);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Padding = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.groupPreview.Size = new System.Drawing.Size(561, 701);
            this.groupPreview.TabIndex = 3;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Холст";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddImage.Image = ((System.Drawing.Image)(resources.GetObject("btnAddImage.Image")));
            this.btnAddImage.Location = new System.Drawing.Point(140, 148);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(105, 36);
            this.btnAddImage.TabIndex = 6;
            this.btnAddImage.Text = "Добавить водяной знак";
            this.btnAddImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid.Size = new System.Drawing.Size(386, 491);
            this.propertyGrid.TabIndex = 8;
            // 
            // btnSourceImage
            // 
            this.btnSourceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSourceImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSourceImage.Image")));
            this.btnSourceImage.Location = new System.Drawing.Point(365, 13);
            this.btnSourceImage.Name = "btnSourceImage";
            this.btnSourceImage.Size = new System.Drawing.Size(21, 21);
            this.btnSourceImage.TabIndex = 7;
            this.btnSourceImage.UseVisualStyleBackColor = true;
            this.btnSourceImage.Click += new System.EventHandler(this.BtnSourceImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Изображение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Водяной знак:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupOptions);
            this.splitContainer1.Panel1.Controls.Add(this.groupFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPreview);
            this.splitContainer1.Size = new System.Drawing.Size(957, 701);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 11;
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.SaveBnt);
            this.groupOptions.Controls.Add(this.propertyGrid);
            this.groupOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupOptions.Location = new System.Drawing.Point(0, 191);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(392, 510);
            this.groupOptions.TabIndex = 1;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Настройки";
            // 
            // SaveBnt
            // 
            this.SaveBnt.Location = new System.Drawing.Point(85, 16);
            this.SaveBnt.Name = "SaveBnt";
            this.SaveBnt.Size = new System.Drawing.Size(75, 23);
            this.SaveBnt.TabIndex = 9;
            this.SaveBnt.Text = "Сохранить";
            this.SaveBnt.UseVisualStyleBackColor = true;
            this.SaveBnt.Click += new System.EventHandler(this.SaveBnt_Click);
            // 
            // groupFiles
            // 
            this.groupFiles.Controls.Add(this.checkReset);
            this.groupFiles.Controls.Add(this.btnResetImage);
            this.groupFiles.Controls.Add(this.btnAddText);
            this.groupFiles.Controls.Add(this.textTextToAdd);
            this.groupFiles.Controls.Add(this.btnWatermark);
            this.groupFiles.Controls.Add(this.textWatermark);
            this.groupFiles.Controls.Add(this.textSourceImage);
            this.groupFiles.Controls.Add(this.label3);
            this.groupFiles.Controls.Add(this.label1);
            this.groupFiles.Controls.Add(this.label2);
            this.groupFiles.Controls.Add(this.btnAddImage);
            this.groupFiles.Controls.Add(this.btnSourceImage);
            this.groupFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFiles.Location = new System.Drawing.Point(0, 0);
            this.groupFiles.Name = "groupFiles";
            this.groupFiles.Size = new System.Drawing.Size(392, 191);
            this.groupFiles.TabIndex = 0;
            this.groupFiles.TabStop = false;
            // 
            // checkReset
            // 
            this.checkReset.AutoSize = true;
            this.checkReset.Location = new System.Drawing.Point(39, 124);
            this.checkReset.Name = "checkReset";
            this.checkReset.Size = new System.Drawing.Size(320, 17);
            this.checkReset.TabIndex = 18;
            this.checkReset.Text = "Сброс холста перед каждым нанесением водяного знака";
            this.checkReset.UseVisualStyleBackColor = true;
            // 
            // btnResetImage
            // 
            this.btnResetImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetImage.Image = ((System.Drawing.Image)(resources.GetObject("btnResetImage.Image")));
            this.btnResetImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetImage.Location = new System.Drawing.Point(12, 148);
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.Size = new System.Drawing.Size(105, 36);
            this.btnResetImage.TabIndex = 17;
            this.btnResetImage.Text = "Сброс";
            this.btnResetImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetImage.UseVisualStyleBackColor = true;
            this.btnResetImage.Click += new System.EventHandler(this.BtnResetImage_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddText.Image = ((System.Drawing.Image)(resources.GetObject("btnAddText.Image")));
            this.btnAddText.Location = new System.Drawing.Point(272, 148);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(105, 36);
            this.btnAddText.TabIndex = 16;
            this.btnAddText.Text = "Добавить текст";
            this.btnAddText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.BtnAddText_Click);
            // 
            // textTextToAdd
            // 
            this.textTextToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTextToAdd.Location = new System.Drawing.Point(109, 71);
            this.textTextToAdd.Multiline = true;
            this.textTextToAdd.Name = "textTextToAdd";
            this.textTextToAdd.Size = new System.Drawing.Size(277, 47);
            this.textTextToAdd.TabIndex = 15;
            // 
            // btnWatermark
            // 
            this.btnWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWatermark.Image = ((System.Drawing.Image)(resources.GetObject("btnWatermark.Image")));
            this.btnWatermark.Location = new System.Drawing.Point(365, 40);
            this.btnWatermark.Name = "btnWatermark";
            this.btnWatermark.Size = new System.Drawing.Size(21, 21);
            this.btnWatermark.TabIndex = 14;
            this.btnWatermark.UseVisualStyleBackColor = true;
            this.btnWatermark.Click += new System.EventHandler(this.BtnWatermark_Click);
            // 
            // textWatermark
            // 
            this.textWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textWatermark.Enabled = false;
            this.textWatermark.Location = new System.Drawing.Point(109, 40);
            this.textWatermark.Name = "textWatermark";
            this.textWatermark.Size = new System.Drawing.Size(250, 20);
            this.textWatermark.TabIndex = 13;
            // 
            // textSourceImage
            // 
            this.textSourceImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSourceImage.Enabled = false;
            this.textSourceImage.Location = new System.Drawing.Point(109, 13);
            this.textSourceImage.Name = "textSourceImage";
            this.textSourceImage.Size = new System.Drawing.Size(250, 20);
            this.textSourceImage.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Текст:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 711);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark-IT";
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.contextMenuPreview.ResumeLayout(false);
            this.groupPreview.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupOptions.ResumeLayout(false);
            this.groupFiles.ResumeLayout(false);
            this.groupFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.GroupBox groupPreview;
        private System.Windows.Forms.ContextMenuStrip contextMenuPreview;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button btnSourceImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.GroupBox groupFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSourceImage;
        private System.Windows.Forms.TextBox textWatermark;
        private System.Windows.Forms.Button btnWatermark;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.TextBox textTextToAdd;
        private System.Windows.Forms.Button btnResetImage;
        private System.Windows.Forms.CheckBox checkReset;
        private System.Windows.Forms.Button SaveBnt;
    }
}

