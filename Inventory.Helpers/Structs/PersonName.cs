namespace Inventory.Helpers.Structs
{
    public struct PersonName
    {
        private readonly string _personName;

        public bool Equals(PersonName other)
        {
            return string.Equals(_personName, other._personName);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is PersonName && Equals((PersonName) obj);
        }

        public override int GetHashCode()
        {
            return (_personName != null ? _personName.GetHashCode() : 0);
        }
        
        private PersonName(string personName)
        {
            _personName = personName;
        }

        public static implicit operator PersonName(string value)
        {
            var personName = new PersonName(value);
            return personName;
        }

        public static bool operator ==(PersonName personName, string value)
        {
            return personName._personName == value;
        }

        public static bool operator !=(PersonName personName, string value)
        {
            return personName._personName != value;
        }

        public override string ToString()
        {
            return _personName;
        }
    }
}
