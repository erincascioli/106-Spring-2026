using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues_Demo
{
    internal class MyStack
    {
        // My stack will use the built-in List class to hold its data
        private List<string> stackData;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public MyStack()
        {
            stackData = new List<string>();
            count = 0;
        }

        // Push --> Add() data to the end
        //    has enough capacity --> O(1)
        //    not enough capacity --> O(n)
        // Pop --> RemoveAt(count - 1)
        //    never shifting data --> O(1)
        // Peek --> access last index
        //    no shifting data --> O(1)
    }
}
