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
            this.ModifierDropDown1.Location = new System.Drawing.Point(47, 64);
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
            this.ModifierDropDown2.Location = new System.Drawing.Point(135, 64);
            this.ModifierDropDown2.Name = "ModifierDropDown2";
            this.ModifierDropDown2.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDown2.TabIndex = 0;
            this.ModifierDropDown2.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDown2_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 69);
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
            this.SettingKeyDropDown.Location = new System.Drawing.Point(223, 64);
            this.SettingKeyDropDown.Name = "SettingKeyDropDown";
            this.SettingKeyDropDown.Size = new System.Drawing.Size(55, 21);
            this.SettingKeyDropDown.TabIndex = 0;
            this.SettingKeyDropDown.SelectionChangeCommitted += new System.EventHandler(this.KeyDropDown_SelectionChangeCommitted);
            // 
            // SaveHotkeyButton
            // 
            this.SaveHotkeyButton.Location = new System.Drawing.Point(47, 112);
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
            this.label3.Location = new System.Drawing.Point(63, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текущий хоткей:";
            // 
            // InfoHotkeySettings
            // 
            this.InfoHotkeySettings.AutoSize = true;
            this.InfoHotkeySettings.Location = new System.Drawing.Point(161, 24);
            this.InfoHotkeySettings.Name = "InfoHotkeySettings";
            this.InfoHotkeySettings.Size = new System.Drawing.Size(52, 13);
            this.InfoHotkeySettings.TabIndex = 3;
            this.InfoHotkeySettings.Text = "не задан";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 163);
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
    }
}

