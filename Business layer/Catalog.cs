using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Object_2.Business_layer
{
    [XmlRoot("Db")]
    public class Catalog : IList<Category>
    {
        [XmlElement]
        private IList<Category> _categories { get; set; } = new List<Category>();

        public int Count => _categories.Count;

        public bool IsReadOnly => false;

        public Category this[int index]
        {
            get { return _categories[index]; }
            set { _categories[index] = value; }
        }

        public Catalog() { }

        public int IndexOf(Category item)
        {
            return _categories.IndexOf(item);
        }

        public void Insert(int index, Category item)
        {
            _categories.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _categories.RemoveAt(index);
        }

        public void Add(Category item)
        {
            _categories.Add(item);
        }

        public void Clear()
        {
            _categories.Clear();
        }

        public bool Contains(Category item)
        {
            return _categories.Contains(item);
        }

        public void CopyTo(Category[] array, int arrayIndex)
        {
            _categories.CopyTo(array, arrayIndex);
        }

        public bool Remove(Category item)
        {
            return _categories.Remove(item);
        }

        public IEnumerator<Category> GetEnumerator()
        {
            return _categories.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
