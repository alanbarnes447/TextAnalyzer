//abParse.cs is an object class that when initialized, makes an object that
//takes a special character as input and treats that character as a bracket
//In addition, a start sequence of characters can be specified
//and an end sequence of characters can be specified

//method will be used to break up a file into logical sections that can
//be further processed by this class

//input:
//specified file as TXT
//string linked list of nested start delineators
//string linked list of corresponding nested end delineators
//input number of times used or untill end of file

using System;
using System.Collections.Generic;
using System.IO;
using DataStruct;



namespace abParseFile {


public class abParse {
  private string filepath;
  private string fileName;
  int numOfLines;
  int numOfDeliminators;
  abLinkedList<abLinkedList<string>> abDelimList; //Data structure to hold info
  private string[] fileContents;  //Array to hold the contents of the file, 1 index per line
  private List<int> ListStatus;

  //private abTreeDataStructure<T> abTree;


  //constructor for the abParse() class
  public abParse(string fPath, string fName) {
      filepath = fPath;
      fileName = fName;
      numOfLines = 0;
      numOfDeliminators = 0;
      //Initialize data structure
      abDelimList = new abLinkedList<abLinkedList<string>>();
  }

    //Set the filename for the document needing parsing
  public void setFileName(string fname) {
      fname = fileName;
  }

  public string getPath() {
    return filepath;
  }

  public void addDelimList() {
    //Create lists and add them to the main list container Data structure
    abLinkedList<String> newList = new abLinkedList<string>(null);
    abDelimList.add(newList);
  }
  
  //Method to add delimiters takes a start delim and end delim
  public void addDeliminators(string d1, string d2, int index) {
    //add a node to a specified list in the list
    abLinkedList<abLinkedList<String>>.node<abLinkedList<String>> n = abDelimList.GetNode(index);
    abLinkedList<string> lst = n.nodeValue;
    lst.add(d1, d2);
  }

  public void addTxtInfoToNode(string txt, int index1, int index2) {
      //get node in first list per index value
      abLinkedList<abLinkedList<String>>.node<abLinkedList<String>> n = abDelimList.GetNode(index1);
      //get list in node
      abLinkedList<string> lst = n.nodeValue;
      abLinkedList<String>.node<String> nn = lst.GetNode(index2);
      nn.setNodeValue3(txt);
  }



  // LinkedList<string> lst, bool continueTolLookForInfo
  //function called to commence parsing of the document
  public void parse_document() {
    readFile();
    //Console.WriteLine(fileContents.Length);
    for (int i = 0; i < fileContents.Length; i++) {
        //pickout words and test each character against only 1st deliminator in each list
        //search entire line for content of each 1st start deliminator
      

    }
  }







  //Read contents of file and add each line to a new array index
  public void readFile() {
      LinkedList<string> licInfo = new LinkedList<string>();
      // if ()
      // {
      string fpth = this.filepath;
        try
        {
          using (StreamReader file = new StreamReader(fpth))
          {
            int count = 0;
            string lineOfText = file.ReadLine();
            while (lineOfText != null)
            {
              licInfo.AddLast(lineOfText);
              //Console.WriteLine(lineOfText);
              lineOfText = file.ReadLine();
              count++;
              numOfLines++;
            }
            file.Close();

          }

          //Print out the second line in the file that is read
          if(licInfo.Count > 0)
          {
            fileContents = new string[licInfo.Count + 1];
            licInfo.CopyTo(fileContents, 0);
            // Console.WriteLine(info[2]);
          }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("Done");
        // finally
        // {
        //     Console.WriteLine("finally Code");
        // }
      // }
  }




      public void printDelimiters(int index1, int index2) {
  //         // while (currentNode != null) {
  //         //     WriteLine(currentNode.value + " , " + currentNode.value2); 
  //         // }
  //         // return values;
  //         //abDelimList.printNodeValue();
          //Console.WriteLine(abDelimList.GetNode(0).GetType());
    //get 1st node 
    abLinkedList<abLinkedList<String>>.node<abLinkedList<String>> n = abDelimList.GetNode(index1);
    //get list in 1st node
    abLinkedList<string> lst = n.nodeValue;
    //get values of nodes in list at value index
    string d = lst.getValue(index2);
    string d2 = lst.getValue2(index2);
    string d3 = lst.getValue3(index2);
    Console.WriteLine("Value1: " + d + ", Value2: " + d2 + ", Value3: " + d3);
  }
  

  /*

  public void printDelimiters() {
    // //Print out all of the start delineators
    // Console.WriteLine("Start Delineators");
    // printDelimitersR(startDelineator);
    // //print out all of the end delimiters
    // Console.WriteLine("End Delineators");
    // printDelimitersR(endDelineator);
    Console.WriteLine(startDelineator.GetType());
    Console.WriteLine("Start Deliminators");
    foreach (var sublist in delineators) {
      foreach (var item in sublist) {
         Console.WriteLine(item);
         //Console.WriteLine("somthing is {0} and something is {1}", Array.x, Array.y);
      }
    }
    // Console.WriteLine("End Deliminators");
    // foreach (var sublist in endDelineator) {
    //   foreach (var item in sublist) {
    //      Console.WriteLine(item);
    //      //Console.WriteLine("somthing is {0} and something is {1}", Array.x, Array.y);
    //   }
    // }
  }

  */






  // recursive solution to iterating data structure
  // static void printDelimitersR(List<string> delim) {
    
  //     foreach (var x in delim) {
  //       if (x.GetType() == typeof(List<string>)) {
  //          Console.WriteLine("List");
  //          printDelimitersR(delim);
  //       } else if (x.GetType() == typeof(string)) {
  //          Console.WriteLine("String");
  //       Console.WriteLine(x);
  //       }
        
  //     }
  //     //Console.WriteLine("somthing is {0} and something is {1}", Array.x, Array.y);

  // }
  


}
}
