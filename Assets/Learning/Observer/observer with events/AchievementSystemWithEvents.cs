using UnityEngine;

namespace LearningPower.Observer
{
    /// <summary>
    /// This class implements the observer notifications through events of POIs instead
    /// of implements a base class that contains the base methods  
    /// </summary>
    public class AchievementSystemWithEvents : MonoBehaviour
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();
            
            // Here registers the method that contains a achievement to unlock
            PointOfInterestWithEvents.OnPOIEntered += PointOfInterest_OnPOIEntered;
        }

        private void OnDestroy()
        {
            // Here unregisters the method when the object is destroyed to clean memory
            PointOfInterestWithEvents.OnPOIEntered -= PointOfInterest_OnPOIEntered;
        }

        /// <summary>
        /// This method it's invoked through the OnTriggerEnter of PointOfInterestWithEvents
        /// and send it the poiName value
        /// </summary>
        /// <param name="poiName"></param>
        private void PointOfInterest_OnPOIEntered(string poiName)
        {
            string achievementKey = "achievement" + poiName;
            
            if(PlayerPrefs.GetInt(achievementKey) == 1)
                return;
            
            PlayerPrefs.SetInt(achievementKey, 1);
            Debug.Log($"Unlocked: {poiName}");
        }
    }
}