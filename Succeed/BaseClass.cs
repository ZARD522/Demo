using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Succeed
{
    class BaseClass
    {

        protected int width;//子类可访问
        protected int height;
        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setHeight(int height)
        {
           this.height = height;
        }


        
    }
}
