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
            this.components = new System.ComponentModel.Container();
            this.ModifierDropDown1 = new System.Windows.Forms.ComboBox();
            this.ModifierDropDown2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyDropDown = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hotKeyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotKeyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hotKeyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotKeyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifierDropDown1
            // 
            this.ModifierDropDown1.DataSource = new TrayGenerator.KeyModifiers[]
            {
                TrayGenerator.KeyModifiers.None,
                TrayGenerator.KeyModifiers.Alt,
                TrayGenerator.KeyModifiers.Control,
                TrayGenerator.KeyModifiers.Shift,
                TrayGenerator.KeyModifiers.Windows
            };
            this.ModifierDropDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDown1.FormattingEnabled = true;
            this.ModifierDropDown1.Location = new System.Drawing.Point(42, 51);
            this.ModifierDropDown1.Name = "ModifierDropDown1";
            this.ModifierDropDown1.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDown1.TabIndex = 0;
            this.ModifierDropDown1.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDown1_SelectionChangeCommitted);
            // 
            // ModifierDropDown2
            // 
            this.ModifierDropDown2.DataSource = new TrayGenerator.KeyModifiers[]
            {
                TrayGenerator.KeyModifiers.None,
                TrayGenerator.KeyModifiers.Alt,
                TrayGenerator.KeyModifiers.Control,
                TrayGenerator.KeyModifiers.Shift,
                TrayGenerator.KeyModifiers.Windows
            };
            this.ModifierDropDown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifierDropDown2.Enabled = false;
            this.ModifierDropDown2.FormattingEnabled = true;
            this.ModifierDropDown2.Location = new System.Drawing.Point(130, 51);
            this.ModifierDropDown2.Name = "ModifierDropDown2";
            this.ModifierDropDown2.Size = new System.Drawing.Size(63, 21);
            this.ModifierDropDown2.TabIndex = 0;
            this.ModifierDropDown2.SelectionChangeCommitted += new System.EventHandler(this.ModifierDropDown2_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // KeyDropDown
            // 
            this.KeyDropDown.DataSource = new System.Windows.Forms.Keys[]
            {
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
                System.Windows.Forms.Keys.Z
            };
            this.KeyDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyDropDown.FormattingEnabled = true;
            this.KeyDropDown.Location = new System.Drawing.Point(218, 51);
            this.KeyDropDown.Name = "KeyDropDown";
            this.KeyDropDown.Size = new System.Drawing.Size(55, 21);
            this.KeyDropDown.TabIndex = 0;
            this.KeyDropDown.SelectionChangeCommitted += new System.EventHandler(this.KeyDropDown_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить хоткей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // hotKeyBindingSource
            // 
            this.hotKeyBindingSource.DataSource = typeof(TrayGenerator.HotKey);
            // 
            // hotKeyBindingSource1
            // 
            this.hotKeyBindingSource1.DataSource = typeof(TrayGenerator.HotKey);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyDropDown);
            this.Controls.Add(this.ModifierDropDown2);
            this.Controls.Add(this.ModifierDropDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form";
            this.Text = "TrayGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hotKeyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotKeyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ModifierDropDown1;
        private System.Windows.Forms.ComboBox ModifierDropDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KeyDropDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hotKeyBindingSource;
        private System.Windows.Forms.BindingSource hotKeyBindingSource1;
    }
}

