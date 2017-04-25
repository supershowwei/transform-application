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
                    return new TestBaseJob(name);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}