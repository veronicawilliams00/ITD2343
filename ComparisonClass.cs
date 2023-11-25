using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Williams
{
    internal class ComparisonClass
    {

        private int _textLeft;
        private int _textCheck;
        private int _textRight;

        public int TextLeft
        {
            get { return this._textLeft; }
            set { this._textLeft = value; }
        }
        public int TextCheck
        {
            get { return this._textCheck; }
            set { this._textCheck = value; }
        }
        public int TextRight
        {
            get { return this._textRight; }
            set { this._textRight = value; }
        }
        public string ForAns()
        {
            if (TextCheck > TextLeft && TextCheck < TextRight)
            {
                return String.Format("{0} {1} {2} {3} {4}", this.TextCheck, "is between the values", this.TextLeft, "and", this.TextRight);
            }
            else if (TextCheck > TextRight && TextCheck > TextLeft)
            {
                return String.Format("{0} {1} {2} {3} {4}", this.TextCheck, "is greater than the values", this.TextLeft, "and", this.TextRight);
            }
            else if (TextLeft > TextCheck && TextLeft > TextRight)
            {
                return String.Format("{0} {1} {2} {3} {4}", this.TextLeft, "is greater than the values", this.TextCheck, "and", this.TextRight);
            }
            else if (TextCheck == TextLeft)
            {
                return String.Format("{0} {1} {2}", this.TextCheck, "is equal to", this.TextLeft);
            }
            else if (TextCheck == TextRight)
            {
                return String.Format("{0} {1} {2}", this.TextCheck, "is equal to", this.TextRight);
            }
            else if (TextCheck > TextLeft)
            {
                return String.Format("{0} {1} {2}", this.TextCheck, "is greater than", this.TextLeft);
            }
            else if (TextCheck > TextRight)
            {
                return String.Format("{0} {1} {2}", this.TextCheck, "is greater than", this.TextRight);
            }
            else
            {
                return String.Format("{0} {1} {2}", this.TextLeft, this.TextCheck, this.TextRight);
            }
        }
    }

    }


      

