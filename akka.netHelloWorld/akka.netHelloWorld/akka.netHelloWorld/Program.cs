using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using akka.netHelloWorld.actors.reciveActors;
using akka.netHelloWorld.actors.typedActors;
using akka.netHelloWorld.messages;
using Akka.Actor;

namespace akka.netHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new actor system (a container for your actors)
            var system = ActorSystem.Create("MySystem");

            // Create your actor and get a reference to it.
            // This will be an "IActorRef", which is not a reference to the actual actor
            // instance but rather a client or proxy to it.
            var greeter = system.ActorOf<GreetingActor>("greeter");

            // Send a message to the actor.
            greeter.Tell(new Greet("World"));

            var greeter2 = system.ActorOf<GreetingActorTyped>();
            // Send a message to the actor.
            greeter2.Tell(new Greet("World 2"));

            var networkSystem = ActorSystem.Create("my-actor-server");
            var networkedOne = system.ActorSelection("akka.tcp://service1@127.0.0.1:8091/user/service-b");
            networkedOne.Tell("Networked !");

            // This prevents the app from exiting
            // before the async work is done.
            Console.WriteLine("----------");
            Console.ReadLine();
        }
    }
}
