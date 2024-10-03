using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueu items with different priorities
    // Expected Result: Items should be dequeued in highest priority first
    // Defect(s) Found: Did not remove items from queue
    // _queue[index].Priority should be > instead of >=
    // Index should start at 0 and be less than _queue.Count
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 5);
        priorityQueue.Enqueue("high", 10);

        var high = priorityQueue.Dequeue();
        Assert.AreEqual(high, "high");
        
        var medium = priorityQueue.Dequeue();
        Assert.AreEqual(medium, "medium");
        
        var low = priorityQueue.Dequeue();
        Assert.AreEqual(low, "low");
    }

    [TestMethod]
    // Scenario: Enqueu multiple items with same priority
    // Expected Result: The first item added should be dequeued first
    // Defect(s) Found: it returned second at first
    // index should start at 0 and be less than _queue.Count and not _queue.Count - 1
    // _queue[index].Priority should be > instead of >=
    // we should add _queue.RemoveAt(highPriorityIndex) before returning value 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 10);
        priorityQueue.Enqueue("second", 10);
        priorityQueue.Enqueue("third", 5);

        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
        Assert.AreEqual("third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}