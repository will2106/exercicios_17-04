 // 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// // menor valor lido.

 int[] valores = new int[10];

 for (var i = 0; i < valores.Length; i++)
 {
     Console.WriteLine($"Informe o valor: ");
     valores[i] = int.Parse(Console.ReadLine());
 }

 int menor = 0;
 int maior = 0;

 for (var i = 0; i < valores.Length; i++)
 {
     if (i == 0)
     {
         menor = valores[0];
        maior = valores[0];
    }
     if (valores[i] < menor)
    {
        menor = valores[i];
     }
     if (valores[i] > maior)
     {
        maior = valores[i];
    }
 }

 Console.WriteLine($"O menor número é {menor}");
 Console.WriteLine($"O maior número é {maior}");