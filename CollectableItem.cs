using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public Counter Counter;
    public bool DestroyAfterCollected = true;

    private void OnTriggerEnter(Collider other)
    {
        PlatformerCharacterController controller = other.GetComponent<PlatformerCharacterController>();
        if (!controller)
        {
            return;
        }

        Counter.AddCount();

        if (!DestroyAfterCollected)
        {
            return;
        }

        Destroy(gameObject);
    }
}
