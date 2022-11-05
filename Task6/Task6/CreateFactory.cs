using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class CreateFactory
    {
        public ColoredBulb returnColor(int number)
        {
            switch (number)
            {
                case 1:
                    return new Red();
                    break;
                case 2:
                    return new Yellow();
                    break;
                case 3:
                    return new Green();
                    break;
                case 4:
                    return new Blue();
                    break;
                case 5:
                    return new Red();
                    break;
                default:
                    throw new InvalidDataException();

            }

        }
    }
}
