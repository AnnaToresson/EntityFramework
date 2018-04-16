using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class BattleLog
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<BattleEvent> Event { get; set; }

    }

    //public class BattleEvent
    //{
    //    public int Id { get; set; }
    //    public int BattleLogId { get; set; }
    //    public string Name { get; set; }
    //    public string Summary { get; set; }
    //    public DateTime Time { get; set; }

    //}


}
