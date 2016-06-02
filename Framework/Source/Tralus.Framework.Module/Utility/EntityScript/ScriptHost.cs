using DevExpress.ExpressApp;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Utility
{
    public class ScriptHostBase
    {
        
    }

    public class ScriptHost<T> : ScriptHostBase
    {
        public ScriptHost(object entity, IObjectSpace objectSpace)
        {
            This = (T) entity;
            Sequence = new SequenceHost(This as EntityBase);
            Database = new DatabaseHost(objectSpace);
        }
        public T This { get; set; }

        public SequenceHost Sequence;

        public DatabaseHost Database;
    }
}