using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoProjectSystem.src.models
{
    class Faculty
    {
		private string fNo;
		private string fName;
		private string fGender;
		private string fTitle;
		private string fCollege;
		private string fEmail;

        public Faculty(string fNo = null, string fName = null, string fGender = null, string fTitle = null, string fCollege = null, string fEmail = null)
        {
            this.FNo = fNo;
            this.FName = fName;
            this.FGender = fGender;
            this.FTitle = fTitle;
            this.FCollege = fCollege;
            this.FEmail = fEmail;
        }

        public string FNo { get => fNo; set => fNo = value; }
        public string FName { get => fName; set => fName = value; }
        public string FGender { get => fGender; set => fGender = value; }
        public string FTitle { get => fTitle; set => fTitle = value; }
        public string FCollege { get => fCollege; set => fCollege = value; }
        public string FEmail { get => fEmail; set => fEmail = value; }
    }
}
