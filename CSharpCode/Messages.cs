// Added class Messages, not to nest classes.
// Changed ExecuteNextCommand() method to public, enabling you to call it in the main method.
// The other way is to nest it inside the Events class and revert the ExecuteNextCommand() method back to private.
// Not sure which way would be better, if you can tell me with your feedback would be great :)

namespace CSharpCode
{
    using System;
    using System.Text;

    public static class Messages
    {
        private static StringBuilder output = new StringBuilder();

        public static void Main()
        {
            while (Events.ExecuteNextCommand())
            {
            }

            Console.WriteLine(output);
        }

        public static void EventAdded()
        {
            output.Append("Event added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }
}
