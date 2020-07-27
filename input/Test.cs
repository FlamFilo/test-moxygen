
using System;

namespace EnterpriseName.ProjectName
{
    /// <summary>
    /// Moxygen Test Class
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Private string
        /// </summary>
        /// <remarks>
        /// Private String description.
        /// <remarks/>
        private string privateString;
        /// <summary>
        /// Public string
        /// </summary>
        /// <remarks>
        /// Public String description.
        /// <remarks/>
        public string publicString;

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <remarks>
        /// Some remarks on the class constructor
        /// <remarks/>
        public Test()
        {
            this.privateString = "I'am private!";
            this.publicString = "I'am public!";
        }

        /// <summary>
        /// Private Method accessing private member
        /// </summary>
        /// <returns>the private string</returns>
        /// <remarks>
        /// Some remarks on the method
        /// <remarks/>
        private string privateMethod()
        {
            return this.privateString;
        }

        /// <summary>
        /// Public Method accessing private member
        /// </summary>
        /// <returns>the private string</returns>
        /// <remarks>
        /// Some remarks on the method
        /// <remarks/>
        public string publicMethod()
        {
            return this.privateString;
        }
    }
}
