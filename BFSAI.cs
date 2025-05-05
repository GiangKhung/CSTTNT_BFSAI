using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSAI
{
    class BFSAI
    {
        private DoThiBFS dt;
        private Queue<int> q;
        private Queue<int> q1;
        private int[] previous;
        static readonly int NIL = -5;
        //Hàm khởi tạo BFS
        public BFSAI()
        {
            dt = new DoThiBFS();
            q = new Queue<int>();
            previous = new int[dt.SoDinh];

            for(int i=0; i < dt.SoDinh; i++)
            {
                previous[i] = -2;
            }
            previous[dt.Start] = NIL;
            q.Enqueue(dt.Start);
        }
        //Hàm tìm kiếm BFS
        public void timKiemBFS()
        {
            while(q.Count > 0)
            {
                q1 = new Queue<int>();
                foreach (var s in q)
                {
                    for(int s1 = 0; s1 < dt.SoDinh; s1++)
                    {
                        if (dt.MaTran[s, s1] > 0 && previous[s1] == -2)
                        {
                            previous[s1] = s;
                            q1.Enqueue(s1);
                        }
                    }
                }
                q = q1;
            }
        }
        //Hàm in kết quả BFS
        public void InDuongDi()
        {
            if (previous[dt.Goal] == -2)
                Console.WriteLine("KHONG tim duoc duong di");
            else
            {
                int current = dt.Goal;
                System.Console.Write("\nDuong di: ");
                while(current != dt.Start)
                {
                    Console.Write($"{current} <== ");
                    current = previous[current];
                }
                Console.Write($"{dt.Start}");
            }
        }
    }
}
