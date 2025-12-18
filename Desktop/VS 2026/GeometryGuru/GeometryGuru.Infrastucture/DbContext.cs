using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryGuru.Domain;

namespace GeometryGuru.Infrastucture
{
    public class DbContext
    {
        public DbContext()
        {
            this.Geometry=new Geometry[50];
        }
        public Geometry[] Geometry {  get; set; }
    }
}
