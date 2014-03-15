TddCalculator
=============

A simple calculator project to demo TDD at its most basic level - Test first development and change management.

The commit history of the project reflects the steps in writing code using TDD's Red-Green-Refactor cycle. Because of this, not every commit will contain code that builds, nor a complete passing set of unit tests.

The project evolves in the following fashion:

1 - The first spec given by the ficticious client is to implement 
a Fibonacci calculator that calculates the nth value of the fibonacci sequence.

In terms of code design, and without any other needs, we implement it using a static method in a class. We also consider that invalid (negative input values) throw exceptions.

This first aproach is the simplest and is used to demonstrate the influence test first can have on design - we crate a simple, logical API through the test.

2 - Our client has come up with a new requirement and asked us to add a method of calculating the square value of a number.

The process is pretty much the same as the first, (and can be used as an excercise) and will help setup the third requirment...

3 - Happy with what we have produced, our client will want to use our library, but needs us to permite choosing which calculator to use.

Still in a Tdd fasion, we begin to introduce interfaces to abstract the individual implementations, add an enumeration for selection, and a factory to instanciate the implementing class, in a Strategy Pattern style.

