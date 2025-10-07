#region Algorithms Intro

// Console.WriteLine("Hello, World!");


// byte age = 30;
// int familyMembers = 3;
// float height = 6.1f;
// float salary = 1000.50f;
// char firstLetter = 'R';
// bool isEmployed = true;
// bool isMarried = false;
// string firstName = "Rashad";
// string lastName = "Mammadov";
// string address = "Baku, Azerbaijan 8 Noyabr St. 12A";


// start -> input(150) -> comparison(150 >= 170) -> output(false) -> process(boy += limit - input ) -> end
// -> output(true) -> end 

#endregion

#region Conditions

// int a = 10;
// int b = 10;
// int c = 20;

// if (a == b)
// {
//       Console.WriteLine("a b ve c beraberdir");
// }
// else
// {
//       Console.WriteLine("a b ye beraberdir deyil");
// }

// int overall = 90;

// if (overall >= 90)
// {
//       Console.WriteLine("Awesome!");
// }
// else if (overall >= 80)
// {
//       Console.WriteLine("Great!");
// }
// else
// {
//       Console.WriteLine("Kasib biraz oxu");
// }


// int age = 20;

// if (age >= 18)
// {
//       Console.WriteLine("Ticket price is 25$");
// }
// else if (age >= 12)
// {
//       Console.WriteLine("Ticket price is 15$");
// }
// else
// {
//       Console.WriteLine("Ticket price is 5$");
// }

// float salary = 800f;
// int workingHours = 12;
// float bonus = 10f;

// if (workingHours > 8 && salary <= 1000)
// {
//       Console.WriteLine(salary += bonus * 30);
// }
// else
// {
//       Console.WriteLine("Az işləyirsən. ona görə maaşın", salary, "qədərdir");
// }

#endregion

#region Switch

// int day = 1;

// switch (day)
// {
//       case 1:
//             Console.WriteLine("Monday");
//             break;
//       case 2:
//             Console.WriteLine("Tuesday");
//             break;
//       case 3:
//             System.Console.WriteLine("Wednesday");
//             break;
//       case 4:
//             System.Console.WriteLine("Thursday");
//             break;
//       case 5:
//             System.Console.WriteLine("Friday");
//             break;
//       case 6:
//             System.Console.WriteLine("Saturday");
//             break;
//       case 7:
//             System.Console.WriteLine("Sunday");
//             break;
//       default:
//             System.Console.WriteLine("Duzgun daxil edin!");
//             break;
// }

// string day = "Thursday";

// int weekDay = day switch
// {
//       "Monday" => 1,
//       "Tuesday" => 2,
//       "Wednesday" => 3,
//       "Thursday" => 4,
//       "Friday" => 5,
//       "Saturday" => 6,
//       "Sunday" => 7,
//       _ => 0
// };

// Console.WriteLine(weekDay);

#endregion

#region Loops

// for (int i = 0; i <= 10; i += 2)
// {
//       Console.WriteLine(i);
// }

// for (int i = 0; i <= 10; i++)
// {
//       if (i % 2 == 0)
//       {
//             System.Console.WriteLine(i);
//       }
// }

// for (int i = 0;; i += 1000)
// {
//     System.Console.WriteLine(i);
// }

//while do while

// int i = 0;
// while (i <= 10)
// {
//       System.Console.WriteLine("Index: " + i);
//       i++;
// }


// int index = 20;

// do
// {
//       System.Console.WriteLine("Index: " + index);
//       index++;
// } while (index <= 10);


// string name = "Rashad Mammadov";


// for (int i = 0; i < name.Length; i++)
// {
//       System.Console.WriteLine(name[i]);
// }


// int x = 0;

// int y = 10;

// int sum = 0;


// while (x <= y)
// {
//       sum += x;
//       x++;
// }
// System.Console.WriteLine(sum);


#endregion

#region Arrays


// string[] names = { "Rashad", "Nihad", "Durdane", "Kamran", "Aysel" };
// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// for (int i = 0; i < numbers.Length; i++)
// {
//       System.Console.WriteLine(numbers[i]);
// }

// foreach (var item in ages)
// {
//       System.Console.WriteLine(item);
// }


// for (int i = 0; i < ages.Length; i++)
// {
//       System.Console.WriteLine(ages[i]);
// }

// int[] ages = new int[10];
// ages[0] = 10;
// ages[1] = 20;
// ages[2] = 30;
// ages[3] = 40;
// ages[4] = 50;
// ages[5] = 60;
// ages[6] = 70;
// ages[7] = 80;
// ages[8] = 90;
// ages[9] = 100;

// string[] names = { "Rashad", "Nihad", "Durdane", "Kamran", "Aysel" };

// foreach (var item in names)
// {
//       System.Console.WriteLine(item);
// }

double[] numbers = { 200.5, 10, 20, 3, 1, 5, 6, 7, 8, 9, 10 };


// Array.Sort(numbers);
// Array.Reverse(numbers);

// int index = Array.IndexOf(numbers, 200.5);
// System.Console.WriteLine(index);

// Array.Clear(numbers, 4, 4);
// for (int i = 0; i < numbers.Length; i++)
// {
//       System.Console.WriteLine(numbers[i]);
// }





// foreach (var item in numbers)
// {
//       System.Console.WriteLine(item);
// }

#endregion
