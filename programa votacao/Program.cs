 // 1 - Ler o ano atual e o ano de nascimento de uma pessoa. 
 //Escrever uma mensagem que diga se ela poderá ou não votar este ano.
 //(não é necessário considerar o mês em que a pessoa nasceu).


 Console.WriteLine(@$"
 
 
     
 
       **********************
      |  Programa Eleitoral  |
       **********************
 
           Seja bem vindo!
          *****************
 
 ");
 
 
 

 Console.WriteLine($"Por favor Informe o ano de nascimento  para verificar se esta apto a votar: ");
 int anoNascimento = int.Parse(Console.ReadLine());

 int idade = DateTime.Now.Year - anoNascimento;

 if (idade >= 16)
 {
     Console.WriteLine($"  voce esta apto a votar!");
 }
 else
 {
     Console.WriteLine($" voce ainda nao para votar!");
 }