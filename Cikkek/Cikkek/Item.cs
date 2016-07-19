using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cikkek
{
    

    public class Item : INotifyPropertyChanged
    {
        string _cikknev,_cikkszam,_vonalkod,_mennyisegiEgyseg;

        public String Cikknev {
            get
            {
                return _cikknev;
            }
            set
            {
                _cikknev = value;
                OnPropertyChanged();
            }
        }
        public String Cikkszam
        {
            get
            {
                return _cikkszam;
            }
            set
            {
                _cikkszam = value;
                OnPropertyChanged();
            }
        }
        public String Vonalkod
        {
            get
            {
                return _vonalkod;
            }
            set
            {
                _vonalkod = value;
                OnPropertyChanged();
            }
        }
        public String MennyisegiEgyseg
        {
            get
            {
                return _mennyisegiEgyseg;
            }
            set
            {
                _mennyisegiEgyseg = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]String propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
