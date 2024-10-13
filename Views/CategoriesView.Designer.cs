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
            tabControl2 = new TabControl();
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
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategorieDesc = new TextBox();
            label5 = new Label();
            TxtCategorieName = new TextBox();
            label4 = new Label();
            TxtCategorieId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl2.SuspendLayout();
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
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPageCategorieList);
            tabControl2.Controls.Add(tabPageCategorieDetail);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 90);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(800, 360);
            tabControl2.TabIndex = 1;
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
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(610, 255);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(146, 55);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(610, 187);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(146, 55);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(610, 42);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(146, 55);
            BtnNew.TabIndex = 5;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(610, 117);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(146, 55);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(24, 96);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.RowHeadersWidth = 51;
            DgCategorie.Size = new Size(541, 223);
            DgCategorie.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(471, 46);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(94, 46);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(24, 53);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(441, 27);
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
            tabPageCategorieDetail.Controls.Add(BtnCancel);
            tabPageCategorieDetail.Controls.Add(BtnSave);
            tabPageCategorieDetail.Controls.Add(TxtCategorieDesc);
            tabPageCategorieDetail.Controls.Add(label5);
            tabPageCategorieDetail.Controls.Add(TxtCategorieName);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Controls.Add(TxtCategorieId);
            tabPageCategorieDetail.Controls.Add(label3);
            tabPageCategorieDetail.Location = new Point(4, 29);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3);
            tabPageCategorieDetail.Size = new Size(792, 327);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "Categorie Detail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(204, 272);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(34, 272);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategorieDesc
            // 
            TxtCategorieDesc.Location = new Point(34, 177);
            TxtCategorieDesc.Multiline = true;
            TxtCategorieDesc.Name = "TxtCategorieDesc";
            TxtCategorieDesc.PlaceholderText = "Categorie Description";
            TxtCategorieDesc.Size = new Size(264, 77);
            TxtCategorieDesc.TabIndex = 5;
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
            // TxtCategorieName
            // 
            TxtCategorieName.Location = new Point(34, 109);
            TxtCategorieName.Name = "TxtCategorieName";
            TxtCategorieName.Size = new Size(264, 27);
            TxtCategorieName.TabIndex = 3;
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
            // TxtCategorieId
            // 
            TxtCategorieId.Location = new Point(34, 36);
            TxtCategorieId.Name = "TxtCategorieId";
            TxtCategorieId.ReadOnly = true;
            TxtCategorieId.Size = new Size(125, 27);
            TxtCategorieId.TabIndex = 1;
            TxtCategorieId.Text = "0";
            TxtCategorieId.TextAlign = HorizontalAlignment.Right;
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
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl2);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl2.ResumeLayout(false);
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
        private TabControl tabControl2;
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
        private TextBox TxtCategorieName;
        private Label label4;
        private TextBox TxtCategorieId;
        private Label label3;
        private TextBox TxtCategorieDesc;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
    }
}