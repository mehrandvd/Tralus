using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("DummyObject", Schema = "System")]
    public class DummyObject : EntityBase
    {
        public byte[] DummyData { get; set; }

        public Guid TestPack { get; set; }

        public static DummyObject CreateDummyObject(int bytes, Guid testPack)
        {
            var dummyObject = new DummyObject()
            {
                Id = Guid.NewGuid(),
                DummyData = new byte[bytes]
            };
            dummyObject.TestPack = testPack;
            return dummyObject;
        }

        public static DummyObject Create1B(Guid testPack)
        {
            return CreateDummyObject(1, testPack);
        }

        public static DummyObject Create1K(Guid testPack)
        {
            return CreateDummyObject(1000, testPack);
        }

        public static DummyObject Create10K(Guid testPack)
        {
            return CreateDummyObject(10000, testPack);
        }

        public static DummyObject Create100K(Guid testPack)
        {
            return CreateDummyObject(100000, testPack);
        }

        public static DummyObject Create1000K(Guid testPack)
        {
            return CreateDummyObject(1000000, testPack);
        }
    }
}
