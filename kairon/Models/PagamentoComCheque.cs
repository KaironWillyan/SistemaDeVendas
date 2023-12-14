using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kairon.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Número do Cheque")]
        public int Banco { get; set; }
        [Display(Name = "Nome do Banco")]
        public string NomeDoBanco { get; set; } = string.Empty;
    }
}