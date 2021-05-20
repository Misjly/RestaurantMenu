using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Object_2.Business_layer
{
    [XmlRoot("Users")]
    public class UserList : IList<User>
    {
        [XmlArrayItem]
        public IList<User> Users { get; set; } = new List<User>();

        public int Count => Users.Count;

        public bool IsReadOnly => false;

        public User this[int index]
        {
            get { return Users[index]; }
            set { Users[index] = value; }
        }

        public UserList() { }

        public int IndexOf(User item)
        {
            return Users.IndexOf(item);
        }

        public void Insert(int index, User item)
        {
            Users.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            Users.RemoveAt(index);
        }

        public void Add(User item)
        {
            Users.Add(item);
        }

        public void Clear()
        {
            Users.Clear();
        }

        public bool Contains(User item)
        {
            return Users.Contains(item);
        }

        public void CopyTo(User[] array, int arrayIndex)
        {
            Users.CopyTo(array, arrayIndex);
        }

        public bool Remove(User item)
        {
            return Users.Remove(item);
        }

        public IEnumerator<User> GetEnumerator()
        {
            return Users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
