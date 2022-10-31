# Command

## My Two Cents

在 Invoker 与 Receiver 之间引入一个新的 layer(Command), 这样可以将 Invoker 与 Receiver 解耦，同时可以实现 queue, log, undo, redo等操作。
> There is no object-oriented problem that cannot be solved by adding a layer of indirection, except, too many layers of indirection.

## Intent

Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue, or log requests, and support undoable operations.

## Also Known As

Action, Transaction

## Applicability
Use the Command pattern when you want to
- parameterize objects by an action to perform. You can express such patameterization in a procedural language with a callback function, that is, a function that's registered somewhere to be called at a later point. Commands are object-oriented replacement for callbacks.
- specify, queue, and execute requests at different times. A command  object can have a lifetime independent of the original request. If the receiver of a request can be represented in an address space-independent way, then you can transfer a command object for the request to a different process and fulfill the request there.
- support undo. The command's Execute operation can store state for reversing its effects in the command itself. The command interface must have an added Unexecute operation that reverses the effects of a previous call to Execute. Executed commands are stored in a history list. Unlimited-level undo and redo is achieved by traversing this list backwards and forwards call Unexecute and Execute, respectively.
- support logging changes so that they can be reapplied in case of a system crash. By augmenting the Command interface with load and store operations, you can keep presistent log of changes. Recovering from a crash involves reloading logged commands from disk and reexecuting them with the Execute operation.
- structure a system around high-level operations built on primitives operations. Such a structure is common in information systems that support transactions. A transaction encapsulates a set of changes data. The Command pattern offers a way to model transactions. Commands have a common interface, letting you invoke all transactions the same way. The pattern also makes it easy to extend the system with new transactions.

## Participants

- Command
  - declares an interface for executing an operation
- ConcreteCommand
  - defines a binding between a Receiver object and an action
  - implements Execute by invoking the corresponding operations on Receiver
- Client
  - creates a ConcreteCommand object and sets its receiver
- Invoker
  - asks the command to carry out the request
- Receiver
  - knows how to perform the operations associated with carrying out a request. Any class may serve as a Receiver.


## Collaborations

- The client creates a ConcreteCommand object and specifies its receiver
- An Invoker object stores the reference to the ConcreteCommand object
- The Invoker object issues a request by calling Execute on the command. When commands are undoable, ConcreteCommand stores state for undoing the command prior to invoking Execute
- The ConcreteCommand object invokes operations on its receiver to carryout the request

## Consequences

The Command pattern has the following consequences:
- Command decouples the object that invokes the operation from the one that knows how to perform it.
- Commands are first-class objects. They can be manipulated and extended like any other object.
- You can assemble commands into a composite command(MacroCommand). In general, composite commands are an instance of the Composite pattern.
- It's easy to add new Commands, because you don't have to change existing classes.


## Implementation

Consider the following issues when implementing the Command pattern:
1. How intelligent should a command be?
2. Supporting undo and redo.
3. Avoiding error accumulation in the undo process.
4. Using C++ templates.



## Known Uses


## Related Patterns
- Composite
- Memento



