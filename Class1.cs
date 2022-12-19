using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_10
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                //If the first value is not equal to a specific value then the automatic value would be false
                if (val == elements[i])
                    return true;
                // else
                //  return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }


        public void clearSet()
        {
            elements.Clear();
        }

        // Created a new set in order to add new values and leave set A unchanged 
        public Set union(Set rhs)
        {
            Set C = new Set();
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                C.addElement(rhs.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            for (int i = 0; i < this.elements.Count; i++)
            {
                C.addElement(this.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            return C;
        }


    }
}
