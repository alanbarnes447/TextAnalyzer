using System;
using System.Collections.Generic;
using abParseFile;
using DataStruct;
//need to create test.txt ahead of time in path

namespace ReadLicenceFiles
{
    class Program
    {
    
        static void Main(string[] args)
        {
        //define the path that for the file to read
        string path = "C:\\CS\\test.txt";
        string fName = "test.txt";

        //define new parsing object
        //
        abParse getCode = new abParse(path, fName);

        //Define 1st deliminator set
        string delim1 = ";";
        string delim2 = ";";
        //final product will take in String characters
        //Add start and end deliminators to object
        // //Add("start delimiter", "end Delimiter", Outer List Index)
        //getCode.addDeliminators(delim1, delim2, 0);
 
        //initialize the lists that hold the nodes
        getCode.addDelimList();
        getCode.addDelimList();
        getCode.addDelimList();
        getCode.addDelimList();



        //Method to add Delimiters to the nodes of the lower lists
        //addDeliminators(string value1, string value2, list number index of main data structure)
        getCode.addDeliminators("Users", ")", 0);
        getCode.addDeliminators("jnorman", "17:39", 0);

        getCode.addDeliminators("bb", "DD", 1);
        getCode.addDeliminators("ff", "DD", 1);

        getCode.addDeliminators("cc", "DD", 2);
        getCode.addDeliminators("gg", "DD", 2);

        getCode.addDeliminators("dd", "DD", 3);
        getCode.addDeliminators("hh", "DD", 3);



        //do the parsing to the document to find the values
        getCode.parse_document();

        //Console.WriteLine(getCode.getPath());
        Console.ReadLine();

        // Write out test for path
        string p = getCode.getPath();  //get path from object
        Console.WriteLine(p);  //write path


        //Text to add is in comma separated list
        getCode.addTxtInfoToNode("This is the text- 0, 0", 0, 0);
        getCode.addTxtInfoToNode("This is the text- 01", 0, 1);
        getCode.addTxtInfoToNode("This is the text- 10", 1, 0);
        getCode.addTxtInfoToNode("This is the text- 11", 1, 1);
        getCode.addTxtInfoToNode("This is the text- 20", 2, 0);
        getCode.addTxtInfoToNode("This is the text-21", 2, 1);
        getCode.addTxtInfoToNode("This is the text-30", 3, 0);
        getCode.addTxtInfoToNode("This is the text-31", 3, 1);

        //getCode.printDelimiters();
        Console.ReadLine();    //pause

        //method to print out the values in each node
        //printDelimiters(Upper List of Lists, Lower List of nodes)
        getCode.printDelimiters(0,0);
        getCode.printDelimiters(0,1);
        getCode.printDelimiters(1,0);
        getCode.printDelimiters(1,1);
        getCode.printDelimiters(2,0);
        getCode.printDelimiters(2,1);
        getCode.printDelimiters(3,0);
        getCode.printDelimiters(3,1);

        


        //return 0;
        //Console.WriteLine("Hello World!");
        }
   


  }
  

}
