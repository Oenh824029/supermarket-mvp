using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEdit;
        private bool isSuccesful;
        private string message;

        private static CategoriesView instance;

        // constructor de la clase
        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            // cuando se ejecuta no aparece uno de los tabs del formulario
            tabControl2.TabPages.Remove(tabPageCategorieDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        public static CategoriesView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl2.TabPages.Remove(tabPageCategorieList);
                tabControl2.TabPages.Add(tabPageCategorieDetail);
                tabPageCategorieDetail.Text = "Add New Categorie";
            };
            BtnEdit.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl2.TabPages.Remove(tabPageCategorieList);
                tabControl2.TabPages.Add(tabPageCategorieDetail);
                tabPageCategorieDetail.Text = "Edit New Categorie";
            };
            BtnDelete.Click += delegate { 
                
                //DeleteEvent?.Invoke(this, EventArgs.Empty);

                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Categorie?",
                    "Warning",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            
            BtnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccesful)
                {
                    tabControl2.TabPages.Remove(tabPageCategorieDetail);
                    tabControl2.TabPages.Add(tabPageCategorieList);
                }
                MessageBox.Show(Message);
            };
            
            
            BtnCancel.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl2.TabPages.Remove(tabPageCategorieDetail);
                tabControl2.TabPages.Add(tabPageCategorieList);
            };
        }


        // métodos implementados de la interfaz
        public string CategoriesId 
        { 
            get { return TxtCategorieId.Text; } 
            set { TxtCategorieId.Text = value; }        
        }
        public string CategoriesName 
        {
            get { return TxtCategorieName.Text; }
            set { TxtCategorieName.Text = value; }
        }
        public string CategoriesDescription 
        {
            get { return TxtCategorieDesc.Text; }
            set { TxtCategorieDesc.Text = value; }
        }
        public string SearchValue 
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit 
        { 
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful 
        {
            get { return isSuccesful;  } 
            set { isSuccesful = value;  }
        }
        public string Message 
        { 
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCategorieListBildingSource(BindingSource categorieList)
        {
            DgCategorie.DataSource = categorieList;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        // fin métodos de la interfaz


        // fin de los métodos
    }
}
