Console.WriteLine("------------------------------1------------------");

// 1.	Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25. 

int firstInput; int secondInput;
            int min1; int max1;
            Console.WriteLine("Enter 1st integer: ");
            firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter a 2nd integer: ");
            secondInput = int.Parse(Console.ReadLine());

            //using ternary operator
            max1 = (firstInput > secondInput) ? firstInput : secondInput;
            min1 = (firstInput < secondInput) ? firstInput : secondInput;


            int arrayspaces1 = 0; 
            for (int i1 = min1; i1 <= max1; i1++)
            {
                if (i1 % 5 == 0)
                {
                    arrayspaces1++;
                }
            }

            int counter1 = 0; int[] array1 = new int[arrayspaces1]; 
            for (int i1 = min1; i1 <= max1; i1++)
            {
                if (i1 % 5 == 0)
                {
                    array1[counter1] = i1;
                    counter1++;
                }
            }
                        
            Console.WriteLine("[{0}]", string.Join(", ", array1));            
            Console.WriteLine("There are {0} numbers that are divisible by 5 and results to zero between your two inputs.", counter1);
        
        Console.WriteLine("------------------------------2------------------");

                // 2.	Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 
         Console.WriteLine("The Fibonacci sequence of 100 are : ");
         int fab = 100;
 
      
 
        int fab1 = 0;
        int fab2 = 1;
        Console.Write("{0} {1} ", fab1, fab2);
 
        for (int i2 = 2; i2 < fab; i2++)
        {
            int fab3 = fab1 + fab2;
            Console.Write("{0} ", fab3);
            fab1 = fab2;
            fab2 = fab3;
        }
        Console.WriteLine();




 Console.WriteLine("------------------------------3------------------");
        // 3.	Write a program that finds the greatest of given 5 numbers. 


        Console.WriteLine("Enter your First Input:");

int FirstInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second Input:");

int SecondInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Third Input:");

int ThirdInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Fourth Input:");

int FourthInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Fifth Input:");

int FifthInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(".... Recorded");
Console.WriteLine("Your First Input is " + FirstInput + ", Your second input is " + SecondInput + ", Your Third input is " + ThirdInput + ", Your Fourth input is " + FourthInput + ", Your fifth input is " + FifthInput);

        int[] arrayNumbers = { FirstInput, SecondInput, ThirdInput, FourthInput, FifthInput};
        decimal arrayBiggest = arrayNumbers.Max();
 
        Console.WriteLine("The Largest of the input is " + arrayBiggest);




         Console.WriteLine("------------------------------ 4 ------------------");
	// Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots. Hints: From math it is known, that a quadratic equation may have one or two real roots or no real roots at all. In order to calculate the real roots of a given quadratic equation, we first calculate the discriminant (D) by the formula: D = b2 - 4ac. If the discriminant is zero, then the quadratic equation has one double real root and it is calculated by the formula: x = -b/2a. If the value of the discriminant is positive, then the equation has two distinct real roots, which are calculated by the formula: x=(-b±√(b^2-4ac))/2a . If the discriminant is negative, the quadratic equation has no real roots.  


Console.Write("enter coefficient of a: ");
 int A4 = Convert.ToInt32(Console.ReadLine());

 Console.Write("enter coefficient of b: ");
int B4 = Convert.ToInt32(Console.ReadLine());

 Console.Write("enter coefficient of c: ");
 int C4 = Convert.ToInt32(Console.ReadLine());
 double X;
 double X2;
 int DEE =  B4*B4 - 4*A4*C4;
 Console.WriteLine(DEE);
 
  if(DEE < 0)
  {
   Console.WriteLine("it has no real root");
  }
  else if (DEE==0)
  {
 X= -B4/2*A4;
 Console.WriteLine(X);
  }
  else
  {
 X = -B4 - Math.Sqrt(DEE)/2*A4; 
 X2 = -B4 + Math.Sqrt(DEE)/2*A4;
 Console.WriteLine("roots of the equation are " + X + " and" + X2);
 }





          Console.WriteLine("------------------------------ 5 ------------------");


// 5.	Write a program that applies bonus points to given scores in the range [1…9] by the following rules: 
// •	If the score is between 1 and 3, the program multiplies it by 10.
// •	If the score is between 4 and 6, the program multiplies it by 100. 
// •	 If the score is between 7 and 9, the program multiplies it by 1000.
// •	 If the score is 0 or more than 9, the program prints an error message. Hints – Use Switch Statements.

Random random = new Random();

 int number5 = random.Next(12);
int bonus5 = 0;
Console.WriteLine("your Score is : " + number5);
   
if (number5 <= 0 )
{
        Console.WriteLine("Invalid Score");
}
    else if (number5 <=3) {
        bonus5 = 10;
    }
     else if (number5 <=6) {
        bonus5 = 100;
    }
     else if (number5 <=9) {
        bonus5 = 1000;
    }
     else if (number5 >9) {
        Console.WriteLine("Invalid Score");
    }

    int Totalscore = number5 * bonus5;
    switch (number5)
    {
        case 1: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 2: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 3: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 4: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 5: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 6: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 7: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 8: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 9: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
    }







           Console.WriteLine("------------------------------ 6 ------------------");

// 6.	Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input. Hints (Use a for-loop and the operator % for finding the remainder in integer division. A number num is not divisible by 3 and 7 simultaneously exactly when (num % (3*7) == 0))



Console.Write("Enter your number to check number not divisible by 3 and 7 simultaneously: ");
            int length6 = Int32.Parse(Console.ReadLine());

            for (int i6 = 1; i6 < length6; i6++)
            {
                if (i6 % (3 * 7) != 0) Console.WriteLine(i6);
            }





            Console.WriteLine("------------------------------7------------------");
// 7.	Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards). Hints (Number the cards from 2 to 14 (these numbers will match the cards 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A). Number the suits from 1 to 4 (1 – club, 2 – diamond, 3 – heart and 4 – spades). Now you can use the two nested loops and print each of the cards with two switch statements) 


 for (int i7 = 0; i7 < 4; i7++)
            {
                if(i7 != 0) Console.WriteLine();

                for (int j7 = 0; j7 < 13; j7++)
                {
                    switch (i7)
                    {
                        case 0: Console.Write("Hearts "); break;
                        case 1: Console.Write("Diamonds "); break;
                        case 2: Console.Write("Spades "); break;
                        case 3: Console.Write("Clubs "); break;
                    }
                    switch(j7)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
                }
            }


             Console.WriteLine("------------------------------ 8  ------------------");
            //  8.	Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … Hints (Fibonacci numbers start from 0 and 1, each additional is obtained as the sum of the previous two. You can find the first n Fibonacci numbers with a for-loop from 1 to n, and at each iteration calculate the next number by using the previous two (which you will keep in two additional variables)). 

   Console.WriteLine("Please enter your Fibonacci number:");
        int Fibonacci1 = int.Parse(Console.ReadLine());
 
        if (Fibonacci1 == 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else if (Fibonacci1 == 1)
        {
            Console.WriteLine(0);
            return;
        }
 
        int x1 = 0;
        int x2 = 1;
        Console.Write("{0} {1} ", x1, x2);
 
        for (int i8 = 2; i8 < Fibonacci1; i8++)
        {
            int x3 = x1 + x2;
            Console.Write("{0} ", x3);
            x1 = x2;
            x2 = x3;
        }
        Console.WriteLine();




              Console.WriteLine("------------------------------ 9 ------------------");


// 9.	Write a program that for a given number n, outputs a matrix in the form of a spiral: 
// Example for n=4 
// 1	2	3	4
// 12	13	14	5
// 11	16	15	6
// 10	9	8	7
// Hints (
// You should use a two-dimensional array (matrix). Search the Internet or see the chapter "Arrays").


Console.Write("Enter your matrix Number: ");
            int num1 = Int32.Parse(Console.ReadLine());            
            int[,] matrix = new int[num1, num1];
            int row = 0, col = 0, direction = 0;

            for (int i9 = 1; i9 <= num1 * num1; i9++)
            {
                switch(direction)
                {
                    case 0:
                            if (col > num1 - 1 || matrix[row, col] != 0)
                            {
                                direction = 1;
                                col--;
                                row++;
                            }
                            break;
                    case 1:
                            if (row > num1 - 1 || matrix[row, col] != 0)
                            {
                                direction = 2;
                                row--;
                                col--;
                            }
                            break;
                    case 2:
                            if (col < 0 || matrix[row, col] != 0)
                            {
                                direction = 3;
                                col++;
                                row--;
                            }
                            break;
                    case 3:
                            if (row < 0 || matrix[row, col] != 0)
                            {
                                direction = 0;
                                row++;
                                col++;
                            }
                            break;
                }

                matrix[row, col] = i9;                

                switch(direction)
                {
                    case 0: col++; break;
                    case 1: row++; break;
                    case 2: col--; break;
                    case 3: row--; break;
                }
            }
            for (int i9 = 0; i9 < num1; i9++)
            {
                for (int j9 = 0; j9 < num1; j9++)
                {
                    if (matrix[i9, j9] < 10) Console.Write("{0}  ", matrix[i9, j9]);
                    else Console.Write("{0} ", matrix[i9, j9]);
                }
                Console.WriteLine();

            }




               Console.WriteLine("------------------------------ 10 ------------------");


// 10.	Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console. 



 int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }




             Console.WriteLine("------------------------------ 11 ------------------");

        // 11.	Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal). 




bool arraysEqual = true;
Console.Write("Enter length of first array: ");
int length11 = Int32.Parse(Console.ReadLine());
int[] arrA = new int[length11];
for (int i11 = 0; i11 < arrA.Length; i11++)
{
Console.Write("Enter element {0}: ", i11);
arrA[i11] = Int32.Parse(Console.ReadLine());
}
Console.Write("\nEnter length of second array: ");
if (length11 != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
else
{
int[] arrB = new int[length11];
for (int i11 = 0; i11 < arrB.Length; i11++)
{
Console.Write("Enter element {0}: ", i11);
arrB[i11] = Int32.Parse(Console.ReadLine());
}
for (int i11 = 0; i11 < arrA.Length; i11++)
{
if (arrA[i11] != arrB[i11])
{
Console.WriteLine("\nArrays are different.");
arraysEqual = false;
break;
}
}
if (arraysEqual) Console.WriteLine("\nArrays are the same.");

}








              Console.WriteLine("------------------------------ 12 ------------------");


        // 12.	Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} {2, 2, 2}. 

int count12 = 1, tempCount12 = 1, number12 = 0;

			Console.WriteLine ("Enter array length: ");
			int length12 = Int32.Parse (Console.ReadLine ());
			int[] array12 = new int[length12];

			for (int i12 = 0; i12 < array12.Length; i12++) 
			{
				Console.Write ("Enter {0} element: ", i12);
				array12 [i12] = Int32.Parse (Console.ReadLine ());
			}

			for (int i12 = 0; i12 < array12.Length - 1; i12++) 
			{
                if (array12[i12] == array12[i12 + 1]) tempCount12++;
                else tempCount12 = 1;

				if (tempCount12 > count12) 
				{
					count12 = tempCount12;
					number12 = array12 [i12];
				}
			}

			for (int i12 = 0; i12 < count12; i12++) Console.WriteLine (" {0} is maximal sequence of consecutive equal numbers in your input ", number12);











               Console.WriteLine("------------------------------ 13 ------------------");

// 13.	Write a program, which finds the most frequently occurring element in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} 4 (5 times). 


 int counter13 = 0, tempCounter = 1, appearance = 0;

            Console.Write("Enter the number of Element you want in this Array  ");
            int length13 = Int32.Parse(Console.ReadLine());

            int[] array13 = new int[length13];

            for (int i = 0; i < length13; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array13[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(array13);

            for (int i = 0; i < length13 - 1; i++)
            {
                if (array13[i] == array13[i + 1]) tempCounter++;
                else tempCounter = 1;
                if (tempCounter > counter13)
                {
                    counter13 = tempCounter;
                        appearance = array13[i];
                }
            }

            Console.WriteLine("{0} was found {1} times in the list of elements you entered.", appearance, counter13);








                Console.WriteLine("------------------------------ 14 ------------------");
                // 14.	Write a program that converts a decimal number to binary one. 

 Console.Write("Enter Decimal Number: ");
    int Decimal = Int32.Parse(Console.ReadLine());    
    string Binary = Convert.ToString(Decimal, 2);
    Console.WriteLine("Result is {0}", Binary);




                 Console.WriteLine("------------------------------ 15 ------------------");
// 15.	Write a program that converts a binary number to decimal one. 

                    Console.Write("Enter binary number: ");
    string Binumber = (Console.ReadLine());
    string BitoDecimal = Convert.ToString(Convert.ToInt32(Binumber, 2), 10);
    Console.WriteLine("Result is {0}", BitoDecimal);




                  Console.WriteLine("------------------------------ 16 ------------------");

  //16.	 Write a program that converts a decimal number to hexadecimal one


Console.Write("Enter decimal number: ");
    int decimalnum = Int32.Parse(Console.ReadLine());
    string HexaDecimal = Convert.ToString(decimalnum, 16);
    Console.WriteLine("Result is {0}", HexaDecimal);



                   Console.WriteLine("------------------------------ 17 ------------------");

//17.	Write a program that converts a hexadecimal number to decimal one.

Console.Write("Enter hexadecimal number: ");
  string hexaDecimal = (Console.ReadLine());
    string HexatoDecimal = Convert.ToString(Convert.ToInt32(hexaDecimal, 16), 10);
    Console.WriteLine("Result is {0}", HexatoDecimal);




                    Console.WriteLine("------------------------------ 18 ------------------");


// 18.	Write a program that converts a hexadecimal number to binary one. 


 Console.Write("Enter HexaDecimal Number: ");
    string HexaToBinary = (Console.ReadLine());    
    string BinaryResult = Convert.ToString(Convert.ToInt32(HexaToBinary, 16), 2);
    Console.WriteLine("Result is {0}", BinaryResult);






                     Console.WriteLine("------------------------------ 19 ------------------");


// 19.	 Write a program that converts a binary number to hexadecimal one. 


 Console.Write("Enter Binary Number: ");
    string BinaryToHexa = (Console.ReadLine());    
    string HexaResult = Convert.ToString(Convert.ToInt32(BinaryToHexa, 2), 16);
    Console.WriteLine("Result is {0}", HexaResult);




                      Console.WriteLine("------------------------------ 20 ------------------");


// 20.	Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. The size of the matrices will be read from the console. See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion: 
// A.	
// 1	5	9	13
// 2	6	10	14
// 3	7	11	15
// 4	8	12	16
// B.	
// 1	8	9	16
// 2	7	10	15
// 3	6	11	14
// 4	5	12	13
// C.	

// 7	11	14	16
// 4	8	12	15
// 2	5	9	13
// 1	3	6	10

 Console.WriteLine("------------------Matrix as shown in A ------------------------- ");
  Console.Write("How many column of matrix do you want : ");
            int qy = Int32.Parse(Console.ReadLine());

            Console.Write("How many row of matrix do you want : ");
            int qx = Int32.Parse(Console.ReadLine());

            int qa = 0;

            for (int qi = 1; qi <= qy; qi++)
            {
                Console.Write("{0} ", qi);

                qa += qi;

                for (int qj = 1; qj < qx; qj++)
                {
                    qa += qy;
                    Console.Write("{0} ", qa);                    
                }

                qa = 0;
                Console.WriteLine();
            }



        Console.WriteLine("------------------Matrix as shown in B---------------- ");
 Console.WriteLine("Enter matrix size: ");
            int matsize = Int32.Parse(Console.ReadLine());

            int[,] matarr = new int[matsize, matsize];
            matarr[0, 0] = 1;

            for (int abb = 1; abb < matarr.GetLength(0); abb++)
                if (abb % 2 == 1) matarr[0, abb] = matarr[0, abb - 1] + matsize * 2 - 1;
                else matarr[0, abb] = matarr[0, abb - 1] + 1;

            for (int abb = 1; abb < matarr.GetLength(0); abb++)
                for (int abc = 0; abc < matarr.GetLength(1); abc++)
                    if (abc % 2 == 1) matarr[abb, abc] = matarr[abb - 1, abc] - 1;
                    else matarr[abb, abc] = matarr[abb - 1, abc] + 1;

            for (int abb = 0; abb < matarr.GetLength(0); abb++)
            {
                for (int abc = 0; abc < matarr.GetLength(1); abc++) Console.Write("{0, 4}", matarr[abb, abc]);
                Console.WriteLine();
            }

    Console.WriteLine("----------------Matrix as shown in C ----------------");

Console.WriteLine("Enter Matrix size: ");
            int Length20 = Int32.Parse(Console.ReadLine());

            int[,] matArray = new int[Length20, Length20];
            matArray[Length20 - 1, 0] = 1;
            int counter20 = 1;
            for (int Row = Length20 - 2; Row >= 0; Row--)
            {
                matArray[Row, 0] = matArray[Row + 1, 0] + counter20;
                int newRow = Row;
                for (int diagonal = 1; diagonal <= counter20; diagonal++)
                {
                    matArray[newRow + 1, diagonal] = matArray[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter20++;
            }

            matArray[0, Length20 - 1] = Length20 * Length20;
            int diagonalLength = 2;
            int posX = 1;
            int posY = Length20 - 1;
            int prevX = 0;
            int prevY = Length20 - 1;

            for (int qbi = 1; qbi < counter20 - 1; qbi++)
            {
                for (int qbj = 1; qbj <= diagonalLength; qbj++)
                {
                   matArray[posX, posY] =matArray[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = qbi + 1;
                posY = Length20 - 1;
            }

            for (int qbi = 0; qbi < matArray.GetLength(0); qbi++)
            {
                for (int qbj = 0; qbj < matArray.GetLength(1); qbj++) Console.Write("{0, 4}",matArray[qbi, qbj]);
                Console.WriteLine();
            }