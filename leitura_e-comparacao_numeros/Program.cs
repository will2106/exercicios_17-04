// // 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos 15 números, 
//o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// // declarado.

 int[] numeros = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

 Array.Sort(numeros);
 foreach (var n in numeros)
 {
     Console.Write($"{n} ");
 }