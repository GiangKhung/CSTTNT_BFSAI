using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSAI
{
    class mainBFS
    {
        static void Main(string[] args)
        {
            //Đọc và in ma trận
            DoThiBFS dt = new DoThiBFS();
            dt.DocDoThi();
            dt.InDoThi();
            
            //In danh sách các đỉnh kề
            //dt.inDanhSachKe();
            
            //Test kết quả của BFS
            BFS bfs = new BFS();
            bfs.timKiemBFS();
            bfs.InDuongDi();
            
            Console.ReadLine();
        }
    }
}
