using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Налаштування генерації")]
    public int numberOfObjects = 5; // Кількість об'єктів
    public float spawnRange = 10.0f; // Межі розміщення (від -10 до 10)

    void Start()
    {
        GenerateObjects();
    }

    void GenerateObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {

            PrimitiveType randomType = (PrimitiveType)Random.Range(0, 4);
            GameObject newObj = GameObject.CreatePrimitive(randomType);

            float randomX = Random.Range(-spawnRange, spawnRange);
            float randomZ = Random.Range(-spawnRange, spawnRange);

            newObj.transform.position = new Vector3(randomX, 0.5f, randomZ);

            newObj.name = "Generated Object " + i;
        }
    }

    // Генерація при натисканні клавіші
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateObjects();
        }
    }
}