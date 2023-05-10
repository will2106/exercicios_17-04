// //6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// //lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// //pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// //entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

 //string[] nomes = { "Eduardo", "Joyce", "Thaís", "Lucas", "Rafael", "Carlos" };
// // string pesquisa = "Thaís";

// // Entrada
 string[] nomes = new string[10];
 bool encontrado = false;

 for (int i = 0; i < nomes.Length; i++)
 {
    Console.WriteLine($"Digite o {i + 1}º Nome");
    nomes[i] = Console.ReadLine()!;
 }

 Console.Write($"Digite um nome para pesquisar no cadastro: ");
 string pesquisa = Console.ReadLine()!;

 // Processamento
foreach (string nome in nomes)
{
     if (nome == pesquisa)
    {
        encontrado = true;
        break;
    }
 }

// // Saída
string resultadoPesquisa = encontrado ? $"{pesquisa} Está na lista: ACHEI" : $"{pesquisa} Não está na lista: NÃO ACHEI";
Console.WriteLine(resultadoPesquisa);

Console.WriteLine(encontrado == true ? "ACHEI" : "NÃO ACHEI");

