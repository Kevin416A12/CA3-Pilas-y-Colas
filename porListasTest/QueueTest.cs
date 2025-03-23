using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementacionListas;

[TestClass]
public class QueueTest
{
    [TestMethod]
    public void LinkedListQueue_QueueCreation()
    {
        LinkedListQueue queue = new LinkedListQueue();
    }

    [TestMethod]
    public void Enqueue_AddElementsToQueue()
    {
        LinkedListQueue queue = new LinkedListQueue();
        queue.Enqueue(2);
        queue.Enqueue(4);
        queue.Enqueue(6);

        Assert.AreEqual(2, queue.getFront());
        Assert.AreEqual(3, queue.getSize());
        Assert.AreEqual("2, 4, 6", queue.getElements());

    }

    [TestMethod]
    public void Enqueue_AddOneElementToQueue()
    {
        LinkedListQueue queue = new LinkedListQueue();
        queue.Enqueue(333);
        
        Assert.AreEqual(333,queue.getFront());
        Assert.AreEqual(1, queue.getSize());
        Assert.AreEqual("333", queue.getElements());
    }

    [TestMethod]
    public void Dequeue_RemoveElementFromQueue()
    {
        LinkedListQueue queue = new LinkedListQueue();
        queue.Enqueue(212);
        queue.Enqueue(424);
        queue.Enqueue(636);
        
        queue.Dequeue();
        Assert.AreEqual(424, queue.getFront());
        Assert.AreEqual(2, queue.getSize());
        Assert.AreEqual("424, 636", queue.getElements());
        
    }

    [TestMethod]
    public void Dequeue_RemoveOnlyElementFromQueue()
    {
        LinkedListQueue queue = new LinkedListQueue();
        queue.Enqueue(123);
        queue.Dequeue();
        
        Assert.AreEqual(-1, queue.getFront());
        Assert.AreEqual(0,queue.getSize() );

    }

    [TestMethod]
    public void Dequeue_RemoveElementFromEmptyQueue()
    {
        LinkedListQueue queue = new LinkedListQueue();
        Assert.AreEqual(-1, queue.Dequeue());
    }
    
}

