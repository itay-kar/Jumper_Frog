using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

/**
 * This component spawns the given object at fixed time-intervals at its object position.
 */
public class TimedSpawner: MonoBehaviour {
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [SerializeField] float secondsBetweenSpawns = 1f;

    // OLD CODE using coroutines:
    //
    void Start() {
        this.StartCoroutine(SpawnRoutine());
        Debug.Log("Start finished");
    }
    
    IEnumerator SpawnRoutine() {
        while (true) {
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, transform.position, transform.rotation);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }
}