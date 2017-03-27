using System;
namespace BladowCasey_ex12_10
{
    interface IShape
    {
        string Name { get; }
        string ToString();
        int X { get; set; }
        int Y { get; set; }
    }
}
