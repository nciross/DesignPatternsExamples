using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Console._01_Creational
{
    /// <summary>
    /// Singleton : a Class must have only one instance.
    /// </summary>
    internal sealed class Singleton
    {
        private static Singleton? instance;
        private static readonly object instanceLock = new object();
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                if (instance != null)
                {
                    lock (instanceLock)
                    {
                        instance ??= new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}
