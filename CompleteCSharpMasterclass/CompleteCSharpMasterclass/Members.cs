using System;
using System.Diagnostics;

namespace CompleteCSharpMasterclass
{
    class Members
    {
        //member - private field
        private string _memberName;
        private string _jobTitle;
        private int _salary;
            
        //member - public field
        public int _age;
            
        //member property (long and explicit) - exposes jobTitle safely - properties start with a capital letter. 
        public string JobTitle
        {
            get
            {
                return _jobTitle;
            }
            set
            {
                _jobTitle = value;
            }
        }
        
        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, My name is {0}, my job title is {1}, my age is {3} " , _memberName , _jobTitle , _age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("salary: {0}." , _salary);
        }
        
        // member constructor

        public  Members()
        {
            _age = 30;
            _memberName = "Lucy";
            _salary = 60000;
            _jobTitle = "developer";
            Console.WriteLine("Object creted");
        }
        
        //member - destructor - finalizer
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Destruction of Member object");
        }
    }
}