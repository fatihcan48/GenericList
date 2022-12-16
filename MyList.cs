using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // Kendi Liste class'ımızı oluşturuyoruz...
    public class MyList<T>  // Generic eleman alacak bir class...
    {
        T[] items;   // Bir dizi alanı tanımlıyoruz.
        //constructor
        public MyList()      // Class new'lendiği zaman 0 elemanlı bir dizi adresi oluşturacak..
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;     // items'ın referans adresini kaybetmemek için adresini oluşturduğumuz geçici diziye veriyoruz...
            items = new T[items.Length + 1];   // Bir eleman ekleneceği için, new ile yeni bir referans oluşturup items'a veriyoruz...
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];   // Geçici dizideki elemanları tekrardan items'a gönderiyoruz..
            }

            items[items.Length-1] = item;   // items'ın boş olan son elemanına eklenecek olan item'ı ekliyoruz...
        }
        public int Lenght
        {
            get { return items.Length; }
        }
        public T[] Items     // items alanının property'si..
        {
            get { return items; }
        }
    }
}
