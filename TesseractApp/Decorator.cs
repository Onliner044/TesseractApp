using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesseractApp.Contracts;

namespace TesseractApp
{
    public abstract class Decorator : IComponent
    {
        IComponent _component;

        public Decorator(IComponent component)
        {
            this._component = component;
        }

        public virtual void Execute()
        {
            _component.Execute();
        }
    }
}
