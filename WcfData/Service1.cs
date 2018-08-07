using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfData
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        static List<Alumno> alumnoList = new List<Alumno>();

        static Service1()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Pepe";
            alumno.Apellidos = "Soto";

            alumnoList.Add(alumno);
        }

        public void Add(Alumno alumno)
        {
            alumnoList.Add(alumno);
        }

        public List<Alumno> GetAll()
        {
            return alumnoList;
        }
    }
}
