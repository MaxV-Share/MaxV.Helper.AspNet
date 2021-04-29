using System;
using System.Collections.Generic;
using System.Text;

namespace MaxV.Helper.Entities
{
    public class GlobalVariable<T>
    {
        public GlobalVariable(T Object)
        {
            _object = Object;
        }

        private static T _object;
        public static T Object
        {
            get => _object;
        }
    }
}
