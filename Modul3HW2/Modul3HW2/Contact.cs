using System.Globalization;
using System.Text;
using Modul3HW2.Interfaces;

namespace Modul3HW2
{
    public class Contact : IFullName
    {
        private string _key;
        private StringBuilder _fullName;

        public Contact()
        {
            _fullName = new StringBuilder();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public StringBuilder FullName()
        {
            _fullName.Append(FirstName);

            // _fullName.Append(" ");
            _fullName.Append(LastName);

            return _fullName;
        }

        public string GetKey()
        {
            _key = FullName().ToString()[0].ToString();

            var status = int.TryParse(_key, out var newKey);

            if (status)
            {
                _key = "0-9";
            }

            return _key;
        }
    }
}
