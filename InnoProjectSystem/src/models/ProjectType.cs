using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoProjectSystem.src.models
{
    public class ProjectType
    {
        private int ptId;
        private string ptName;
        private string ptDes;

        public ProjectType()
        {
        }

        public ProjectType(int ptId, string ptName, string ptDes)
        {
            this.PtId = ptId;
            this.PtName = ptName;
            this.PtDes = ptDes;
        }

        public int PtId { get => ptId; set => ptId = value; }
        public string PtName { get => ptName; set => ptName = value; }
        public string PtDes { get => ptDes; set => ptDes = value; }
    }
}
