using System;

namespace EXERCICÍO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string estado;
            int idade;
            double salario;

            do {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu salario: ");
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu estado civil: solteiro(s), casado(c), viuvo(v), divorciado(d): ");
                estado = Console.ReadLine();

                if (nome == null){
                    Console.WriteLine("Nome invalido");
                }
                if(idade < 0 || idade > 150){
                    Console.WriteLine("Idade inválida");
                }
                if (salario < 0){
                    Console.WriteLine(" Salario Invalido");
                }
                if (estado == "s" || estado == "c" || estado == "d" || estado == "v") {
                    Console.WriteLine(" |Estado Civil Invalido");
                }
            }

             while(nome == null);
                Console.WriteLine("Nome Valido");

                while(idade < 0 || idade > 150);
                Console.WriteLine("Idade Valida");

                while(salario < 0);
                Console.WriteLine("Salario Valido");

                while(estado == "s" || estado == "c" || estado == "d" || estado == "v");
                Console.WriteLine("Estado Valido");
            
                Console.WriteLine("Tudo certo pode continuar");
        }
    }
}
