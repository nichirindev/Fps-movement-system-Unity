using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;

    [Header("Landing Effect")]
    public float landingRecoverSpeed = 5f;
    public float maxLandingOffset = 0.05f;

    [Header("Head Bob")]
    public float bobFrequency = 20f;
    public float bobAmplitude = 0.08f;
    public float bobSwayAmount = 0.25f;

    private float landingOffset;
    private float landingVel;
    private bool wasGrounded;
    private float bobTimer;
    private Vector3 currentBobOffset;
    private Vector3 bobVel;

    void Update() {
        PlayerMovement pm = PlayerMovement.Instance;

        // Landing effect umm it's subtle but cool by nishi-san 2026... nichirindev
        if (pm != null && !wasGrounded && pm.grounded) {
            float fallSpeed = Mathf.Abs(pm.GetFallSpeed());
            float t = Mathf.InverseLerp(0.1f, 15f, fallSpeed);
            landingOffset = Mathf.Lerp(maxLandingOffset * 3f, maxLandingOffset, t);
        }

        wasGrounded = pm != null && pm.grounded;

        landingOffset = Mathf.SmoothDamp(landingOffset, 0f, ref landingVel, 1f / landingRecoverSpeed);

        // Head bob is way to go
        Vector3 bobTarget = Vector3.zero;
        if (pm != null && pm.grounded) {
            Vector3 vel = pm.GetVelocity();
            Vector3 horizontalVel = new Vector3(vel.x, 0f, vel.z);
            float horizontalSpeed = horizontalVel.magnitude;

            if (horizontalSpeed > 0.5f) {
                bobTimer += Time.deltaTime * bobFrequency * (horizontalSpeed / pm.walkSpeed);
                Vector3 swayDir = Vector3.Cross(horizontalVel.normalized, Vector3.up);
                float bobY = Mathf.Sin(bobTimer) * bobAmplitude;
                float bobSway = Mathf.Cos(bobTimer * 0.5f) * bobSwayAmount;
                bobTarget = new Vector3(swayDir.x * bobSway, bobY, swayDir.z * bobSway);
            }
        }

        currentBobOffset = Vector3.SmoothDamp(currentBobOffset, bobTarget, ref bobVel, 0.1f);

        transform.position = player.transform.position + Vector3.down * landingOffset + currentBobOffset;
    }
}
