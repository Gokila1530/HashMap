using System.Collections;

namespace HashMap
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {

            Hashtable ht = new Hashtable();
            ht.Add("RollNo", 1);
            ht.Add("Name", "Gokila");
            ht.Add("Age", 26);

            if (ht.ContainsKey("Name"))
            {
                String name = (String)ht["Name"];
                Console.WriteLine($"Name: {name}");
            }

           

        }
    }
}