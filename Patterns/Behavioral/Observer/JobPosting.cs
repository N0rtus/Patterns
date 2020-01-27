using System;
using System.Collections.Generic;

namespace Observer
{
    public class JobPosting : IObservable<JobPost>
    {
        private List<IObserver<JobPost>> _observers;
        private List<JobPost> _jobPosts;

        public JobPosting()
        {
            _jobPosts = new List<JobPost>();
            _observers = new List<IObserver<JobPost>>();
        }

        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new UnSubscriber(_observers, observer);
        }

        private void Notify(JobPost jobPost)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(jobPost);
            }
        }
        
        public void AddJob(JobPost jobPost)
        {
            _jobPosts.Add(jobPost);
            Notify(jobPost);
        }
    }
}