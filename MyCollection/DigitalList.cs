using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class DigitalLIst<T> : IEnumerable<T> where T : IComparable
    {
        private T[] _arr;
        private T _maxValue;
        private int _length;
        private int _currentValue;
        public DigitalLIst()
        {
            Validation();
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
            if (element.CompareTo(_maxValue) == 1)
                _maxValue = element;
            if (_currentValue >= _length)
            {
                Expansion();
            }
            _arr[_currentValue++] = element;

        }

        // Вставка по индексу О(n)
        public void AddByIndex(int index, T element)
        {
            if (element.CompareTo(_maxValue) == 1)
                _maxValue = element;
            if (index >= _length)
            {
               Expansion(index);
            }
            _arr[index] = element;


        }

        // Удаление О(n)

        public void Remove(T element)
        {
            _arr = _arr.Where((val, idx) => val.CompareTo(element) != 0).ToArray();

        }
        // Удаление по индексу О(n)
        public void RemoveByIndex(int index)
        {
            T[] newArr = new T[_arr.Length - 1];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (i < index)
                {
                    newArr[i] = _arr[i];
                }
                else if (i > index)
                {
                    newArr[i - 1] = _arr[i];
                }
            }
            _arr = newArr;
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
        private bool Validation()
        {
            if (_maxValue is byte || _maxValue is int || _maxValue is long || _maxValue is double || _maxValue is float || _maxValue is decimal)
            {
                return true;
            }
            else
            {
                throw new Exception();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _arr.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)_arr).GetEnumerator();
        }
    }
}
