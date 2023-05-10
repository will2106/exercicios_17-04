/*2 -  Um posto está vendendo combustíveis com a seguinte tabela de descontos:
 Álcool:
 . até 20 litros, desconto de 3% por litro Álcool
  . acima de 20 litros, desconto de 5% por litro
   Gasolina:
 . até 20 litros, desconto de 4% por litro Gasolina
 . acima de 20 litros, desconto de 6% por litro

  Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
 da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
 sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
 Dica: utilize switch case e funções/métodos para otimizar o algorítimo.
*/

// Metodos



 static float Alcool(float quantidade, float preco) 
 {
    if (quantidade <= 20)
    {
       return (quantidade * preco) * 0.97f;
     }
     else
     {
         return (quantidade * preco) * 0.95f;
     }
 }

 static float Gasolina(float quantidade, float preco)
 {
     if (quantidade <= 20)
    {
         return (quantidade * preco) * 0.96f;
     }
     else
     {
         return (quantidade * preco) * 0.94f;
     }
 }



 Console.Clear();
 Console.WriteLine($"Bem vindo ao Posto de Combustível!");

 float precoLitroAlcool = 4.90f; // variavel do tipo float com valor atribuido
 float precoLitroGasolina = 5.30f; // variavel do tipo float com valor atribuido

 float quantidadeLitroAlcool;// variavel com valor em aberto
 float quantidadeLitroGasolina;// variavel com valor em aberto

 float valorAbastecimento;

 char opcao;

 do
 {
     Console.WriteLine(@$"
   -------------------------
   |Informe o combustível: |
   |                       |
   | (a) - álcool          |
   | (g) - gasolina        |
   |                       |
   -------------------------
 ");

 Console.WriteLine($"digite o combustivel conforme a opcao:");
 
       opcao = char.Parse(Console.ReadLine());

        switch (opcao)
     {
         case 'a':
            Console.WriteLine($"Informe a quantidade de álcool em litros: ");
            quantidadeLitroAlcool = float.Parse(Console.ReadLine());

             valorAbastecimento = Alcool(quantidadeLitroAlcool, precoLitroAlcool);

            Console.WriteLine($"O valor do abastecimento é : {valorAbastecimento} ");

            break;
         case 'g':
            Console.WriteLine($"Informe a quantidade de gasolina em litros: ");
            quantidadeLitroGasolina = float.Parse(Console.ReadLine());

            valorAbastecimento = Alcool(quantidadeLitroGasolina, precoLitroGasolina);

             Console.WriteLine($"O valor do abastecimento é : {valorAbastecimento} ");
             break;
         default:
            Console.WriteLine($"Opção inválida, informe uma opção válida!");
            break;
     }
 } while (opcao != 'a' && opcao != 'g');

