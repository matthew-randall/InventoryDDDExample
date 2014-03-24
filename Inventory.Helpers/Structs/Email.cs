namespace Inventory.Helpers.Structs
{
    public struct Email
    {
        private readonly string _email;

        public bool Equals(Email other)
        {
            return string.Equals(_email, other._email);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Email && Equals((Email) obj);
        }

        public override int GetHashCode()
        {
            return (_email != null ? _email.GetHashCode() : 0);
        }
        
        private Email(string email)
        {
            _email = email;
        }

        public static implicit operator Email(string value)
        {
            var email = new Email(value);
            return email;
        }

        public static bool operator ==(Email currency, string value)
        {
            return currency._email == value;
        }

        public static bool operator !=(Email currency, string value)
        {
            return currency._email != value;
        }

        public override string ToString()
        {
            return _email;
        }
    }
}
