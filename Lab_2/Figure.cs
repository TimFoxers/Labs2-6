﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
	public abstract class Figure : IComparable
	{
		public string Type { get; set; }
		public abstract double Area();
		public override string ToString()
		{
			return this.Type + " с площадью " + this.Area().ToString();
		}
		public int CompareTo(object obj)
		{
			Figure f = (Figure)obj; //Сравнение
			if (this.Area() < f.Area())
				return -1;
			else
			{
				if (this.Area() == f.Area())
					return 0;
				else
					return 1;
			}
		}
	}
}
