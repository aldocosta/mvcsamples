using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loja.UI.Models
{
    public class ProdutoViewModel
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(150)]
        [DisplayName("Nome do Produto")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(500)]
        [DisplayName("Descricao do Produto")]        
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Preco { get; set; }
        public string Categoria { get; set; }

        public string GetProductDescription()
        {
            return Nome + " - " + Descricao + " : " + Preco.ToString("c");
        }
    }
}