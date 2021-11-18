using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tariff.model;
using Tariff.Presenter;

namespace Tariff
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormTariffAssistant formMain = new FormTariffAssistant();
            TariffData financeData = new TariffData();
            MainPresenter presenter = new MainPresenter(financeData, formMain);
            Application.Run(formMain);
        }
    }
}
