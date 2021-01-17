using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists.Lib
{
    public class IntegerLinkedList
    {
        //private int v; //member variable is v
        IntegerNode headNode;
       
        public IntegerLinkedList()
        {
        }
        public IntegerLinkedList(int val)
        {
            
            headNode = new IntegerNode(val);
        }
      
        //public int Sum { get; }, already have a sum function

        public void AddToEnd(int v)
        {
            if (headNode == null)
            {
                headNode = new IntegerNode(v);
            }
            else
            {
                headNode.AddToEnd(v);
            }
                
        }
        public void AddToBeginning(int v)
        {
            if (headNode == null) //ie not a recursive basecase but just to literally check the start
            { 
                headNode = new IntegerNode(v);
            }
            else
            {
                IntegerNode temp = new IntegerNode(v);
                temp._next = headNode;
                headNode = temp;
            }
        }
        public int Count() 
        {
            if (headNode == null)
                return 0;
            else
                return headNode.Count();
        }
        public void print()
        {
            if (headNode == null)
            {
                Console.Write("Empty");
            }
            else
                headNode.print();
        }
        public int sum()
        {
            if (headNode == null)
                return 0;
            else
                return headNode.sum();
        }
        public bool delete(int a)
        {
            if (headNode == null)
            {
                return false;
            }
            else
                return headNode.delete(a);
        }
        public override string ToString()
        {
            if(headNode == null)
            {
                return "{}";
            }
            else
            {
                List<string> numbers = new List<string>();
                numbers.Add(headNode.ToString());
                return "todo";
            }
        }
        public void remove_duplicates()
        {
            if (headNode == null)
                Console.WriteLine("Empty");
            else
                headNode.remove();
        }
        public void merge(IntegerLinkedList a)
        {
            if (headNode == null)
                headNode = a.headNode;
            else
            {
                headNode.merge(a.headNode);
            }
        }
        public IntegerLinkedList reversedList()
        {
            IntegerLinkedList reversed = new IntegerLinkedList();
            
            return headNode.reversedList(reversed); 
        }
        public int first()
        {
            return headNode._value;
        }

        public int finalNode(IntegerLinkedList a, int from_end)
        {
            int position = a.Count() - (from_end+1);
            return headNode.finalNode(position);
        }
    }
    public class SortedIntegerLinkedList
    {
        IntegerNode headNode;
        
        public SortedIntegerLinkedList()
        {
        }
        public SortedIntegerLinkedList(int val)
        {
            headNode = new IntegerNode(val);
        }
        public void AddSorted(int a)
        {
            if (headNode == null)
                headNode = new IntegerNode(a);
            else if (a < headNode._value)
                AddToBeginning(a);
            else
                headNode.AddSorted(a);
        }
        public void AddToBeginning(int v)
        {
            if (headNode == null) 
            {
                headNode = new IntegerNode(v);
            }
            else
            {
                IntegerNode temp = new IntegerNode(v);
                temp._next = headNode;
                headNode = temp;
            }
        }
        public int first()
        {
            return headNode._value;
        }
        public int third()
        {
            return headNode._next._next._value;
        }
    }



    class IntegerNode
    {
        List<string> strings = new List<string>();
        List<int> check = new List<int>();
 
        public int _value;
        public IntegerNode _next;
    
        
       
        public IntegerNode(int v)
        {
            _value = v;
            _next = null;
        }
        public void AddToEnd(int v)
        {
            if(_next == null)
            {
                _next = new IntegerNode(v);
            }
            else
            {
                _next.AddToEnd(v);
            }
        }
        public int Count()
        {
            if (_next == null)
                return 1;
            else
            {
                return 1+_next.Count();
            }
            
        }
       public void print()
       {
            Console.Write("|" + _value + "->");
            if (_next != null)
                _next.print();
       }
       public int sum()
       {
            if (_next == null)
                return _value;
            else
                return _value + _next.sum();
       }
       public bool delete(int a)
       {
            

            if (_next == null)
                return false;
            else if (a == _next._value)
            {
                this._next = _next._next;
                _next._next = null;
                return true;
            }
            else
                return delete(a);

       }
        public override string ToString()
        {
            if (_next != null)
                return _value.ToString();
            return "todo";
        }
       
        public void remove() //does not work
        {

            check.Add(_value);
            Console.WriteLine(_value);
            if (_next == null)
            {
                Console.WriteLine("reached null");
                Console.WriteLine("components in list"+ string.Join(",", check));
                check.Clear();
            }
            
            else
            {
                
                if (check.Contains(_next._value))
                {
                    this._next = _next._next;
                    _next._next = null;
                    
                }
                _next.remove();
            }
        }
        public void AddSorted(int a)
        {
            if (_next == null)
            {
                _next = new IntegerNode(a);
            }
            else if (a < _next._value)
            {
                IntegerNode tempNode = new IntegerNode(a);
                tempNode._next = _next;
                this._next = tempNode;
            }
            else
                _next.AddSorted(a);
        }
        
        public void merge(IntegerNode a)
        {
            if (_next == null)
                this._next = a;
            else
                _next.merge(a);
        }
        public IntegerLinkedList reversedList(IntegerLinkedList a)
        {
            a.AddToBeginning(_value);
            if (_next == null)
                return a;
            else
                return _next.reversedList(a);
            
        }
        public int finalNode(int return_postion)
        {
            if (return_postion == 0)
                return _value;
            else
                return _next.finalNode(return_postion-1);
        }
    }
}
