using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20;
    public SFXManager sFXManager;
    void Start()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
            grabbable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        grabbable.activated.AddListener(FireBullet);
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        sFXManager.PlayBeamSound();

        GameObject spawnedBullet = Instantiate(bullet);

        spawnedBullet.transform.position = spawnPoint.position;

        spawnedBullet.GetComponent<Rigidbody>().linearVelocity = spawnPoint.forward * fireSpeed;

        Destroy(spawnedBullet, 5);
    }
}
