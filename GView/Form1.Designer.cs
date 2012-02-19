using System.Windows.Forms;
namespace GView
{
    partial class G_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(G_View));
            this.btnImgUp = new System.Windows.Forms.Button();
            this.btnImgDown = new System.Windows.Forms.Button();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.thoughtsLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.devBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.pubBox = new System.Windows.Forms.TextBox();
            this.thoughtsBox = new System.Windows.Forms.TextBox();
            this.modeBox = new System.Windows.Forms.TextBox();
            this.devlabel = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.pubLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.engineLabel = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.engineBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImgUp
            // 
            this.btnImgUp.Location = new System.Drawing.Point(92, 396);
            this.btnImgUp.Name = "btnImgUp";
            this.btnImgUp.Size = new System.Drawing.Size(75, 23);
            this.btnImgUp.TabIndex = 0;
            this.btnImgUp.Text = "Next";
            this.btnImgUp.UseVisualStyleBackColor = true;
            this.btnImgUp.Click += new System.EventHandler(this.btnImgUp_Click);
            // 
            // btnImgDown
            // 
            this.btnImgDown.Location = new System.Drawing.Point(11, 396);
            this.btnImgDown.Name = "btnImgDown";
            this.btnImgDown.Size = new System.Drawing.Size(75, 23);
            this.btnImgDown.TabIndex = 1;
            this.btnImgDown.Text = "Previous";
            this.btnImgDown.UseVisualStyleBackColor = true;
            this.btnImgDown.Click += new System.EventHandler(this.btnImgDown_Click);
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPhoto.ErrorImage = null;
            this.imgPhoto.InitialImage = null;
            this.imgPhoto.Location = new System.Drawing.Point(3, 3);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(250, 360);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhoto.TabIndex = 2;
            this.imgPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 374);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.imgPhoto);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 366);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.thoughtsLabel);
            this.panel3.Controls.Add(this.nameBox);
            this.panel3.Controls.Add(this.devBox);
            this.panel3.Controls.Add(this.genreLabel);
            this.panel3.Controls.Add(this.pubBox);
            this.panel3.Controls.Add(this.thoughtsBox);
            this.panel3.Controls.Add(this.modeBox);
            this.panel3.Controls.Add(this.devlabel);
            this.panel3.Controls.Add(this.genreBox);
            this.panel3.Controls.Add(this.pubLabel);
            this.panel3.Controls.Add(this.ratingLabel);
            this.panel3.Controls.Add(this.modeLabel);
            this.panel3.Controls.Add(this.engineLabel);
            this.panel3.Controls.Add(this.yearBox);
            this.panel3.Controls.Add(this.yearLabel);
            this.panel3.Controls.Add(this.engineBox);
            this.panel3.Controls.Add(this.ratingBox);
            this.panel3.Location = new System.Drawing.Point(286, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 408);
            this.panel3.TabIndex = 26;
            // 
            // thoughtsLabel
            // 
            this.thoughtsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.thoughtsLabel.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoughtsLabel.Location = new System.Drawing.Point(6, 311);
            this.thoughtsLabel.Name = "thoughtsLabel";
            this.thoughtsLabel.Size = new System.Drawing.Size(692, 41);
            this.thoughtsLabel.TabIndex = 25;
            this.thoughtsLabel.Text = "Thoughts :";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.nameBox.ForeColor = System.Drawing.Color.Salmon;
            this.nameBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameBox.Location = new System.Drawing.Point(6, 5);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(692, 49);
            this.nameBox.TabIndex = 12;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // devBox
            // 
            this.devBox.BackColor = System.Drawing.SystemColors.Control;
            this.devBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.devBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.devBox.Location = new System.Drawing.Point(204, 94);
            this.devBox.Name = "devBox";
            this.devBox.ReadOnly = true;
            this.devBox.Size = new System.Drawing.Size(494, 33);
            this.devBox.TabIndex = 8;
            this.devBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.genreLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(6, 202);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(192, 33);
            this.genreLabel.TabIndex = 19;
            this.genreLabel.Text = "Genre ";
            // 
            // pubBox
            // 
            this.pubBox.BackColor = System.Drawing.SystemColors.Control;
            this.pubBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pubBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pubBox.Location = new System.Drawing.Point(204, 130);
            this.pubBox.Name = "pubBox";
            this.pubBox.ReadOnly = true;
            this.pubBox.Size = new System.Drawing.Size(494, 33);
            this.pubBox.TabIndex = 14;
            this.pubBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thoughtsBox
            // 
            this.thoughtsBox.BackColor = System.Drawing.SystemColors.Control;
            this.thoughtsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thoughtsBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoughtsBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.thoughtsBox.Location = new System.Drawing.Point(6, 350);
            this.thoughtsBox.Multiline = true;
            this.thoughtsBox.Name = "thoughtsBox";
            this.thoughtsBox.ReadOnly = true;
            this.thoughtsBox.Size = new System.Drawing.Size(692, 53);
            this.thoughtsBox.TabIndex = 24;
            this.thoughtsBox.Text = "                                      ";
            // 
            // modeBox
            // 
            this.modeBox.BackColor = System.Drawing.SystemColors.Control;
            this.modeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modeBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modeBox.Location = new System.Drawing.Point(204, 238);
            this.modeBox.Name = "modeBox";
            this.modeBox.ReadOnly = true;
            this.modeBox.Size = new System.Drawing.Size(494, 33);
            this.modeBox.TabIndex = 20;
            this.modeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // devlabel
            // 
            this.devlabel.BackColor = System.Drawing.SystemColors.Control;
            this.devlabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devlabel.Location = new System.Drawing.Point(6, 94);
            this.devlabel.Name = "devlabel";
            this.devlabel.Size = new System.Drawing.Size(192, 33);
            this.devlabel.TabIndex = 9;
            this.devlabel.Text = "Developer";
            // 
            // genreBox
            // 
            this.genreBox.BackColor = System.Drawing.SystemColors.Control;
            this.genreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.genreBox.Location = new System.Drawing.Point(204, 202);
            this.genreBox.Name = "genreBox";
            this.genreBox.ReadOnly = true;
            this.genreBox.Size = new System.Drawing.Size(494, 33);
            this.genreBox.TabIndex = 18;
            this.genreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pubLabel
            // 
            this.pubLabel.BackColor = System.Drawing.SystemColors.Control;
            this.pubLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubLabel.Location = new System.Drawing.Point(6, 130);
            this.pubLabel.Name = "pubLabel";
            this.pubLabel.Size = new System.Drawing.Size(192, 33);
            this.pubLabel.TabIndex = 15;
            this.pubLabel.Text = "Publisher";
            // 
            // ratingLabel
            // 
            this.ratingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ratingLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(6, 274);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(192, 33);
            this.ratingLabel.TabIndex = 23;
            this.ratingLabel.Text = "Personal Rating";
            // 
            // modeLabel
            // 
            this.modeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.modeLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(6, 238);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(192, 33);
            this.modeLabel.TabIndex = 21;
            this.modeLabel.Text = "Modes";
            // 
            // engineLabel
            // 
            this.engineLabel.BackColor = System.Drawing.SystemColors.Control;
            this.engineLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineLabel.Location = new System.Drawing.Point(6, 166);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(192, 33);
            this.engineLabel.TabIndex = 17;
            this.engineLabel.Text = "Engine";
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.SystemColors.Control;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.yearBox.Location = new System.Drawing.Point(204, 58);
            this.yearBox.Name = "yearBox";
            this.yearBox.ReadOnly = true;
            this.yearBox.Size = new System.Drawing.Size(494, 33);
            this.yearBox.TabIndex = 10;
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.SystemColors.Control;
            this.yearLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(6, 58);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(192, 33);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Text = "Year";
            // 
            // engineBox
            // 
            this.engineBox.BackColor = System.Drawing.SystemColors.Control;
            this.engineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.engineBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.engineBox.Location = new System.Drawing.Point(204, 166);
            this.engineBox.Name = "engineBox";
            this.engineBox.ReadOnly = true;
            this.engineBox.Size = new System.Drawing.Size(494, 33);
            this.engineBox.TabIndex = 16;
            this.engineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ratingBox
            // 
            this.ratingBox.BackColor = System.Drawing.SystemColors.Control;
            this.ratingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ratingBox.Location = new System.Drawing.Point(204, 274);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.ReadOnly = true;
            this.ratingBox.Size = new System.Drawing.Size(494, 33);
            this.ratingBox.TabIndex = 22;
            this.ratingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(173, 396);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 27;
            this.openBtn.Text = "Open Folder";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Image = global::GView.Properties.Resources.Button_Info_icon;
            this.aboutBtn.Location = new System.Drawing.Point(254, 396);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(21, 23);
            this.aboutBtn.TabIndex = 28;
            this.aboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // G_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 430);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImgDown);
            this.Controls.Add(this.btnImgUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "G_View";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "G_View";
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImgUp;
        private System.Windows.Forms.Button btnImgDown;
        private System.Windows.Forms.PictureBox imgPhoto;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label thoughtsLabel;
        private TextBox nameBox;
        private TextBox devBox;
        private Label genreLabel;
        private TextBox pubBox;
        private TextBox thoughtsBox;
        private TextBox modeBox;
        private Label devlabel;
        private TextBox genreBox;
        private Label pubLabel;
        private Label ratingLabel;
        private Label modeLabel;
        private Label engineLabel;
        private TextBox yearBox;
        private Label yearLabel;
        private TextBox engineBox;
        private TextBox ratingBox;
        private Button openBtn;
        private Button aboutBtn;
    }
}

