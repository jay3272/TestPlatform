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
    public class AdtranPresenter
    {
        //Fields
        private IAdtranView view;
        private IAdtranRepository repository;
        private BindingSource adtransBindingSource;
        private IEnumerable<AdtranModel> adtranList;

        //Constructor
        public AdtranPresenter(IAdtranView view, IAdtranRepository repository)
        {
            this.adtransBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            //Set pets bindind source
            this.view.SetAdtranListBindingSource(adtransBindingSource);
            //Load pet list view
            LoadAllAdtranList();
            //Show view
            this.view.Show();
        }

        private void LoadAllAdtranList()
        {
            adtranList = repository.GetAll();
            adtransBindingSource.DataSource = adtranList;//Set data source.
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                adtranList = repository.GetByValue(this.view.SearchValue);
            else adtranList = repository.GetAll();
            adtransBindingSource.DataSource = adtranList;
        }
    }
}
