using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Talent { get; set; }
        public int Value { get; set; }
    }
}
