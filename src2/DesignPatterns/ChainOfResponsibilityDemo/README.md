# Chain of Responsibility

## My Two Cents

 为避免 Invoker 与 Receiver 之间的耦合，引入一条 Receiver 链（Chain），使得 Invoker 不直接依赖目标 Receiver，而与 Receiver 链建立联系，同样使多个 Receiver 都有机会处理 Invoker 的请求。

## Intent

Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.


## Applicability
Use Chain of Responsibility when
- more than one object may handle a request, and the handler isn't knowns priori. The handler should be ascertained automatically.
- you want to issue a request to one of serveral objects without specifying the receiver explicitly.
- the set of objects that can handle a request should be specified dynamically.

## Participants

- Handler
  - defines an interface for handling requests.
  - (optional) implements the successor link.
- ConcreteHandler
  - handles requests it is responsible for.
  - can access its successor
  - if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor.
- Client
  - initiates the request to a ConcreteHandler object on the chain.


## Collaborations

- When a client issues a request, the request propagates along the chain until a ConcreteHandler object takes responsibility for handling it.

## Consequences

Chain of Responsibility has the following benefits and liabilities:
1. Reduced coupling. The pattern frees an object from knowing which other object handles a request. An object only has to know that a request will be handled "appropriately". Both receiver and the sender have no explicit knowledge of each other, and an object in the chain doesn't have to know about the chain's structure.
   - As a results, Chain of Responsibility can simplify object interconnections. Instead of objects maintaining references to all candidate receivers, they keep a single reference to their successor.
2. Added flexibility in assigning responsibilities to objects. Chain of Responsibility gives you added flexibility in distributing responsibilities among objects. You can add or change responsiblities for handling a request by adding to or otherwise changing the chain at run-time. You can combine this with subclassing to specialize handlers statically.
3. Receipt isn't guranteed. Since a request has no explicit receiver, there's no gurantee it'll be handled - the request can fall off the end of chain without ever being handled. A request can also go unhandled when the chain is not configured properly.

## Implementation

Here are implementation issues to consider in Chain of Responsibility:
1. Implementing the successor chain. There are 2 possible ways to implement the successor chain:
   - Define new links (usually in the Handler, but ConcreteHandlers could define them instead).
   - Use existing links.

2. Connecting successors. If there are no preexisting references for defining a chain, then you'll have to introduce them youself. In that case, the Handler not only defines the interface for the requests but usually maintains the successor as well. That lets the handler provide a default implementation of HandleRequest that forwards the request to the successor (if any). If a ConcreteHandler subclass isn't interested in the request, it doesn't have to override the forwarding operation, since its default implementation forwards unconditionally.

3. Representing requests. Different options are available for representing requests. In the simplest form, the request is hard-coded operation invocation, as in the case of HandleHelp. This is convenient and safe, but you can forward only the fixed set of requests that the Handler class defines.
An alternative is to use a single handler function that takes a request code (e.g. an integer constant or a string) as parameter. This supports an open-ended set of requests. The only requirement is that the sender and receiver agree on how the request should been coded.



## Known Uses
GUI 事件处理：
- 鼠标点击
- 按键

## Related Patterns
- Composite
- Template Method



