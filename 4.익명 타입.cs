using System;
using System.Collections.Generic;
using System.Text;

namespace _20220808
{
    class _4
    {
        private void RunTest()
        {
            var v = new[] {
        new { Name="Lee", Age=33, Phone="02-111-1111" },
        new { Name="Kim", Age=25, Phone="02-222-2222" },
        new { Name="Park", Age=37, Phone="02-333-3333" },
    };

            // LINQ Select를 이용해 Name과 Age만 갖는 새 익명타입 객체들을 리턴.
            var list = v.Where(p => p.Age >= 30).Select(p => new { p.Name, p.Age });
            foreach (var a in list)
            {
                Debug.WriteLine(a.Name + a.Age);
            }
        }

    }
}
