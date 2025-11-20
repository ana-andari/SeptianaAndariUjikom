using Unity.Mathematics;
using UnityEngine;
public class Peluru : MonoBehaviour
{
    public GameObject peluru;
    public float gayaLompat = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Klik");
            MunculPeluru();
        }
    }

    void MunculPeluru()
    {
        //posisi kursor mouse
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //posisi titik paling atas layar 
        Vector3 titikbawah = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));

        //posisi kursor sumbu x, titik paling atas layar dan vector3 tempat jatuh
        Vector3 tempatJatuh = new Vector3(0, titikbawah.y, 0);

        //memunculkan objek bola jatuh di posisi tempat jatuh dengan rotasi quaternion.identity
        Instantiate(peluru, tempatJatuh, Quaternion.identity);
    }
}
