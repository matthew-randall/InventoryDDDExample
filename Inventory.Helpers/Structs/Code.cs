namespace Inventory.Helpers.Structs
{
    public struct Code
    {
        private readonly string _documentCode;

        public bool Equals(Code other)
        {
            return string.Equals(_documentCode, other._documentCode);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Code && Equals((Code) obj);
        }

        public override int GetHashCode()
        {
            return (_documentCode != null ? _documentCode.GetHashCode() : 0);
        }
        
        private Code(string documentCode)
        {
            _documentCode = documentCode;
        }

        public static implicit operator Code(string value)
        {
            var documentCode = new Code(value);
            return documentCode;
        }

        public static bool operator ==(Code documentCode, string value)
        {
            return documentCode._documentCode == value;
        }

        public static bool operator !=(Code documentCode, string value)
        {
            return documentCode._documentCode != value;
        }

        public override string ToString()
        {
            return _documentCode;
        }
    }
}
