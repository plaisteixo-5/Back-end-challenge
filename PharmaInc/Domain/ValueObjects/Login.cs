using System;

namespace Domain.ValueObjects
{
    public class Login
    {
        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Salt { get; private set; }
        public string Md5 { get; private set; }
        public string Satl { get; private set; }
        public string Sha1 { get; private set; }
        public string Sha256 { get; private set; }
    }
}