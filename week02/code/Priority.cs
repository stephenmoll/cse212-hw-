/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: Expected to remove "Peter" 
        Console.WriteLine("Test 1");

        // Defect(s) Found: It removed Bob istead of Peter. Has been fixed.
        Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Stephen", 1);
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Peter", 3);

        Console.WriteLine($"{priorityQueue.Dequeue()} has been removed from the list.");
        Console.WriteLine(priorityQueue);

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: Should remove "Bob" first, the highest priority item before any other items of the same value are found.
        Console.WriteLine("Test 2");

        Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Stephen", 1);
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Peter", 2);

        Console.WriteLine($"{priorityQueue.Dequeue()} has been removed from the list.");
        Console.WriteLine(priorityQueue); 
        // Defect(s) Found: It says it removed Peter(Should have been Bob), also didn't actually remove anyone from the list.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        
    }
}