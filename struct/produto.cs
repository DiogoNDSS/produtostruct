namespace Struct;

public struct produtinho
{
  public string NomeProduto;
  public string VerificarQuantidadeEstoque;
  public string Marca;
  public float preco;


  public produtinho(string nome, string estoque, string marca)
  {
    this.NomeProduto = nome;
    this.VerificarQuantidadeEstoque = estoque;
    this.Marca = marca;
    this.preco = preco;
  }

  public void descontao(float desconto)
  {
    float x = (this.preco * desconto) / 100;
    this.preco = this.preco - x;
  }

  public string imprimir()
  {
    return "\nProduto: " + this.NomeProduto +
    "\nEstoque: " + this.VerificarQuantidadeEstoque +
    "\nMarca: " + this.Marca +
    "\nValor: " + this.preco;
  }
}