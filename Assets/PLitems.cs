using UnityEngine;

public class ItemInteractor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        IPickable pickable = other.GetComponent<IPickable>();

        if (pickable != null)
        {
            pickable.PickUp();
        }
    }
}