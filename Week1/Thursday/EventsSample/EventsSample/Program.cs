using System;

namespace EventsSample
{
    public delegate void MyDelegate(int x);

    class Program
    {
        // public event MyDelegate MyEvent;
        private MyDelegate _myEvent;
        public event MyDelegate MyEvent
        {
            add { _myEvent += value; }
            remove { _myEvent -= value; }
        }

        public void FireMyEvent(int x)
        {
            if (_myEvent != null)
            {
                _myEvent(x);
            }

            MyDelegate handler = _myEvent;
            if (handler != null)
            {
                handler(x);
            }

            _myEvent?.Invoke(x);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MyProperty { get; set; }

        private int myVar;

        public int MyProperty1
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}
