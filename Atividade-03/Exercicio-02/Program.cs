/*
    Crie uma classe chamada "Calculadora"
    que contenha métodos para as operações de soma, subtração, multiplicação e divisão.
    Esses métodos devem receber dois números como parâmetro e retornar o resultado da operação. 
*/

namespace Exercicio_02;

public class Program {
    static void Main() {
        Calculadora calculadora = new Calculadora();

        calculadora.Somar(1, 1);
        calculadora.Multiplicar(2, 2);
        calculadora.Dividir(4,2);
        calculadora.Subtrair(1, 1);
    }
}