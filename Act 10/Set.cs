using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
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
            if (containsElement(val))
            {
                return false;
            }
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
                if (val == elements[i])
                    return true;
                // Removed the else statement since it would invalidate the for loop iteration and end the loop short without adding all elements. 
                /*else
                    return false; */
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

        public Set union(Set rhs)
        {
            // union() would change the original A set. Removed the original for loop and added a new C set and added two for loops below utilizing the new C set.
            /*for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;*/

            Set C = new Set(); // Create a temp set to store the union. This set represents to A union B output.

            for (int i = 0; i < elements.Count; i++) // Iterate through C set and add elements from A set that don't already exist (no duplicates).
            {
                if (C.containsElement(elements[i]) == false)
                {
                    C.addElement(elements[i]);
                }
            }

             for (int i = 0; i < rhs.elements.Count; i++) // Iterate through C set and add elements from B set that don't already exist (no duplicates).
            {
                if (C.containsElement(rhs.elements[i]) == false)
                {
                    C.addElement(rhs.elements[i]);
                }
            } 

            return C; // Return the final A union B set.

        }
    }
}
