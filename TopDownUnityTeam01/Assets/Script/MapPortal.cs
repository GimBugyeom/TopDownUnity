using Unity.Cinemachine;
using UnityEngine;

public class MapPortal : MonoBehaviour
{
    public Transform movePosition;
    public Collider2D mapBoundary;
    public CinemachineConfiner2D Confiner;
    public Animator SceneTransitionAnimator;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Player")) 
        {
            Confiner.BoundingShape2D = mapBoundary;
            collision.transform.position = movePosition.position;
            SceneTransitionAnimator.SetTrigger("Show");
        }
    }
}
