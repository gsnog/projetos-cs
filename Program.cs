//importando a classe calculadora
using Projetos.Models;
Calculadora calc = new Calculadora(); //variavel do tipo calculadora criada
bool continuar = true;

while(continuar == true){
    //criando o menu
    Console.Clear();
    Console.WriteLine("Bem vindo a sua calculadora!");
    Console.WriteLine("Escolha a operação que gostaria de realizar!");
    Console.WriteLine("1 - Somar \n2 - Subtrair \n3 - Multiplicar \n4 - Dividir \n5 - Potência \n6 - Raiz Quadrada \n");

    //recebendo a entrada do usuario
    string opcaoStr = Console.ReadLine();


    //declarando as variaveis
    double x, y;

    //validando a entrada
    if (int.TryParse(opcaoStr, out int opcao)){
        if(opcao >=1 && opcao <=6){
            switch(opcao){
                case 1:
                    Console.WriteLine("Digite o primeiro número: ");
                    if(double.TryParse(Console.ReadLine(), out x)){
                        Console.WriteLine("Digite o segundo número: ");
                        if(double.TryParse(Console.ReadLine(), out y)){
                            calc.Somar(x,y);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Digite o primeiro número: ");
                    if(double.TryParse(Console.ReadLine(), out x)){
                        Console.WriteLine("Digite o segundo número: ");
                        if(double.TryParse(Console.ReadLine(), out y)){
                            calc.Subtrair(x,y);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Digite o primeiro número: ");
                    if(double.TryParse(Console.ReadLine(), out x)){
                        Console.WriteLine("Digite o segundo número: ");
                        if(double.TryParse(Console.ReadLine(), out y)){
                            calc.Multiplicar(x,y);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Digite o primeiro número: ");
                    if(double.TryParse(Console.ReadLine(), out x)){
                        Console.WriteLine("Digite o segundo número: ");
                        if(double.TryParse(Console.ReadLine(), out y)){
                            calc.Dividir(x,y);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Digite o primeiro número: ");
                    if(double.TryParse(Console.ReadLine(), out x)){
                        Console.WriteLine("Digite o segundo número: ");
                        if(double.TryParse(Console.ReadLine(), out y)){
                            calc.Potencia(x,y);
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Digite o número: ");
                    if(double.TryParse(Console.ReadLine(), out x)){
                        calc.RaizQuadrada(x);
                    }
                    break;
            }
        }
    }
    Console.WriteLine("Deseja continuar? \ns - Sim \nn - Não");
    string resposta = Console.ReadLine().ToLower();

    if (resposta != "s"){
        continuar = false; // Encerra o loop se a resposta não for 's'
        Console.WriteLine("Encerrando! Obrigada!");
    }
}    
