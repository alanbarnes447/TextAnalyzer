
//This is a class that implements a linked List data structure

using System;
using System.Collections.Generic;
//using System.delegate;

namespace DataStruct {


///////////////////////////////////////////////////
//Class for creating a linkedList data structure
///////////////////////////////////////////////////

    public class abLinkedList<T> { 
      private node<T> firstNode;
      private int numNodes;
      private node<T> lastNode;

      /////////////////////////////////
      //Constructor fo the linked list
      /////////////////////////////////
      public abLinkedList(T value) {
          clearList();
           firstNode = new node<T>(value);
           lastNode = firstNode;
           numNodes = 0;
      }

            public abLinkedList() {
          clearList();
           numNodes = 0;
      }



      

      ///////////////////////////////////////////////
      //Methods for the linked list
      ///////////////////////////////////////////////
      //end of linked list is marked by nextNode == null

      //Method to add a new node to the end of the list
      public void add(T value)
      {addLast(value);}

      public void add(T value1, T value2)
      {addLast(value1, value2);}

      public void add(T value1, T value2, T value3)
      {addLast(value1, value2, value3);}



      //replace a node with a new Node
      public void changeNode(T value, int index) {
          addAtIndexValue(value, index);
      }

      //Method to remove the last node in the list
      //if list is empty throws exception
      public void remove() 
      {removeLast();}

      //remove a node at a given index value
      //throws an exception if value is < numNodes
      public void remove(int value)
      {removeAtIndexValue(value);}

      //remove a node from a given value
      //throws an exception if value is not in the list
      public void removeValue(T value)
      {removeAtValue(value);}

      //get a node value at a specified index
      //Returns null if the index is >= numNodes
      public T getValue(int index) {
          T nodeValue = getValueAt(index);
          return nodeValue;
      }

      public T getValue2(int index) {
          T nodeValue = getValue2At(index);
          return nodeValue;
      }

      public T getValue3(int index) {
          T nodeValue = getValue3At(index);
          return nodeValue;
      }

      //Get the first node in a list from a nodes value
      //returns null if the node is not found
      public node<T> getValue(T value) {
          node<T> currentNode = getNodeFromValue(value);
          return currentNode;
      }

      public T getNodeValue3(node<T> n) {
          T value = n.nodeValue3;
          return value;
      }

      //Return a node at a specified index
      //Returns null if the index is >= numNodes
      public node<T> GetNode(int index) {
          node<T> aNode = getNodeAt(index);
          return aNode;
      }



      //Method to find if a list contains a certain value
      public bool contains(T value)
      {return containsValue(value);}

      //Find the index of a node from a value
      //if the value is not found, this method returns -1
      public int findNodeIndex(T value)
      {return getNodeIndex(value);}
    
      //Returns true if the list is empty
      public bool isEmpty() {
        bool empty = false;
        getStatusOfList(empty);
        return empty;
      }

      //public string[] getAllValues() 
      //{return  printNodeValue();}

      //public void GetFrequencyOf(T anEntry);
      //public void getReferenceTo(T anEntry);








      ///////////////////////////////////////
	  //Implementation of linked List Methods
	  ///////////////////////////////////////

      //Method to clear an existing linked list
      //Set first and last node to null to effectively clear the node
      //set numNodes to 0
      private void clearList() {
          firstNode = null;
          lastNode = null;
          numNodes = 0;
      }

      private bool getStatusOfList(bool empty) {
          if (firstNode == null) {
            empty = true;
          }
          return empty;
      }

      //Method to add a new node to the end of a linked list
      //Add boolean return to tell if method was successfull
      private bool addLast(T value) {

          node<T> aNode = new node<T>(value);
          //aNode.nodeValue = value;

          //If this is the first node in the list, initialize the first node to this node
          if(firstNode == null || firstNode.nodeValue == null) {
              firstNode = aNode;
              firstNode.nextNode = null;
              lastNode = aNode;
              numNodes++;
          } else {
              lastNode.nextNode = aNode;
              lastNode = aNode;
              numNodes++;
          }
          return true;
      }

          //method to add multiple values inside of node
          //possible changing input values to array
          private bool addLast(T value1, T value2) {

          node<T> aNode = new node<T>(value1, value2);
          //aNode.nodeValue = value1;

          //If this is the first node in the list, initialize the first node to this node
          if(firstNode == null || firstNode.nodeValue == null) {
              firstNode = aNode;
              firstNode.nextNode = null;
              lastNode = aNode;
              numNodes++;
          } else {
              lastNode.nextNode = aNode;
              lastNode = aNode;
              numNodes++;
          }
          return true;
      }

          private bool addLast(T value1, T value2, T value3) {

          node<T> aNode = new node<T>(value1, value2, value3);
          //aNode.nodeValue = value1;

          //If this is the first node in the list, initialize the first node to this node
          if(firstNode == null || firstNode.nodeValue == null) {
              firstNode = aNode;
              firstNode.nextNode = null;
              lastNode = aNode;
              numNodes++;
          } else {
              lastNode.nextNode = aNode;
              lastNode = aNode;
              numNodes++;
          }
          return true;
      }


      public void addToList(T value1, T value2, int index) {

    //       if (lastNode.GetType() == typeof(abLinkedList<T>)) {
    //          lastNode.addLast(value);
    //          Console.WriteLine("1");
    //       }

    //       node<T> aNode = new node<T>(value1, value2);
    //       //aNode.nodeValue = value1;

    //       //If this is the first node in the list, initialize the first node to this node
    //       if(firstNode == null) {
    //           firstNode = aNode;
    //           firstNode.nextNode = null;
    //           lastNode = aNode;
    //           numNodes++;
    //       } else {
    //           lastNode.nextNode = aNode;
    //           lastNode = aNode;
    //           numNodes++;
    //       }
    //       return true;
      }


      //Method to add node at a specified index
      private void addAtIndexValue(T value, int index) {
          node<T> currentNode = getNodeAt(index - 1);
          node<T> nxtNode = getNodeAt(index + 1);
          node<T> newNode = new node<T>(value, nxtNode);
          currentNode.nextNode = newNode;
          newNode.nextNode = nxtNode;
          numNodes++;
      }


////////////////////////////////////////////////////////////////////
    //   public void addToSubList(T value1, T value2, int index) {
    //       node<T> n = getNodeAt(index);
    //       n.nodeValue.addLast(value1, value2);
    //   }
///////////////////////////////////////////////////////////////////////





      //Method to remove a node at a specified index value
      private void removeAtIndexValue(int index) {
          if (index < numNodes) {
              node<T> currentNode = getNodeAt(index - 1);
              node<T> nxtNode = getNodeAt(index + 1);
              currentNode.nextNode = nxtNode;
              numNodes--;
          } else {
              throw new Exception("Node RemoveAtIndexValue Exception");
          }
      }

      //Method to remove a node at a specified value
      private void removeAtValue(T value) {
          node<T> previousNode = null;
          node<T> currentNode = firstNode;
          bool found = false;
          if (containsValue(value)) {
              if (firstNode != null) {
                  //(currentNode.nodeValue == value)
                  if (EqualityComparer<T>.Default.Equals(currentNode.nodeValue , value))  
                  {found = true;}
                  //((found == false) && (currentNode.nodeValue != value) && (currentNode != null))
                  while ((found == false) && (!EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value)) && (currentNode != null)) {
                      previousNode = currentNode;
                      currentNode = currentNode.nextNode;
                      //(currentNode.nodeValue == value)
                      if(EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value))
                      {found = true;}
                  }
              }
              if (currentNode != null) {
                  previousNode.nextNode = currentNode.nextNode;
                  numNodes--;
              }
          } else {
              throw new Exception();
          }
      }

      //Method to remove the last node in the list
      private void removeLast() {
          if (!isListEmpty()) {
              node<T> currentNode = getNodeAt(numNodes - 1);
              currentNode.nextNode = null;
              lastNode = currentNode;
              numNodes--;
          } else {
              throw new Exception();
          }
      }

      //Method to retrieve a node at a specified index
      private T getValueAt(int index) {
          if (index < numNodes) {
              node<T> currentNode = getNodeAt(index);
              T value = currentNode.nodeValue;
              return value;
          }
          return default(T);
      }

      private T getValue2At(int index) {
          if (index < numNodes) {
              node<T> currentNode = getNodeAt(index);
              T value = currentNode.nodeValue2;
              return value;
          }
          return default(T);
      }

      private T getValue3At(int index) {
          if (index < numNodes) {
              node<T> currentNode = getNodeAt(index);
              T value = currentNode.nodeValue3;
              return value;
          }
          return default(T);
      }

      //Method to retrieve the first node from a specified value
      private node<T> getNodeFromValue(T value) {
          node<T> currentNode = firstNode;
          bool found = false;
          if (firstNode != null) {
              //((found == false) && (currentNode.nodeValue != value) && (currentNode != null))
              while ((found == false) && (!EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value)) && (currentNode != null)) {
                  currentNode = currentNode.nextNode;
                  if (!EqualityComparer<T>.Default.Equals(currentNode.nodeValue , value))  //(currentNode.nodeValue == value)
                  {found = true;}
              }
          }
          if (found)
          {return currentNode;}
          return null;
      }

      //Method to return a node at a specified index
      private node<T> getNodeAt(int index) {
          if (index < numNodes) {
              node<T> currentNode = firstNode;
              for (int i = 0; i < index; i++)
              {currentNode = currentNode.nextNode;}
              return currentNode;
          }
          return null;
      }

      //Method to determine if linked list contains an item
      private bool containsValue(T value) {
          node<T> currentNode = firstNode;
          bool found = false;
          if (firstNode != null) {
              //(currentNode == value)
              if (EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value))
              {found = true;}
              //((found == false) && (currentNode.nodeValue != value) && (currentNode != null))
              while ((found == false) && (!EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value)) && (currentNode != null)) {
                  currentNode = currentNode.nextNode;
                  //(currentNode.nodeValue == value)
                  if (EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value))
                  {found = true;}
              }
          }
          return found;
      }

      //Method to find out if linked list is empty
      private bool isListEmpty() {
          bool isEmpty = true;
          if (firstNode != null)
          {isEmpty = false;}
          return isEmpty;
      }

      //Method to retrieve the index value for a specified value for a node
      public int getNodeIndex(T value) {
          int i = 0;
          node<T> currentNode = firstNode;
          bool found = false;
          if (firstNode != null) {
              //(currentNode == value)
              if (EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value))
              {found = true;}
              //((found == false) && (currentNode.nodeValue != value) && (currentNode != null))
              while ((found == false) && (!EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value)) && (currentNode != null)) {
                  currentNode = currentNode.nextNode;
                  i++;
                  //(currentNode.nodeValue == value)
                  if (EqualityComparer<T>.Default.Equals(currentNode.nodeValue, value))
                  {found = true;}
              }
          }
          if (found == false)
          {i = -1;}
          return i;
      }

    //   public void printNodeValue() {
    //       //LinkedList<string> values;
    //       int i = 1;
    //       node<T> currentNode = firstNode;
    //       while (currentNode != null) {
    //           Console.WriteLine(i + ":  " + currentNode.nodeValue + " * " + currentNode.nodeValue2); 
    //           currentNode = currentNode.nextNode;
    //           Console.ReadLine();
    //           i++;
    //       }
    //       //return values;
    //   }


 
    public class node<T> {
        //value for the node
        public T nodeValue;
        public T nodeValue2;
        public T nodeValue3;

         //Link to the next node in the list
        public node<T> nextNode;

        //Constructor for node class
        public node(T value) {
            nodeValue = value;
        }

            public node(T value, node<T> next) {
            nodeValue = value;
            nextNode = next;
        }

            public node(T value, T value2) {
            nodeValue = value;
            nodeValue2 = value2;
        }

            public node(T value, T value2, T value3) {
            nodeValue = value;
            nodeValue2 = value2;
            nodeValue3 = value3;
        }
            public node(T value, T value2, node<T> next) {
            nodeValue = value;
            nodeValue2 = value2;
            nextNode = next;
        }

          public void setNodeValue3(T value) {
          //node<T> aNode = getNodeAt(index);
          nodeValue3 = value;
      }

        //get and set methods
    }


    }
      



    //nested node class



         //iterator for linked list


        //  public Iterator<ThreadStaticAttribute> iterator() {
        //      return new Iterator<T>() {
        //          node currentNode = firstNode;

        //          @override
        //          public boolean hasNext() {

        //          }
        //      }
        //  }
}





