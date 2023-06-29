using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETORES_C {
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            double[] vect= new double[N];

            for (int i=0; i<N; i++) {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
            }
            //encontra media - criando variael soma 
            double soma = 0.0;
            for ( int i=0; i<N;i++) {
                //for para acumular a soma das alturas
                soma += vect[i];
            }
            //calcular a media das alturas
            double avg = soma /N;

            Console.WriteLine("Altura media: " + avg);
            Console.ReadKey();
        }
    }
}
