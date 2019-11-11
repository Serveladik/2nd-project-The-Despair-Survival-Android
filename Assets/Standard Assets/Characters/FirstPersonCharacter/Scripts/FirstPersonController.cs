using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;


namespace UnityStandardAssets.Characters.FirstPerson
{
    [RequireComponent(typeof (CharacterController))]
    [RequireComponent(typeof (AudioSource))]
    
    public class FirstPersonController : MonoBehaviour
    {
        public CharacterController characterController;
        [SerializeField] public bool m_IsWalking;
        [SerializeField] public float m_WalkSpeed;
        [SerializeField] public float m_RunSpeed;
        [SerializeField] [Range(0f, 1f)] private float m_RunstepInterval;
        [SerializeField] private float m_StepInterval;
        [SerializeField] private float m_JumpSpeed;
        [SerializeField] private float m_StickToGroundForce;
        [SerializeField] private float m_GravityMultiplier;
        [SerializeField] private MouseLook m_MouseLook;
     
        public float speed = 0f;
        public bool allowRun = true;
        
        
        [SerializeField] private AudioClip[] m_FootstepSounds;    // an array of footstep sounds that will be randomly selected from.
        [SerializeField] private AudioClip m_JumpSound;           // the sound played when character leaves the ground.
        [SerializeField] private AudioClip m_LandSound;           // the sound played when character touches back on ground.

        private Camera m_Camera;
        private bool m_Jump;
        private float m_YRotation;
        private Vector2 m_Input;
        private Vector3 m_MoveDir = Vector3.zero;
        private CharacterController m_CharacterController;
        private CollisionFlags m_CollisionFlags;
        private bool m_PreviouslyGrounded;
        private Vector3 m_OriginalCameraPosition;
        private float m_StepCycle;
        private float m_NextStep;
        private bool m_Jumping;
        private AudioSource m_AudioSource;

        public Animator animLeft;
	    public Animator animRight;

	    public Animator CameraWalk;
	    public Animator RunWithPistol;
       
	    //public RunToIdle runningToIdle;

            // Use this for initialization
        private void Start()
        {
            
            m_CharacterController = GetComponent<CharacterController>();
            m_Camera = Camera.main;
            m_OriginalCameraPosition = m_Camera.transform.localPosition;
            m_StepCycle = 0f;
            m_NextStep = m_StepCycle/2f;
            m_Jumping = false;
            m_AudioSource = GetComponent<AudioSource>();
			m_MouseLook.Init(transform , m_Camera.transform);
        }


        // Update is called once per frame
        private void Update()
        {
            NothingPressed();
            RotateView();
            // the jump state needs to read here to make sure it is not missed
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }

            if (!m_PreviouslyGrounded && m_CharacterController.isGrounded)
            {
                PlayLandingSound();
                m_MoveDir.y = 0f;
                m_Jumping = false;
            }
            if (!m_CharacterController.isGrounded && !m_Jumping && m_PreviouslyGrounded)
            {
                m_MoveDir.y = 0f;
            }

            m_PreviouslyGrounded = m_CharacterController.isGrounded;
            
        }


        private void PlayLandingSound()
        {
            m_AudioSource.clip = m_LandSound;
            m_AudioSource.Play();
            m_NextStep = m_StepCycle + .5f;
        }


        private void FixedUpdate()
        {
            float speed;
            GetInput(out speed);
            // always move along the camera forward as it is the direction that it being aimed at
            Vector3 desiredMove = transform.forward*m_Input.y + transform.right*m_Input.x;
            
            // get a normal for the surface that is being touched to move along it
            RaycastHit hitInfo;
            Physics.SphereCast(transform.position, m_CharacterController.radius, Vector3.down, out hitInfo,
                               m_CharacterController.height/2f, Physics.AllLayers, QueryTriggerInteraction.Ignore);
            desiredMove = Vector3.ProjectOnPlane(desiredMove, hitInfo.normal).normalized;

            m_MoveDir.x = desiredMove.x*speed;
            m_MoveDir.z = desiredMove.z*speed;


            if (m_CharacterController.isGrounded)
            {
                m_MoveDir.y = -m_StickToGroundForce;

                if (m_Jump)
                {
                    m_MoveDir.y = m_JumpSpeed;
                    m_Jump = false;
                    m_Jumping = true;
                }
            }
            else
            {
                m_MoveDir += Physics.gravity*m_GravityMultiplier*Time.fixedDeltaTime;
            }
            m_CollisionFlags = m_CharacterController.Move(m_MoveDir*Time.fixedDeltaTime);

            ProgressStepCycle(speed);
           

            m_MouseLook.UpdateCursorLock();
        }
        void NothingPressed()
        {
            if(Input.GetKeyDown(KeyCode.W)==false && Input.GetKeyDown(KeyCode.A)==false && Input.GetKeyDown(KeyCode.S)==false && Input.GetKeyDown(KeyCode.D)==false)
            {
                animLeft.SetBool("LeftPicked",true);
                animRight.SetBool("RightPicked",true);
                animLeft.SetBool("Stay",true);
                animRight.SetBool("Stay",true);
                animLeft.SetBool("LeftHandsRun",false);
                animRight.SetBool("RightHandsRun",false);
                m_WalkSpeed = speed;
                Debug.Log(m_WalkSpeed);
            }
            if(Input.GetKey(KeyCode.W)==true | Input.GetKey(KeyCode.A)==true | Input.GetKey(KeyCode.S)==true | Input.GetKey(KeyCode.D)==true)
            {
                animLeft.SetBool("LeftPicked",false);
                animRight.SetBool("RightPicked",false);
                animLeft.SetBool("Stay",false);
                animRight.SetBool("Stay",false);
                animLeft.SetBool("LeftHandsRun",false);
                animRight.SetBool("RightHandsRun",false);
                m_WalkSpeed = 10f;
                Debug.Log(m_WalkSpeed);
            }
            if(m_IsWalking == false)
            {
                animLeft.SetBool("LeftHandsRun",true);
                animRight.SetBool("RightHandsRun",true);
            }
    if(Input.GetKeyDown(KeyCode.LeftShift))
	{
		allowRun = true;
		if(allowRun == true)
		{
			RunWithPistol.SetBool("RunWithPistol",true);
//			runningToIdle.runInAnim=true;
		}
	}
	if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			allowRun=false;
			if(allowRun==false)
			{
				RunWithPistol.SetBool("RunWithPistol",false);
				//runningToIdle.runInAnim=false;
			}
	
		}
            
        }




        private void ProgressStepCycle(float speed)
        {
            if (m_CharacterController.velocity.sqrMagnitude > 0 && (m_Input.x != 0 || m_Input.y != 0))
            {
                m_StepCycle += (m_CharacterController.velocity.magnitude + (speed*(m_IsWalking ? 1f : m_RunstepInterval)))*Time.fixedDeltaTime;
            }
            if (!(m_StepCycle > m_NextStep))
            {
                return;
            }
            m_NextStep = m_StepCycle + m_StepInterval;
            PlayFootStepAudio();
        }


        private void PlayFootStepAudio()
        {
            if (!m_CharacterController.isGrounded)
            {
                return;
            }
            // pick & play a random footstep sound from the array,
            // excluding sound at index 0
            int n = Random.Range(1, m_FootstepSounds.Length);
            m_AudioSource.clip = m_FootstepSounds[n];
            m_AudioSource.PlayOneShot(m_AudioSource.clip);
            // move picked sound to index 0 so it's not picked next time
            m_FootstepSounds[n] = m_FootstepSounds[0];
            m_FootstepSounds[0] = m_AudioSource.clip;
        }


       

        private void GetInput(out float speed)
        {
            // Read input
            float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
            float vertical = CrossPlatformInputManager.GetAxis("Vertical");

            bool waswalking = m_IsWalking;

#if !MOBILE_INPUT
            // On standalone builds, walk/run speed is modified by a key press.
            // keep track of whether or not the character is walking or running
            m_IsWalking = !Input.GetKey(KeyCode.LeftShift);
#endif
            // set the desired speed to be walking or running
            speed = m_IsWalking ? m_WalkSpeed : m_RunSpeed;
            m_Input = new Vector2(horizontal, vertical);

            // normalize input if it exceeds 1 in combined length:
            if (m_Input.sqrMagnitude > 1)
            {
                m_Input.Normalize();
            }
            // handle speed change to give an fov kick
            // only if the player is going to a run, is running and the fovkick is to be used
        }


        private void RotateView()
        {
           // m_MouseLook.LookRotation (transform, m_Camera.transform);
        }


        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            Rigidbody body = hit.collider.attachedRigidbody;
            //dont move the rigidbody if the character is on top of it
            if (m_CollisionFlags == CollisionFlags.Below)
            {
                return;
            }

            if (body == null || body.isKinematic)
            {
                return;
            }
            body.AddForceAtPosition(m_CharacterController.velocity*0.1f, hit.point, ForceMode.Impulse);
        }
    }
}
