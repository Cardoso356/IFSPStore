using IFSPStore.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto() 
        {
        }
        
        public Produto(int id, string nome, float preco, int quantidade, DateTime datacompra, int unidadevenda)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.DataCompra = datacompra;
            this.UnidadeVenda = unidadevenda;
        }

        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra {  get; set; }
        public int UnidadeVenda { get; set; }

    }
}
