using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Guía:11
// Ejercicio:7
// Fecha: 30/5/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Ing. Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia
{
	//Descripcion del programa:
	/*Se leen diez nombres de frutas y se despliegan sólo las que sus nombres comiencen con
	  m, reportando la cantidad de frutas seleccionadas.*/


	class Program
	{
		public static void Main(string[] args)
		{
			//Identificacion del programa en pantalla
			Console.Title = ("Las Frutas");
			Console.WriteLine("Las Frutas");
			Console.WriteLine("Autor:Brandon Gomez");

			//DECLARACION DE VARIABLES
			string[] frutas = new string[10];

			//ENTRADA DE DATOS
				Console.WriteLine("-------------------------------------------- ");
				for (int i = 0; i < frutas.Length; i++)
				{
					Console.WriteLine("Ingrese el nombre de la fruta");
					frutas[i] = Console.ReadLine();
				}

			//PROCESO DE DATOS
			Imprimir(frutas);
			Console.ReadKey();
			//PROCESO DE DATOS
			static void Imprimir(string[] frutas)
			{
				string letraFrutaMayus = "M";
				string letraFrutaMin = "m";
				char primeraLetra;
				int cuentaFruta = 0;
				string nombreFruta = "";
				for (int i = 0; i < frutas.Length; i++)
				{
					primeraLetra = frutas[i][0];
					if (letraFrutaMayus == primeraLetra.ToString() || letraFrutaMin == primeraLetra.ToString())
					{
						cuentaFruta += 1;
						nombreFruta += " " + frutas[i];
					}
				}
				//SALIDA DE DATOS
				if (cuentaFruta <=0)
                {
					Console.WriteLine("-------------------------------------------- ");
					Console.Write("No se introdujo frutas que empiecen con la letra [M] ");
				}
				Console.WriteLine("-------------------------------------------- ");
				Console.Write("Frutas que empiezan con la letra m: {0}",nombreFruta);
				Console.WriteLine("\n--------------------------------------------");
				Console.WriteLine("cantidad de frutas que empiezan con la letra m: #{0}", cuentaFruta);
			}

		}
	}
}