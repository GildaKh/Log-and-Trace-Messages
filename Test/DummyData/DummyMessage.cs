using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DummyData
{
    internal static class DummyMessage
    {
        internal static IEnumerable<string> GenerateDummyMessagesAllInt()
        {
            for (int i = 0; i < 2; i++)
            {
                yield return "Message" + i;
            }
        }
        internal static IEnumerable<string> GenerateDummyMessagesAllString()
        {
            for (int i = 0; i < 2; i++)
            {
                yield return "Message";
            }
        }
        internal static IEnumerable<string> GenerateDummyMessageOneString()
        {
            yield return "Message";

        }
        internal static IEnumerable<string> GenerateDummyMessages()
        {
            for (int i = 0; i < 2; i++)
            {
                if (i % 2 == 0)
                    yield return "Message";
                else
                    yield return "Message" + i;
            }
        }
    }
}
