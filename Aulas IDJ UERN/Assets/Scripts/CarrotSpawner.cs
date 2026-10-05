using UnityEngine;

public class CarrotSpawner : MonoBehaviour
{
    [SerializeField] private GameObject carrotPrefab;
    [SerializeField] private int carrotAmount;

    [Header("Limites de Spawn na Tela")]
    [SerializeField] private float xMin;
    [SerializeField] private float xMax;
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;

    void Start()
    {
        SpawnCarrots();
    }

    private void SpawnCarrots()
    {
        for (int i = 0; i < carrotAmount; i++)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);
            Vector3 randomPosition = new Vector3(randomX, randomY, 0f);

            Instantiate(carrotPrefab, randomPosition, Quaternion.identity);
        }
    }
}