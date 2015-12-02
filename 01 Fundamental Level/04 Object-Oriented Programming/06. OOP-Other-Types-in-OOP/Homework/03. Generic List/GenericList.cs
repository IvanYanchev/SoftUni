using _04.Generic_List_Version;
using System;
using System.Linq;

namespace _03.Generic_List
{
    [VersionAttribute(1, 0)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int currentIndex;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        //o	adding an element 
        public void Add(T element)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.currentIndex] = element;
            this.currentIndex++;
        }

        //o	accessing element by index
        public T this[int index]
        {
            get
            {
                if (this.IsEmpty())
                {
                    throw new NullReferenceException("The list is empty.");
                }
                else if (this.IndexIsOutOfRange(index))
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return this.elements[index];
            }
            set
            {
                if (this.IsEmpty())
                {
                    throw new NullReferenceException("The list is empty.");
                }
                else if (this.IndexIsOutOfRange(index))
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                this.elements[index] = value;
            }
        }

        //o	removing element by index
        public void RemoveAtIndex(int index)
        {
            if (this.IndexIsOutOfRange(index))
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            for (int i = index; i < this.currentIndex; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.currentIndex--;
            this.elements[currentIndex] = default(T);
        }

        //o	inserting element at given position
        public void InsertAtIndex(T element, int index)
        {
            if (index < 0 || index > this.currentIndex)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }

            for (int i = currentIndex; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;

            currentIndex++;
        }

        //o	clearing the list
        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                elements[i] = default(T);
            }

            this.currentIndex = 0;
        }

        //o	finding element index by given value
        public int Find(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        //o	checking if the list contains a value
        public bool Contains(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        //o	printing the entire list (override ToString()). 
        public override string ToString()
        {
            string stringJoin = string.Empty;
            if (this.currentIndex != 0)
            {
                stringJoin = string.Join(", ", this.elements.Take(currentIndex));
            }

            return string.Format("[ {0} ]", stringJoin);
        }

        public T Min()
        {
            if (this.IsEmpty())
            {
                throw new NullReferenceException("The list is empty.");
            }
            T minElement = this.elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.elements[i].CompareTo(minElement) < 0)
                {
                    minElement = this.elements[i];
                }
            }

            return minElement;
        }

        public T Max()
        {
            if (this.IsEmpty())
            {
                throw new NullReferenceException("The list is empty.");
            }
            T maxElement = this.elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.elements[i].CompareTo(maxElement) > 0)
                {
                    maxElement = this.elements[i];
                }
            }

            return maxElement;
        }

        public void GetVersion()
        {
            Type type = typeof(GenericList<T>);

            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (object atribute in allAttributes)
            {
                if (atribute is VersionAttribute)
                {
                    VersionAttribute version = atribute as VersionAttribute;
                    Console.WriteLine("This program is version {0}.{1}", version.Major, version.Minor);
                }
            }

        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < this.currentIndex; i++)
            {
                newElements[i] = elements[i];
            }
            this.elements = newElements;
        }

        private bool IsEmpty()
        {
            if (this.currentIndex == 0)
            {
                return true;
            }

            return false;
        }

        private bool IndexIsOutOfRange(int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                return true;
            }

            return false;
        }
    }
}
