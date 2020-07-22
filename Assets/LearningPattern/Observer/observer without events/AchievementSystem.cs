using UnityEngine;

namespace LearningPower.LearningPatterns.Observer
{
    public class AchievementSystem : Observer
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();
           
            // Search for all subscribers that observer is interested
            // This could also be a respawn point
            foreach (var poi in FindObjectsOfType<PointOfInterest>())
            {
                poi.RegisterObserver(this);
            }
        }

        /// <summary>
        /// This is called when a change was made
        /// </summary>
        /// <param name="value"></param>
        /// <param name="notificationType"></param>
        public override void OnNotify(object value, NotificationType notificationType)
        {
            if (notificationType == NotificationType.AchievementUnlocked)
            {
                string achivementKey = "achiviement" + value;

                if (PlayerPrefs.GetInt(achivementKey) == 1)
                    return;

                PlayerPrefs.SetInt(achivementKey, 1);
                Debug.Log($"Unlocked: {value}");
            }
        }
    }

    /// <summary>
    /// This defines a type of notify
    /// </summary>
    public enum NotificationType
    {
        AchievementUnlocked
    }
}