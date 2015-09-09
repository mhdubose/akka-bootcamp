# My Akka.NET Bootcamp Fork

### Unit 1
In Unit 1, we will learn the fundamentals of how the actor model and Akka.NET work.

*NIX systems have the `tail` command built-in to monitor changes to a file (such as tailing log files), whereas Windows does not. We will recreate `tail` for Windows and use the process to learn the fundamentals.

In Unit 1 you will learn:

1. How to create your own `ActorSystem` and actors;
2. How to send messages actors and how to handle different types of messages;
3. How to use `Props` and `IActorRef`s to build loosely coupled systems.
4. How to use actor paths, addresses, and `ActorSelection` to send messages to actors.
5. How to create child actors and actor hierarchies, and how to supervise children with `SupervisionStrategy`.
6. How to use the Actor lifecycle to control actor startup, shutdown, and restart behavior.

**[Begin Unit 1](src/Unit-1)**.

### Unit 2
In Unit 2, we're going to get into some more of the intermediate Akka.NET features to build a more sophisticated application than what we accomplished at the end of unit 1.

In Unit 2 you will learn:

1. How to use [HOCON configuration](http://getakka.net/wiki/Configuration "Akka.NET HOCON Configurations") to configure your actors via App.config and Web.config;
1. How to configure your actor's [Dispatcher](http://getakka.net/wiki/Dispatchers) to run on the Windows Forms UI thread, so actors can make operations directly on UI elements without needing to change contexts;
1. How to handle more sophisticated types of pattern matching using `ReceiveActor`;
1. How to use the `Scheduler` to send recurring messages to actors;
1. How to use the [Publish-subscribe (pub-sub) pattern](http://en.wikipedia.org/wiki/Publish%E2%80%93subscribe_pattern) between actors;
1. How and why to switch actor's behavior at run-time; and
2. How to `Stash` messages for deferred processing.

**[Begin Unit 2](src/Unit-2)**.

### Unit 3 
In Unit 3, we will learn how to use actors for parallelism and scale-out using [Octokit](http://octokit.github.io/) and data from Github repos!

In Unit 3 you will learn:

1. How to perform work asynchronously inside your actors using `PipeTo`;
2. How to use `Ask` to wait inline for actors to respond to your messages;
2. How to use `ReceiveTimeout` to time out replies from other actors;
4. How to use `Group` routers to divide work among your actors;
5. How to use `Pool` routers to automatically create and manage pools of actors; and
6. How to use HOCON to configure your routers.

**[Begin Unit 3](src/Unit-3)**.

