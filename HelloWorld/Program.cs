using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //ENUM --> é uma forma de criar seu próprio tipo
        enum Opcao {Criar = 1, Deletar = 2 , Editar = 3,Listar = 4 , Atualizar = 5, Voltar = 6}
        enum Cor { Azul , verde , Amarelo , Vermelho  }
        static void Main(string[] args)
        {
            string meuNome = "João";

                
            
            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse Sistema é TOP!!");
            Console.WriteLine("o´lá olá olá");
            Console.WriteLine("Bem Vindo");

                     

        }
        static void GerarPreco(int preco, string nome)
        {
            Console.WriteLine("O preço é: " + preco);
            Console.WriteLine("o nome é " + nome);
        }
        static void GerarPreco2(int preco)
        {
            //a funcao abs impede que o número seja negativo
            //assim o arredondando

            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor Final: " + valorFinal);
        }
        static int somar(int a , int b , int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal ;
        }
    }
}

//constante (const)nunca pode mudar o valor
// variável (var)pode mudar a qualquer momento o valor, mas não o tipo
/*
 * --------------------------------------------------
 int a = 12;
     string animal = "macaco";
 float velocidade = 12.2f;
     bool vouf = true;
evitar usar int usar sempre float
--------------------------------------------------

float num = 2 + 2;
string nome = "";
Console.WriteLine("Escreva o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Seu Nome é : ");
Console.WriteLine(nome);
Console.WriteLine(num);
---------------------------------------------------


if (10 < 2)
{
    Console.WriteLine("É verdade");
}
else if(20==20)
{
    Console.WriteLine("Executou Else if");
}


else
{
    Console.WriteLine("é falso");
}
-----------------------------------------
|| -> basta que um seja verdadeiro
&& -> os dois devem ser verdadeiros

----------------------------------------------------------
 //Parse converterá o texto para número, pois
            //naturalmente o console lê tudo como texto
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente");
            }else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto");
            }
            else
            {
                Console.WriteLine("Você é um idoso");
            }
-------------------------------------------------------------------
class Program
    {
        static void Main(string[] args)
        {

            ExibirMsg();
            
            GerarPreco(60,"eai");
            GerarPreco(30,"macaco");
            GerarPreco(20,"banana");
            GerarPreco(-20,"notebook");
            
            GerarPreco2(6);
            GerarPreco2(-2);
            GerarPreco2(-333333);

            Console.ReadLine();

        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse Sistema é TOP!!");
            Console.WriteLine("o´lá olá olá");
            Console.WriteLine("Bem Vindo");

                     

        }
        static void GerarPreco(int preco, string nome)
        {
            Console.WriteLine("O preço é: " + preco);
            Console.WriteLine("o nome é " + nome);
        }
        static void GerarPreco2(int preco)
        {
            //a funcao abs impede que o número seja negativo
            //assim o arredondando

            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor Final: " + valorFinal);
        }
    }
}

--------------------------------------------------------------



static void Main(string[] args)
        {
          int soma1 = somar(1, 2, 3);
            int soma2 = somar(10, 20, 30);
            int soma3 = somar(100, 200, 300);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

            Console.ReadLine();

         }
 static int somar(int a , int b , int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal ;
        }

//return --> ao lado de static devvemos colocar o tipo a ser retornado
após isso, ao fim da função escrever "return <nome da variavel>"
no "Main" chamamos a função colocando seus parâmetros e a inserimos em 
uma nova variável ex: int soma1 = somar(1, 2, 3); 


----------------------------------------------------------------

static void Main(string[] args)
        {
            string produto1 = "jogo a";
            string produto2 = "jogo b";
            string produto3 = "jogo c";
            string produto4 = "jogo d";
            string produto5  = "jogo e";
            

            string[] produtos = new string[5]
            {
                "jogo a",
                "jogo b",
                "jogo c",
                "jogo d",
                "jogo e",
            };

            int[] valores = { 40, 50, 60, 70, 20 }; // maneira mais simples de criar array

            produtos[1] = "jogo novo"; //assim atualizamos o valor do array
            Console.WriteLine(produtos[4]); //assim acessamos


            Console.ReadLine();

        }

----------------------------------------------------------------------------------


static void Main(string[] args)
        {
            string cor = "Azul";
            
            //switch só faz operações de igualdade "==" diferente do if

            switch(cor){
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;

                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul!");
                    break;

                //default é para caso não seja nenhum dos casos anteriores
                default:
                    Console.WriteLine("não sei sua cor favorita");
                    break;
            } 


            Console.ReadLine();

        }

---------------------------------------------------------------------------------



class Program
    {
        //ENUM --> é uma forma de criar seu próprio tipo
        enum Cor { Azul , verde , Amarelo , Vermelho  }
        static void Main(string[] args)
        {
            Cor corfavorita = Cor.Vermelho;
            Cor corfavoritaDaCarla = Cor.Azul;

            Console.WriteLine(corfavorita);
            Console.WriteLine(corfavoritaDaCarla);
            Console.WriteLine((int)corfavorita);
            Console.WriteLine((Cor)2);

            Console.ReadLine();

        }
}

------------------------------------------------------------------------------------
class Program
    {
        //ENUM --> é uma forma de criar seu próprio tipo
        enum Opcao {Criar = 1, Deletar = 2 , Editar = 3,Listar = 4 , Atualizar = 5, Voltar = 6}
        enum Cor { Azul , verde , Amarelo , Vermelho  }
        static void Main(string[] args)
        {
            Console.WriteLine("Selecionar uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Voce quer criar algo!");
                    break;

                case Opcao.Deletar:
                    Console.WriteLine("Delete imediatamente ");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editar é top!");
                    break;
                default:
                    Console.WriteLine("Opcao não encontrada");
                    break;


            }

                Console.ReadLine();

        }
}

 ------------------------------------------------------------------------------------

static void Main(string[] args)
        {
            int contador = 0;
            while(contador < 20)
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine("Rodando o while!");
                contador = contador++;
                //outras maneiras : contador += 1;
                //contador = contador + 1;
            }


                Console.ReadLine();

        }

---------------------------------------------------------------------

Do While --> quase nunca será usado

int contador = 0;
do {
Console.WriteLine("Do While");
contador++;
}While (contador < 20);

Console.WriteLine("Fim da linha");
Console.WriteLine();
}




-------------------------------------------------------------------------------------------

static void Main(string[] args)
        {
            string[] palavras = { "João", "Marcus", "Guia do pro", "java", "curso" };
            foreach(string palavra in palavras) //para cada palavra no array palavras repita o bloco de código
            {
                Console.WriteLine(palavra);
            }


                
            
            Console.ReadLine();

        }
-----------------------------------------------------------------------------------------

 static void Main(string[] args)
        {
            string[] palavras = { "João", "Marcus", "Guia do pro", "java", "curso" };
            
            for(int contador = 0 ;contador < palavras.Length ;contador++)//Lenght se referencia aos elementos do array
            {
                Console.WriteLine(palavras[contador]);
               
            }


                
            
            Console.ReadLine();
        }


------------------------------------------------------------------------------------------------------------------------
for(int contador2 = palavras.Length-1;contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }
----------------------------------------------------------------------------------------




*/