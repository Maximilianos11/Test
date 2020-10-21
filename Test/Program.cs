using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Test
{
	class Program
	{
		public static void Action(Itypes movable)
			{
				movable.Work();
			}
		public static void Ac(Ibrigadier br)
		{
			br.Brigad();
		}
		public static void Act(Imanager me)
		{
			me.Manage();
		}
		static void Main(string[] args)
		{
			List<string> type = new List<string>();
			type.Add("Workman");
			type.Add("Manager");
			type.Add("Brigadier");
			Console.WriteLine();
			foreach (string dsf in type)
			{
				Console.WriteLine(dsf);
			}
			Console.WriteLine();
			List<string> list = new List<string>();
			Console.WriteLine("Список сотрудников:");
			list.Add("Димов Дмитрий Дмитриевич");
			list.Add("Петров Петр Петрович");
			
			foreach (string s in list)
			{
				Console.WriteLine(s);

			}

			Console.WriteLine("\nКоличество сотрудников:");
			Console.WriteLine(list.Count);
		Employee p1 = new Employee();
			Action(p1);
			Ac(p1);
			Act(p1);
			Console.WriteLine("\nДля проверки наличия сотрудника в фирме введите его ФИО!");
			string c1;
			c1 = Console.ReadLine();
			if (list.Contains(c1))
			{
				Console.WriteLine("Этот сотрудник уже работает на этой фирме!");
			}
			else
			{
				Console.WriteLine("Этот сотрудник не работает в этой фирме!");
			}
			Console.WriteLine("Для добавления сотрудника введите его ФИО!");
			string name;
			name = Console.ReadLine();
			p1.name = name;
		}
	}
}
