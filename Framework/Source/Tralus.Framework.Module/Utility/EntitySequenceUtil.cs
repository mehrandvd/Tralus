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
           EntityBase forEntity,
           EntityBase restartBy1 = null,
           EntityBase restartBy2 = null,
           EntityBase restartBy3 = null,
           EntityBase restartBy4 = null,
           EntityBase restartBy5 = null
           )
        {
            var usedFor = forEntity.Id.ToString();
            return GetNext(
                sequenceName,
                restartBy1?.Id.ToString(),
                restartBy2?.Id.ToString(),
                restartBy3?.Id.ToString(),
                restartBy4?.Id.ToString(),
                restartBy5?.Id.ToString(),
                usedFor
                );
        }

        public static long GetNext(
            string sequenceName,
            EntityBase forEntity,
            string restartBy1 = null,
            string restartBy2 = null,
            string restartBy3 = null,
            string restartBy4 = null,
            string restartBy5 = null
            )
        {
            var usedFor = forEntity.Id.ToString();
            return GetNext(
                sequenceName,
                restartBy1,
                restartBy2,
                restartBy3,
                restartBy4,
                restartBy5,
                usedFor
                );
        }

        public static long GetNext(
            string sequenceName,
            string param1 = null,
            string param2 = null,
            string param3 = null,
            string param4 = null,
            string param5 = null,
            string usedFor = null
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
                    //    temp.Description = $"Automatically created for: {usedFor}";
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
                    Param1 = param1,
                    Param2 = param2,
                    Param3 = param3,
                    Param4 = param4,
                    Param5 = param5,
                    UsedFor = usedFor
                };


                db.Set<EntitySequenceItem>().Add(esi);
                db.SaveChanges();

                return esi.SeqValue;
            }
        }
    }
}
