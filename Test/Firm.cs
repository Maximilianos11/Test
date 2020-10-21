using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
	interface Itypes
	{
		void Work();
	}
	interface Imanager
	{
		void Manage();
	}
	interface Ibrigadier
	{
		void Brigad();
	}
	class Firm : Itypes, Imanager, Ibrigadier
	{
		public void Work()
		{
			Console.WriteLine("Рабочий-(выпуск продукции)\nМенеджер-(сборка заказов)\nБригадир-(закупка материалов)");
		}
		public void Manage()
		{
			Console.WriteLine("Менеджер дает всем задания и он с этим справляется");
		}
		public void Brigad()
		{
			Console.WriteLine("Бригадир уже проверил выполнение работы рабочими");
		}
	}
}
