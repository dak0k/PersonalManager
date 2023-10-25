namespace PersonalManager
{
    class Person
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime? AddmissionDate { get; set; }
        public StatusType Status { get; set; }


        public Person(
                    string name,
                    string lastName,
                    string fatherName,
                    string department = "НЕ НАЗНАЧЕН",
                    string position = "НЕ НАЗНАЧЕН",
                    DateTime? addmissionDate = null
                   
        )
        {
            if (addmissionDate == null)
            {
                addmissionDate = DateTime.Now;
            }
            this.Name = name;
            this.LastName = lastName;
            this.FatherName = fatherName;
            this.Department = department;
            this.Position = position;
            this.AddmissionDate = addmissionDate;
          
        }

    }

}