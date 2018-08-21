using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDBTeste.Controller
{
    class PersonController
    {
        void Inserir(Person p)
        {
            MeuDBContainer contexto = new MeuDBContainer();
            contexto.Person.Add(p);
            contexto.SaveChanges();
        }
        List<Person> ListarTodosPerson()
        {
            MeuDBContainer contexto = new MeuDBContainer();
            return contexto.Person.ToList();
            
        }
        Person BuscarPorID(int id)
        {
            MeuDBContainer contexto = new MeuDBContainer();
            return contexto.Person.Find(id);
        }

        void Excluir(int id)
        {
            Person pExcluir = BuscarPorID(id);

            if(pExcluir != null)
            {
                MeuDBContainer contexto = new MeuDBContainer();
                contexto.Person.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(int id, Person novosDadosPerson)
        {
            Person personAntigo = BuscarPorID(id);

            if(personAntigo != null)
            {
                personAntigo.FirstName = novosDadosPerson.FirstName;
                personAntigo.LastName = novosDadosPerson.LasttName;
                personAntigo.Title = novosDadosPerson.Title;

                MeuDBContainer contexto = new MeuDBContainer();

                contexto.Entry(personAntigo).State = System.Data.Entity.EntityState.Modified;

                contexto.SaveChanges();
            }
        }

        List<Person> PersquisarPorFirstName(string firstName)
        {
            //LINQ

        }
    }
}
