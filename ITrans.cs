using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaOpenGl
{
    interface ITrans
    {

        void RotateX(float Angle);

        void RotateY(float Angle);

        void RotateZ(float Angle);

        void Scale(float valor);

        void TraslateX(float valor);
        void TraslateY(float valor);
        void TraslateZ(float valor);
    }
}
