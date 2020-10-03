using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //============================= STEP 245 ASSIGNMENT =============================
            Console.Write("===================================== STEP 245 ASSIGNMENT =====================================\n\n");

            List<Employee> all = new List<Employee>();

            all.Add(new Employee(ID: 100, firstName: "Joe", lastName: "Gibbs"));
            all.Add(new Employee(ID: 101, firstName: "Steve", lastName: "Hilton"));
            all.Add(new Employee(ID: 102, firstName: "Heidi", lastName: "Hilton"));
            all.Add(new Employee(ID: 103, firstName: "Vince", lastName: "Hilton"));
            all.Add(new Employee(ID: 104, firstName: "Drew", lastName: "Hilton"));
            all.Add(new Employee(ID: 105, firstName: "Kirk", lastName: "Hilton"));
            all.Add(new Employee(ID: 106, firstName: "Rob", lastName: "Hilton"));
            all.Add(new Employee(ID: 107, firstName: "Joe", lastName: "Montana (not Biden)"));
            all.Add(new Employee(ID: 108, firstName: "Dave", lastName: "Hilton"));
            all.Add(new Employee(ID: 109, firstName: "Jeff", lastName: "Hilton"));

            List<Employee> joes = new List<Employee>();

            foreach (Employee x in all)
            {
                if (x.firstName == "Joe")
                {
                    Console.WriteLine(x.firstName + " " + x.lastName);
                    joes.Add(x);
                }               
            }

            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe);
            }

            Console.ReadLine();
            
            



            //foreach (string person in list1)
            //{

            //}



        }
    }
}

//===============================================================================================================================================================

//LAMBDA EXPRESSIONS ARE:
//HARD TO DEBUG
//CAN'T STEP THROUGH LAMBDA EXPRESSIONS UPON EACH LOOP OF THE CODE
//TOO MUCH LOGIC IN ONE LONG LAMBDA EXPRESSION CAN GET VERY COMPLICATED TO READ/UNDERSTAND

////======================================== SNIPPET ========================================
////HOW TO CHECK HOW MANY OF A CERTAIN CARD EXISTS IN THE DECK (TEDIOUS TO WRITE AND NOT AS EASY TO READ, ALSO NOT AS FAST WHEN IT RUNS)
//int counter = 0;
//foreach (Card card in deck.Cards)
//{
//    if (card.Face == Face.Ace)
//    {
//        counter++;
//    }
//}
//Console.WriteLine(counter);
////====================================== END SNIPPET ======================================


////======================================== SNIPPET ========================================
////HOW TO WRITE THE ABOVE CODE USING A LAMBDA FUNCTION INSTEAD
//int count = deck.Cards.Count(x => x.Face == Face.Ace); //THE LAMBDA SIGN '=>' CAN BE READ ALOUD SAYING "WHERE" OR "EVALUATE AND DO THE FOLLOWING THINGS TO EACH ITEM TO THE LEFT SIDE"
//Console.WriteLine(count);

////USING A LAMBDA FUNCTION ON A LIST OF CUSTOM OBJECTS
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //TAKE THE NEW LIST OF CARDS AND FIND OUT WHERE THE FACE IS EQUAL TO KING AND MAP THEM TO A NEW LIST (SHOULD SHOW JUST KINGS IN THE LIST)

//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}
////====================================== END SNIPPET ======================================


////======================================== SNIPPET ========================================
////USING A LAMBDA ON A LIST OF INTEGERS
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
////------------ A FEW DIFFERENT LAMBDA FUNCTION EXAMPLES ON TYPE 'List<int>'
////int sum = numberList.Sum();
////int sum = numberList.Sum(x => x + 5); //ADDS MORE SPECIFICS TO WHAT TO DO WHEN ADDING
////int sum = numberList.Max(); //GETS THE MAXIMUM VALUE IN THE LIST OF INTEGERS
////int sum = numberList.Min(); //GETS THE MINIMUM VALUE IN THE LIST OF INTEGERS
//int sum = numberList.Where(x => x > 20).Sum(); //THIS CHAINS TWO LAMBDA FUNCTIONS TOGETER (BASICALLY CONCATENATES THEM). 'Where()' CREATES A NEW LIST

//Console.WriteLine(sum);
//====================================== END SNIPPET ======================================



//===============================================================================================================================================================

////CONTROL VARIABLE
//bool executing = true;

//            //ENTER DO-WHILE LOOP (FOR EASE OF TESTING PROGRAM)
//            do
//            {
//                //THE CODE I WANT TO WORK
//                try
//                {
                   
//                    //USER INSTRUCTIONS 
//                    Console.WriteLine("\n\tWELCOME, YOU ARE NOW ATTEMPTING TO ENTER THE ONLINE EMPLOYEE PORTAL. " +
//                        "\n\n============================================ START ============================================" +
//                        "\n\n\tPLEASE FILL OUT THE FOLLOWING:");
//                    //GET USER INPUT FOR FIRST NAME 
//                    Console.Write("\n" +
//                        "\tFIRST NAME: ");
//                    string first = Console.ReadLine();

//////GET USER INPUT FOR LAST NAME
//Console.Write("\n" +
//                        "\tLAST NAME: ");
//                    string last1 = Console.ReadLine();

////GET USER EMPLOYEE ID
//Console.Write("\n" +
//                        "\tEMPLOYEE ID: ");
//                    int Id1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("\n\t=======================================================================================" +
//                        "\n\n\tFOR VERIFICATION PURPOSES, PLEASE ENTER YOUR EMPLOYEE ID AGAIN: ");

//                    //VERIFY USER EMPLOYEE ID 
//                    Console.Write("\n" +
//                        "\tEMPLOYEE ID: ");
//                    int Id2 = Convert.ToInt32(Console.ReadLine());

////INSTANTIATE AND INITIATE 'Employee' OBJECTS
//all.Add(new Employee());
//all.Add(new Employee());

//employee1.Id = Id1;
//                    employee2.Id = Id2;

//                    //CALL SUPERCLASS METHOD 'FullName' ON THE 'Employee' OBJECTS
//                    employee1.employeeInfo(Id: Id1, FirstName: first, Info: out string Full1, LastName: last1);
//                    employee2.employeeInfo(Id: Id2, FirstName: first, Info: out string Full2, LastName: last1);

//                    //CONDITION TO BE CHECKED BASED UPON EMPLOYEE ID 
//                    if (employee1 != employee2)
//                    {
//                        Console.WriteLine("\n\tEMPLOYEE ID: " + Id2 + " DID NOT MATCH!" +
//                            "\n\n\tPLEASE CHECK YOUR EMPLOYEE ID CAREFULLY AND TRY AGAIN\n");
//                    }
//                    else
//                    {         
//                        Console.WriteLine("\n\tYOUR EMPLOYEE ID HAS BEEN VALIDATED!\n");
//                    }
//                }

//                //================ EXCEPTION HANDLING ================              
//                //WRONG FORMAT CATCH
//                catch (FormatException ex)
//                {
//                    Console.WriteLine("\n\tTISK TISK, WRONG FORMAT!!! " +
//                        "\n\n\t   - TEXT NOT ALLOWED. " +
//                        "\n\n\t   - WHOLE NUMBERS ONLY. " +
//                        "\n\n\t   - NULL IS NOT ACCEPTABLE EITHER." +
//                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
//                    Console.ReadLine();
//                }
//                //GENERAL CATCH IF TOO LARGE OF OR TOO SMALL OF AN INTEGER WERE ENTERED
//                catch (Exception ex)
//                {
//                    Console.WriteLine("\n\tEASY DOES IT THERE!!!" +
//                        "\n\n\t   - YOUR " + ex.Message.ToUpper() +
//                        "\n\n\t   - NOT TOO BIG." +
//                        "\n\n\t   - NOT TOO NEGATIVE." +
//                        "\n\n\t   - NICE AND EASY." +
//                        "\n\n\t(PRESS ENTER TO LEAVE THE TRY-CATCH BLOCK)");
//                    Console.ReadLine();
//                }
//                //INSTRUCTIONS TO USER
//                finally
//                {
//                    //PROGRAM NOTE   
//                    Console.Write("======================================== END TRY/CATCH ========================================\n" +
//                        "\n\t                 ---- (PRESS ENTER TO RUN AGAIN) ----\n\n" +
//                        "\t\t\t\t            OR\n\n" +
//                        "\t\t        XXX (PRESS \'X\' TO EXIT THE PROGRAM) XX");

//                    string exit = Console.ReadLine();
//Console.WriteLine("\n===============================================================================================");
//                    //OPTION TO EXIT WITH CONTROLLED CASE SENSITIVITY
//                    if ((exit == "x") || (exit == "X"))
//                    {
//                        executing = false;
//                    }
//                }
//            }
//            while (executing);

//            //EXIT PROGRAM INFO
//            Console.WriteLine("\n\tTHANK YOU FOR USING THE \"STEP 245 ASSIGNMENT\" PROGRAM" +
//                "\n\n\t(PRESS ENTER TO CLOSE THE WINDOW)\n");
//            Console.ReadKey(true);
//        }