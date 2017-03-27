using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex_10_08
{
    public class IntegerSet : IIntegerSet
    {
        private const int SETSIZE = 101;
        private bool[] mySet;

        //parameters constructor, creates an empty set
        public IntegerSet()
        {
            mySet = new bool[SETSIZE];
        } //end parameterless constructor

        //constructor creates a set from array of integers
        public IntegerSet(int[] array)
            : this()
        {
            for (int i = 0; i < array.Length; i++)
                InsertElement(array[i]);
        } //return string representation of set
        public override string ToString()
        {
            //return base.ToString();
            string setString = "{ ";

            //get set elements
            for (int count = 0; count < SETSIZE; count++)
            {
                if (mySet[count])
                {
                    setString += count + " ";
                } //end if
            }//end for

            //empty set
            if (setString == "{ ")
                setString += "--- ";//display empty set

            setString += "}";
            return setString;
        }//end method ToString

    
        public void DeleteElement(int deleteInteger)
        {
 	    //throw new NotImplementedException();
            if (ValidEntry(deleteInteger))
                mySet[deleteInteger] = false;
        }
        //insert new element into the set
        public void InsertElement(int insertInteger)
        {
 	        //throw new NotImplementedException();
            if (ValidEntry(insertInteger))
             mySet[insertInteger] = true;
        }

        public IntegerSet Intersection(IntegerSet integerSet)
        {
 	            //throw new NotImplementedException();
            IntegerSet temp = new IntegerSet();

            for (int count = 0; count < SETSIZE; count++)
                temp.mySet[count] = (mySet[count] && integerSet.mySet[count]);

            return temp;

        }

        public bool IsEqualTo(IntegerSet integerSet)
        {
 	        //throw new NotImplementedException();
        for (int count = 0; count < SETSIZE; count++)
            {
            if (mySet[count] != integerSet.mySet[count])
                return false;
            }
        return true;
        }

        public IntegerSet Union(IntegerSet integerSet)
        {
 	           //throw new NotImplementedException();
            IntegerSet temp = new IntegerSet();

            for (int count = 0; count < SETSIZE; count++)
                temp.mySet[count]= (mySet[count] || integerSet.mySet[count]);

            return temp;
        }
        private bool ValidEntry(int input)
        {
            return input >= 0 && input < SETSIZE;
        }
}
}
