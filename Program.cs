﻿namespace LinkedListAssignment
{
    class Program
    {
        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Current Size of the list is: " + list.getListSize());

            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(70);
            list.printNodes();


            Console.WriteLine("Finding 30 in the Lineked list");
            list.findNode(30);
            list.printNodes();

        }
    }

}