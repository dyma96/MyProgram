using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using elemntType;

namespace sort
{
    // quick sort
    class qSort
    {
        // quick sort массива mas с begin элемента до end.
        public static void qsort(ElementType[] mas, int begin, int end)
        {
            int general = 0;
            int i = 0;
            for (i = 0; i < end - begin && mas[begin + i].value() == mas[begin].value(); i++) ;

            if (mas[begin].value() == mas[begin + i].value())
                return;
            else if (mas[begin].value() < mas[begin + i].value())
                general = mas[begin + i].value();
            else
                general = mas[begin].value();

            int left = begin;
            int right = end;

            while (left < right)
            {
                while (mas[left].value() < general)
                    left++;
                while (mas[right].value() > general || mas[right].value() == general)
                    right--;
                if (left >= right)
                    break;
                ElementType.swap(ref mas[left], ref mas[right]);

                left++;
                right--;
            }
            qsort(mas, begin, right);
            qsort(mas, left, end);
        }
    }
}
