﻿using UnityTests.Data;

namespace UnityTests.Business
{
    public class BusinessClass : IBusiness
    {
        IData _dataClass;

        public BusinessClass(IData dataClass)
        {
            _dataClass = dataClass;
        }

        public string GetBusinessData()
        {
            return _dataClass.GetData();
        }
    }
}
