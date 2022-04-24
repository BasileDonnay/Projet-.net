
using UnityEngine;

public class PickupObjet : MonoBehaviour
{
    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.CompareTag("Player"))
        {
            AudioManager.instance.PlayClipAt(sound, transform.position);
            Inventory.instance.AddCoins(1);
            Destroy(gameObject);
        }



    }
}
