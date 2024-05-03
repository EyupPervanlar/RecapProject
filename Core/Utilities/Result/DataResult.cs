﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool succces,string message):base(succces,message)
        {
            Data = data;
        }
        public DataResult(T data, bool succces) : base(succces)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
