using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using practica.Models;

namespace practica
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Entities db = Helper.GetContext();
        public Window1()
        {
            InitializeComponent();
            var zapros = db.Dogovor;
            dtg_Dogovor.ItemsSource = zapros.ToList();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if ((tb_Sotrydnik.Text.Equals("")) || (tb_Klient.Text.Equals("")) || (tb_Tyra.Text.Equals("")) || (tb_DataZaklycheniya.Text.Equals("")) || (tb_DataDeistvya.Text.Equals("")) || (tb_SpisokYslyg.Text.Equals("")))
            {
                MessageBox.Show("Введите данные ");
            }
            else
            {
                Dogovor newDogovor = new Dogovor();
                DateTime vremya = DateTime.Parse(tb_DataZaklycheniya.Text.ToString());
                newDogovor.DataDeistvtya = vremya;
                DateTime data = DateTime.Parse(tb_DataDeistvya.Text.ToString());
                newDogovor.DataZaklycheniya = data;
                newDogovor.ID_Klient = int.Parse(tb_Klient.Text);
                newDogovor.ID_Tyra = int.Parse(tb_Tyra.Text);
                newDogovor.ID_Sotrydnik = int.Parse(tb_Sotrydnik.Text);
                newDogovor.SpisokYslyg = String.Format(tb_SpisokYslyg.Text);
                Create(newDogovor);
            }
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            Dogovor item = dtg_Dogovor.SelectedItem as Dogovor;

            if (item != null)
            {
                DbSet<Dogovor> items = db.Dogovor;
                items.Remove(item);
                db.SaveChanges();
                refresh();
            }
        }
        public void refresh()
        {
            InitializeComponent();
            var zapros = db.Dogovor;
            dtg_Dogovor.ItemsSource = zapros.ToList();
        }

        public void Create(Dogovor dogovor)
        {
            db.Dogovor.Add(dogovor);
            db.SaveChanges();
            refresh();
        }

            private void btn_red_Click(object sender, RoutedEventArgs e)
        {
            Dogovor item = dtg_Dogovor.SelectedItem as Dogovor;

            if (item != null)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                refresh();
            }
        }
    }
}
