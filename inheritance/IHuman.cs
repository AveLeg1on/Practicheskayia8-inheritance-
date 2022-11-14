using System;

namespace inheritance
{
    internal interface IHuman : IComparable, ICloneable
    {

        string Name { get; set; }
        string SecondName { get; set; }
        string SureName { get; set; }
        bool PrintName(string FIO, out string name);
        new object Clone();
        new int CompareTo(object obj);
        
    }
}
