using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    partial class SettingsForm
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
            this.ModifierDropDownIp1 = new System.Windows.Forms.ComboBox();
            this.ModifierDropDownIp2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingKeyDropDownIp = new System.Windows.Forms.ComboBox();
            this.SaveIpHotkeyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InfoHotkeySettingsIP = new System.Windows.Forms.Label();
            this.InfoHotkeySettingsUL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveUlHotkeyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SettingKeyDropDownUl = new System.Windows.Forms.ComboBox();
            this.ModifierDropDownUl2 = new System.Windows.Forms.ComboBox();
            this.ModifierDropDownUl1 = new System.Windows.Forms.ComboBox();
            this.ReselHotkeyIp = new System.Windows.Forms.Button();
            this.ResetHotkeyUl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifierDropDownIp1
            // 
            this.ModifierDropDownIp1.DataSource = new TrayGenerator.KeyModifiers[] {
        TrayGenerator.KeyModifiers.None,
        TrayGenerator.KeyModifiers.Alt,
        TrayGenerator.KeyModifiers.Control,
        TrayGenerator.KeyModifiers.Shift};
            this.ModifierDropDownIp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDownIp1.FormattingEnabled = true;
            this.ModifierDropDownIp1.Location = new System.Drawing.Point(7, 56);
            this.ModifierDropDownIp1.Name = "ModifierDropDownIp1";
            this.ModifierDropDownIp1.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDownIp1.TabIndex = 0;
            this.ModifierDropDownIp1.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDownIp1_SelectionChangeCommitted);
            // 
            // ModifierDropDownIp2
            // 
            this.ModifierDropDownIp2.DataSource = new TrayGenerator.KeyModifiers[] {
        TrayGenerator.KeyModifiers.None,
        TrayGenerator.KeyModifiers.Alt,
        TrayGenerator.KeyModifiers.Control,
        TrayGenerator.KeyModifiers.Shift,
        TrayGenerator.KeyModifiers.Windows};
            this.ModifierDropDownIp2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDownIp2.Enabled = false;
            this.ModifierDropDownIp2.FormattingEnabled = true;
            this.ModifierDropDownIp2.Location = new System.Drawing.Point(95, 56);
            this.ModifierDropDownIp2.Name = "ModifierDropDownIp2";
            this.ModifierDropDownIp2.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDownIp2.TabIndex = 0;
            this.ModifierDropDownIp2.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDownIp2_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // SettingKeyDropDownIp
            // 
            this.SettingKeyDropDownIp.DataSource = new System.Windows.Forms.Keys[] {
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
            this.SettingKeyDropDownIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingKeyDropDownIp.FormattingEnabled = true;
            this.SettingKeyDropDownIp.Location = new System.Drawing.Point(183, 56);
            this.SettingKeyDropDownIp.Name = "SettingKeyDropDownIp";
            this.SettingKeyDropDownIp.Size = new System.Drawing.Size(55, 21);
            this.SettingKeyDropDownIp.TabIndex = 0;
            this.SettingKeyDropDownIp.SelectionChangeCommitted += new System.EventHandler(this.KeyDropDownIp_SelectionChangeCommitted);
            // 
            // SaveIpHotkeyButton
            // 
            this.SaveIpHotkeyButton.Location = new System.Drawing.Point(7, 85);
            this.SaveIpHotkeyButton.Name = "SaveIpHotkeyButton";
            this.SaveIpHotkeyButton.Size = new System.Drawing.Size(151, 43);
            this.SaveIpHotkeyButton.TabIndex = 2;
            this.SaveIpHotkeyButton.Text = "Сохранить хоткей";
            this.SaveIpHotkeyButton.UseVisualStyleBackColor = true;
            this.SaveIpHotkeyButton.Click += new System.EventHandler(this.SaveIpHotkeyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текущий хоткей:";
            // 
            // InfoHotkeySettingsIP
            // 
            this.InfoHotkeySettingsIP.AutoSize = true;
            this.InfoHotkeySettingsIP.Location = new System.Drawing.Point(107, 31);
            this.InfoHotkeySettingsIP.Name = "InfoHotkeySettingsIP";
            this.InfoHotkeySettingsIP.Size = new System.Drawing.Size(52, 13);
            this.InfoHotkeySettingsIP.TabIndex = 3;
            this.InfoHotkeySettingsIP.Text = "не задан";
            // 
            // InfoHotkeySettingsUL
            // 
            this.InfoHotkeySettingsUL.AutoSize = true;
            this.InfoHotkeySettingsUL.Location = new System.Drawing.Point(105, 31);
            this.InfoHotkeySettingsUL.Name = "InfoHotkeySettingsUL";
            this.InfoHotkeySettingsUL.Size = new System.Drawing.Size(52, 13);
            this.InfoHotkeySettingsUL.TabIndex = 10;
            this.InfoHotkeySettingsUL.Text = "не задан";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Текущий хоткей:";
            // 
            // SaveUlHotkeyButton
            // 
            this.SaveUlHotkeyButton.Location = new System.Drawing.Point(6, 85);
            this.SaveUlHotkeyButton.Name = "SaveUlHotkeyButton";
            this.SaveUlHotkeyButton.Size = new System.Drawing.Size(151, 43);
            this.SaveUlHotkeyButton.TabIndex = 9;
            this.SaveUlHotkeyButton.Text = "Сохранить хоткей";
            this.SaveUlHotkeyButton.UseVisualStyleBackColor = true;
            this.SaveUlHotkeyButton.Click += new System.EventHandler(this.SaveUlHotkeyButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "+";
            // 
            // SettingKeyDropDownUl
            // 
            this.SettingKeyDropDownUl.DataSource = new System.Windows.Forms.Keys[] {
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
            this.SettingKeyDropDownUl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingKeyDropDownUl.FormattingEnabled = true;
            this.SettingKeyDropDownUl.Location = new System.Drawing.Point(182, 56);
            this.SettingKeyDropDownUl.Name = "SettingKeyDropDownUl";
            this.SettingKeyDropDownUl.Size = new System.Drawing.Size(55, 21);
            this.SettingKeyDropDownUl.TabIndex = 4;
            this.SettingKeyDropDownUl.SelectionChangeCommitted += new System.EventHandler(this.KeyDropDownUl_SelectionChangeCommitted);
            // 
            // ModifierDropDownUl2
            // 
            this.ModifierDropDownUl2.DataSource = new TrayGenerator.KeyModifiers[] {
        TrayGenerator.KeyModifiers.None,
        TrayGenerator.KeyModifiers.Alt,
        TrayGenerator.KeyModifiers.Control,
        TrayGenerator.KeyModifiers.Shift,
        TrayGenerator.KeyModifiers.Windows};
            this.ModifierDropDownUl2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDownUl2.Enabled = false;
            this.ModifierDropDownUl2.FormattingEnabled = true;
            this.ModifierDropDownUl2.Location = new System.Drawing.Point(94, 56);
            this.ModifierDropDownUl2.Name = "ModifierDropDownUl2";
            this.ModifierDropDownUl2.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDownUl2.TabIndex = 5;
            this.ModifierDropDownUl2.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDownUl2_SelectionChangeCommitted);
            // 
            // ModifierDropDownUl1
            // 
            this.ModifierDropDownUl1.DataSource = new TrayGenerator.KeyModifiers[] {
        TrayGenerator.KeyModifiers.None,
        TrayGenerator.KeyModifiers.Alt,
        TrayGenerator.KeyModifiers.Control,
        TrayGenerator.KeyModifiers.Shift};
            this.ModifierDropDownUl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDownUl1.FormattingEnabled = true;
            this.ModifierDropDownUl1.Location = new System.Drawing.Point(6, 56);
            this.ModifierDropDownUl1.Name = "ModifierDropDownUl1";
            this.ModifierDropDownUl1.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDownUl1.TabIndex = 6;
            this.ModifierDropDownUl1.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDownUl1_SelectionChangeCommitted);
            // 
            // ReselHotkeyIp
            // 
            this.ReselHotkeyIp.Location = new System.Drawing.Point(167, 85);
            this.ReselHotkeyIp.Name = "ReselHotkeyIp";
            this.ReselHotkeyIp.Size = new System.Drawing.Size(75, 43);
            this.ReselHotkeyIp.TabIndex = 12;
            this.ReselHotkeyIp.Text = "сбросить настройку";
            this.ReselHotkeyIp.UseVisualStyleBackColor = true;
            this.ReselHotkeyIp.Click += new System.EventHandler(this.ResetHotkeyIp_Click);
            // 
            // ResetHotkeyUl
            // 
            this.ResetHotkeyUl.Location = new System.Drawing.Point(166, 85);
            this.ResetHotkeyUl.Name = "ResetHotkeyUl";
            this.ResetHotkeyUl.Size = new System.Drawing.Size(75, 43);
            this.ResetHotkeyUl.TabIndex = 13;
            this.ResetHotkeyUl.Text = "сбросить настройку";
            this.ResetHotkeyUl.UseVisualStyleBackColor = true;
            this.ResetHotkeyUl.Click += new System.EventHandler(this.ResetHotkeyUl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveUlHotkeyButton);
            this.groupBox1.Controls.Add(this.ResetHotkeyUl);
            this.groupBox1.Controls.Add(this.ModifierDropDownUl1);
            this.groupBox1.Controls.Add(this.ModifierDropDownUl2);
            this.groupBox1.Controls.Add(this.InfoHotkeySettingsUL);
            this.groupBox1.Controls.Add(this.SettingKeyDropDownUl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(299, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Хоткей генерации ИНН ЮЛ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReselHotkeyIp);
            this.groupBox2.Controls.Add(this.ModifierDropDownIp1);
            this.groupBox2.Controls.Add(this.ModifierDropDownIp2);
            this.groupBox2.Controls.Add(this.InfoHotkeySettingsIP);
            this.groupBox2.Controls.Add(this.SettingKeyDropDownIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SaveIpHotkeyButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(31, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 150);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Хоткей генерации ИНН ИП";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SettingsForm";
            this.Text = "TrayGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ModifierDropDownIp1;
        private System.Windows.Forms.ComboBox ModifierDropDownIp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SettingKeyDropDownIp;
        private System.Windows.Forms.Button SaveIpHotkeyButton;
        private Label label3;
        private Label InfoHotkeySettingsIP;
        private Label InfoHotkeySettingsUL;
        private Label label5;
        private Button SaveUlHotkeyButton;
        private Label label6;
        private Label label7;
        private ComboBox SettingKeyDropDownUl;
        private ComboBox ModifierDropDownUl2;
        private ComboBox ModifierDropDownUl1;
        private Button ReselHotkeyIp;
        private Button ResetHotkeyUl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}

