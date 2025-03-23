namespace ImplementacionListas;

public class LinkedListQueue
{
    private Node front;
    private Node rear;
    private int size;

    public LinkedListQueue()
    {
        front = null;
        rear = null;
        size = 0;
    }

    public void Enqueue(int element)
    {
        Node newNode = new Node(element);

        if (front == null)
        {
            front = newNode;
            rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
        size++;
    }

    public int Dequeue()
    {
        if (front == null)
        {
            return -1;
        }
        else
        {
            int data = front.data;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            size--;
            return data;
        }
    }

    public int getFront()
    {
        if (front == null)
        {
            return -1;
        }
        else
        {
            return front.data;
        }
    }

    public int getSize()
    {
        return size;
    }

    public string getElements()
    {
        Node current = front;
        string elements = "";

        while (current != rear)
        {
            elements += current.data.ToString() + ", ";
            current = current.next;
        }
        
        elements = elements + rear.data.ToString();
        return elements;
    }
}