
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
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.lendBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.memRegBtn = new System.Windows.Forms.Button();
            this.reserveBooksBtn = new System.Windows.Forms.Button();
            this.booksInquiries = new System.Windows.Forms.Button();
            this.memUnRegBtn = new System.Windows.Forms.Button();
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
            this.userConReturnBook1 = new LibraryManagingSystem.UserConReturnBook();
            this.btnPanel1.SuspendLayout();
            this.btnPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPanel1
            // 
            this.btnPanel1.BackgroundImage = global::LibraryManagingSystem.Properties.Resources._500_F_241695755_Ixz5vC6ZNYKqpT7X3OuF3DsY58sSMHFU;
            this.btnPanel1.Controls.Add(this.returnBookBtn);
            this.btnPanel1.Controls.Add(this.lendBtn);
            this.btnPanel1.Controls.Add(this.editBookBtn);
            this.btnPanel1.Controls.Add(this.addbtn);
            this.btnPanel1.Controls.Add(this.removebtn);
            this.btnPanel1.Controls.Add(this.button1);
            this.btnPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPanel1.Location = new System.Drawing.Point(0, 0);
            this.btnPanel1.Name = "btnPanel1";
            this.btnPanel1.Size = new System.Drawing.Size(281, 853);
            this.btnPanel1.TabIndex = 0;
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.returnBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBookBtn.FlatAppearance.BorderSize = 4;
            this.returnBookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.returnBookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.returnBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnBookBtn.Image = global::LibraryManagingSystem.Properties.Resources._return;
            this.returnBookBtn.Location = new System.Drawing.Point(12, 447);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Padding = new System.Windows.Forms.Padding(10);
            this.returnBookBtn.Size = new System.Drawing.Size(255, 95);
            this.returnBookBtn.TabIndex = 14;
            this.returnBookBtn.Text = "Return Books";
            this.returnBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnBookBtn.UseVisualStyleBackColor = false;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // lendBtn
            // 
            this.lendBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lendBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lendBtn.FlatAppearance.BorderSize = 4;
            this.lendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lendBtn.Image = global::LibraryManagingSystem.Properties.Resources.open_book;
            this.lendBtn.Location = new System.Drawing.Point(12, 569);
            this.lendBtn.Name = "lendBtn";
            this.lendBtn.Padding = new System.Windows.Forms.Padding(10);
            this.lendBtn.Size = new System.Drawing.Size(255, 95);
            this.lendBtn.TabIndex = 15;
            this.lendBtn.Text = "Lend Books";
            this.lendBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lendBtn.UseVisualStyleBackColor = false;
            this.lendBtn.Click += new System.EventHandler(this.lendBtn_Click);
            // 
            // editBookBtn
            // 
            this.editBookBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.editBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editBookBtn.FlatAppearance.BorderSize = 4;
            this.editBookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.editBookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.editBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBookBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBookBtn.Image = global::LibraryManagingSystem.Properties.Resources.edit1;
            this.editBookBtn.Location = new System.Drawing.Point(12, 324);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Padding = new System.Windows.Forms.Padding(10);
            this.editBookBtn.Size = new System.Drawing.Size(255, 95);
            this.editBookBtn.TabIndex = 17;
            this.editBookBtn.Text = "Edit Book";
            this.editBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBookBtn.UseVisualStyleBackColor = false;
            this.editBookBtn.Click += new System.EventHandler(this.editBookBtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addbtn.FlatAppearance.BorderSize = 4;
            this.addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbtn.Image = global::LibraryManagingSystem.Properties.Resources.add;
            this.addbtn.Location = new System.Drawing.Point(12, 74);
            this.addbtn.Name = "addbtn";
            this.addbtn.Padding = new System.Windows.Forms.Padding(10);
            this.addbtn.Size = new System.Drawing.Size(255, 95);
            this.addbtn.TabIndex = 18;
            this.addbtn.Text = "Add Book";
            this.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.removebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removebtn.FlatAppearance.BorderSize = 4;
            this.removebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.removebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removebtn.Image = global::LibraryManagingSystem.Properties.Resources.remove_b;
            this.removebtn.Location = new System.Drawing.Point(12, 201);
            this.removebtn.Name = "removebtn";
            this.removebtn.Padding = new System.Windows.Forms.Padding(10);
            this.removebtn.Size = new System.Drawing.Size(255, 95);
            this.removebtn.TabIndex = 18;
            this.removebtn.Text = "Remove Book";
            this.removebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
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
            // memRegBtn
            // 
            this.memRegBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.memRegBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memRegBtn.FlatAppearance.BorderSize = 4;
            this.memRegBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.memRegBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.memRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memRegBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memRegBtn.Image = global::LibraryManagingSystem.Properties.Resources.new_user;
            this.memRegBtn.Location = new System.Drawing.Point(14, 157);
            this.memRegBtn.Name = "memRegBtn";
            this.memRegBtn.Padding = new System.Windows.Forms.Padding(10);
            this.memRegBtn.Size = new System.Drawing.Size(255, 95);
            this.memRegBtn.TabIndex = 12;
            this.memRegBtn.Text = "Member Registration";
            this.memRegBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.memRegBtn.UseVisualStyleBackColor = false;
            this.memRegBtn.Click += new System.EventHandler(this.memRegBtn_Click);
            // 
            // reserveBooksBtn
            // 
            this.reserveBooksBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reserveBooksBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reserveBooksBtn.FlatAppearance.BorderSize = 4;
            this.reserveBooksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.reserveBooksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.reserveBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveBooksBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserveBooksBtn.Image = global::LibraryManagingSystem.Properties.Resources.reserved;
            this.reserveBooksBtn.Location = new System.Drawing.Point(14, 395);
            this.reserveBooksBtn.Name = "reserveBooksBtn";
            this.reserveBooksBtn.Padding = new System.Windows.Forms.Padding(10);
            this.reserveBooksBtn.Size = new System.Drawing.Size(255, 95);
            this.reserveBooksBtn.TabIndex = 13;
            this.reserveBooksBtn.Text = "Reserve Books";
            this.reserveBooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reserveBooksBtn.UseVisualStyleBackColor = false;
            this.reserveBooksBtn.Click += new System.EventHandler(this.reserveBooksBtn_Click);
            // 
            // booksInquiries
            // 
            this.booksInquiries.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.booksInquiries.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.booksInquiries.FlatAppearance.BorderSize = 4;
            this.booksInquiries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.booksInquiries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.booksInquiries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksInquiries.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booksInquiries.Image = global::LibraryManagingSystem.Properties.Resources.book1;
            this.booksInquiries.Location = new System.Drawing.Point(14, 277);
            this.booksInquiries.Name = "booksInquiries";
            this.booksInquiries.Padding = new System.Windows.Forms.Padding(10);
            this.booksInquiries.Size = new System.Drawing.Size(255, 95);
            this.booksInquiries.TabIndex = 16;
            this.booksInquiries.Text = "Book Inquiries";
            this.booksInquiries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.booksInquiries.UseVisualStyleBackColor = false;
            this.booksInquiries.Click += new System.EventHandler(this.booksInquiries_Click);
            // 
            // memUnRegBtn
            // 
            this.memUnRegBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.memUnRegBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memUnRegBtn.FlatAppearance.BorderSize = 4;
            this.memUnRegBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.memUnRegBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.memUnRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memUnRegBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memUnRegBtn.Image = global::LibraryManagingSystem.Properties.Resources.remove_user;
            this.memUnRegBtn.Location = new System.Drawing.Point(14, 513);
            this.memUnRegBtn.Name = "memUnRegBtn";
            this.memUnRegBtn.Padding = new System.Windows.Forms.Padding(10);
            this.memUnRegBtn.Size = new System.Drawing.Size(255, 95);
            this.memUnRegBtn.TabIndex = 11;
            this.memUnRegBtn.Text = "Member Unregistration";
            this.memUnRegBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.memUnRegBtn.UseVisualStyleBackColor = false;
            this.memUnRegBtn.Click += new System.EventHandler(this.memUnRegBtn_Click);
            // 
            // btnPanel2
            // 
            this.btnPanel2.BackgroundImage = global::LibraryManagingSystem.Properties.Resources._500_F_241695755_Ixz5vC6ZNYKqpT7X3OuF3DsY58sSMHFU;
            this.btnPanel2.Controls.Add(this.memUnRegBtn);
            this.btnPanel2.Controls.Add(this.reserveBooksBtn);
            this.btnPanel2.Controls.Add(this.memRegBtn);
            this.btnPanel2.Controls.Add(this.booksInquiries);
            this.btnPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPanel2.Location = new System.Drawing.Point(1251, 0);
            this.btnPanel2.Name = "btnPanel2";
            this.btnPanel2.Size = new System.Drawing.Size(281, 853);
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
            // userConReturnBook1
            // 
            this.userConReturnBook1.Location = new System.Drawing.Point(287, 2);
            this.userConReturnBook1.Name = "userConReturnBook1";
            this.userConReturnBook1.Size = new System.Drawing.Size(958, 751);
            this.userConReturnBook1.TabIndex = 27;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 853);
            this.Controls.Add(this.userConReturnBook1);
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
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.Button lendBtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button memRegBtn;
        private System.Windows.Forms.Button reserveBooksBtn;
        private System.Windows.Forms.Button booksInquiries;
        private System.Windows.Forms.Button memUnRegBtn;
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
        private System.Windows.Forms.Button addbtn;
        private UserConReturnBook userConReturnBook1;
    }
}