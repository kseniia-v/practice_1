/*
 here we launch a falcon heavy rocket and see if stage lands successfully on a platform
 */
using System;

namespace practice_1
{
    //for successful stage landing we only check for 1 coordinate (OX). 2D world :) 
    class Program
    {
        delegate void Message(bool status);

        static void SuccessMsg(bool status)
        {
            Console.WriteLine("Mission Complete!");
        }

        static void FailMsg(bool status)
        {
            Console.WriteLine("Mission Failed!");
        }

        static bool Landing(double PlatformStart, double PlatformEnd, double StageStart, double StageEnd)
        {
            return (StageStart >= PlatformStart && StageEnd <= PlatformEnd);
        }

        static void Main(string[] args)
        {
            bool successLanding;
            Message infoMsg;

            //construct objects
            FalconHeavy rocket1 = new FalconHeavy("FH1", Falcon.Medium);
            Platform plate1 = new Platform(Plate.Medium, 1000, "Pacific Ocean");
            Engineer engineer1 = new Engineer("Elon", Seniority.Junior, Responsibility.Normal);
            //prepare launch
            rocket1.LocationLeft = engineer1.CalcStageLocation(plate1.LocationLeft);
            //launch!
            var random = new Random();
            double deviation = 1 + (random.NextDouble() * 3);
            rocket1.Fly(deviation);
            Console.WriteLine($"Platform coordinates: { plate1.LocationLeft}-{plate1.LocationRight}. Stage Landed: {rocket1.LocationLeft}-{rocket1.LocationRight}");
            //land the stage
            successLanding = Landing(plate1.LocationLeft, plate1.LocationRight, rocket1.LocationLeft, rocket1.LocationRight);
            if (successLanding) { infoMsg = SuccessMsg; } else { infoMsg = FailMsg; }
            infoMsg?.Invoke(successLanding);
        }
    }
}
