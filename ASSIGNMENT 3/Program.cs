namespace ASSIGNMENT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            Console.WriteLine("PLEASE ENTER THE NUMBER");
            int.TryParse(Console.ReadLine(), out int X);
            if (X%3==0 && X%4==0)
            {
                Console.WriteLine("YES");
            }
            else { Console.WriteLine("No"); }
            #endregion

            #region Q2

            Console.WriteLine("Please enter the number :) ");
            int.TryParse(Console.ReadLine(), out int Y);
            if (Y>=0)
            {
                Console.WriteLine("Positive");
            }
            else { Console.WriteLine("negative"); }

            #endregion

            #region Q3
            Console.WriteLine("enter the first number");
            int.TryParse(Console.ReadLine(), out int X1);

            Console.WriteLine("enter the second number");
            int.TryParse(Console.ReadLine(), out int Y2);

            Console.WriteLine("enter the Third number");
            int.TryParse(Console.ReadLine(), out int Z3);

            int max = X1;
            int min = X1;
            if (max>Y2)
            {
                max=X1;
            }
            else if (min<Y2)
            {
                min=X1;
            }
            if (Z3 > max)
            {
                max = Z3;
            }
            if (Z3 < min)
            {
                min = Z3;
            }


            Console.WriteLine($"The maximum value is: {max}");
            Console.WriteLine($"The minimum value is: {min}");

            #endregion


            //#region Q4
            //Console.WriteLine( "Q4");
            //Console.WriteLine( "enter the number");
            //int.TryParse(Console.ReadLine(), out int M);
            //    if (M%2==0) {

            //    Console.WriteLine( "this nmber is even");
            //}
            //else
            //{
            //    Console.WriteLine( "odd");
            //}
            //#endregion



            #region Q5

            Console.WriteLine("enter The character");
            char.TryParse(Console.ReadLine(), out char K);
            if (K=='a' ||K=='e'||K=='o'||K=='i'||K=='u')
            {

                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("constant");
            }
            #endregion

            #region Q7



            Console.WriteLine("Enter an integer: ");
            int number;


            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"\n Multiplication Table for {number} up to 12:");

                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            #endregion

            #region Q9
            Console.WriteLine( "enter the number");
            int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine("enter the power");
            int.TryParse(Console.ReadLine(), out int Power);
            
            int Result;
            
            for (int i = 0; i<=Power; i++) {
                
                Result= num *i;
                Console.WriteLine($"Result: {Result}");
            }



            #endregion



            #region Q11

            Console.WriteLine(" enter the number of month");

            int.TryParse( Console.ReadLine(),out int Months );

            int days=0;
            switch (Months) {

                case 1:            
                case 3: 
                case 5: 
                case 7: 
                case 8:
                case 10: 
                case 12: 
                    days = 31;
                    break;

                case 4: 
                case 6: 
                case 9: 
                case 11: 
                    days = 30;
                    break;

                case 2:
                    days = 28;
                    break;

            }

            Console.WriteLine($"The month {Months} has {days} days");

            #endregion


        }
    }
}
