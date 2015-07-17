namespace PaulSharp.Console.Models
{
    public class MyDate
    {
        private System.DateTime _innerDateTime;
        private bool isYearOnly { get; set; }
        public override string ToString()
        {
            if (isYearOnly)
            {
                return this._innerDateTime.ToString("yyyy");
            }
            return this._innerDateTime.ToString();
        }
        public MyDate(int _year)
        {
            if(_year > -1 && _year < 9999)
            {
                this.isYearOnly = true;
                this._innerDateTime = new System.DateTime(_year, 1, 1);
            }
        }
        public MyDate(int _year, int _month, int _date)
        {
            this.isYearOnly = false;
            this._innerDateTime = new System.DateTime(_year, _month, _date);
        }
    }
}