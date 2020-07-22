using UnityEngine;

namespace LearningPower.LearningPatterns.Observer
{
    /// <summary>
    /// This class represent the subscriber for the AchievementSystem observer
    /// </summary>
    public class PointOfInterest : Subject
    {
        [SerializeField] private string _poiName;

        private void Start()
        {
            _poiName = name;
        }

        private void OnTriggerEnter(Collider other)
        {
            // When occurs the trigger event, this call the Notify base method
            // and send the value and the type of Notification
            Notify(_poiName, NotificationType.AchievementUnlocked);
        }
    }
}