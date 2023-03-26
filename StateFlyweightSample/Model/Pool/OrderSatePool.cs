using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateFlyweightSample.Model.States;

namespace StateFlyweightSample.Model.Pool
{
    public class OrderSatePool
    {
        // public static Dictionary<string, OrderState> _state = new Dictionary<string, OrderState>(); 
        // **** this is not safe we should use ConcurrentDictionary. ****

        //  ConcurrentDictionary this is thread safe  
        public static ConcurrentDictionary<string, OrderState> _state = new ConcurrentDictionary<string, OrderState>();
        public static T GetState<T>() where T : OrderState, new()
        {
            var typeName = typeof(T).Name;
            return _state.GetOrAdd(typeName, (key) => new T()) as T;

            // ****if (_state.ContainsKey(typeName))
            //    _state.Add(typeName, new T());

            //return _state[typeName] as T ****;
        }
    }
}
