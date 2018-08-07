using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfData.Model;

namespace WcfData
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        WcfCRUDEntities db;

        public Service1()
        {
            db = new WcfCRUDEntities();
        }


        public bool Delete(Guid id)
        {
            try
            {
                Students students = db.Students.Where(x => x.id == id).FirstOrDefault();

                db.Students.Remove(students);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Students> GetAll()
        {
            List<Students> studentsList = db.Students.ToList();
            return studentsList;
        }

        public Students GetById(Guid id)
        {
            Students students = db.Students.Where(x => x.id == id).FirstOrDefault();

            return students;
        }

        public Students Post(Students students)
        {
            db.Students.Add(students);
            db.SaveChanges();

            Students insertedStudent = db.Students.Where(x => x.id == students.id).FirstOrDefault();

            return insertedStudent;
        }

        public Students Put(Guid id, Students students)
        {
            try
            {
                Students foundStudent = db.Students.Where(x => x.id == id).FirstOrDefault();

                foundStudent.id = students.id;
                foundStudent.name = students.name;
                foundStudent.surname = students.surname;
                foundStudent.email = students.email;

                db.SaveChanges();

                return GetById(students.id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
