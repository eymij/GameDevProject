
using UnityEngine;

public class FinishLinee : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneCon.instance.NextLevel();

        }
    }

}
