using UnityEngine;

public class Nyawa : MonoBehaviour
{
    public GameObject objectTerdeteksi;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (objectTerdeteksi != null)
        {
            if (objectTerdeteksi.CompareTag("Lantai"))
            {
                GameObject objectHapus = objectTerdeteksi.gameObject;
                Destroy(objectHapus);
            }
        }

    }
}
