using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public string Name  // read-write instance property
        { get; set; }

        public string Type  // read-write instance property
        {
            get
            {
                return "Single";
            }
        }

        private DelegateFunc delegateFunc;

        public SingleMission(DelegateFunc del, string name)
        {
            Name = name;
            delegateFunc = del;
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double retVal = delegateFunc(value);
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, retVal);
            }
            return retVal;
        }
    }
}
