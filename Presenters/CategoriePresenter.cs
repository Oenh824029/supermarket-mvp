using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriePresenter
    {
        private ICategoriesView view;
        private ICategorieRepository repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<CategoriesModel> categorieList;

        // constructor de la clase
        public CategoriePresenter(ICategoriesView view, ICategorieRepository repository)
        {
            this.categorieBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;
            // asociación de los eventos
            this.view.SearchEvent += SearchCategorie;
            this.view.AddNewEvent += AddNewCategorie;
            this.view.EditEvent += LoadSelecteCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategorie;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(categorieBindingSource);

            loadAllCategorieList();

            this.view.Show();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategorie(object? sender, EventArgs e)
        {
            var categorie = new CategoriesModel();
            categorie.Id = Convert.ToInt32(view.CategoriesId);
            categorie.Name = view.CategoriesName;
            categorie.Description = view.CategoriesDescription;
            try
            {   
                new Common.ModelDataValidation().Validate(categorie);
                if (view.IsEdit)
                {
                    repository.Edit(categorie);
                    view.Message = "Categorie edited sucessfuly";
                }
                else
                {
                    repository.Add(categorie);
                    view.Message = "Categorie added sucessfuly";
                }
                view.IsSuccesful = true;
                loadAllCategorieList();
                CleanViewFields();
            }
            catch(Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";

        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            try
            {
                var categorie = (CategoriesModel)categorieBindingSource.Current;

                repository.Delete(categorie.Id);
                view.IsSuccesful = true;
                view.Message = "Categorie delected successgfully";
                loadAllCategorieList();
            }
            catch(Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete categorie";
            }
        }

        private void LoadSelecteCategorieToEdit(object? sender, EventArgs e)
        {
            var categorie = (CategoriesModel)categorieBindingSource.Current;

            view.CategoriesId = categorie.Id.ToString();
            view.CategoriesName = categorie.Name;
            view.CategoriesDescription = categorie.Description;

            view.IsEdit = true;
        }

        private void AddNewCategorie(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void loadAllCategorieList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void SearchCategorie(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }

            categorieBindingSource.DataSource = categorieList;
        }


        // fin de los métodos
    }
}
