using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnPatterns
{
    sealed class Singleton
    {
        static int count = 0;
        static Singleton instance;  //Memory not alloted so object does not exist
        public static Singleton GetInstance
        {
            get
            {
                //Memory is alloted for 1st object when instance is null
                if (instance == null)
                    return new Singleton();
                else 
                    //Existing Instance reference will be returned
                    return instance;
            }
        }
        
        
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }

        public void print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
