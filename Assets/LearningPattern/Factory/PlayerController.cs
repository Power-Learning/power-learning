using System.Collections;
using UnityEngine;

namespace LearningPattern.Factory
{
    /// <summary>
    /// This class shows the particles from factory
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private GameObject[] _particles;
        public int Health { get; internal set; }

        public void ShowParticle(int index)
        {
            GameObject currentParticle = _particles[index];
            
            currentParticle.SetActive(true);
            StartCoroutine(HideParticleDelayed(currentParticle));
        }

        private IEnumerator HideParticleDelayed(GameObject currentParticle)
        {
            yield return new WaitForSeconds(currentParticle.GetComponent<ParticleSystem>().main.duration * 2);
            currentParticle.SetActive(false);
        }
    }
}