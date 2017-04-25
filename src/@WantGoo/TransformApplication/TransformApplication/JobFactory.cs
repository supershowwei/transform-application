using System;
using TransformApplication.Jobs;

namespace TransformApplication
{
    internal static class JobFactory
    {
        public static IJob GenerateJob(string name)
        {
            switch (name)
            {
                case "TestJob":
                    return new TestJob(name);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}