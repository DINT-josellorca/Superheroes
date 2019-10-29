using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Superheroes
{
    class Configuracion:INotifyPropertyChanged
    {

        private string _ajusteImagen;

        public string AjusteImagen
        {
            get { return _ajusteImagen; }
            set {
                if (this._ajusteImagen != value)
                {
                    this._ajusteImagen = value;
                    this.NotifyPropertyChanged("AjusteImagen");
                }
            }
        }


        public string Fondo { get; set; }

        public Configuracion()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
