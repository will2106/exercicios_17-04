// //5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// //Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
// Console.WriteLine("Tabuada de 1 até 10 !");//exibição da mensagem

for (var e = 0; e <= 10; e++)//laço de repetição do tipo for para o número à esquerda   
 {
    for (var d = 0; d <= 10; d++)//laço de repetição para o número da direita
     {
       Console.WriteLine(+e + " x " + d + " = " + e * d);//exibição do número da esquerda x número da direita                    
     }
     Console.WriteLine();//pular linha
 }

 Console.WriteLine("----- Fim da tabuada -----");//exibição da mensagem