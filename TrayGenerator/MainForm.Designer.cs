using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.snilsLabel = new System.Windows.Forms.Label();
            this.snilsGenButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ogrnUlLabel = new System.Windows.Forms.Label();
            this.ogrnUlGenButton = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ogrnIpLabel = new System.Windows.Forms.Label();
            this.ogrnIpGenButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.innUlLabel = new System.Windows.Forms.Label();
            this.innUlGenButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.innIpLabel = new System.Windows.Forms.Label();
            this.innIpGenButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer5);
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Controls.Add(this.splitContainer4);
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 280);
            this.panel1.TabIndex = 5;
            // 
            // splitContainer5
            // 
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(9, 218);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.snilsLabel);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.snilsGenButton);
            this.splitContainer5.Size = new System.Drawing.Size(260, 45);
            this.splitContainer5.SplitterDistance = 175;
            this.splitContainer5.TabIndex = 3;
            // 
            // snilsLabel
            // 
            this.snilsLabel.AutoSize = true;
            this.snilsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snilsLabel.Location = new System.Drawing.Point(3, 14);
            this.snilsLabel.Name = "snilsLabel";
            this.snilsLabel.Size = new System.Drawing.Size(160, 22);
            this.snilsLabel.TabIndex = 0;
            this.snilsLabel.Text = "_______________";
            this.snilsLabel.UseMnemonic = false;
            this.snilsLabel.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // snilsGenButton
            // 
            this.snilsGenButton.Location = new System.Drawing.Point(3, 3);
            this.snilsGenButton.Name = "snilsGenButton";
            this.snilsGenButton.Size = new System.Drawing.Size(75, 38);
            this.snilsGenButton.TabIndex = 1;
            this.snilsGenButton.Text = "Gen\'n\'Copy Snils";
            this.snilsGenButton.UseVisualStyleBackColor = true;
            this.snilsGenButton.Click += new System.EventHandler(this.SnilsGenButton_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(9, 169);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ogrnUlLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ogrnUlGenButton);
            this.splitContainer3.Size = new System.Drawing.Size(260, 45);
            this.splitContainer3.SplitterDistance = 175;
            this.splitContainer3.TabIndex = 3;
            // 
            // ogrnUlLabel
            // 
            this.ogrnUlLabel.AutoSize = true;
            this.ogrnUlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ogrnUlLabel.Location = new System.Drawing.Point(3, 14);
            this.ogrnUlLabel.Name = "ogrnUlLabel";
            this.ogrnUlLabel.Size = new System.Drawing.Size(160, 22);
            this.ogrnUlLabel.TabIndex = 0;
            this.ogrnUlLabel.Text = "_______________";
            this.ogrnUlLabel.UseMnemonic = false;
            this.ogrnUlLabel.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // ogrnUlGenButton
            // 
            this.ogrnUlGenButton.Location = new System.Drawing.Point(3, 3);
            this.ogrnUlGenButton.Name = "ogrnUlGenButton";
            this.ogrnUlGenButton.Size = new System.Drawing.Size(75, 38);
            this.ogrnUlGenButton.TabIndex = 1;
            this.ogrnUlGenButton.Text = "Gen\'n\'Copy Ogrn UL";
            this.ogrnUlGenButton.UseVisualStyleBackColor = true;
            this.ogrnUlGenButton.Click += new System.EventHandler(this.OgrnUlGenButton_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(9, 118);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.ogrnIpLabel);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.ogrnIpGenButton);
            this.splitContainer4.Size = new System.Drawing.Size(260, 45);
            this.splitContainer4.SplitterDistance = 175;
            this.splitContainer4.TabIndex = 3;
            // 
            // ogrnIpLabel
            // 
            this.ogrnIpLabel.AutoSize = true;
            this.ogrnIpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ogrnIpLabel.Location = new System.Drawing.Point(3, 14);
            this.ogrnIpLabel.Name = "ogrnIpLabel";
            this.ogrnIpLabel.Size = new System.Drawing.Size(160, 22);
            this.ogrnIpLabel.TabIndex = 0;
            this.ogrnIpLabel.Text = "_______________";
            this.ogrnIpLabel.UseMnemonic = false;
            this.ogrnIpLabel.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // ogrnIpGenButton
            // 
            this.ogrnIpGenButton.Location = new System.Drawing.Point(3, 3);
            this.ogrnIpGenButton.Name = "ogrnIpGenButton";
            this.ogrnIpGenButton.Size = new System.Drawing.Size(75, 38);
            this.ogrnIpGenButton.TabIndex = 1;
            this.ogrnIpGenButton.Text = "Gen\'n\'Copy Ogrn IP";
            this.ogrnIpGenButton.UseVisualStyleBackColor = true;
            this.ogrnIpGenButton.Click += new System.EventHandler(this.OgrnIpGenButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(9, 67);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.innUlLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.innUlGenButton);
            this.splitContainer2.Size = new System.Drawing.Size(260, 45);
            this.splitContainer2.SplitterDistance = 175;
            this.splitContainer2.TabIndex = 3;
            // 
            // innUlLabel
            // 
            this.innUlLabel.AutoSize = true;
            this.innUlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.innUlLabel.Location = new System.Drawing.Point(3, 14);
            this.innUlLabel.Name = "innUlLabel";
            this.innUlLabel.Size = new System.Drawing.Size(160, 22);
            this.innUlLabel.TabIndex = 0;
            this.innUlLabel.Text = "_______________";
            this.innUlLabel.UseMnemonic = false;
            this.innUlLabel.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // innUlGenButton
            // 
            this.innUlGenButton.Location = new System.Drawing.Point(3, 3);
            this.innUlGenButton.Name = "innUlGenButton";
            this.innUlGenButton.Size = new System.Drawing.Size(75, 38);
            this.innUlGenButton.TabIndex = 1;
            this.innUlGenButton.Text = "Gen\'n\'Copy Inn UL";
            this.innUlGenButton.UseVisualStyleBackColor = true;
            this.innUlGenButton.Click += new System.EventHandler(this.InnUlGenButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(9, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.innIpLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.innIpGenButton);
            this.splitContainer1.Size = new System.Drawing.Size(260, 45);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 3;
            // 
            // innIpLabel
            // 
            this.innIpLabel.AutoSize = true;
            this.innIpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.innIpLabel.Location = new System.Drawing.Point(3, 14);
            this.innIpLabel.Name = "innIpLabel";
            this.innIpLabel.Size = new System.Drawing.Size(160, 22);
            this.innIpLabel.TabIndex = 0;
            this.innIpLabel.Text = "_______________";
            this.innIpLabel.UseMnemonic = false;
            this.innIpLabel.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // innIpGenButton
            // 
            this.innIpGenButton.Location = new System.Drawing.Point(3, 3);
            this.innIpGenButton.Name = "innIpGenButton";
            this.innIpGenButton.Size = new System.Drawing.Size(75, 38);
            this.innIpGenButton.TabIndex = 1;
            this.innIpGenButton.Text = "Gen\'n\'Copy Inn IP";
            this.innIpGenButton.UseVisualStyleBackColor = true;
            this.innIpGenButton.Click += new System.EventHandler(this.InnIpGenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataList);
            this.groupBox1.Location = new System.Drawing.Point(295, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 284);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Последние генерации";
            // 
            // DataList
            // 
            this.DataList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataList.FormattingEnabled = true;
            this.DataList.ItemHeight = 18;
            this.DataList.Location = new System.Drawing.Point(10, 20);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(144, 256);
            this.DataList.TabIndex = 0;
            this.DataList.TabStop = false;
            this.DataList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataList_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label snilsLabel;
        private System.Windows.Forms.Button snilsGenButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label ogrnUlLabel;
        private System.Windows.Forms.Button ogrnUlGenButton;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label ogrnIpLabel;
        private System.Windows.Forms.Button ogrnIpGenButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label innUlLabel;
        private System.Windows.Forms.Button innUlGenButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label innIpLabel;
        private System.Windows.Forms.Button innIpGenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private ListBox DataList;
    }
}