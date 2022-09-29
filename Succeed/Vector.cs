using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Succeed
{
    class Vector
    {

        private float x;//私有类不能直接访问
        private float y;
        private float z;

        public void SetX(float x)
        {
            this.x = x;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }

        public float GetX()
        {
            return x;
        }

        public float GetY()
        {
            return y;
        }

        public float GetZ()
        {
            return z;
        }

        public double Length()//求向量的长度
        {
            return Math.Sqrt(x*x+y*y+z*z);
        }
    }
}
