﻿using System;

namespace Temperatura
{
    public class Temperatura
    {
        public float temperaturaF;
        public float temperaturaC;
        public Temperatura()
        {
            Console.WriteLine("Ingrese Temperatura en grados Farenheit: ");
            temperaturaF =float.Parse(Console.ReadLine());
            temperaturaC = (temperaturaF - 32) * 5 / 9;
        }
 
    }
    class Principal
    {
        static void Main(string[] args)
        {
            Temperatura Conv = new Temperatura();
            Console.WriteLine("La temperatura en celcius es: {0:f2}", Conv.temperaturaC);
        }
    }
}
