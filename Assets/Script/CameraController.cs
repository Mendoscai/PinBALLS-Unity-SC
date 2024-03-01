using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public Transform dummyTarget;
    private Vector3 defaultPosition;

    public float returnTime;
    public float followSpeed;
    public float length;

    public bool hasTarget { get { return dummyTarget != null; } }

    private void Start()
    {
        defaultPosition = transform.position;
    }

    private void Update()
    {
        if (hasTarget)
        {
            Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
            Vector3 targetPosition = dummyTarget.position + (targetToCameraDirection * length);

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }

    public void FollowTarget(Transform targetTransform, float targetLength)
    {
        StopAllCoroutines();

        dummyTarget = targetTransform;
        length = targetLength;
    }


    public void GoBackToDefault()
    {
        StopAllCoroutines();

        dummyTarget = null;

        StartCoroutine(MovePosition(defaultPosition, returnTime));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while (timer < time)
        {
            // pindahkan posisi camera secara bertahap
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer / time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }
}
