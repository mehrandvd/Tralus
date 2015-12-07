namespace Tralus.Framework.BusinessModel.Utility
{
    public class WorkerResult
    {
        public WorkerResult(string resultSummary)
        {
            ResultSummary = resultSummary;
        }

        public string ResultSummary { get; set; }

        public override string ToString()
        {
            return ResultSummary;
        }
    }
}