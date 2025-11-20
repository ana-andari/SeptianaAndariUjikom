using UnityEngine;

public class PlaySuara : MonoBehaviour
{
    public AudioSource _SFXGameplay;
    public AudioSource _SFXDestroyAnimal;
    public AudioSource _SFXEat;
    public AudioSource _SFXThrowFood;


    public void putarSFXGamePlay()
    {
        _SFXGameplay.Play();

    }
    public void putarSFXDestroyAnimal()
    {
        _SFXDestroyAnimal.Play();

    }
    public void putarSFXEat()
    {
        _SFXEat.Play();

    }

    public void putarSFXThrowFood()
    {
        _SFXThrowFood.Play();

    }
}
