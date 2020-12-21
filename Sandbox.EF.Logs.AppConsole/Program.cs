using System.Linq;

namespace Sandbox.EF.Logs.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            var products = context.Products.Where(e => e.Name.Contains("A")).ToList();
        }
    }
}