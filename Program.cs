using System;

namespace _1_ProjetoGFT_Visual
{
    class Program
    {
        static void Main(string[] args)
        {
			carro c = new carro();

			c.ligar();
			c.abastecer(25);
			c.abastecer(200);
			c.acelerar();
			c.frear();
			c.frear();
			c.acelerar();
			c.acelerar();
			c.acelerar();
			c.acelerar();
			c.acelerar();
			c.abastecer(2);
			c.desligar();
		}
    }
}
