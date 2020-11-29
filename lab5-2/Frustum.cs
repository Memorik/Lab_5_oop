using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Frustum : Cone
    {
        private double secondRadius;
        public Frustum()
        {
            secondRadius = Convert.ToDouble(Program.MainForm.lRadiusU.Text);
        }
        public override double Area()
        {
            double result = (1.0/3.0) * (Math.PI * height * (Math.Pow(coneRadius, 2) * Math.Pow(secondRadius, 2) * coneRadius * secondRadius));
            return result;
        }
    }
}
