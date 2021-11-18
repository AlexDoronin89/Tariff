using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tariff.model;

namespace Tariff
{
    public partial class FormTariffAssistant : Form
    {
        public event Action OpeningAdminForm;

        public FormTariffAssistant()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_tariffData.AddTariff("Мой разговор", 200, 5, 50, 250);
            //_tariffData.AddTariff("Мой онлайн", 500, 15, 100, 350);
            //_tariffData.AddTariff("Мой онлайн+", 625, 25, 0, 550);
            //_tariffData.AddTariff("Везде онлайн", 400, 40, 50, 500);

            //foreach (var item in _tariffs)
            //{
            //    listBoxTariffs.Items.Add(item.Name);
            //}
        }

        private void listBoxTariffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (var item in tariffs)
            //{
            //    if (item.Name == listBoxTariffs.SelectedItem.ToString())
            //    {
            //        textBoxGygabytes.Text = item.Gygabytes.ToString();
            //        textBoxMinutes.Text = item.Gygabytes.ToString();
            //        textBoxMessages.Text = item.Messages.ToString();
            //        textBoxPrice.Text = item.Price.ToString();
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpeningAdminForm?.Invoke();
        }
    }
}
