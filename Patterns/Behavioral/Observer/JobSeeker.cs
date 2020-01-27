using System;

namespace Observer
{
    public class JobSeeker : IObserver<JobPost>
    {
        public JobSeeker(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        
        
        public void OnNext(JobPost value)
        {
            Console.WriteLine($"Hey {Name}, You have new job post with {value.Title} title.");
        }

        public void OnError(Exception error)
        {
        }

        public void OnCompleted()
        {
        }
    }
}