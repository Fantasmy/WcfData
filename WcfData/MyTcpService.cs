using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfData
{
    public class MyTcpService : IMyTcpService
    {
        public List<Alumno> GetAll()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Pepe";
            alumno.Apellidos = "Soto";

            List<Alumno> alumnoList = new List<Alumno>();
            alumnoList.Add(alumno);

            return alumnoList;
        }
    }
}
