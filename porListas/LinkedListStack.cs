namespace ImplementacionListas;

public class LinkedListStack {

    private Node top;
    private int size;
    
    public LinkedListStack()
    {
        top = null;
    }

    public void Push(int element)
    {
        Node newNode = new Node(element);
        newNode.next = top;
        top = newNode;
        size++;
    }

    public int Pop()
    {
        if (top == null)
        {
            return -1;
        }
        else
        {
            int element = top.data;
            top = top.next;
            size--;
            return element;
        }
    }

    public int Top()
    {
        if (top == null)
        {
            return -1;
        }
        else
        {
            return top.data;
        }
    }

    public int getSize()
    {
        return size;
    }

    public string getElements()
    {
        Node current = top;
        string elements = "";

        while (current.next != null)
        {
            elements += current.data.ToString() + ", ";
            current = current.next;
        }
        return elements + current.data.ToString();
    }

}