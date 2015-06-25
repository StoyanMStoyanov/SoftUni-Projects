using System;
using System.Linq;

class CustomList<T>
    where T:IComparable<T>
{
    private const int DefaultCapacity = 2;

    private T[] elements;
    private int currentIndex;

    public CustomList(int capacity = DefaultCapacity)
    {
        this.elements = new T[capacity];
        this.currentIndex = 0;
    }

    public T this[int position]
    {
        get
        {
            if (position < 0 || position > this.currentIndex)
                throw new ArgumentOutOfRangeException("position", string.Format("Position should be in the range [0 ... {0}].", this.currentIndex));
            
            return this.elements[position];
        }
        set
        {
            if (position < 0 || position > this.currentIndex)
                throw new ArgumentOutOfRangeException("position", string.Format("Position should be in the range [0 ... {0}].", this.currentIndex));

            this.elements[position] = value;
        }
    }

    //Methods
    public void Add(T element)
    {
        if (this.currentIndex == this.elements.Length)
            Resize();
        this.elements[currentIndex] = element;
        this.currentIndex++;
    }   

    public void Remove(T element)
    {
        for (int index = 0; index < elements.Length; index++)
        {
            if (this.elements[index].Equals(element))
            {
                this.ReorderElements(index);
                index--;
            }
        }
    }

    public int IndexOf(T element)
    {
        for (int i = 0; i < this.currentIndex; i++)
        {
            if (this.elements[i].Equals(element))
                return i;
        }
        return -1;
    }

    public T Min()
    {
        T min = this.elements[0];
        for (int index = 1; index < this.currentIndex; index++)
        {
            T currentElement = this.elements[index];
            if (currentElement.CompareTo(min) < 0)
                min = currentElement;
        }
        return min;
    }

    public T Max()
    {
        T max = this.elements[0];
        for (int index = 0; index < this.currentIndex; index++)
        {
            T currentElement = this.elements[index];
            if (currentElement.CompareTo(max) > 0)
                max = currentElement;
        }
        return max;
    }

    public void Insert(T element, int position)
    {
        if (position > this.currentIndex)
            throw new IndexOutOfRangeException("Index is out of range.");
        
        for (int index = this.currentIndex; index > position; index--)
        {
            this.elements[index] = this.elements[index - 1];
        }
            this.currentIndex++;
            this.elements[position] = element;
    }

    public void Clear()
    {
        for (int i = 0; i < currentIndex; i++)
        {
            this.elements[i] = default(T);
        }
        this.currentIndex = 0;
    }

    public bool ContainsValue(T element)
    {
        for (int index = 0; index < currentIndex; index++)
        {
            if (this.elements[index].Equals(element))
                return true;
        }
        return false;
    }

    public override string ToString()
    {
        string temp = string.Join(", ", this.elements.Take(this.currentIndex));
        return temp;
    }

    private void Resize()
    {
        T[] temp = new T[this.elements.Length * 2];
        for (int index = 0; index < this.elements.Length; index++)
        {
            temp[index] = this.elements[index];
        }
        this.elements = temp;
    }

    private void ReorderElements(int index)
    {
        for (int i = index; i < this.currentIndex; i++)
        {
            if (i == this.elements.Length-1) break;
                
            this.elements[i] = this.elements[i + 1];
        }
        this.currentIndex--;
        this.elements[this.currentIndex] = default(T);        
    }
}
