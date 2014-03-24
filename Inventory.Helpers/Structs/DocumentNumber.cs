namespace Inventory.Helpers.Structs
{
    public struct DocumentNumber
    {
        public bool Equals(DocumentNumber other)
        {
            return string.Equals(_documentNumber, other._documentNumber);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is DocumentNumber && Equals((DocumentNumber) obj);
        }

        public override int GetHashCode()
        {
            return (_documentNumber != null ? _documentNumber.GetHashCode() : 0);
        }

        private readonly string _documentNumber;

        private DocumentNumber(string documentNumber)
        {
            _documentNumber = documentNumber;
        }

        public static implicit operator DocumentNumber(string value)
        {
            var documentNumber = new DocumentNumber(value);
            return documentNumber;
        }

        public static bool operator ==(DocumentNumber documentNumber, string value)
        {
            return documentNumber._documentNumber == value;
        }

        public static bool operator !=(DocumentNumber documentNumber, string value)
        {
            return documentNumber._documentNumber != value;
        }

        public override string ToString()
        {
            return _documentNumber;
        }
    }
}
