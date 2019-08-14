using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
        private string firstDate;

        private string secondDate;

        public DateModifier(string firstDate , string secondDate)
        {
            FirstDate = firstDate;
            SecondDate = secondDate;
        }
        public string Difference()
        {
            var firstDateI = firstDate
                .Split()
                .Select(int.Parse)
                .ToArray();
            var secondDateI = secondDate
                .Split()
                .Select(int.Parse)
                .ToArray();
            DateTime x = new DateTime(firstDateI[0], firstDateI[1], firstDateI[2]);
            DateTime y = new DateTime(secondDateI[0], secondDateI[1], secondDateI[2]);

            TimeSpan span = x.Subtract(y);

            return Math.Abs(span.Days).ToString();
        }
        public string FirstDate
        {
            get => this.firstDate;
            set => this.firstDate = value;
        }

        public string SecondDate
        {
            get => this.secondDate;
            set => this.secondDate = value;
        }
    }

       
}
