using System.Collections;
using UnityEngine;

public class SkripMusuh : MonoBehaviour
{
    public GameObject musuhKapsul;
    public GameObject musuhKotak;
    public GameObject musuhHexagon;


    public bool masihSpawn = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnMusuhKapsul());
        StartCoroutine(spawnMusuhKotak());
        StartCoroutine(spawnMusuhHexagon());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnMusuhKapsul()
    {
        while (masihSpawn)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 5, 0);

            GameObject objectBaru = Instantiate(musuhKapsul, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator spawnMusuhKotak()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(2);
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 5, 0);
            GameObject objectBaru = Instantiate(musuhKotak, spawnPosition, Quaternion.identity);
        }
    }

    IEnumerator spawnMusuhHexagon()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(3);
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 5, 0);
            GameObject objectBaru = Instantiate(musuhHexagon, spawnPosition, Quaternion.identity);
        }
    }

}
