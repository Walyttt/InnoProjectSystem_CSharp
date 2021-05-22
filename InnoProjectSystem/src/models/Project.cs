using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoProjectSystem.src.models
{
    public class Project
    {
		private string pNo;
		private string pName;
		private string fName;
		private string ptName;
		private string subName;
		private string colName;
		private int pGroup;

        public Project(string pNo = null, string pName = null, string fName = null, string ptName = null, string subName = null, string colName = null, int pGroup = 0)
        {
            this.PNo = pNo;
            this.PName = pName;
            this.FName = fName;
            this.PtName = ptName;
            this.SubName = subName;
            this.ColName = colName;
            this.PGroup = pGroup;
        }

        public string PNo { get => pNo; set => pNo = value; }
        public string PName { get => pName; set => pName = value; }
        public string FName { get => fName; set => fName = value; }
        public string PtName { get => ptName; set => ptName = value; }
        public string SubName { get => subName; set => subName = value; }
        public string ColName { get => colName; set => colName = value; }
        public int PGroup { get => pGroup; set => pGroup = value; }
    }
}
