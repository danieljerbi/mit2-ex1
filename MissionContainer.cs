using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double DelegateFunc(double num);

    public class FunctionsContainer
    {
        Dictionary<string, DelegateFunc> dict = new Dictionary<string, DelegateFunc>();
        public double same(double val) => val; 
         
        public DelegateFunc this[string name]
        {
            get
            {
                if (dict.ContainsKey(name))
                {
                    return dict[name];
                }
                else
                {
                    dict[name] = val => val;
                    return dict[name];
                }

            }
            set
            {
                dict[name] = value;
            }
        }

        public List<string> getAllMissions()
        {
            return dict.Keys.ToList();
        }
    }
}

