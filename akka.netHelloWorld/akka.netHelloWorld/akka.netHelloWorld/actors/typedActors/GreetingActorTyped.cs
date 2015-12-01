using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using akka.netHelloWorld.messages;
using Akka.Actor;

namespace akka.netHelloWorld.actors.typedActors
{
    public class GreetingActorTyped : TypedActor, IHandle<Greet>
    {
        public void Handle(Greet greet)
        {
            Console.WriteLine("Hello {0}!", greet.Who);
        }
    }
}
