using System;
namespace GameEngine
{
	public class Treasure
	{
		public string Description { get; set; }
		public int Value { get; set; }

		public Treasure(string description, int value)
		{
			Description = description;
			Value = value;
		}

		public override string ToString()
		{
			return $"{Description} (Value: {Value})";
		}
	}

}
