﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSAI
{
    class DoThiBFS
    {
        public int i;
        public int j;
        private int sodinh;
        private int start;
        private int goal;
        private int[,] matran;
        //Hàm khởi tạo lớp DoThi
        public DoThiBFS()
        {
            this.sodinh = -1;
            this.start = -1;
            this.matran = new int[7, 7];
            DocDoThi();
        }
        //Hàm đọc đồ thị từ tệp text
        public void DocDoThi()
        {
            //Đường đẫn tuyệt đối
            string textFile = @"D:\110122103\AI\CSTTNT_AI\BFSAI\BFS_input.txt";

            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                string line0 = lines[0].Trim();
                this.sodinh = int.Parse(line0);

                string line1 = lines[1].Trim();
                string[] tam = line1.Split(' ');
                this.start = int.Parse(tam[0]);
                this.goal = int.Parse(tam[1]);
                
                for(i=0; i < this.sodinh; i++)
                {
                    string linei = lines[i + 2].Trim();
                    string[] arr = linei.Split(' ');
                    for(j=0; j < this.sodinh; j++)
                    {
                        this.matran[i, j] = int.Parse(arr[j]);
                    }
                }
            }
        }
        //Hàm in đồ thị ra màn hình
        public void InDoThi()
        {
            System.Console.WriteLine($"So dinh: {this.sodinh}");
            System.Console.WriteLine($"Start: {this.start}\nGoal: {this.goal}");
            System.Console.WriteLine("\nMa tran duong di:");
            for(i=0; i < this.sodinh; i++)
            {
                for(j=0; j < this.sodinh; j++)
                {
                    Console.Write(this.matran[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        //Tạo danh sách các đỉnh kề
        
        public Queue<int> succs(int s)
        {
            Queue<int> ke = new Queue<int>();

            for (int i = 0; i < this.sodinh; i++)
            {
                if (matran[s, i] == 1)
                {
                    ke.Enqueue(i);
                }
            }

            return ke;
        }
        public void inDanhSachKe()
        {
            Console.WriteLine("\nDanh sach cac dinh ke:");
            for (int i = 0; i < this.sodinh; i++)
            {
                Queue<int> danhSachKe = succs(i);
                Console.Write("Dinh " + i + ": ");
                foreach (var dinh in danhSachKe)
                {
                    Console.Write(dinh + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        //GET và SET các thuộc tính
        public int SoDinh
        {
            get { return sodinh; }
            set { sodinh = value; }
        }
        public int Start
        {
            get { return start; }
            set { start = value; }
        }
        public int Goal
        {
            get { return goal; }
            set { goal = value; }
        }
        public int [,] MaTran
        {
            get { return matran; }
            set { matran = value; }
        }
    }
}
