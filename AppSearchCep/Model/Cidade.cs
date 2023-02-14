using System;
using System.Collections.Generic;
using System.Text;

namespace AppSearchCep.Model
{
    public class Cidade
    {
        public string id_cidade { get; set; }
        public string descricao { get; set; }
        public string uf { get; set; }
        public int codigo_ibge { get; set; }
        public int ddd { get; set; }
    }
}
