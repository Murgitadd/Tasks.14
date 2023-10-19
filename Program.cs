using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Fruit[] Basket = new Fruit[]
        {
            new Apple { Price = 5, Sort = "Quba Alması", VitaminA = 10, VitaminB = 5 },
            new Pineapple { Price = 10, Sort = "Ela nov", VitaminE = 8, VitaminD = 2 },
            new Orange { Price = 8, Sort = "Lankaran", VitaminC = 30 }
            
        };

        foreach (var fruit in Basket)
        {
            Type type = fruit.GetType();
            Console.WriteLine("Type:" + type.Name);

            FieldInfo[] fields = type.GetFields();
            foreach (var field in fields)
            {
            	int value = (int)field.GetValue(fruit);
                Console.WriteLine(field.Name + ":" + value);
            }

            fruit.Taste();
            Console.WriteLine();
        }
        // TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
    }
}
