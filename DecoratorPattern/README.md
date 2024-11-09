# Decorator Pattern

## Introduction

The decorator pattern is used to add properties or functions to an already instantiated main component without modifying its core. We create a Decorator abstract class that implements the same interface as the main component. Whenever we want to add functionality to our main component, we create a subclass that extends the Decorator class to add our functionality. All of our subclasses must follow the rules set by the interface that the main component implements.

## Usage

When we want to add functionality to a main component, instead of modifying and recompiling the base class, we can use a decorator. Each decorator takes a MainComponent instance in its constructor, applies the modification, and returns an object of the same type.

## Example

For example:

ICoffee is the main interface for the main component Coffee.

We create a decorator (an abstract class) that implements the ICoffee interface. This is a rule decorators must follow in order to return an object of the same type after modifying the main component Coffee.

Let’s say we want to add milk to our coffee. Instead of creating an addMilk function in the base component, we create a subclass of the decorator that implements the ICoffee interface, and we redefine the relevant functions with updates that reflect adding milk, such as increasing the price of the coffee.

We then receive our Coffee object, assign it to a private ICoffee instance, and that new instance takes on all the updated methods, making it a modified coffee—no longer a plain Coffee, but a coffee with milk.
