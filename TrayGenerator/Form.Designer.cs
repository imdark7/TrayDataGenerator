using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModifierDropDown1 = new System.Windows.Forms.ComboBox();
            this.ModifierDropDown2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingKeyDropDown = new System.Windows.Forms.ComboBox();
            this.SaveHotkeyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InfoHotkeySettings = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // ModifierDropDown1
            // 
            this.ModifierDropDown1.DataSource = new TrayGenerator.KeyModifiers[] {
        TrayGenerator.KeyModifiers.None,
        TrayGenerator.KeyModifiers.Alt,
        TrayGenerator.KeyModifiers.Control,
        TrayGenerator.KeyModifiers.Shift,
        TrayGenerator.KeyModifiers.Windows};
            this.ModifierDropDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDown1.FormattingEnabled = true;
            this.ModifierDropDown1.Location = new System.Drawing.Point(33, 57);
            this.ModifierDropDown1.Name = "ModifierDropDown1";
            this.ModifierDropDown1.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDown1.TabIndex = 0;
            this.ModifierDropDown1.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDown1_SelectionChangeCommitted);
            // 
            // ModifierDropDown2
            // 
            this.ModifierDropDown2.DataSource = new TrayGenerator.KeyModifiers[] {
        TrayGenerator.KeyModifiers.None,
        TrayGenerator.KeyModifiers.Alt,
        TrayGenerator.KeyModifiers.Control,
        TrayGenerator.KeyModifiers.Shift,
        TrayGenerator.KeyModifiers.Windows};
            this.ModifierDropDown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDown2.Enabled = false;
            this.ModifierDropDown2.FormattingEnabled = true;
            this.ModifierDropDown2.Location = new System.Drawing.Point(121, 57);
            this.ModifierDropDown2.Name = "ModifierDropDown2";
            this.ModifierDropDown2.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDown2.TabIndex = 0;
            this.ModifierDropDown2.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDown2_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // SettingKeyDropDown
            // 
            this.SettingKeyDropDown.DataSource = new System.Windows.Forms.Keys[] {
        System.Windows.Forms.Keys.None,
        System.Windows.Forms.Keys.A,
        System.Windows.Forms.Keys.B,
        System.Windows.Forms.Keys.C,
        System.Windows.Forms.Keys.D,
        System.Windows.Forms.Keys.E,
        System.Windows.Forms.Keys.F,
        System.Windows.Forms.Keys.G,
        System.Windows.Forms.Keys.H,
        System.Windows.Forms.Keys.I,
        System.Windows.Forms.Keys.J,
        System.Windows.Forms.Keys.K,
        System.Windows.Forms.Keys.L,
        System.Windows.Forms.Keys.M,
        System.Windows.Forms.Keys.N,
        System.Windows.Forms.Keys.O,
        System.Windows.Forms.Keys.P,
        System.Windows.Forms.Keys.Q,
        System.Windows.Forms.Keys.R,
        System.Windows.Forms.Keys.S,
        System.Windows.Forms.Keys.T,
        System.Windows.Forms.Keys.U,
        System.Windows.Forms.Keys.V,
        System.Windows.Forms.Keys.W,
        System.Windows.Forms.Keys.X,
        System.Windows.Forms.Keys.Y,
        System.Windows.Forms.Keys.Z};
            this.SettingKeyDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingKeyDropDown.FormattingEnabled = true;
            this.SettingKeyDropDown.Location = new System.Drawing.Point(209, 57);
            this.SettingKeyDropDown.Name = "SettingKeyDropDown";
            this.SettingKeyDropDown.Size = new System.Drawing.Size(55, 21);
            this.SettingKeyDropDown.TabIndex = 0;
            this.SettingKeyDropDown.SelectionChangeCommitted += new System.EventHandler(this.KeyDropDown_SelectionChangeCommitted);
            // 
            // SaveHotkeyButton
            // 
            this.SaveHotkeyButton.Location = new System.Drawing.Point(33, 93);
            this.SaveHotkeyButton.Name = "SaveHotkeyButton";
            this.SaveHotkeyButton.Size = new System.Drawing.Size(231, 23);
            this.SaveHotkeyButton.TabIndex = 2;
            this.SaveHotkeyButton.Text = "Сохранить хоткей";
            this.SaveHotkeyButton.UseVisualStyleBackColor = true;
            this.SaveHotkeyButton.Click += new System.EventHandler(this.SaveHotkeyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текущий хоткей:";
            // 
            // InfoHotkeySettings
            // 
            this.InfoHotkeySettings.AutoSize = true;
            this.InfoHotkeySettings.Location = new System.Drawing.Point(147, 26);
            this.InfoHotkeySettings.Name = "InfoHotkeySettings";
            this.InfoHotkeySettings.Size = new System.Drawing.Size(52, 13);
            this.InfoHotkeySettings.TabIndex = 3;
            this.InfoHotkeySettings.Text = "не задан";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer5);
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Controls.Add(this.splitContainer4);
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 266);
            this.panel1.TabIndex = 4;
            // 
            // splitContainer5
            // 
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
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoHotkeySettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveHotkeyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingKeyDropDown);
            this.Controls.Add(this.ModifierDropDown2);
            this.Controls.Add(this.ModifierDropDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form";
            this.Text = "TrayGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ModifierDropDown1;
        private System.Windows.Forms.ComboBox ModifierDropDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SettingKeyDropDown;
        private System.Windows.Forms.Button SaveHotkeyButton;
        private Label label3;
        private Label InfoHotkeySettings;
        private Panel panel1;
        private Button innIpGenButton;
        private Label innIpLabel;
        private SplitContainer splitContainer5;
        private Label snilsLabel;
        private Button snilsGenButton;
        private SplitContainer splitContainer3;
        private Label ogrnUlLabel;
        private Button ogrnUlGenButton;
        private SplitContainer splitContainer4;
        private Label ogrnIpLabel;
        private Button ogrnIpGenButton;
        private SplitContainer splitContainer2;
        private Label innUlLabel;
        private Button innUlGenButton;
        private SplitContainer splitContainer1;
    }
}

