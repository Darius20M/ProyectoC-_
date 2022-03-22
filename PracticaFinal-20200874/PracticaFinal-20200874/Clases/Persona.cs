using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal_20200874.Clases
{
    class Persona
    {
        private string Nombre;
        private string Apellido;
        private long ID;
        DateTime fecha;
        private string sexo;      
        private string estado;
        private long telefono;
        private string direccion;

        public Persona()
        {

        }
        public Persona(string nom, string ape, long id, DateTime fecha1, string sex, string est, long tel, string dire)
        {
            Nombre = nom;
            Apellido = ape;
            ID = id;
            fecha = fecha1;          
            sexo = sex;
            estado = est;
            telefono = tel;
            direccion = dire;

        }

       /* public string getNombre()
        {
          return Nombre +" "+ Apellido;
        }*/

        public string getNombre { get { return Nombre + " " + Apellido; } }

      

        public DateTime getNacimiento( )
        {
            //DateTime mifecha = new DateTime(agn, mes, dia,0,0,0);
            
            return fecha;
        }

        public string Getsexo()
        {
            return sexo;
        }
        public string getestado()
        {
            return estado;
        }
        public long gettelefono()
        {
            return telefono;
        }

        public string getdire()
        {
            return direccion;
        }
       

        public void setvalidacion(int agn, int mes, int dia)
        {

            DateTime fechaDelusario = new DateTime(agn, mes, dia,0,0,0);

            DateTime now = DateTime.Today;
            int edad = DateTime.Today.Year - fechaDelusario.Year;
            if (DateTime.Today < fechaDelusario.AddYears(edad))
                edad--;

            if (edad >= 18)
            {
                validFecha = true;
            }
            else
            {
                validFecha = false;
            }

        }
        public string getValidacion()
        {
            return " Eres mayor de edad: " + validFecha;
        }

        public void getIndentificacion()
        {
            Console.WriteLine("\t\t\t Numero de identidad: " + String.Format("{0:[###-#######-#]}", ID));
            
        }

        public void MostrarDatos()
        {
            Console.WriteLine("\t\t\t__________________________________________________________________________");
            Console.WriteLine("\t\t\t__________________________________________________________________________");
            Console.WriteLine("\t\t\t Nombre y apellido: " + Nombre + " " + Apellido);
            Console.WriteLine("\t\t\t Numero de identidad: " + String.Format("{0:[###-#######-#]}", ID));
            Console.WriteLine("\t\t\t Fecha de nacimiento: " + fecha.ToString("d/MMM/yyyy"));
            Console.WriteLine("\t\t\t Sexo: " + sexo);
            Console.WriteLine("\t\t\t Estado civil: " + estado);
            Console.WriteLine("\t\t\t Eres mayor de edad: " + validFecha);
            Console.WriteLine("\t\t\t Numero telefonico: " + telefono.ToString("(###)-###-####"));
            Console.WriteLine("\t\t\t Direccion: " + direccion);
            Console.WriteLine("\t\t\t__________________________________________________________________________");
            Console.WriteLine("\t\t\t__________________________________________________________________________");
        }

        public void EditarD(String Editar)
        {
            direccion = Editar;
        }

        public void EditarE(String Editar)
        {
            estado = Editar;
        }

        public void EditarN(long Editar)
        {
            telefono = Editar;
        }

        //VALIDARO DE QUE NO SE ENTRE NUMERO EN NOMBRE Y APELLIDO

        public bool Letra(string sCaracteres)
        {
            foreach (char ch in sCaracteres)
            {
                if (!Char.IsLetter(ch) && ch != 32) // entra aqui si se almacena numero
                {
                    return true;
                }
            }
            return false; //aqui si son letras
        }


        bool validFecha;
    }

}
