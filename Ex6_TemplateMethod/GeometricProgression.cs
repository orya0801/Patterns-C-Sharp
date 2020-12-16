using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_TemplateMethod
{
    class GeometricProgression : Progression
    {
        public GeometricProgression(int f, int l, int h) : base(f, l, h) { }

        public override void Progress()
        {
            int fF = First;
            do
            {
                progList.Add(fF);
                fF = fF * H;
            }
            while (fF <= Last);
        }
    }
}
