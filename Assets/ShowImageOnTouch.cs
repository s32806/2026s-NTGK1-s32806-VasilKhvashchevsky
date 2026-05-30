using UnityEngine;

public class ShowImageOnTouch : MonoBehaviour
{
    public GameObject imageUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            imageUI.SetActive(true);
        }
    }
}