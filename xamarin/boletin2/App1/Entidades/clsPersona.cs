using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Entidades2
{
    public class clsPersona 
    {
        #region atributos privados
        private int id;
        private string nombre;
        private string apellidos;
  
        //foto
        //Para añadir foto a bdd poner url d una foto que esté subida a un servidor
        // Tanmbien se puede añadir mediante un array de bytes. Consultar
        //Datetime
       
        #endregion
        #region propiedades publicas
        


        
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

    
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }
        #endregion


        #region constructores
        //Constructor por defecto

        public clsPersona(string nombre, string apellidos) {
         
            this.Nombre = nombre;
            this.Apellidos = apellidos;
      
        }

       
        public clsPersona() {
            this.Nombre = "George";
            this.Apellidos = "Sadouski";
            
        }
        #endregion


    }
}

