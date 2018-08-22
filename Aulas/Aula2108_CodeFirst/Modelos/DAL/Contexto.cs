

using System.Data.Entity;

namespace Aula2108_CodeFirst.Modelos.DAL
{
    public class Contexto : DbContext
    {
        //Construtor
        public Contexto() : base("nomeStringConexao")
        {
                
        }

         DbSet<Categoria> Categorias { get; set; }

         DbSet<Produto> Produtos { get; set; }
    }
}
