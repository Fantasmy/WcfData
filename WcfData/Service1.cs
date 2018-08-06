using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfData
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public Alumno Add(Alumno alumno)
        {
            try
            {
                alumno.Nombre = "";
                alumno.Apellidos = "";
                if (alumno == null)
                    throw new ArgumentNullException("Field is empty");
                return alumno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public Add(Alumno alumno, string surname)
        //{
        //    //Alumno alumno = new Alumno();
        //    //alumno.Nombre = "Juan";
        //    //alumno.Apellidos = "Pozo";

        //    //if (alumno == null)
        //    //    throw new ArgumentNullException("Field is empty");
        //    //alumno.Add(alumno);
        //    //return alumno;
        //}

        public List<Alumno> GetAll()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Pepe";
            alumno.Apellidos = "Soto";

            List<Alumno> alumnoList = new List<Alumno>();
            alumnoList.Add(alumno);

            return alumnoList;
        }

        public Alumno GetBySurname(string surname)
        {
            throw new NotImplementedException();
        }

        public Alumno Update(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        bool IService1.Delete(string surname)
        {
            throw new NotImplementedException();
        }
    }
}
