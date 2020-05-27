namespace NativeAppClient
{

    using System;
    using System.Collections.Generic;
    public partial class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public Nullable<int> Dept_ID { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
    }
}