using UnityEngine;

public class Script_EdgeRollover : MonoBehaviour
{
    public Transform entity;
    Vector3 moveTo;
    // Update is called once per frame
    void Update()
    {
        if (entity.position.x >= 50)
        {
            moveTo = entity.position;
            moveTo.x = -49;
            entity.SetPositionAndRotation(moveTo, entity.rotation);
        }
        else if (entity.position.x <= -50)
        {
            moveTo = entity.position;
            moveTo.x = 49;
            entity.SetPositionAndRotation(moveTo, entity.rotation);
        }
        else if (entity.position.y >= 50)
        {
            moveTo = entity.position;
            moveTo.y = -49;
            entity.SetPositionAndRotation(moveTo, entity.rotation);
        }
        else if (entity.position.y <= -50)
        {
            moveTo = entity.position;
            moveTo.y = 49;
            entity.SetPositionAndRotation(moveTo, entity.rotation);
        }
    }
}
