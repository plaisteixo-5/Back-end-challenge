using System;

namespace Domain.ValueObjects
{
    public class Dob
    {
        public DateTime Date { get; private set; }
        public int Age { get; private set; }
    }
}