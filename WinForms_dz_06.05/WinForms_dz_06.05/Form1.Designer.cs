﻿namespace WinForms_dz_06._05
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
            this.txbTopLevelMenu = new System.Windows.Forms.TextBox();
            this.txbSubItem = new System.Windows.Forms.TextBox();
            this.btnAddTopMenu = new System.Windows.Forms.Button();
            this.btnAddSubMenu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTopLevelMenu
            // 
            this.txbTopLevelMenu.Location = new System.Drawing.Point(12, 57);
            this.txbTopLevelMenu.Name = "txbTopLevelMenu";
            this.txbTopLevelMenu.Size = new System.Drawing.Size(177, 20);
            this.txbTopLevelMenu.TabIndex = 0;
            // 
            // txbSubItem
            // 
            this.txbSubItem.Location = new System.Drawing.Point(12, 160);
            this.txbSubItem.Name = "txbSubItem";
            this.txbSubItem.Size = new System.Drawing.Size(177, 20);
            this.txbSubItem.TabIndex = 1;
            // 
            // btnAddTopMenu
            // 
            this.btnAddTopMenu.Location = new System.Drawing.Point(205, 55);
            this.btnAddTopMenu.Name = "btnAddTopMenu";
            this.btnAddTopMenu.Size = new System.Drawing.Size(142, 23);
            this.btnAddTopMenu.TabIndex = 2;
            this.btnAddTopMenu.Text = "Добавить пункт меню";
            this.btnAddTopMenu.UseVisualStyleBackColor = true;
            this.btnAddTopMenu.Click += new System.EventHandler(this.btnAddTopMenu_Click);
            // 
            // btnAddSubMenu
            // 
            this.btnAddSubMenu.Location = new System.Drawing.Point(205, 158);
            this.btnAddSubMenu.Name = "btnAddSubMenu";
            this.btnAddSubMenu.Size = new System.Drawing.Size(142, 23);
            this.btnAddSubMenu.TabIndex = 3;
            this.btnAddSubMenu.Text = "Добавить подменю";
            this.btnAddSubMenu.UseVisualStyleBackColor = true;
            this.btnAddSubMenu.Click += new System.EventHandler(this.btnAddSubMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TopMenu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SubMenu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSubMenu);
            this.Controls.Add(this.btnAddTopMenu);
            this.Controls.Add(this.txbSubItem);
            this.Controls.Add(this.txbTopLevelMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTopLevelMenu;
        private System.Windows.Forms.TextBox txbSubItem;
        private System.Windows.Forms.Button btnAddTopMenu;
        private System.Windows.Forms.Button btnAddSubMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

