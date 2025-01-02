# Bank Document Production System

A bank offers different types of official documents to its customers depending on their status (private or professional):
Individual customers receive :

A simplified bank identity statement
A standardised account statement

Business customers receive :

A detailed bank details statement with SIRET
An account statement with specific legal information

Each document must be generated according to strict security standards and bear the bank's logo, whatever the version (individual or business).

## Questions :

### Using the Abstract Factory pattern, model the creation of banking documents according to the type of customer (individual or business).

### Produce the corresponding UML class diagram, which must include :

- Abstract and concrete factories
- Abstract products (banking documents) and their concrete implementations
- The relationships between the different classes

### Propose a C# implementation of the class diagram, focusing on :

- The structure of the factories
- The creation of different document types
- An example of use in a Main() method

### How would your solution make it easy to add a new type of document (for example a tax certificate) while respecting the Open/Closed principle?