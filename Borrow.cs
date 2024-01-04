using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemVersion2
{
    public class Borrow
    {
        public int BorrowBookID; // 
        public int BookID;  // 
        public int UserID;// 
        public DateTime BorrowDate;// 
        public DateTime ReturnDate;// 
        public int BookCount;// 
        public Borrow(int borrowbookID, int bookID)
        { 
            BorrowBookID= borrowbookID;
            BookID= bookID;
        }
        public Borrow(int borrowbookID, int bookID,DateTime borrowDate,DateTime returnDate)
        {
            BorrowBookID = borrowbookID;
            BookID = bookID;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
        }

    }
}
