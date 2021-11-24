﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Interfaces
{
    public interface IObserver<T>
    {
        public void Update(T provider);
        public List<T> GetObservables();
    }
}
