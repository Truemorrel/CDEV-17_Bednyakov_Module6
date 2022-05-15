using System;

namespace Task_6_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
		class User
		{
			private int age;
			private string login;
			private string email;

			public int Age
			{
				get
				{
					return age;
				}

				set
				{
					if (value < 18)
					{
						Console.WriteLine("Возраст должен быть не меньше 18");
					}
					else
					{
						age = value;
					}
				}
			}
			public string Login
            {
				get
                {
					return login;
                }
				set
                {
					if (value.Length <= 3)
                    {
                        Console.WriteLine("login mast have more than 3 symbols");
                    }
					else
                    {
						login = value;
                    }
                }
            }
			private string Email
			{
				get
				{
					return email;
				}
				set
                {
					if (value.Contains("@"))
					{
						login = value;
					}
				}
			}
		}
	}
}
