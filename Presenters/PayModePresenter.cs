using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
       internal class PayModePresenter
    {

        // variables de clase
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        // constructor de la clase
        public PayModePresenter(IPayModeView view, IPayModeRepository repository) {

            this.payModeBindingSource = new BindingSource();
            
            this.view = view;
            this.repository = repository;


            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent   += LoadSelectPayModeToEdit;
            this.view.SaveEvent   += SavePayMode;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();
            this.view.Show();
        }

        // lógica en botones

        

        private void loadAllPayModeList() {

            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }
   
        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited successfuly";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode added succesfuly";
                }
                view.IsSuccesful = true;
                loadAllPayModeList();
                CleanViewFields();
            }
            catch (Exception ex) {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            //MessageBox.Show("CLieck en botón editar");
            var payMode = (PayModeModel) payModeBindingSource.Current;
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            // MessageBox.Show("CLieck en botón nuevo");
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }

            payModeBindingSource.DataSource = payModeList;
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel) payModeBindingSource.Current;

                repository.Delete(payMode.Id);
                view.IsSuccesful = true;
                view.Message = "Pay Mode deleted succesfully";
                loadAllPayModeList();
            }
            catch (Exception ex) { 
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }

        }

        // fin de los métodos
    }
}
