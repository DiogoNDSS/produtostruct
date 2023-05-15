using System;
using Struct;

namespace PRODUTO
{
  class Program
  {

    static void Main(string[] args)
    {
      //Struct
      produtinho produto1 = new();
      produto1.NomeProduto = "Omo Blue";
      produto1.VerificarQuantidadeEstoque = "18";
      produto1.Marca = "omo limpezas gerais legais";
      produto1.preco = (250);
      produto1.descontao(10);

      Console.WriteLine(produto1.imprimir());
    }

  }
}