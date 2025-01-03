# Multi-platform Notification System
---
An e-commerce company wanted to overhaul its customer notification system. The system needs to manage different types of notification (Order, Delivery, Support) with different levels of urgency, and be able to send them via different platforms (Email, SMS, Mobile Push).
Here is the existing source code that needs restructuring:

Questions:

1. Identify the problems in the existing code, particularly in terms of :
   - Code duplication
   - Extensibility
   - Maintenance
   - Coupling between components

2. Which design pattern would make it possible to :
   - Separate notification types from their implementations
   - Allow both aspects to evolve independently
   - Avoid the combinatorial explosion of classes
   
3. Model the solution using a UML class diagram that will make it possible to :
   - Decouple notification types from sending methods
   - Facilitate the addition of new notification types
   - Facilitate the addition of new sending platforms

4. How would your solution facilitate :

   - Adding a new type of notification (e.g. ‘Promotion’)
   - Adding a new sending platform (e.g. ‘Discord’)
   - Modifying the sending behaviour for a specific platform

5. Implement the proposed solution in C#, showing how it solves the problems identified in the initial code.

The code provided shows clear signs of duplication and rigidity. The appropriate pattern will separate two aspects that vary independently.

