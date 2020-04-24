using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Events
    {
        public List<EventElement> EventElementArray;
        public EventsType         EventsType;
        public string             String;

        public static implicit operator Events(List<EventElement> EventElementArray) => new Events { EventElementArray = EventElementArray };
        public static implicit operator Events(EventsType         eventsType)        => new Events { EventsType        = eventsType };
        public static implicit operator Events(string             String)            => new Events { String            = String };
    }
}