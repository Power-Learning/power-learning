using System.Collections.Generic;
using UnityEngine;

namespace LearningPower.Observer
{
    public abstract class Observer : MonoBehaviour
    {
        public abstract void OnNotify(object value, NotificationType notificationType);
    }

    public abstract class Subject : MonoBehaviour
    {
        private List<Observer> _observers = new List<Observer>();

       /// <summary>
       /// Register the subscribers that for the system
       /// </summary>
       /// <param name="observer"></param>
        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Notifies when a subscriber was unlocked
        /// </summary>
        /// <param name="value"></param>
        /// <param name="notificationType"></param>
        protected void Notify(object value, NotificationType notificationType)
        {
            foreach (var observer in _observers)
                // call the OnNotify base method to send the message to all subscribers
                observer.OnNotify(value, notificationType);
        }
    }
}

