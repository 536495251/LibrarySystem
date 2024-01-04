using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemVersion2
{   
    public enum  Category
    {
        杂志期刊,
        计算机,
        文学,
        精品小说,
        经济理财,
        科学技术
    }
    public class Book
    {
        public string Name; //书名
        public string Press; // 出版社
        public int Count; // 图书数量
        public int ISBN;  // ISBN 图书标识
        public string Category;// 图书类别
        public string Remake; // 备注信息
        public int BorrowCount; // 借阅量
        public Image Image;
        public Book() { }
        public Book(string name, string press, int count, int isbn, string category, string remake, Image image)
        {
            Name = name;
            Press = press;
            Count = count;
            ISBN = isbn;
            Category = category;
            Remake = remake;
            Image = image;
        }
        public Book(string name,string press,int count,int borrowcount,int isbn,string category,string remake,Image image) 
        { 
            Name = name; 
            Press = press;
            Count = count;
            BorrowCount = borrowcount;
            ISBN = isbn;
            Category = category;
            Remake = remake;
            Image=image;
        }
        public Book(string name, string press, int count, int isbn, string category, Image image)
        {
            Name = name;
            Press = press;
            Count = count;
            ISBN = isbn;
            Category = category;
            Image = image;
        }
    }
}
