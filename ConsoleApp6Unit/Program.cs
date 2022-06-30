using System;

namespace ConsoleApp6Unit
{
	class User
	{
		private int age;

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
		private string login;
		public string Login
        {
			get
			{ return login; }
			set 
			{ if (value.Length < 3) 
				{
					Console.WriteLine("Login должен быть больше 3х символов");
			    }
				else 
				{ login = value; }
			}
        }

		private string email;
	     public string Email
        {
			get { return email; }
			set 
			{
                if (value.Contains('@'))
                {
					Console.WriteLine("Неверный формат адреса электронной почты");
				}
                else
                {
					email = value;
                }
		}
        }
            
     }

}