using System.Collections;
using UnityEngine;

namespace LearningPower.Prototype
{
    public class TextFloating : MonoBehaviour
    {
        [SerializeField] private float _verticalSpeed;
        private void OnEnable()
        {
            StartCoroutine(Kill());
        }

        private IEnumerator Kill()
        {
            yield return new WaitForSeconds(5f);
            Destroy(gameObject);
        }

        private void Update()
        {
           
            transform.position += Vector3.up * _verticalSpeed * Time.deltaTime;
        }
    }
}