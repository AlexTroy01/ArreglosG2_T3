using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArrelo
    {
        //Atributos o campos

        private int _tope;
        private int[] _arreglo;

        //constructor

        public MiArrelo(int n) 
        {
            N= n;
            _arreglo = new int[N];
            _tope = 0;
        }

        //Propiedades

        public int N { get; }
        public bool EstaVacio => _tope == 0;
        public bool EstaLleno => _tope == N;
        //Metodos

        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }

            _tope = N;
        }

        public override string ToString()
        {

            string salida = string.Empty;
            for (int i = 0; i < _tope; i++)
            {
                salida += $"{_arreglo[i]}\t";
            }
            return salida;
        }
    }
}
