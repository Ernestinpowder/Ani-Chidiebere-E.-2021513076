#include<iostream>
using namespace std;
{
   class project
   {
    static void main(sting[] args)
    {
    //Qestion 1a: Delcare an array of list of Phones

    string[] phones - {"iphone","samsung","redmi","oppo","infinix"};

    //accessing the array
    
    console.writeline(phones[0]);
    console.writeline(phones[1]);
    console.writeline(phones[2]);
    console.writeline(phones[3]);
    console.writeline(phones[4]);

    //Qestion 1b: Declaring and intializing a two dimentional array

    //Declaring the array with dimention

    sting[] electronics =new string{2};

    //assigning values to the array

    electronics[0] = "television";
    electronics[1] = "refregirator";
    electronics[2] = "microwave";
    electronics[3] = "music system";

    // you can also access the array

    console.writeline(electronics[2]);

    //Qestion 1c: Tranversing array
    //tranversing an array of phones above

    for (int i =0; i <phones.length; i++)
    {

    console.writeline(phones[i]);
  
     }

    //Qestion 1d: concatinating and array
    //concatinating the arrays of phones and electronics above

    string[] join_array - phones.Union(electronics).toarray();
    PrintArray(numbers);

     console.Readkey();

}

     //creating a method that will help print concatinated array

     private static void printArray(string[] join_array)
    {
         foreach (var item in join_array)
         {
          console.write(item);
       }

     }
  }
}







