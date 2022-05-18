// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Variable explanation.
// What is a variable?
// named objects / values that can change
// variables are names objects with values and types
// built-in types: string, int, double, boolean
// string - text, int - whole numbers, double - decimals, booleans - true/false


// variable declaration is creating a variable
// variableType variableName;
string instructor; // this variable is 'null' (has no value)

// variable assignment is giving a variable a value
// variableName = value;
instructor = "davis";  // instructor has a value of davis (setting a variable)
instructor = "gavin";

Console.WriteLine(instructor);


// instructor has a value of gavin

// variable declaration AND assignment
// variableType variableName = value;
string coInstructor = "davis";
int studentCount = 8;

// declaring a variable and assinging it to the value the user types in the console
string input = Console.ReadLine();

Console.WriteLine(input);

// operators are ways that we can manipulate values / variables
// example: addition (+)
// 5 + 5
//  10
decimal num = 5 + 5; //10
Console.WriteLine(num);
    num = 5 * 5; // 25
    num = 5 / 5; // 1
    num = 5 / 3.0M; // 1.66666666667 ---> 1


// visual variable type cues
// quotes "" ---> string          "hello"
// d,D,  .0 ---> double           3d 3.0
// f,F ---> float                 3f 3.0f
// m,M ----> decimal              3m 3.0m
// true,false ---> boolean        true false
// number ---> int                3 2 1
// single quotes ' ' ----> char   'c'  's'

