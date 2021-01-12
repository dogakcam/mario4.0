using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using DG.Tweening;


public class MarioThrowingCap : MonoBehaviour
{
    public TrailRenderer CapTrailRenderer;
    public ParticleSystem CapTrail;
    [Header("Public References")]
    public ParticleSystem CapEffect;
    public Transform Cap;
    public Transform Mario;
    public Transform ReturnPoint;
    [Space]
    [Header("Game Settings")]
    public float CapSpinningSpeed;
    public float spinningDuration;
    public float throwDuration;
    public float ReturnDuration;
    [Space]
    [Header("Public bools")]
    public bool Spinning;

    private void Start()
    {
        CapTrail.Stop();
        CapTrailRenderer.enabled = false;

    }

    void Update()
    {

        if ( Input.GetKey(KeyCode.H)) // H Letter
        {

            ThrowingCap();
            CapEffect.Play();
            Spinning = true;
        }

        if ( Input.GetButtonDown("Fire2") && Spinning ) // option button
        { 

            ReturnCap();
        }

        if(Spinning)
        {

            Cap.transform.Rotate (0f,CapSpinningSpeed,0f);
        }
        
    }
    
    

    void ThrowingCap()
    {
        CapTrailRenderer.enabled = true;

        Sequence throwSequence = DOTween.Sequence();

        //Throw the Cap
        throwSequence.Append(Cap.DOMove(transform.position + transform.forward * 25, throwDuration));

        //Scale Cap
        throwSequence.Join(Cap.DOScale(1.6f, throwDuration));

        //Mario Spinning
        //throwSequence.Join(Mario.DORotate(new Vector3(0, 360f, 0), spinningDuration, RotateMode.FastBeyond360));
        CapTrail.Play();

    }

    void ReturnCap()
    {
        CapTrailRenderer.enabled = false;
        Sequence ReturnSequence = DOTween.Sequence();

        //Return the Cap
        ReturnSequence.Append(Cap.DOMove(ReturnPoint.transform.position, ReturnDuration));

        //Cap original Scale
        ReturnSequence.Join(Cap.DOScale(0.65f, ReturnDuration));

        //Cap original Rotation
        Invoke("OriginalRotation", ReturnDuration);
        CapTrail.Stop();
    }

    void OriginalRotation()
    {

        CapEffect.Stop();
        Spinning = false;
        //Cap.DORotate(new Vector3(24f, 0f, 10f), 0f);
        Cap.localRotation = Quaternion.identity;
    }



}