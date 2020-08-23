//This is a class that implements a tree data structure

using System;
using System.Collections.Generic;
//using System.delegate;

namespace DataStruct {


///////////////////////////////////////////////////
//Class for creating a tree data structure
///////////////////////////////////////////////////
//delegate is pointer to a function
//delegate void TreeIterator<T>(T nodeData);

    public class abIntTree {
        Node top;
        //private LinkedList<abTree<T> children;

        //constructor for class, empty tree
        public abIntTree() {
            //initialize both variables
            top = null;
        }

        //constructor for class, initialize root
        public abIntTree(int initial) {
            top = new Node(initial);
        }

        public void Add(int value) {
            //non-recursive add
            //tree is empty
            if (top ==null) {
              //Add item as the base node
              Node NewNode = new Node(value);
              top = NewNode;
              return;
            }
            Node currentnode = top;
            bool added = false;
            do {
              //treverse tree
              //compare value being added to current node value
              //look at left node 1st
              if (value < currentnode.value) {
                //if value is less, go left
                if (currentnode.left == null) {
                  //add the item if node is null (not set)
                  Node NewNode = new Node(value);
                  currentnode.left = NewNode;
                  added = true;
                } else {
                  //next iteration of loop will move current node down
                  currentnode = currentnode.left;
                }
              }

              //look at right node
              if (value >= currentnode.value) {
                if (currentnode.right == null) {
                  Node NewNode = new Node(value);
                  currentnode.right = NewNode;
                  added = true;
                } else {
                  //next iteration of the loop will move current node down
                  currentnode = currentnode.right;
                }
              }

            } while (!added);
        } //end of non-recursive version of add


        public void AddRc(int value) {
            //recursive add
            AddR(ref top, value);
        }

        private void AddR(ref Node N, int value) {
            //private recursive search for where to add the new node
            //enter here if at a null node after recursing
            if (N == null) {
              //node doesn't exist, add it here
              Node NewNode = new Node(value);
              //set the old Node reference to te new node which attaches it to the tree
              N = NewNode;
              //end the function call and fall back
              return;
            }

            //enter here if not yet at a null node
            //this tells to start recursing to the left
            if (value < N.value) {
              AddR(ref N.left, value);
              return;
            }

            //this tells to start recursing to the right
            if (value >= N.value) {
              AddR(ref N.right, value);
              return;
            }

        } //end of recursive add function


        public void Print(Node N, ref string s) {
            //write out the tree  in sorted order to the string newstring
            //implement using recursion

            //if N is null N is Top, stop case
            if (N == null)
            {N = top;}

            //if left node is not null, print the node contents
            if (N.left != null) {
              Print(N.left, ref s);
              s = s + N.value.ToString().PadLeft(3);
            } else {
              s = s + N.value.ToString().PadLeft(3);
            }

            if (N.right != null) {
              Print(N.right, ref s);
            }
        }
      

        // public abTree<T> GetChild(int i) {

        // }

        public void Traverse() {

            }
        }


    /////////////////////////////////////////////////////
    //Class for creating a node for a tree data structure
    /////////////////////////////////////////////////////

    public class Node {
        public int value;
        public Node left;
        public Node right;
        public String OuterDelim;
        public String innerDelim;


        // T root;
        // T leftChild;
        // T rightChild;
        // T parent;

        public Node(int initial) {
            value = initial;
            left = null;
            right = null;
            OuterDelim = null;
            innerDelim = null;

        }

                public Node(int initial, String OuterDelim, String innerDelim) {
            value = initial;
            left = null;
            right = null;
            this.OuterDelim = OuterDelim;
            this.innerDelim = innerDelim;
        }

    }





}

 