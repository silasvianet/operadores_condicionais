using System;
using System.Collections.Generic;

namespace operadores_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oLSt = new List<int>();

            int? x = oLSt?[0];

            int? nome = 500;

            nome = nome ?? 100;

            Console.WriteLine(nome);
            Console.WriteLine(GetProduto().Descricao);
        }

        public static Produto GetProduto()
        {
            var x = new Produto
            {
                Codigo = 1,
                Descricao = "cabo",
                Valor = 10.3
            };

            return x;
        }

    }
}
