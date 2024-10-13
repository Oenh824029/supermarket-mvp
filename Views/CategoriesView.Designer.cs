namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategorieList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnNew = new Button();
            BtnEdit = new Button();
            DgCategorie = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategorieDetail = new TabPage();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).BeginInit();
            tabPageCategorieDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 90);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(183, 21);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategorieDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 360);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.Controls.Add(BtnClose);
            tabPageCategorieList.Controls.Add(BtnDelete);
            tabPageCategorieList.Controls.Add(BtnNew);
            tabPageCategorieList.Controls.Add(BtnEdit);
            tabPageCategorieList.Controls.Add(DgCategorie);
            tabPageCategorieList.Controls.Add(BtnSearch);
            tabPageCategorieList.Controls.Add(TxtSearch);
            tabPageCategorieList.Controls.Add(label2);
            tabPageCategorieList.Location = new Point(4, 29);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3);
            tabPageCategorieList.Size = new Size(792, 327);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "Categorie List";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(590, 254);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(146, 55);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(590, 187);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(146, 55);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(590, 45);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(146, 55);
            BtnNew.TabIndex = 5;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(590, 116);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(146, 55);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(24, 96);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.RowHeadersWidth = 51;
            DgCategorie.Size = new Size(486, 223);
            DgCategorie.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(227, 42);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(94, 46);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(24, 53);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(178, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categorie";
            // 
            // tabPageCategorieDetail
            // 
            tabPageCategorieDetail.Controls.Add(button2);
            tabPageCategorieDetail.Controls.Add(button1);
            tabPageCategorieDetail.Controls.Add(textBox3);
            tabPageCategorieDetail.Controls.Add(label5);
            tabPageCategorieDetail.Controls.Add(textBox2);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Controls.Add(textBox1);
            tabPageCategorieDetail.Controls.Add(label3);
            tabPageCategorieDetail.Location = new Point(4, 29);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3);
            tabPageCategorieDetail.Size = new Size(792, 327);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "Categorie Detail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(34, 13);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 0;
            label3.Text = "Categorie Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(34, 86);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 2;
            label4.Text = "Categorie Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(34, 154);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Categorie Description";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 177);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Categorie Description";
            textBox3.Size = new Size(264, 77);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(34, 272);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(204, 272);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).EndInit();
            tabPageCategorieDetail.ResumeLayout(false);
            tabPageCategorieDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategorieList;
        private TabPage tabPageCategorieDetail;
        private TabPage tabPage1;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnSearch;
        private DataGridView DgCategorie;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnNew;
        private Button BtnEdit;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}