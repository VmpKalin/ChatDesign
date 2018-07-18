using GalaSoft.MvvmLight;
using MyFirstControlApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstControlApp.ViewModels.Users
{
    public class MainWindowViewModel : ViewModelBase
    {
        ObservableCollection<Person> _people;

        public ObservableCollection<Person> People
        {
            get
            {
                if(_people==null)
                    _people = PersonRepository.AllClients;
                return _people;
            }
        }
    }
}
