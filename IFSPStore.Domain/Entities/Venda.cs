using IFSPStore.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda()
        {
            Items = new List<VendaItem>();
        }


        public Venda(int id, DateTime data, float valortotal, Usuario usuario, Cliente cliente, List<VendaItem> items)
        {
            this.Id = id;
            this.Data = data;
            this.ValorTotal = valortotal;
            this.Usuario = usuario;
            this.Cliente = cliente;
            this.Items = items;
        }


        public DateTime? Data { get; set; }
        public float? ValorTotal { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<VendaItem> Items { get; set; }
    }

    public class VendaItem : BaseEntity<int>
    {
        public VendaItem()
        {

        }

        public VendaItem(int id, Produto? produto, int quantidade, float valorunitario, float valortotal, Venda venda)
        {
            this.Id = id;
            this.Quantidade = quantidade;
            this.Produto = produto;
            this.ValorUnitario = valorunitario;
            this.ValorTotal = valortotal;
            this.Venda = venda;
        }


        public virtual Produto? Produto { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
        public virtual Venda? Venda { get; set; }
    }
}
