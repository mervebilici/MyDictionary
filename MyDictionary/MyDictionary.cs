using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<X, Y>
    {
        X[] Key;
        Y[] Volue;

        public MyDictionary() //contructor oluşturduk
        {
            Key = new X[0];
            Volue = new Y[0];
        }
        public void Add(X key, Y volue)
        {
            X[] tempKey = Key;
            Y[] tempVolue = Volue;

            Key = new X[Key.Length + 1];
            Volue = new Y[Volue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Key[i] = tempKey[i];
            }
            for (int i = 0; i < tempVolue.Length; i++)
            {
                Volue[i] = tempVolue[i];
            }
            key = Key[Key.Length - 1];
            volue = Volue[Volue.Length - 1];
        }

        public int count
        {
            get { return Key.Length; }

        }

    }
}
