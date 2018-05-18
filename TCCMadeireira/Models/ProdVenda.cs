﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Models
{
    class ProdVenda
    {
        private Produto produto;
        private decimal quantidade;

        public ProdVenda(Produto produto, decimal quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
        }

        public decimal Quantidade { get => quantidade; set => quantidade = value; }
        internal Produto Produto { get => produto; set => produto = value; }
    }
}
