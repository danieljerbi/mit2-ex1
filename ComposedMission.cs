using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {

        private List<DelegateFunc> list;
        public ComposedMission(string name)
        {
            list = new List<DelegateFunc>();
            this.Name = name;
        }

        public string Name  // read-write instance property
        { get; set; }

        public string Type  // read-write instance property
        {  get
            {
                return "Composed";
            } }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            foreach (var delegate1 in list)
            {
                value = delegate1(value);
            }
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, value);
            }
            return value;
        }

        public ComposedMission Add(DelegateFunc func)
        {
            list.Add(func);
            return this;
        }
    }
}
