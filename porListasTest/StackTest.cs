using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementacionListas;

[TestClass]
public class StackTest
{
    [TestMethod]
    public void Stack_CreationOfAStack()
    {
        LinkedListStack stack = new LinkedListStack();
    }

    [TestMethod]
    public void Push_AddingElementToEmptyStack()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Push(484);
        stack.Push(363);
        stack.Push(242);
        
        Assert.AreEqual(242, stack.Top());
        Assert.AreEqual(3, stack.getSize());
        Assert.AreEqual("242, 363, 484", stack.getElements());
        
    }

    [TestMethod]
    public void Pop_RemovingElementFromEmptyStack_ReturnsNegative1()
    {
        LinkedListStack stack = new LinkedListStack();
        Assert.AreEqual(-1, stack.Pop());
    }

    [TestMethod]
    public void Pop_RemovingElementFromStack_ReturnsElement()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Push(123);
        stack.Push(456);
        stack.Push(789);
        
        int element = stack.Pop();
        int topOfStack = stack.Top();
        int sizeOfStack = stack.getSize();
        
        Assert.AreEqual(789, element);
        Assert.AreEqual(456, topOfStack);
        Assert.AreEqual(2, sizeOfStack);
    }

    [TestMethod]
    public void Top_GettingTheTopElementFromEmptyStack_ReturnMinusOne()
    {
        LinkedListStack stack = new LinkedListStack();
        Assert.AreEqual(-1, stack.Top());
    }

}