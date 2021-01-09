using System;

namespace HelloWorld
{
    class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            /* int segundaGuerraMundial = 1942; // numero inteiro, não utiliza aspas 
            String corFavorita = "azul"; //usa " " para identificar que é um texto
            float velocidadeF1 = 294.98f; // necessario colocar o f no final 
            bool segundaGuerraMundialAconteceu = true; //não pode ter o mesmo nome da variavel no mesmo lugar 

            /*
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 398.56f;
            corFavorita = "roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);
            */
            /*
            var corFavorita = "azul"; 
            var modeloDoProduto = 1996; 
            */

            /* dynamic corFavorita = "azul"; //variavel dinamica. parece pratico, mas não é 

           Console.WriteLine(corFavorita);

           corFavorita = 15151545;

           Console.WriteLine(corFavorita);

           corFavorita = 16.96f; 

            const float PI = 3.4545454f; // quando é criado uma constante, o valor não pode ser mudado.  */

            // Console.WriteLine("escreva seu nome:");
            //string nome = Console.ReadLine(); /* ou  string nome = "";  nome = Console.ReadLine();     */
            // Console.WriteLine("seu nome é: ");
            //  Console.WriteLine(nome); */ 

            /* int numeroQualquer = 24 + 50;
             int numeroMult = 50 * 30;
             float numeroDiv = 773f/ 3;
             int teste = (5 + 3) * 4;
             Console.WriteLine(numeroQualquer);
             Console.WriteLine(numeroMult);
             Console.WriteLine(numeroDiv);
             Console.WriteLine(teste); */


            // + de uma condição dentro do if você usa o (E ou AND) && e || (OU/OR) sempre que tiver 2 opções ele entra como verdadeiro, caso se encaixe em uma delas
            // true || true => true 
            // false || true => true 
            // true || false => true 
            // False || false => false 

            /*
            int a = 10;
            int b = 20;
            int c = 200;

            if (a < b ||  a > c) // SE 
            {
                Console.WriteLine("É verdade!");
            }
            else if (20 != 20)
            {
                Console.WriteLine("executou o elseIf");
            }
            else // SE NAO 
            {
                Console.WriteLine("É Falso!");
            } 
            */
            /*Console.WriteLine("digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if (idade >= 12 && idade <= 18) 
            {
                Console.WriteLine("Você é um adolescente"); 
            } 
            else if (idade >= 19 && idade <= 60) 
            {
                Console.WriteLine("voce é um adulto");
            }
            else
            {
                Console.WriteLine("voce é um idoso");
            }
           */
           //  ExibirMensagem(); //serve para a quantidade de vezes que você quer mostrar a mensg. 
            GerarPreco(500);
            Console.ReadLine(); 
        }
        static void ExibirMensagem ()
        {
            Console.WriteLine("esse programa é bom");
            Console.WriteLine("Agora usando o VSC");
            Console.WriteLine("não sei se vai da bom!!!");
        }
        static void GerarPreco(int preco);
        {
            Console.WriteLine(preco);
        }
    }
}
