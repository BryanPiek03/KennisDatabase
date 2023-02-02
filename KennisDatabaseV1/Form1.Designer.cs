﻿
namespace KennisDatabaseV1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ClsBtn = new System.Windows.Forms.Button();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.NavMenuPnl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NavMenuLBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchbarTxt = new System.Windows.Forms.TextBox();
            this.HamburgerBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NavMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.NavMenuPnl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.ClsBtn);
            this.panel1.Controls.Add(this.ReloadBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1707, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1387, 66);
            this.label1.TabIndex = 4;
            this.label1.Text = "KennisDatabase | Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // MinBtn
            // 
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Location = new System.Drawing.Point(1547, 0);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(80, 66);
            this.MinBtn.TabIndex = 6;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // ClsBtn
            // 
            this.ClsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClsBtn.BackgroundImage")));
            this.ClsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClsBtn.FlatAppearance.BorderSize = 0;
            this.ClsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClsBtn.Location = new System.Drawing.Point(1627, 0);
            this.ClsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClsBtn.Name = "ClsBtn";
            this.ClsBtn.Size = new System.Drawing.Size(80, 66);
            this.ClsBtn.TabIndex = 5;
            this.ClsBtn.UseVisualStyleBackColor = true;
            this.ClsBtn.Click += new System.EventHandler(this.ClsBtn_Click);
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReloadBtn.FlatAppearance.BorderSize = 0;
            this.ReloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadBtn.Location = new System.Drawing.Point(0, 0);
            this.ReloadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(160, 66);
            this.ReloadBtn.TabIndex = 0;
            this.ReloadBtn.Text = "Reload";
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // NavMenuPnl
            // 
            this.NavMenuPnl.Controls.Add(this.panel4);
            this.NavMenuPnl.Controls.Add(this.panel3);
            this.NavMenuPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.NavMenuPnl.Location = new System.Drawing.Point(1627, 66);
            this.NavMenuPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NavMenuPnl.Name = "NavMenuPnl";
            this.NavMenuPnl.Size = new System.Drawing.Size(80, 820);
            this.NavMenuPnl.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NavMenuLBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 758);
            this.panel4.TabIndex = 1;
            // 
            // NavMenuLBox
            // 
            this.NavMenuLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavMenuLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavMenuLBox.FormattingEnabled = true;
            this.NavMenuLBox.ItemHeight = 29;
            this.NavMenuLBox.Items.AddRange(new object[] {
            "Chapter 1 Introduction to Programming",
            "Chapter 2 Primitive Types and Variables",
            "Chapter 3 Operators and Expressions",
            "Chapter 4 Console Inputand Output",
            "Chapter 5 Conditional Statements",
            "Chapter 6 Loops",
            "Chapter 7 Arrays",
            "Chapter 8 Numeral Systems",
            "Chapter 9 Methods",
            "Chapter 10 Recursion",
            "Chapter 11 Creating and Using Objects",
            "Chapter 12 Exception Handling",
            "Chapter 13 Strings and Text Processing",
            "Chapter 14 Defining Classes",
            "Chapter 15 Text Files",
            "Chapter 16 Linear Data Structures",
            "Chapter 17 Trees and Graphs",
            "Chapter 18 Dictionaries, Hash-Tables and Sets",
            "Chapter 19 Data Structures and Algorithm Complexity",
            "Chapter 20 Object-Oriented Programming Principles",
            "Chapter 21 High-Quality Programming Code",
            "Chapter 22 Lambda Expressions and LINQ",
            "Chapter 23 Methodology of Problem Solving"});
            this.NavMenuLBox.Location = new System.Drawing.Point(0, 0);
            this.NavMenuLBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NavMenuLBox.Name = "NavMenuLBox";
            this.NavMenuLBox.Size = new System.Drawing.Size(80, 758);
            this.NavMenuLBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SearchbarTxt);
            this.panel3.Controls.Add(this.HamburgerBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 62);
            this.panel3.TabIndex = 0;
            // 
            // SearchbarTxt
            // 
            this.SearchbarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchbarTxt.Location = new System.Drawing.Point(179, 7);
            this.SearchbarTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchbarTxt.Multiline = true;
            this.SearchbarTxt.Name = "SearchbarTxt";
            this.SearchbarTxt.Size = new System.Drawing.Size(448, 46);
            this.SearchbarTxt.TabIndex = 1;
            // 
            // HamburgerBtn
            // 
            this.HamburgerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HamburgerBtn.BackgroundImage")));
            this.HamburgerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HamburgerBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.HamburgerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamburgerBtn.Location = new System.Drawing.Point(0, 0);
            this.HamburgerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HamburgerBtn.Name = "HamburgerBtn";
            this.HamburgerBtn.Size = new System.Drawing.Size(80, 62);
            this.HamburgerBtn.TabIndex = 0;
            this.HamburgerBtn.UseVisualStyleBackColor = true;
            this.HamburgerBtn.Click += new System.EventHandler(this.HamburgerBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1627, 820);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1627, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dit programma is gemaakt door klas 2SV1.\r\nDit is een programma waar informatie om" +
    "trend C# opgeslagen is voor uw gemakkelijkheid.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1627, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welkom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavMoveTimer
            // 
            this.NavMoveTimer.Interval = 0;
            this.NavMoveTimer.Tick += new System.EventHandler(this.NavMoveTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.NavMenuPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.NavMenuPnl.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button ClsBtn;
        private System.Windows.Forms.Panel NavMenuPnl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox NavMenuLBox;
        private System.Windows.Forms.Button HamburgerBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchbarTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer NavMoveTimer;
    }
}
