    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public void Main(){
                var misterBond = new Person(true, 35);
                var mrsRobinson = new Person(false, 35);
                Console.WriteLine(misterBond.age);
                Console.WriteLine(mrsRobinson.age);
            }
        }
        
        public class Person
        {
            public bool IsMan { get; set; }
            private int? _age;
            public int? age
            {
                get
                {
                    if (!IsMan)
                        return null;
                    return _age;
                } 
                set
                {
                    _age = value;
                }
            }
     
            public Person(bool isMan, int age)
            {
                this.IsMan = isMan;
                this.age = age;
            }
        }
    }

