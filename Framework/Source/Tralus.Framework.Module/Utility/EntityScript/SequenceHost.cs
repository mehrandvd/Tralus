using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Utility
{
    public class SequenceHost
    {
        private readonly EntityBase _thisEntity;

        public SequenceHost(EntityBase thisEntity)
        {
            _thisEntity = thisEntity;
        }

        public long GetNext(
          string sequenceName,
          EntityBase forEntity = null,
          EntityBase restartBy1 = null,
          EntityBase restartBy2 = null,
          EntityBase restartBy3 = null,
          EntityBase restartBy4 = null,
          EntityBase restartBy5 = null
          )
        {
            if (forEntity == null)
                forEntity = _thisEntity;

            return EntitySequenceUtil.GetNext(
                sequenceName,
                forEntity,
                restartBy1,
                restartBy2,
                restartBy3,
                restartBy4,
                restartBy5
                );
        }

        //public long GetNext(
        //    string sequenceName,
        //    EntityBase forEntity = null,
        //    string restartBy1 = null,
        //    string restartBy2 = null,
        //    string restartBy3 = null,
        //    string restartBy4 = null,
        //    string restartBy5 = null
        //    )
        //{
        //    if (forEntity == null)
        //        forEntity = _thisEntity;

        //    return EntitySequenceUtil.GetNext(
        //        sequenceName,
        //        forEntity,
        //        restartBy1,
        //        restartBy2,
        //        restartBy3,
        //        restartBy4,
        //        restartBy5
        //        );
        //}

        public long GetNextCore(
            string sequenceName,
            string param1 = null,
            string param2 = null,
            string param3 = null,
            string param4 = null,
            string param5 = null,
            string usedFor = null
            )
        {
            return EntitySequenceUtil.GetNext(sequenceName, param1, param2, param3, param4, param5, usedFor);
        }
    }
}