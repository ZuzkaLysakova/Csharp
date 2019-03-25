using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaMistru
{
    // Spojový seznam by měl realizovat rozhraní IEnumerable, ICollection a IList
    // Shoddu prvků testujte pomocí metody Equals
    // Doplňte Equals do třídy Hrac

    public class SpojovySeznam : IEnumerable, ICollection, IList
    {
        
        private class PrvekSeznamu 
        {
            public object Data;
            public PrvekSeznamu Predchozi = null;
            public PrvekSeznamu Dalsi;

            
        }

        private PrvekSeznamu Prvni = null;
        private PrvekSeznamu Posledni = null;
        private PrvekSeznamu Aktualni = null;
        private int PocetPrvku = 0;

        public int Count => throw new NotImplementedException();

        public object SyncRoot => this;

        public bool IsSynchronized => false;

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int[] values = new int[] { };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < values.Length; i++)
            {
                yield return values[i];
            }
        }

        public void CopyTo(Array array, int index)
        {
            
        }

        public int Add(object value)
        {
            if (Prvni == null)
            {
                PrvekSeznamu prvek = new PrvekSeznamu();
                prvek.Data = value;
                Prvni = Posledni = prvek;
            }
            Posledni.Dalsi = Aktualni;
            Aktualni.Data = value;
            
            return PocetPrvku++;           
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {           
            Prvni = null;
            Posledni = null;
            PocetPrvku = 0;
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            PrvekSeznamu pom = Prvni;
            if(Posledni != null)
            {
                Prvni = null;
                pom.Dalsi = Aktualni;

            }

        }

        public void RemoveAt(int index)
        {
            PrvekSeznamu pom = Prvni;
            for (int i = 0; i < index; i++)
            {

            }
        }
    }
}
