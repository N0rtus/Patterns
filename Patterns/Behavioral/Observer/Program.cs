using System;

namespace Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var soheil = new JobSeeker("Soheil");
            var ali = new JobSeeker("Ali");
            
            var jobPosting = new JobPosting();

            jobPosting.Subscribe(soheil);
            jobPosting.Subscribe(ali);
            
            jobPosting.AddJob(new JobPost(".NET Developer"));
            jobPosting.AddJob(new JobPost("Java Developer"));

            Console.ReadKey();
        }
    }
}