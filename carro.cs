using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ProjetoGFT_Visual
{
    class carro
    {
		// ATRIBUTOS
		private String marca, modelo, placa, cor;
		private float km;
		private bool isLigado;
		private int litrosCombustivel, Velocidade;
		private Double preco;

		// METODOS
		// METODO CONSTRUTOR

		public carro()
		{
			this.marca = "";
			this.modelo = "";
			this.placa = "";
			this.cor = "Amarelo";
			this.km = 0;
			this.isLigado = false;
			this.litrosCombustivel = 50;
			this.Velocidade = 0;
			this.preco = 25000.00;
		}

		public String getMarca()
		{
			return marca;
		}

		public void setMarca(String marca)
		{
			this.marca = marca;
		}

		public String getModelo()
		{
			return modelo;
		}

		public void setModelo(String modelo)
		{
			this.modelo = modelo;
		}

		public String getPlaca()
		{
			return placa;
		}

		public void setPlaca(String placa)
		{
			this.placa = placa;
		}

		public String getCor()
		{
			return cor;
		}

		public void setCor(String cor)
		{
			this.cor = cor;
		}

		public float getKm()
		{
			return km;
		}

		public void setKm(float km)
		{
			this.km = km;
		}

		public bool getisLigado()
		{
			return isLigado;
		}

		public void setisLigado(bool isLigado)
		{
			this.isLigado = isLigado;
		}

		public int getLitrosCombustivel()
		{
			return litrosCombustivel;
		}

		public void setLitrosCombustivel(int litrosCombustivel)
		{
			this.litrosCombustivel = litrosCombustivel;
		}

		public int getVelocidade()
		{
			return Velocidade;
		}

		public void setVelocidade(int velocidade)
		{
			Velocidade = velocidade;
		}

		public Double getPreco()
		{
			return preco;
		}

		public void setPreco(Double preco)
		{
			this.preco = preco;
		}

		public void acelerar()
		{
			if (this.isLigado == true)
			{
				this.Velocidade += 20;
				this.litrosCombustivel -= 1;
				Console.WriteLine("o carro foi acelerado, a velocidade agora é: " + this.Velocidade + " km por hora");
				Console.WriteLine("O combustivel diminuiu e agora tem: " + this.litrosCombustivel + " litros");
			}
			else
			{
				Console.WriteLine("Não é possivel acelerar, Ligue o carro");
			}

		}

		public void abastecer(int qtdLitros)
		{
			if (this.litrosCombustivel >= 100)
			{
				this.litrosCombustivel = 100;
				Console.WriteLine("O carro foi abastecido e tem " + this.litrosCombustivel + " litros de combustivel");
			}
			else
			{
				this.litrosCombustivel += qtdLitros;
				if (this.litrosCombustivel >= 100)
				{
					this.litrosCombustivel = 100;
					Console.WriteLine("O carro foi abastecido e tem " + this.litrosCombustivel + " litros de combustivel");
				}
				else
				{
					Console.WriteLine("O carro foi abastecido e tem " + this.litrosCombustivel + " litros de combustivel");
				}
			}
		}

		public void frear()
		{
			if (this.isLigado == true)
			{
				if (this.Velocidade <= 10)
				{
					this.Velocidade = 0;
					Console.WriteLine("O carro parou");
				}
				else if (this.Velocidade >= 10)
				{
					this.Velocidade -= 10;
					Console.WriteLine("O  carro foi freado a velocidade agora é: " + this.Velocidade + " km por hora");
				}
				else
				{
					Console.WriteLine("O carro está parado!");
				}
			}
		}

		public void pintar()
		{

		}

		public void ligar()
		{
			if (this.isLigado == false)
			{
				this.isLigado = true;
				Console.WriteLine("Carro ligou");
			}
			else
			{
				Console.WriteLine("O carro ja está ligado!");
			}
		}

		public void desligar()
		{
			if (this.isLigado == true)
			{
				this.isLigado = false;
				Console.WriteLine("Carro desligou");
			}
			else
			{
				Console.WriteLine("O carro ja está desligado!");
			}
		}
	}
}
