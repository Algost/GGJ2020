using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPreview : MonoBehaviour
{
    public Animator anim;
    /*
    private float inputH;
    private float inputV;
    private bool run;
    */

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //run = false;
    }

    public void theIdle()
    {
        //anim.SetTrigger("theIdle");
        anim.Play("Idle", -1, 0f);

    }

    public void MeleeHitReact()
    {
        anim.Play("Melee_Hit_React", -1, 0f);
    }

    public void Jump()
    {
        anim.Play("Jump", -1, 0f);
    }
    public void JumpStart()
    {
        anim.Play("Jump_Start", -1, 0f);
    }
    public void Fall()
    {
        anim.Play("Fall", -1, 0f);
    }
    public void Land()
    {
        anim.Play("Land", -1, 0f);
    }
       


    public void Sit_GetUp()
    {
        anim.Play("Sit_getUP", -1, 0f);
    }

    public void Sit_SitDown()
    {
        anim.Play("Sit_down", -1, 0f);
    }

    public void Sit_Sitting()
    {
        anim.Play("Sitting", -1, 0f);
    }


    public void Weapon_Idle()
    {
        anim.Play("Idle1(Weapon)",-1,0f);
    }

    public void Weapon_Idle2()
    {
        anim.Play("Idle2(Weapon)", -1, 0f);
    }
    public void Weapon_Attack1()
    {
        anim.Play("Attack1", -1, 0f);
    }
    public void Weapon_Attack2()
    {
        anim.Play("Attack2", -1, 0f);
    }
    public void Weapon_Attack3()
    {
        anim.Play("Attack3", -1, 0f);
    }
    public void Weapon_Attack4()
    {
        anim.Play("Attack4", -1, 0f);
    }
    public void Kick1()
    {
        anim.Play("Kick1", -1, 0f);
    }
    public void Kick2()
    {
        anim.Play("Kick2", -1, 0f);
    }

    public void Walk()
    {
        anim.Play("Walk", -1, 0f);
    }
    public void Run()
    {
        anim.Play("Run", -1, 0f);
    }
    public void IdleLeanOnWall()
    {
        anim.Play("Idle(LeanOnWall)", -1, 0f);
    }

    public void WalkWeapon()
    {
        anim.Play("Walk_Weapon", -1, 0f);
    }
    public void RunWeapon()
    {
        anim.Play("Run_Weapon", -1, 0f);
    }
    public void DodgeL()
    {
        anim.Play("Dodge_Left", -1, 0f);
    }
    public void DodgeR()
    {
        anim.Play("Dodge_Right", -1, 0f);
    }


    public void Stunned()
    {
        anim.Play("Stunned", -1, 0f);
    }
    public void HitReactWeapon()
    {
        anim.Play("HitReactWeapon", -1, 0f);
    }
    public void Spawn()
    {
        anim.Play("Spawn", -1, 0f);
    }

    public void GetUp()
    {
        anim.Play("Get UP (Knocked Out)", -1, 0f);
    }
    public void Death()
    {
        anim.Play("Death", -1, 0f);
    }
    public void KnockedOut()
    {
        anim.Play("Knocked_Out", -1, 0f);
    }
    public void Revive()
    {
        anim.Play("Revive", -1, 0f);
    }
    public void SleepStart()
    {
        anim.Play("Sleep_Start", -1, 0f);
    }
    public void Sleeping()
    {
        anim.Play("Sleeping", -1, 0f);
    }
    public void SleepGetUp()
    {
        anim.Play("Sleep_getUP", -1, 0f);
    }

    public void Wave()
    {
        anim.Play("Wave", -1, 0f);
    }
    public void Taunt()
    {
        anim.Play("Taunt", -1, 0f);
    }
    public void Dance()
    {
        anim.Play("Dance", -1, 0f);
    }
    public void Pushup()
    {
        anim.Play("Pushup", -1, 0f);
    }
    public void ClimbRM()
    {
        anim.Play("Climb_RM", -1, 0f);
    }
    public void Climb()
    {
        anim.Play("Climb", -1, 0f);
    }



    // Update is called once per frame
    void Update()
    {
        /**
        if(Input.GetMouseButtonDown(1))
        {
            anim.Play("Melee_Hit_React", -1, 0f);
            print("I clicked");
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
        anim.SetBool("run", run);
    */


    }
}
