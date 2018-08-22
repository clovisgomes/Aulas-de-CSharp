using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Categoria
    {
        //Chave Primaria Id / ID/ id ou nomeClasseID
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        //Relacionamento Categoria <--> Produto
        //1Categoria para muitos produtos
        public ICollection<Produto> _Produtos { get; set; }


    }
}
