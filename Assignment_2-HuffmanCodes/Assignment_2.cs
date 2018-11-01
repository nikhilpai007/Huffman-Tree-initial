﻿/* 
 * COIS 2020 - Data Structures and Algorithms, Trent Univerisity Fall 2018 
 * Assignment 2
 * Done by: Nikhil Pai Ganesh - 0595517 
 *          Anuj Arora - 0594437
 * Description: Use of Huffman Tree in building a C# program 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_HuffmanCodes
{
    class Assignment_2
    {
        static void Main(string[] args)
        {
            Console.Write("Hello,World!");
        }
    class Node : IComparable
        {
            public char Character { get; set; }
            public int Frequency { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        public Node (char character, int frequency, Node left, Node right)
            {

                //Leaf 
                if (Right == null && Left == null)
                {
                    if (character.Equals(this.Character))
                    {
                        return Data;
                    
                    }
                    else
                    {
                        return null; 
                    }
                }
                else
                {
                    Node left = null;
                    Node right = null;

                    if (Left != null)
                    {
                        Node leftPath = new Node;
                        leftPath.AddRange(data);
                        leftPath.Add(false);

                        left = Left.Node(character, leftPath);
                    }
                    if (Right != null)
                    {
                        List Node rightPath = new List Node;
                        rightpath.AddRange(data);
                        rightpath.Add(true);
                        right = Right.Node(character, rightPath);
                    }

                    if (left != null)
                    {
                        return left;
                    }
                    else
                    {
                        return right;
                    }

                    }


                    }
                }
            }
        //5 marks
            {

        public int CompareTo (Object Obj)
            }
        }
        class Huffman
        {
            private Node HT;    //Huffman tree to create codes and decode text 
            private Dictionary<char, string> D; //Dictionary to encode text

        //constructor 
        public Huffman (string S)
            {

            }
        //15 marks 
        // Return the frequency of each character in the given text (invoked by Huffman) 
        private int[] AnalyzeText (string S)
            {

            }
        //20 marks 
        // Build a Huffman tree based on the character frequencies greater than 0 (invoked by Huffman) 
        private void Build(int[] F)
            {
                priorityQueue<Node> PQ;
            }

        //20 marks 
        // Create the code of 0s and 1s for each character by traversing the Huffman tree (invoked by Huffman) 
        private void CreateCode ()
            {

            }
        //10 marks 
        //Encode the given text and return a string of 0s an 1s
        public string Encode (string S)
            {

            }
            //10marks 
            //Decode the given string of 0s and 1s and return the original text
        public string Decode (string S)
            {

            }
        }
    }
}
