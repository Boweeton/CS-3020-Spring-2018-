using System;
using System.Runtime.InteropServices.ComTypes;
using System.Linq;

namespace queryTesting
{
    public class Class1
    {
        static string[] nameArray = { "Joe", "Ken", "Luke", "Errik", "Tom", "Alex", "Jackson", "Tim" };

        var nameQuery = from name in nameArray where name.ElementAt(0) == 'J' orderby name select name;
    }
}
