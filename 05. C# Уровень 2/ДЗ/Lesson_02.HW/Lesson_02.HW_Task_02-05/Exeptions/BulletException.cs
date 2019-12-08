using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class BulletException: ArgumentException
    {
        public BulletException(string message) : base(message)
        {


        }
    }
}
