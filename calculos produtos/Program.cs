

// // 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// // - Se quantidade &lt;= 5 o desconto será de 2%
// // - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// // - Se quantidade &gt; 10 o desconto será de 5%
// // Dica: utilize if / else if / else


 Console.Write($"Informe a descrição do produto: ");
 string descricaoProduto = Console.ReadLine()!;

 Console.Write($"Informe a quantidade adquirida: ");
 int qdtProduto = int.Parse(Console.ReadLine()!);

Console.Write($"Informe o preço do produto: ");
 float precoProduto = float.Parse(Console.ReadLine()!);

 float novoPreco = CalculaPrecoProduto(qdtProduto, precoProduto);
 Console.WriteLine($"Produto: {descricaoProduto}");
 Console.WriteLine($"Quantidade: {qdtProduto}");
 Console.WriteLine($"Preco Cheio: {precoProduto}");
 Console.WriteLine($"Preco com Desconto: {novoPreco}");

static float CalculaPrecoProduto(int qtd, float preco)
{

     if (qtd <= 5)
    {
        return preco -= ((preco / 100) * 2);
    }
     else if (qtd < 10)
     {
        return preco -= ((preco / 100) * 3);
     }

  
    return preco -= ((preco / 100) * 5);
 }

