using System;
using System.Threading.Tasks;
using Orleans;

namespace Farm.Core
{
    public interface IValueGrain : IGrainWithIntegerKey
    {
        Task<string> GetValue();

        Task SetValue(string value);
    }
}
