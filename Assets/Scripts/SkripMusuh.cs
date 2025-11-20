using System.Collections;
using UnityEngine;

public class SkripMusuh : MonoBehaviour
{
    public GameObject musuhKapsul;
    public Sprite[] daftarGambarMusuh;

    public bool masihSpawn = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnMusuh());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnMusuh()
    {
        while (masihSpawn)
        {
            //ambil posisi untuk spawn dengan posisi x antara -8 s.d. 8 dan posisi y tetap di 5
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 5, 0);

            //Instantiate 1 daurUlangObject di spawnPosition kemudian simpan di objectBaru
            GameObject objectBaru = Instantiate(musuhKapsul, spawnPosition, Quaternion.identity);

            // cek apakah array gambar untuk sampah daur ulang > 0
            if (daftarGambarMusuh.Length > 0)
            {
                // ambil nilai random dari 0 s.d. Length daftarGambarDaurUlang untuk menentukan index gambar yang mau ditampilkan
                int index = Random.Range(0, daftarGambarMusuh.Length);

                //buat object Sprite untuk menyimpan gambar sampah daur ulang terpilih melalui pengacakan index
                Sprite gambarTerpilih = daftarGambarMusuh[index];

                //render objectBaru dengan gambar terpilih
                objectBaru.GetComponent<SpriteRenderer>().sprite = gambarTerpilih;

                BoxCollider2D colliderBox = objectBaru.GetComponent<BoxCollider2D>();

                if (colliderBox != null)
                {
                    colliderBox.size = gambarTerpilih.bounds.size;
                    colliderBox.offset = Vector2.zero;
                }

            }
            //menentukan delay s.d. pemanggilan berikutnya di 2 detik
            yield return new WaitForSeconds(1);
        }
    }
}
