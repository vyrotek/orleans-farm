using Farm.Core;
using Orleans;
using System;
using System.Threading.Tasks;

namespace Farm.Silo
{
    public class ValueGrain : Grain, IValueGrain
    {
        private string value = "none";

        public Task<string> GetValue()
        {
            return Task.FromResult(this.value);
        }

        public Task SetValue(string value)
        {
            this.value = value;
            return Task.CompletedTask;
        }
    }
}