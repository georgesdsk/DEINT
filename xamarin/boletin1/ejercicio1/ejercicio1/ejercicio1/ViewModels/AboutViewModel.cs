using Entidades2;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ejercicio1.ViewModels
{

    public class AboutViewModel : INotifyPropertyChanged
    {

        private Command comandoBoton;

        public Command ComandoBoton { get => comandoBoton; set => comandoBoton = value; }

        clsPersona persona;
        public clsPersona Persona { get => persona; set { 
                persona = value;
                OnPropertyChanged("persona");
                ChangeCanExecute();
            } }
        // se podria arreglar con un boolen
        


        public AboutViewModel()
        {
            comandoBoton = new Command(Execute(), CanExecute());
             persona = new clsPersona();

        }
        /// <summary>
        /// si nop hay ningun cambio, no esta activo
        /// </summary>
        /// <returns></returns>
        public bool CanExecute()
        {
            
            return true;
        }

        async public void Execute(object parameter)
        {
            
        }


        public void ChangeCanExecute()
        {
            
        }







        public event PropertyChangedEventHandler PropertyChanged;

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}