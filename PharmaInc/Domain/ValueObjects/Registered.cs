using System;

namespace Domain.ValueObjects
{
    public class Registered
    {
        public DateTime Date { get; private set; }
        public int Age { get; private set; }
    }
}