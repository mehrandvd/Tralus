namespace Tralus.Framework.Module.Utility
{
    public class SequenceHost
    {
        public long GetNext(
            string sequenceName,
            string refInfo = null,
            string param1 = null,
            string param2 = null,
            string param3 = null,
            string param4 = null,
            string param5 = null
            )
        {
            return EntitySequenceUtil.GetNext(sequenceName, refInfo, param1, param2, param3, param4, param5);
        }
    }
}