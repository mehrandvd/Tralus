namespace Tralus.Framework.Module.Utility
{
    public class ScriptHost<T>
    {
        public ScriptHost(object entity)
        {
            Entity = (T) entity;
        }
        public T Entity { get; set; }

        public SequenceHost Sequence = new SequenceHost();
    }
}