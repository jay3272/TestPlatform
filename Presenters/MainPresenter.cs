using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPlatform.Models;
using TestPlatform.Repositories;
using TestPlatform.Views;

namespace TestPlatform.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;
        private readonly string sqlConnectionString2;

        public MainPresenter(IMainView mainView, string sqlConnectionString, string sqlConnectionString2)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.sqlConnectionString2 = sqlConnectionString2;
            this.mainView.ShowPetView += ShowPetsView;
            this.mainView.ShowAdtranView += ShowAdtranView;
            this.mainView.ShowFlowView += ShowFlowView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetView view = PetView.GetInstace((MainView)mainView);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
        }
        private void ShowAdtranView(object sender, EventArgs e)
        {
            IAdtranView view = AdtranView.GetInstace((MainView)mainView);
            IAdtranRepository repository = new AdtranRepository(sqlConnectionString2);
            new AdtranPresenter(view, repository);
        }
        private void ShowFlowView(object sender, EventArgs e)
        {
            IFlowView view = FlowView.GetInstace((MainView)mainView);
            IFlowRepository repository = new FlowRepository(sqlConnectionString2);
            new FlowPresenter(view, repository);
        }
    }
}
