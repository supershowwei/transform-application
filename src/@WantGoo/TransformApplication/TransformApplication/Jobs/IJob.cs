using System;
using System.Threading;
using System.Threading.Tasks;

namespace TransformApplication.Jobs
{
    internal interface IJob
    {
        Task Task { get; }

        void Run(Action jobCompleted = null, CancellationTokenSource cancellationTokenSource = null);

        void SetCustomDate(DateTime? date);
    }
}