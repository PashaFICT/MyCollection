using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class MyColl<T> : IEnumerable where T : IComparable
    {
        private T[] _arr;
        private T _maxValue;
        private int _length;
        private int _currentValue;
        public MyColl()
        {
            _currentValue = 0;
            _length = 16;
            _arr = new T[_length];
        }
        //Получить макс. значение О(1)
        public T MaxValue()
        {
            try
            {
                return _maxValue;
            }
            catch
            {
                throw new Exception();
            }
            
        }

        // Получить по индексу О(1)
        public T GetByIndex(int index)
        {
            if (index < _length)
                return _arr[index];
            else throw new Exception();
        }

        // Вставка О(1)

        public void Add( T element)
        {
            //if (element > _maxValue)
            //    _maxValue = element;
            if (_currentValue >= _length)
            {
                Expansion();
            }
            _arr[_currentValue++] = element;

        }

        // Вставка по индексу О(n)
        public void AddByIndex(int index, T element)
        {
            if (index >= _length)
            {
               Expansion(index);
            }
            _arr[index] = element;


        }

        // Удаление О(n)

        public void Remove(T element)
        {
           // _arr = _arr.Where(val => val != element).ToArray();
            //foreach (T t in _arr)
            //{
            //    if (t != element)
            //}
        }
        // Удаление по индексу О(n)
        public void RemoveByIndex(int index)
        {
            
            
        }


        // Расширение массива
        private void Expansion(int size)
        {
            Array.Resize(ref _arr, size);
            _length = size;
        }
        private void Expansion()
        {
            Array.Resize(ref _arr, _arr.Length * 2);
            _length *= 2;
        }

        // Проверка на число
        private bool Validation(T element)
        {
            if (element is byte || element is int || element is long || element is double || element is float || element is decimal)
            {
                return true;
            }
            else
            {
                throw new Exception();
                //return false;
            }
        }

        //public int CompareTo(object o1, object o2)
        //{
        //    if (o1 != o2)
        //        return 1;
        //    else
        //        return 0;
        //}

        public IEnumerator GetEnumerator()
        {
            return _arr.GetEnumerator();
        }

    }
}
