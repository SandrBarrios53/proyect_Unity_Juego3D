using UnityEngine;

public class SpawnerPelotas : MonoBehaviour
{
    public GameObject pelotaPrefab;
    public float tiempo = 2f;

    void Start()
    {
        InvokeRepeating(nameof(CrearPelota), 0f, tiempo);
    }

    void CrearPelota()
    {
        float x = Random.Range(-130f, 130f);
        float z = Random.Range(-45f, 45f);
        Vector3 pos = new Vector3(x, 12f, z);
        Instantiate(pelotaPrefab, pos, Quaternion.identity);
    }
}

