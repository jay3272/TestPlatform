using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPlatform.Models;
using TestPlatform.Views;

namespace TestPlatform.Presenters
{
    public class FlowPresenter
    {
        //Fields
        private IFlowView view;
        private IFlowRepository repository;
        private BindingSource flowBindingSource;
        private IEnumerable<FlowModel> flowList;

        //Constructor
        public FlowPresenter(IFlowView view, IFlowRepository repository)
        {
            this.flowBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchFlow;
            this.view.AddNewEvent += AddNewFlow;
            this.view.EditEvent += LoadSelectedFlowToEdit;
            this.view.DeleteEvent += DeleteSelectedFlow;
            this.view.SaveEvent += SaveFlow;
            this.view.CancelEvent += CancelAction;
            //Set pets bindind source
            this.view.SetFlowListBindingSource(flowBindingSource);
            //Load pet list view
            LoadAllFlowList();
            //Show view
            this.view.Show();
        }

        private void LoadAllFlowList()
        {
            flowList = repository.GetAll();
            flowBindingSource.DataSource = flowList;//Set data source.
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveFlow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedFlow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedFlowToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewFlow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchFlow(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                flowList = repository.GetByValue(this.view.SearchValue);
            else flowList = repository.GetAll();
            flowBindingSource.DataSource = flowList;
        }
    }
}
