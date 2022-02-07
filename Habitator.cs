using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using KSP;

namespace Terraforming
{

    [KSPAddon(KSPAddon.Startup.Flight, false)]




    public class Habitator : PartModule
    {

        bool Htoggle = false;
    [KSPEvent(active = true, guiActive = true, guiName = "Terraform")]

    public void Terraform()
    {

        Vessel.Situations HVBLanded = Vessel.Situations.LANDED;
        CelestialBody HVB = vessel.mainBody;


            if (HVBLanded is Vessel.Situations.LANDED)
            {
                Htoggle = !Htoggle;
                while (HVB.atmosphereDepth < HVB.Radius / 8.6 & Htoggle is true)
                {

                    Task.Delay(2000);
                    HVB.atmosphereDepth = HVB.atmosphereDepth + 100;
                    HVB.atmosphere = true;
                    HVB.atmosphereContainsOxygen = true;
                }
            }
            else
            {
                ScreenMessages.PostScreenMessage("You need to be landed on a celestial body.");
            }
        }


    }
}
