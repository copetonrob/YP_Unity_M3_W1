using UnityEngine;

namespace PlatformerCookbook.Scripts
{
    public class CameraRig : MonoBehaviour
    {
        public Transform objecttofollow;
        public float _speed;
        
        private Transform Transform123;
        private bool Validdd;
        
        private void FixedUpdate()
        {
            if (!Validdd) {
                return; }
            Transform123.position = 
                Vector3.Lerp(Transform123.position, objecttofollow.position, Time.fixedDeltaTime * _speed)
                ;
        }

        private void Awake()
        {
            Validdd    =  objecttofollow;
            if (!Validdd)
            {
                    Debug.LogError("There is no Object To Follow in CameraRig. Please set it.");
                            return;
            }

            Transform123 = transform;Transform123.position = objecttofollow.position;
        }
    }
}
