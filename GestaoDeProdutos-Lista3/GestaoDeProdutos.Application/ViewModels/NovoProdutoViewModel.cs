using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Application.ViewModels
{
    public class NovoProdutoViewModel
    {
        #region - Propriedades

        [JsonIgnore]
        public int Codigo { get; set; }

        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        [JsonIgnore]
        public DateTime DataCadastro { get; set; }

        #endregion
    }
}
