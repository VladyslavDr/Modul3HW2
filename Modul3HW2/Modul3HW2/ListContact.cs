using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Modul3HW2
{
    public class ListContact : IReadOnlyCollection<Contact>
    {
        private int _count;

        private List<Contact> _contacts;

        public ListContact()
        {
            _contacts = new List<Contact>();
        }

        public int Count => _count;

        public void Add(Contact contact)
        {
            _contacts.Add(contact);

            _count++;
        }

        public void Remove(Contact contact)
        {
            _contacts.Remove(contact);
        }

        public IEnumerator<Contact> GetEnumerator()
        {
            foreach (var contact in _contacts)
            {
                yield return contact;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var contact in _contacts)
            {
                yield return contact;
            }
        }
    }
}
