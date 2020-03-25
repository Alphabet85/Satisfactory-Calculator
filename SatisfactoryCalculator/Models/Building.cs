using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SatisfactoryCalculator.Models.Enums;

namespace SatisfactoryCalculator.Models
{
    public class Building
    {
        public string Name { get; set; }
        public BuildingType EBuildingType { get; set; }
        public string ResourceInput { get; set; }
        public int ResourceInputPerMinute { get; set; }
        public string ResourceOutput { get; set; }
        public int ResourceOutputPerMinute { get; set; }

    }
}
