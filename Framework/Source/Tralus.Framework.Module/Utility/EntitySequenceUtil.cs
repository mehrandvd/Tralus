using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Data;

namespace Tralus.Framework.Module.Utility
{
    public class EntitySequenceUtil
    {
        public static ConcurrentDictionary<string, EntitySequence> Cache = new ConcurrentDictionary<string, EntitySequence>();

        public static long GetNext(
            string sequenceName,
            string refInfo = null,
            string param1 = null,
            string param2 = null,
            string param3 = null,
            string param4 = null,
            string param5 = null
            )
        {
            using (var db = new FrameworkDbContext())
            {
                var seq = Cache.GetOrAdd(sequenceName, (seqName) =>
                {
                    var s = db.Set<EntitySequence>().FirstOrDefault(es => es.Name == seqName);

                    //if (s == null)
                    //{
                    //    var temp = db.Set<EntitySequence>().Create();
                    //    temp.Name = seqName;
                    //    temp.Description = $"Automatically created for: {refInfo}";
                    //    db.SaveChanges();
                    //}
                    return s;
                });

                if (seq == null)
                    throw new Exception($"Sequence is not defined: {sequenceName}");

                var sameSequenceItems = db.Set<EntitySequenceItem>()
                    .Where(si=>
                        si.Param1 == param1 &&
                        si.Param2 == param2 &&
                        si.Param3 == param3 &&
                        si.Param4 == param4 &&
                        si.Param5 == param5);

                var maxValue = 
                    sameSequenceItems.Any()?
                    sameSequenceItems.Max(si => si.SeqValue):
                    0;

                var esi = new EntitySequenceItem(true)
                {
                    SeqValue = maxValue + 1,
                    EntitySequenceId = seq.Id,
                    CreationDateTime = DateTime.Now,
                    RefInfo = refInfo
                };


                db.Set<EntitySequenceItem>().Add(esi);
                db.SaveChanges();

                return esi.SeqValue;
            }
        }
    }
}
