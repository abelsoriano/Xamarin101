using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Counter.ViewModels
{
  public  class MainViewModel : INotifyPropertyChanged
    {
        private static MainViewModel _instance;
        private int _counter;

        public static MainViewModel GetInstance()

        {
            if (_instance == null)

            {
                _instance = new MainViewModel();

            }
            return _instance;

        }

        private bool _isRunning;
        private bool _isEnabled;
        private string _texto;

        public MainViewModel()
        {
            _instance = this;
            _counter = 1;
            IsEnabled = true;
            IsRunning = true;
            Texto = _counter.ToString();
        }

       
        public bool IsEnabled
        {
            set {
                if (_isEnabled == value) return;
                _isEnabled = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsEnabled"));
            }
            get => _isEnabled;
        }
        public bool IsRunning
        {
            set {
                if (_isRunning == value) return;
                _isRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
            }
            get => _isRunning;
        }

        public string Texto
        {
            set {
                if (_texto == value) return;
                _texto = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Texto"));
            }
            get => _texto;
        }


        public ICommand IncrementarCommand => new Command(Incrementar);

        private  void Incrementar()
        {
           

            IsRunning = true;
            IsEnabled = false;

            System.Threading.Thread.Sleep(3000);
            _counter++;
            Texto = _counter.ToString();
            IsRunning = false;
            IsEnabled = true;

            

             
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
