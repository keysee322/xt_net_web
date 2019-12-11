using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Task3
{
    class DynamicArray<MAS> : IEnumerable, IEnumerable<MAS>, ICloneable//, ICollection<T>, IList<T>
    {
        protected MAS[] _mas;
        private MAS[] _tempMas;

        public DynamicArray()
        {
            _mas = new MAS[8];
            Length = 8;
        }

        public DynamicArray(int n)
        {
            _mas = new MAS[n];
            Length = n;
        }

        public DynamicArray(MAS[] array)
        {
            if (array == null)
                throw new ArgumentException("Null parameter", "item");

            _mas = array;
            Length = array.Length;
        }

        public DynamicArray(IEnumerable<MAS> ie)
        {

            if (ie == null)
                throw new ArgumentException("Null parameter", "item");

            _mas = new MAS[ie.Count()];

            int Count = 0;

            foreach (MAS item in ie)
            {
                _mas[Count] = item;
                Count++;
            }

            Length = ie.Count();
        }


        public MAS this[int index]
        {
            get
            {
                if (index > Length - 1)
                    throw new ArgumentOutOfRangeException();

                return index >= 0 ? _mas[index] : _mas[Length + index];
            }

            set
            {
                if (index > Length - 1)
                    throw new ArgumentOutOfRangeException();

                if (index >= 0) _mas[index] = value;
                else _mas[Length + index] = value;
            }
        }

        public int Length { get; protected set; }

        public void Add(MAS item)
        {
            if (Length < Capacity)
            {
                _mas[Length] = item;
                Length++;
            }
            else
            {
                _tempMas = _mas;
                _mas = new MAS[_tempMas.Length * 2];

                _tempMas.CopyTo(_mas, 0);
                _mas[Length] = item;
                Length++;
            }
        }


        public int Capacity
        {
            get
            {
                return _mas.Length;
            }

            set
            {
                _tempMas = _mas;
                _mas = new MAS[value];

                if (Length > value)
                {
                    Length = value;

                    for (int i = 0; i < Length; i++)
                    {
                        _mas[i] = _tempMas[i];
                    }
                }
                else
                {
                    for (int i = 0; i < _tempMas.Length; i++)
                    {
                        _mas[i] = _tempMas[i];
                    }
                }
            }
        }


        public void AddRange(IEnumerable<MAS> collection)
        {
            if (Length + collection.Count() <= Capacity)
            {

                _tempMas = new MAS[collection.Count()];

                int Count = 0;

                foreach (MAS item in collection)
                {
                    _tempMas[Count] = item;
                    Count++;
                }

                _tempMas.CopyTo(_mas, Length);

                Length += collection.Count();
            }
            else
            {
                _tempMas = _mas;

                int a = 2;

                while (Length + collection.Count() > Capacity)
                {
                    _mas = new MAS[_tempMas.Length * a];
                    a += 2;
                }

                _tempMas.CopyTo(_mas, 0);

                //_tempArr = collection.ToArray<T>(); 

                //Вместо collection.ToArray<T>() делаем через foreach
                _tempMas = new MAS[collection.Count()];

                int Count = 0;

                foreach (MAS item in collection)
                {
                    _tempMas[Count] = item;
                    Count++;
                }

                _tempMas.CopyTo(_mas, Length); //вставляем новые элементы

                Length += collection.Count();
            }

        }

        public object Clone()
        {
            DynamicArray<MAS> Temp = new DynamicArray<MAS>(this._mas);
            Temp.Length = this.Length;
            return Temp;
        }

        public virtual IEnumerator<MAS> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return _mas[i];
            }
        }


        public bool Insert(int index, MAS item)
        {
            if (index > Length - 1)
                throw new ArgumentOutOfRangeException("Index is out of range", "index");

            if (item == null)
                return false;

            int j = 0;

            if (Length < Capacity)
            {
                _tempMas = new MAS[Length + 1];

                for (int i = 0; i < _tempMas.Length; i++, j++)
                {
                    if (i == index)
                    {
                        _tempMas[i] = item;
                        j--;
                    }
                    else _tempMas[i] = _mas[j];
                }

                _mas = _tempMas;
                Length++;
            }
            else
            {
                _tempMas = _mas;
                _mas = new MAS[_tempMas.Length * 2];

                _tempMas.CopyTo(_mas, 0);

                _tempMas = new MAS[Length + 1];

                for (int i = 0; i < _tempMas.Length; i++, j++)
                {
                    if (i == index)
                    {
                        _tempMas[i] = item;
                        j--;
                    }
                    else _tempMas[i] = _mas[j];
                }

                _tempMas.CopyTo(_mas, 0);

                Length++;
            }

            return true;
        }



        public bool Contains(MAS item)
        {
            for (int i = 0; i < _mas.Length; i++)
            {
                if (item.Equals(_mas[i])) return true;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            _tempMas = new MAS[Length];

            for (int i = 0; i < Length; i++)
            {
                _tempMas[i] = _mas[i];
            }

            return _tempMas.GetEnumerator();
        }

        

        public MAS[] ToArray()
        {
            _tempMas = new MAS[Length];

            for (int i = 0; i < Length; i++)
            {
                _tempMas = _mas;
            }

            return _tempMas;
        }


        public bool Remove(MAS item)
        {
            int j = 0;
            int Index = 0;
            int LastCapacity;

            if (_mas.Contains(item))
            {
                _tempMas = new MAS[Length];
                LastCapacity = Capacity;

                for (int i = 0; i < _mas.Length; i++)
                {
                    if (_mas[i].Equals(item))
                    {
                        Index = i;
                        break;
                    }
                }


                for (int i = 0; i < Length; i++, j++)
                {
                    if (i != Index) _tempMas[j] = _mas[i];
                    else j--;
                }

                _mas = _tempMas; 
                Length--;
                Capacity = LastCapacity;

                return true;
            }

            return false;
        }
    }



    namespace Task3
    {
        class Program
        {
            static void Main(string[] args)
            {

                DynamicArray<string> arr = new DynamicArray<string>();

                Console.WriteLine(arr.Insert(1, "kek"));

            }


        }
    }
}