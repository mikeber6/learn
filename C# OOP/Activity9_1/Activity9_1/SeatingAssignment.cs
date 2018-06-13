using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_1
{
    class SeatingAssignment
    {
        int _row;
        int _seat;
        string _student;

        public SeatingAssignment(int row, int seat, string student)
        {
            Row = row;
            Seat = seat;
            Student = student;
        }

        public int Row { get => _row; set => _row = value; }
        public int Seat { get => _seat; set => _seat = value; }
        public string Student { get => _student; set => _student = value; }
    }
}
