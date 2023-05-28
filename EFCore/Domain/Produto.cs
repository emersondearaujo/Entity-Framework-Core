using EFCore.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public decimal Telefone { get; set; }
        public decimal Cep { get; set; }
        public String Estado { get; set; }
        public String Cidade { get; set; }
        public int CodigoBarras { get; set; }
        public String Descricao { get; set; }
        public bool Ativo { get; set; }
        public TipoProduto TipoProduto { get; set; }

    }
}
