using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class CoinManager : MonoBehaviour
    {
        public float lifeTime = 5;
        public int scoreValue = 20;
        private float speed = 100.0f;

        // Rotate the coin
        void Update()
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);

        }

        void Start()
        {
            StartCoroutine(Duration());
        }

        IEnumerator Duration()
        {
            yield return new WaitForSeconds(lifeTime);
            Destroy(gameObject);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Destroy(gameObject);
                ScoreManager.score += scoreValue;
            }
        }

    }
}