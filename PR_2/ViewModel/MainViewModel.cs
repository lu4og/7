using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Json;
using PR_2.ViewModel.Helpers;
using PR_2.Model;
using System.DirectoryServices.ActiveDirectory;
using System.Windows;
using Newtonsoft.Json.Linq;

namespace PR_2.ViewModel
{
    internal class MainViewModel : BindingHelpes
    {
        #region Свойства
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }
        public DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set { date = value; OnPropertyChanged(); }
        }
        public ObservableCollection<string> listBox;
        public ObservableCollection<string> ListBox
        {
            get
            {
                return listBox;
            }
            set
            {
                listBox = value;
                OnPropertyChanged();
            }
        }
        public string select;
        public string Select
        {
            get
            {
                return select;
            }
            set
            {
                select = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public ObservableCollection<zametka> Zam;
        public ObservableCollection<zametka> zam
        {
            get
            {
                return Zam;
            }
            set
            {
                if (value != null)
                {
                    Zam = value;
                }
            }
        }
        #region Команды
        public BindableCommands Delete { get; set; }
        public BindableCommands Update { get; set; }
        public BindableCommands Add { get; set; }
        public BindableCommands SelectDate { get; set; }
        public BindableCommands SelectItem { get; set; }
        #endregion
        public MainViewModel()
        {
            ListBox = new ObservableCollection<string>();
            Date = DateTime.Today;
            zam = J.Des<ObservableCollection<zametka>>("zametka.json") ?? new ObservableCollection<zametka>();
            selectDate();
            Delete = new BindableCommands(_ => delete());
            Update = new BindableCommands(_ => update());
            Add = new BindableCommands(_ => add());
            SelectDate = new BindableCommands(_ => selectDate());
            SelectItem = new BindableCommands(_ => selctItem());
        }

        private void selctItem()
        {
            foreach (var item in zam)
            {
                if (item.Name == select)
                {
                    Name = select;
                    Description = item.Description;
                    break;
                }
            }
        }

        private void selectDate()
        {
            clear();
            ListBox.Clear();
            foreach (var item in zam)
            {
                if (date.Date == item.date.Date)
                    ListBox.Add(item.Name);
            }
        }
        private void чзх()
        {
            J.Ser<ObservableCollection<zametka>>("zametka.json", Zam);
            clear();
            selectDate();
        }

        private void add()
        {
            if (!ContainZam(Name))
            {
                ListBox = new ObservableCollection<string>();
                zam.Add(new zametka(name, description, date.Date));
                чзх();
            }
            else MessageBox.Show("Заметка с таким названием уже есть");
        }

        private void update()
        {
            if (select == null)
            {
                MessageBox.Show("Заметка не выбрана");
                return;
            }
            if (!ContainZam(Name))
            {
                get_zam(select).Name = Name;
                get_zam(select).Description = Description;
                чзх();
            }
            else MessageBox.Show("Заметка с таким названием уже есть");
        }

        private void delete()
        {
            if (select == null)
            {
                MessageBox.Show("Заметка не выбрана");
                return;
            }
            zam.Remove(get_zam(select));
            чзх();
        }
        private void clear()
        {
            Name = "";
            Description = "";
        }
        private zametka get_zam(string name)
        {
            foreach (var item in zam)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return new zametka("", "", new DateTime());
        }
        private bool ContainZam(string name)
        {
            foreach (var item in zam)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
