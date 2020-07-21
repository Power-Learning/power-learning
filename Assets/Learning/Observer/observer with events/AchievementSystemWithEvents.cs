using System;
using UnityEngine;

namespace LearningPower.Observer
{
    public class AchievementSystemWithEvents : MonoBehaviour
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();
            PointOfInterestWithEvents.OnPOIEntered += PointOfInterest_OnPOIEntered;
        }

        private void OnDestroy()
        {
            PointOfInterestWithEvents.OnPOIEntered -= PointOfInterest_OnPOIEntered;
        }

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