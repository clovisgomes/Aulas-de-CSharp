using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWControllers.Controllers
{
    class PersonController
    {
        void Inserir (Person p)
        {
            ClovisApplicationTestingEntities contexto = new ClovisApplicationTestingEntities();
            contexto.Person.Add(p);
            contexto.SaveChanges();
        }
        List<Person> ListarTodosPerson()
        {
            ClovisApplicationTestingEntities contexto = new ClovisApplicationTestingEntities();
            return contexto.Person.ToList();
        }

        Person BuscarPorID(int id)
        {
            ClovisApplicationTestingEntities contexto = new ClovisApplicationTestingEntities();
            return contexto.Person.Find(id);
        }

        void Excluir(int id)
        {
            Person pExcluir = BuscarPorID(id);

            if (pExcluir != null)
            {
                ClovisApplicationTestingEntities contexto = new ClovisApplicationTestingEntities();
                contexto.Person.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(int id, Person novosDadosPerson)
        {
            Person personAntigo = BuscarPorID(id);

            if (personAntigo != null)
            {
                personAntigo.FirstName = novosDadosPerson.FirstName;
                personAntigo.LastName = novosDadosPerson.LasttName;
                personAntigo.Title = novosDadosPerson.Title;

                ClovisApplicationTestingEntities contexto = new ClovisApplicationTestingEntities();

                contexto.Entry(personAntigo).State = System.Data.Entity.EntityState.Modified;

                contexto.SaveChanges();
            }
        }

        List<Person> PersquisarPorFirstName(string firstName)
        {
            ClovisApplicationTestingEntities contexto = new ClovisApplicationTestingEntities();
            //LINQ
            //var lista = from p in contexto.Person
            //          select p; //SELECT * FROM Person     
            //comentario
            ///comentario2

            var lista = from p in contexto.Person
                        where p.FirstName == firstName
                        select p;

            return lista.ToList();
        }

    }
}
