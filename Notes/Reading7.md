# Abstract, Polymorphism and inheritance

- Including the encapsulation, abstract polymorphism and inheritance form four pillar of object oriented program.
- Amongst those four, inheritance is arguably the most important pillar in OOP. 

## Inheritance
---
- Inheritance allows developer to reuese, extend and modify from base class to derived class.
- Base class is most upper class that everything inherits from and those that inherits characterist from the base class is called `derived class`.
ie. `Class B` is derived from `Class A` and `Class C` derived from `Class B`. This makes `Class C` able to access anything from A and B classes.
- When you define a class to derive from another class, derived class implicitly gains all the members, `except` ***constructors and finalizer***.

### Abstract and virtual methods
- When base calss declare a method as virtual, derived class can override it implment their own methods. If base class use absract, then the derived class has to orridden any non abstract class that directly inherits from that class.

### Interfaces
- A reference type that defines a set of emembers.

- To prevent further inheritance, you can use sealed access modifier.

## Polymorphism
- When polymorphism occurs, it can lead object declared type to no longer identical to run-time type.

## Abstract
- When class has `abstract` keyword in their modifier, object cannot be instantiated to the class. 
- Abstract method does not have implementation, so the method definition is followed by semi colon. The derived class then has to implement all abstract methods.
- Sealed classes cannot be used as a base class and can't be abstract class.
