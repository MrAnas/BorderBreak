using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

        public GameObject enemy;
        public Vector3 spawnValues;
        public int hazardCount;
        public float spawnWait;
        public float startWait;
        public float waveWait;
        public Transform goal;
        void Start()
        {
            StartCoroutine(SpawnWaves());
        }

        IEnumerator SpawnWaves()
        {
            yield return new WaitForSeconds(startWait);
            while (true) // Here if you want to change the number of waves later
            {
                for (int i = 0; i < hazardCount; i++)
                {
                    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    GameObject go = (GameObject) Instantiate(enemy, spawnPosition, spawnRotation);
                    EnemyMove enemymove = go.GetComponent<EnemyMove>();
                    enemymove.goal = goal;
                    yield return new WaitForSeconds(spawnWait);
                }
                yield return new WaitForSeconds(waveWait);
            }
        }
    }
