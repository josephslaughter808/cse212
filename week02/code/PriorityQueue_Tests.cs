using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add Apple (2), Banana (5), and Cherry (3) to the queue.
    // Expected Result: Banana, Cherry, Apple.
    // Defect(s) Found: none. the original code added new people to the front of the line instead of the back
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Banana", 5);
        priorityQueue.Enqueue("Cherry", 3);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Banana", result);
        result = priorityQueue.Dequeue();
        Assert.AreEqual("Cherry", result);
        result = priorityQueue.Dequeue();
        Assert.AreEqual("Apple", result);


    }

    [TestMethod]
    // Scenario: Add Apple (5), Banana (5), and Cherry (1) to the queue. 
    // Expected Result: Apple, Banana, Cherry.  Since Apple and Banana have the same priority, the one that was added first should be removed first.
    // Defect(s) Found: Items with the same priority were not being removed in the order they were added.  The original code used >= instead of > when comparing priorities.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 5);
        priorityQueue.Enqueue("Banana", 5);
        priorityQueue.Enqueue("Cherry", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Apple", result);
        result = priorityQueue.Dequeue();
        Assert.AreEqual("Banana", result);
        result = priorityQueue.Dequeue();
        Assert.AreEqual("Cherry", result);

    }

    [TestMethod]
    // Scenario: Try to remove an item from an empty priority queue.
    // Expected Result: An InvalidOperationException with the message "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_Empty()
    {
    var priorityQueue = new PriorityQueue();
    var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    Assert.AreEqual("The queue is empty.", exception.Message);
    }
}