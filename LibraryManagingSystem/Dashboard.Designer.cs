
namespace LibraryManagingSystem
{
    partial class Dashboard
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
            this.btnPanel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnPanel2 = new System.Windows.Forms.Panel();
            this.userControl11 = new LibraryManagingSystem.UserControl1();
            this.userControl21 = new LibraryManagingSystem.UserControl2();
            this.userConAddBook1 = new LibraryManagingSystem.UserConAddBook();
            this.userConBookInquiries1 = new LibraryManagingSystem.UserConBookInquiries();
            this.userConEditBook1 = new LibraryManagingSystem.UserConEditBook();
            this.userConLendBooks1 = new LibraryManagingSystem.UserConLendBooks();
            this.userConMemReg1 = new LibraryManagingSystem.UserConMemReg();
            this.userConMemUnreg1 = new LibraryManagingSystem.UserConMemUnreg();
            this.userConReserveBook1 = new LibraryManagingSystem.UserConReserveBook();
            this.btnPanel1.SuspendLayout();
            this.btnPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPanel1
            // 
            this.btnPanel1.Controls.Add(this.button6);
            this.btnPanel1.Controls.Add(this.button5);
            this.btnPanel1.Controls.Add(this.button3);
            this.btnPanel1.Controls.Add(this.button2);
            this.btnPanel1.Controls.Add(this.button1);
            this.btnPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPanel1.Location = new System.Drawing.Point(0, 0);
            this.btnPanel1.Name = "btnPanel1";
            this.btnPanel1.Size = new System.Drawing.Size(281, 753);
            this.btnPanel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderSize = 4;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Image = global::LibraryManagingSystem.Properties.Resources._return;
            this.button6.Location = new System.Drawing.Point(12, 395);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10);
            this.button6.Size = new System.Drawing.Size(255, 95);
            this.button6.TabIndex = 14;
            this.button6.Text = "Return Books";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = global::LibraryManagingSystem.Properties.Resources.open_book;
            this.button5.Location = new System.Drawing.Point(12, 513);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10);
            this.button5.Size = new System.Drawing.Size(255, 95);
            this.button5.TabIndex = 15;
            this.button5.Text = "Lend Books";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::LibraryManagingSystem.Properties.Resources.edit1;
            this.button3.Location = new System.Drawing.Point(12, 277);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(255, 95);
            this.button3.TabIndex = 17;
            this.button3.Text = "Edit Book";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::LibraryManagingSystem.Properties.Resources.minus;
            this.button2.Location = new System.Drawing.Point(12, 157);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(255, 95);
            this.button2.TabIndex = 18;
            this.button2.Text = "Remove Book";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::LibraryManagingSystem.Properties.Resources.add;
            this.button1.Location = new System.Drawing.Point(-386, 29);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(187, 95);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Book";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.BorderSize = 4;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Image = global::LibraryManagingSystem.Properties.Resources.new_user;
            this.button8.Location = new System.Drawing.Point(14, 157);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10);
            this.button8.Size = new System.Drawing.Size(255, 95);
            this.button8.TabIndex = 12;
            this.button8.Text = "Member Registration";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.BorderSize = 4;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Image = global::LibraryManagingSystem.Properties.Resources.reserved;
            this.button7.Location = new System.Drawing.Point(14, 395);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10);
            this.button7.Size = new System.Drawing.Size(255, 95);
            this.button7.TabIndex = 13;
            this.button7.Text = "Reserve Books";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::LibraryManagingSystem.Properties.Resources.book1;
            this.button4.Location = new System.Drawing.Point(14, 277);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(255, 95);
            this.button4.TabIndex = 16;
            this.button4.Text = "Book Inquiries";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.BorderSize = 4;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Image = global::LibraryManagingSystem.Properties.Resources.remove_user;
            this.button9.Location = new System.Drawing.Point(14, 513);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10);
            this.button9.Size = new System.Drawing.Size(255, 95);
            this.button9.TabIndex = 11;
            this.button9.Text = "Member Unregistration";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnPanel2
            // 
            this.btnPanel2.Controls.Add(this.button9);
            this.btnPanel2.Controls.Add(this.button7);
            this.btnPanel2.Controls.Add(this.button8);
            this.btnPanel2.Controls.Add(this.button4);
            this.btnPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPanel2.Location = new System.Drawing.Point(1251, 0);
            this.btnPanel2.Name = "btnPanel2";
            this.btnPanel2.Size = new System.Drawing.Size(281, 753);
            this.btnPanel2.TabIndex = 17;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(287, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(958, 753);
            this.userControl11.TabIndex = 18;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(287, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(958, 753);
            this.userControl21.TabIndex = 19;
            // 
            // userConAddBook1
            // 
            this.userConAddBook1.Location = new System.Drawing.Point(287, 0);
            this.userConAddBook1.Name = "userConAddBook1";
            this.userConAddBook1.Size = new System.Drawing.Size(958, 694);
            this.userConAddBook1.TabIndex = 20;
            // 
            // userConBookInquiries1
            // 
            this.userConBookInquiries1.Location = new System.Drawing.Point(287, 0);
            this.userConBookInquiries1.Name = "userConBookInquiries1";
            this.userConBookInquiries1.Size = new System.Drawing.Size(958, 753);
            this.userConBookInquiries1.TabIndex = 21;
            // 
            // userConEditBook1
            // 
            this.userConEditBook1.Location = new System.Drawing.Point(287, 0);
            this.userConEditBook1.Name = "userConEditBook1";
            this.userConEditBook1.Size = new System.Drawing.Size(958, 753);
            this.userConEditBook1.TabIndex = 22;
            // 
            // userConLendBooks1
            // 
            this.userConLendBooks1.Location = new System.Drawing.Point(287, 0);
            this.userConLendBooks1.Name = "userConLendBooks1";
            this.userConLendBooks1.Size = new System.Drawing.Size(958, 753);
            this.userConLendBooks1.TabIndex = 23;
            // 
            // userConMemReg1
            // 
            this.userConMemReg1.Location = new System.Drawing.Point(287, 0);
            this.userConMemReg1.Name = "userConMemReg1";
            this.userConMemReg1.Size = new System.Drawing.Size(958, 753);
            this.userConMemReg1.TabIndex = 24;
            // 
            // userConMemUnreg1
            // 
            this.userConMemUnreg1.Location = new System.Drawing.Point(287, 0);
            this.userConMemUnreg1.Name = "userConMemUnreg1";
            this.userConMemUnreg1.Size = new System.Drawing.Size(958, 753);
            this.userConMemUnreg1.TabIndex = 25;
            // 
            // userConReserveBook1
            // 
            this.userConReserveBook1.Location = new System.Drawing.Point(287, 2);
            this.userConReserveBook1.Name = "userConReserveBook1";
            this.userConReserveBook1.Size = new System.Drawing.Size(958, 751);
            this.userConReserveBook1.TabIndex = 26;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 753);
            this.Controls.Add(this.userConReserveBook1);
            this.Controls.Add(this.userConMemUnreg1);
            this.Controls.Add(this.userConMemReg1);
            this.Controls.Add(this.userConLendBooks1);
            this.Controls.Add(this.userConEditBook1);
            this.Controls.Add(this.userConBookInquiries1);
            this.Controls.Add(this.userConAddBook1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnPanel2);
            this.Controls.Add(this.btnPanel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.btnPanel1.ResumeLayout(false);
            this.btnPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnPanel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel btnPanel2;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserConAddBook userConAddBook1;
        private UserConBookInquiries userConBookInquiries1;
        private UserConEditBook userConEditBook1;
        private UserConLendBooks userConLendBooks1;
        private UserConMemReg userConMemReg1;
        private UserConMemUnreg userConMemUnreg1;
        private UserConReserveBook userConReserveBook1;
    }
}