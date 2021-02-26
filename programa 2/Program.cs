/*
 * Created by SharpDevelop.
 * User: Virginia
 * Date: 25/02/2021
 * Time: 12:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace programa_2
{
	class Program
	{
		public static void Main(string[] args)
		{
		string cadena = "";
		int edad = 0;
		double estatura = 0.0;
		int lugar= 0;	
		
		Console.WriteLine("Bienvenido a super park");
		Console.WriteLine("Por favor, Ingrese su edad");
		cadena= Console.ReadLine();
		edad= Convert.ToInt32(cadena);
		
		if (edad >= 18)
		{
			Console.WriteLine("Disculpe ha superado el limite de edad para entrar al parque");
			
		}
		else
		{
		
		
		Console.WriteLine("Ingrese su estatura");
		cadena= Console.ReadLine();
		estatura=Convert.ToDouble(cadena);
		
		if(estatura < 1.6)
		{
		Console.WriteLine("tienes permitido a ir a estas zonas, elije a cual quieres ir");
		Console.WriteLine("1= rueda de la fortuna 2= carritos chocones 3= sillas voladoras 4=gusanito");
		
		cadena= Console.ReadLine();
		lugar= Convert.ToInt32(cadena);
		
		if(lugar == 1)
		{Console.WriteLine("Imprimiendo boleto para la rueda de la fortuna");}
		else
		{
			if(lugar == 2)
		{Console.WriteLine("Imprimiendo boleto para Carritos chocones");}
			else
		{
			if(lugar == 3)
		{Console.WriteLine("Imprimiendo boleto para las sillas voladoras");}
			else
			{
				if(lugar == 4)
		{Console.WriteLine("Imprimiendo boleto para el Gusanito");}
			}
		}
		}
		}
		
		
		else
		{			
		Console.WriteLine("A donde quiere ir?");
		Console.WriteLine("1= rueda de la fortuna 2= Montaña Rusa 3= Carritos Chocones");
		Console.WriteLine("4= Gusanito 5= Sillas voladoras 6= Casa embrujada 7= el Martillo");
		cadena= Console.ReadLine();
		lugar= Convert.ToInt32(cadena);
		if(lugar == 1)
		{Console.WriteLine("Imprimiendo boleto para la rueda de la fortuna");}
		else
		{
			if(lugar == 2)
		{Console.WriteLine("Imprimiendo boleto para Montaña rusa");}
			else
		{
			if(lugar == 3)
		{Console.WriteLine("Imprimiendo boleto para los carritos chocones");}
			else
			{
				if(lugar == 4)
		{Console.WriteLine("Imprimiendo boleto para el Gusanito");}
				else
		{
			if(lugar == 5)
		{Console.WriteLine("Imprimiendo boleto para las sillas voladoras");}
			else
			{
				if(lugar == 6)
		{Console.WriteLine("Imprimiendo boleto para la casa embrujada");}
			
 				else
			{
				if(lugar == 7)
		{Console.WriteLine("Imprimiendo boleto para el Martillo ");}
				
		}
		}
		}
		}
		}
		}
		}
		}
		if(lugar>7)
		{Console.WriteLine("este lugar no se ecncuentra en el sistema");}
			            else{
		Console.WriteLine("Fin del programa, Gracias por la espera");
		Console.ReadLine();
			                   }
		Console.ReadLine();
		
		
		}
		
	   }
		
	}
