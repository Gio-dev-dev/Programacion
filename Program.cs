/*
 * Created by SharpDevelop.
 * User: EQUIPO
 * Date: 1/02/2021
 * Time: 2:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Programación_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("¡Bienvinido Profe!");
			
			// Para este ejercicio tendremos un número de tres digitos que tiene la forma abc.
			// Por ejemplo ->241 para este caso "a" seria el numero 2, "b" seria el número 4. "c" seria el numero 1.
			// Haz un programa que produzca números aacb, bca, bcbc.
			// Yo usare los números 135 "a mivalor1" será 1. "b mivalor3" será 3, "c mivalo5" será 5.
			
			int mivalora= 1;
			int mivalorb= 3;
			int mivalorc= 5;
			int resultado=0;
			resultado= mivalora=mivalorb=mivalorc;
			Console.WriteLine ("El primer valor pedido es de: 1153");
			Console.WriteLine ("El segundo valor pedido es de: 351");
			Console.WriteLine ("El tercer valor pedido es de: 3535");
			
			// Ahora haremos que las personas puedan agregrar los numeros que el programa le pida en esta ocación usaremos
			// Los nuemros 258 de esta manera las personas podrán ver los resultados esperados
			int valor= 2;
			
			Console.WriteLine("!Ingrese tres numeros del 2 al 8 por favor¡");
			Console.WriteLine("¡Luego de seleccionar los tres números presione enter para continuar por favor!");
			Console.WriteLine("Los valores son:");
			valor=int.Parse (Console.ReadLine());
		
			// Ahora realizaremos una suma, resta, multiplicación, división y un residuo
			// Con los numeros 753 
            // primero comenzaremos con la suma +
            double nuestrovalora= 7;
            double nuestrovalorb= 5;            	
			double nuestrovalorc= 3;	
			double total= 0;
			
			total= nuestrovalora+nuestrovalorb+nuestrovalorc;
			Console.WriteLine("{0} + {1} + {2} = {3}", nuestrovalora,nuestrovalorb,nuestrovalorc,total);
			// Ahora lo haremos con la resta -
			double nuestrovalord= 7;
            double nuestrovalore= 5;            	
			double nuestrovalorf= 3;	
			double totaliti= 0;
			
			totaliti= nuestrovalord-nuestrovalore-nuestrovalorf;
			Console.WriteLine("{0} - {1} - {2} = {3}", nuestrovalord,nuestrovalore,nuestrovalorf,totaliti);
			// Ahora lo haremos con la multiplicación *
			
			double nuestrovalorg= 7;
            double nuestrovalorh= 5;            	
			double nuestrovalori= 3;	
			double Seria= 0;
			
			Seria= nuestrovalorg*nuestrovalorh*nuestrovalori;
			Console.WriteLine("{0} * {1} * {2} = {3}", nuestrovalorg,nuestrovalorh,nuestrovalori,Seria);
			
			// Ahora lo heremos con división /
			
			double nuestrovalorj= 7;
            double nuestrovalork= 5;            	
			double nuestrovalorm= 3;	
			double Totall= 0;
			
			Totall= nuestrovalorj/nuestrovalork/nuestrovalorm;
			Console.WriteLine("{0} / {1} / {2} = {3}", nuestrovalorj,nuestrovalork,nuestrovalorm,Totall);
			
			// Y por ultimo con residuo % 
			
			double nuestrovalorn= 7;
            double nuestrovalorÑ= 5;            	
			double nuestrovaloro= 3;	
			double Totalll= 0;
			
			Totalll= nuestrovalorn%nuestrovalorÑ%nuestrovaloro;
			Console.WriteLine("{0} % {1} % {2} = {3}", nuestrovalorn,nuestrovalorÑ,nuestrovaloro,Totalll);
			
			// Y eso seria todo mi trabajo!!
			
			
	Console.ReadLine();
			
			
			
			
			
			
			
			
			
			
		   
				
		}
	}
}