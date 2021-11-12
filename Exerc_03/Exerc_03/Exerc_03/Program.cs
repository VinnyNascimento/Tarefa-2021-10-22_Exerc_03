using System;

namespace Exerc_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra a Área de um Quadrado, através de sua diagonal");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o valor da diagonal de um quadrado: ");
            s.setNum1(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("Com o Valor da Diagonal {0} a área do quadrado é: {1}", s.getNum1(), s.getResultado());
            #endregion
        }
    }
}