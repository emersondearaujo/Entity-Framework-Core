using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFCore.ValueObjects;

namespace EFCore.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public String CodigoBarras { get; set; }
        public String Descricao { get; set; }
        public decimal valor { get; set; }
        public TipoProduto TipoProdduto { get; set; }

        public bool Ativo { get; set; }
        public String Nome { get; set; }
        public decimal Telefone { get; set; }
        public decimal Cep { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
    }
}
