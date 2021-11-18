using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tariff.model;

namespace Tariff.Presenter
{
    class MainPresenter
    {
        private TariffData _model;
        private FormTariffAssistant _view;

        public MainPresenter(TariffData model, FormTariffAssistant view)
        {
            _model = model;
            _view = view;

            _view.OpeningAdminForm += OnOpeningAdminForm;
        }

        private void OnOpeningAdminForm()
        {
            AdminForm view = new AdminForm();
            MainPresenter presenter = new MainPresenter(_model, _view);
            view.ShowDialog();
        }
    }
}
