using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Library_System.Models
{
    public interface IBorrowable
    {
        void Borrow();
        void Return();
    }
}
