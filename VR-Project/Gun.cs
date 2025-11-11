using UnityEngine;
using UnityEngine.InputSystem; // Add this line

public class Gun : MonoBehaviour
{
    public InputActionReference triggerAction; // Reference to the trigger
    public GameManager gameManager; // Reference to the score manager
    public ParticleSystem muzzleFlash; // Optional: for a visual effect
    public float shootDistance = 100f;

    void Start()
    {
        // Find the GameManager in the scene
        gameManager = FindObjectOfType<GameManager>();

        // Register a "performed" (button pressed) event
        triggerAction.action.Enable();
        triggerAction.action.performed += Shoot;
    }

    private void OnDestroy()
    {
        // Unregister the event when this object is destroyed
        triggerAction.action.performed -= Shoot;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        // Optional: Play a particle effect at the gun's tip
        if (muzzleFlash != null)
        {
            muzzleFlash.Play();
        }

        // Raycast logic
        RaycastHit hit;
        // Shoots a ray forward from this object's position and direction
        if (Physics.Raycast(transform.position, transform.forward, out hit, shootDistance))
        {
            // Check if the object we hit has the "Destroyable" tag
            if (hit.collider.CompareTag("Destroyable"))
            {
                // Destroy the object
                Destroy(hit.collider.gameObject);

                // Add score
                if (gameManager != null)
                {
                    gameManager.AddScore(1);
                }
            }
        }
    }
}