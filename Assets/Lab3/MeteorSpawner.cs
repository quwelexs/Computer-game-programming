using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public Transform playerTransform;
    public float spawnInterval = 3f;
    public float spawnRadius = 15f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnMeteor), 2f, spawnInterval);
    }

    void SpawnMeteor()
    {
        if (playerTransform == null) return;

        Vector2 randomCirclePoint = Random.insideUnitCircle.normalized * spawnRadius;
        Vector3 spawnPosition = new Vector3(randomCirclePoint.x, randomCirclePoint.y, 0f);

        GameObject newMeteor = ObjectPooler.Instance.SpawnFromPool("Meteor", spawnPosition, Quaternion.identity);

        Meteor meteorScript = newMeteor.GetComponent<Meteor>();
        if (meteorScript != null)
        {
            meteorScript.SetTarget(playerTransform.position);
        }
    }
}