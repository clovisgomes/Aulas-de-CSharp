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
            //dsa
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
    }
}
