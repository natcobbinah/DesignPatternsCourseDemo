# Insurance Contract Generation System

---

An insurance company needs to generate a large number of insurance contracts. Each contract contains :

- Standard clauses (identical for all contracts of the same type)
- Customised information (customer name, dates, amounts)
- Specific appendices

There are three basic types of contract:

- Home insurance
- Motor insurance
- Life insurance

Each basic policy serves as a template and can be customised to create customer-specific versions. Creating a new policy from scratch is costly in terms of resources, as it requires all the standard clauses to be loaded and the document to be formatted. In addition, some customers wish to have several versions of the same contract with minor variations (different franchises, different options).

Questions :

1. What design pattern would enable new contracts to be created efficiently without having to recreate each contract from scratch?

2. Model the solution using a UML class diagram which should include:

   - The structure of the contracts
   - The mechanism for creating new contracts
   - The relationships between the different classes

3. Propose a C# implementation of the class diagram that will allow you to :

   - Create a basic contract
   - Copy an existing contract
   - Customise the information in a contract

4. How can your solution effectively manage :
   - Creating multiple versions of the same contract
   - Adding a new type of contract
   - Modification of standard clauses