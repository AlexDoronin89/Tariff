using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tariff.model
{
    class TariffData
    {
        private List<Tariff> _tariffs;

        public event Action UpdatedTariff;
        public event Action RemovedTariff;

        public TariffData()
        {
            _tariffs = new List<Tariff>();
        }

        public void AddTariff(string name, int minutes, int gygabytes, int messages, int price)
        {
            _tariffs.Add(new Tariff(name, minutes, gygabytes, messages, price));
        }

        public void RemoveTariff(int index)
        {
            _tariffs.RemoveAt(index);
        }

        public void UpdateTariff(string name, int minutes, int gygabytes, int messages, int price, int index)
        {
            _tariffs[index] = new Tariff(name, minutes, gygabytes, messages, price);
        }
        
        public IReadOnlyList<IReadOnlyTariff> GetTariffs() => _tariffs;
    }
}
