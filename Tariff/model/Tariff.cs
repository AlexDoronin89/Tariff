using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tariff
{
    class Tariff : IReadOnlyTariff
    {
        public double Price { get; private set; }
        public string Name { get; private set; }
        public int Minutes { get; private set; }
        public int Gygabytes { get; private set; }
        public int Messages { get; private set; }

        public Tariff(string name, int minutes, int gygabytes, int messages, int price)
        {
            Minutes = minutes;
            Gygabytes = gygabytes;
            Messages = messages;
            Price = price;
            Name = name;
        }
    }

    public interface IReadOnlyTariff
    {
        double Price { get; }
        string Name { get; }
        int Minutes { get; }
        int Gygabytes { get; }
        int Messages { get; }
    }
}
