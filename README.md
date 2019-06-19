# Requirements
Using the prepared environment (C#/Dotnet Core), write a thread safe FIFO queue with the following capabilities:

* Uses generics to store any data type
* Ability to queue a single item
* Ability to queue a collection of items
* Method(s) to dequeue with the following use-cases:
* Block forever until an item becomes available and return it
  * Block until a timeout occurs
  * Do not block, return immediately always
  * Ability to dequeue all items
* Ability to get a count of all items in queue

Write unit tests to demonstrate all use-cases for the operation of the queue. 

You will have 1 hour to complete the test; emphasis is on problem solving and your approach.  Show your work, partial credit will be given to incomplete projects.

# Design considerations
You are able to use existing collections for storing your data, however, you are not allowed to use concurrent collections, as this would be against the spirit of the test.

Things we're looking for:

**Correctness** - The solution should be thread-safe  
**Friendliness** - The solution should have an API that is intuitive and follows framework guidelines  
**Efficiency** - The solution should not waste cpu cycles, threads, or memory unnecessarily  
**Tested** - The solution should have tests that verify every piece of functionality for the above requirements

# Bonus challenge
Allow user to specify whether the queue should be FIFO or LIFO and code it accordingly.

