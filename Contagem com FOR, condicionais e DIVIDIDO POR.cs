//Esse código utiliza a estrutura de repetição FOR para uma contagem de 1 a 100, 
// e suas condicionais IF, ELSE IF e ELSE avaliam se tais condições são verdadeiras.

//Esse código retorna a string Fizz quando um número é divisível por 3,
// retorna a string Buzz quando um número é divisível por 5,
// e retorna FizzBuzz quando um número é divisível por 3 e 5 simultaneamente.

for (int i = 1; i < 101; i++)
{
    if (i%3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");        
    }
    else if (i%5 ==0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else if ((i%3 ==0) && (i%5 ==0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
};
