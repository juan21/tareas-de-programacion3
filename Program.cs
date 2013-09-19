/*
 * Created by SharpDevelop.
 * User: Juan Carlos
 * Date: 9/18/2013
 * Time: 10:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tarea1
{
	class Program
	{
		public static void Main(string[] args)
		{
			persona p= new persona();
		Console.WriteLine ("\nnombre:");
		p.nombre=Console.ReadLine();
		Console.WriteLine("\nTu nombre es:"+p.nombre);
		
		Console.WriteLine("\ncorreo:");
		p.correo=Console.ReadLine();
		Console.WriteLine("\nTu correo es:"+p.correo);
		
		Console.WriteLine("\nedad:");
	    p.edad=Console.ReadLine();
		Console.WriteLine("\nTu edad es:"+p.edad);
		
			Console.Write("\nPresione cualquier tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}