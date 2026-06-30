using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using MonoMod.Utils;
using Quintessential;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using TrueAnimismus;
using Permissions = enum_149;
using Texture = class_256;

namespace MagnusAnimismus;

public class MagnusAnimismus : QuintessentialMod
{

    public static string contentPath;
    public override void Load()
    {
    }
    public override void Unload()
    {
        Quintessential.Logger.Log("[MagnusAnimismus] Unloaded");
    }
    public override void LoadPuzzleContent()
    {
        Quintessential.Logger.Log("[MagnusAnimismus] Loading");
        MagnusAnimismusAtoms.AddAtomTypes();
        QApi.AddAtomType(MagnusAnimismusAtoms.SublimeVitae);
        QApi.AddAtomType(MagnusAnimismusAtoms.AbjectMors);
    }
    public override void PostLoad()
    {
        LoadTARules();
    }
    private static void LoadTARules()
    {
        //Add Disproportion
        TrueAnimismus.API.addDisproportionRule(TrueAnimismus.ModdedAtoms.TrueVitae, MagnusAnimismusAtoms.SublimeVitae, TrueAnimismus.ModdedAtoms.RedVitae);
        TrueAnimismus.API.addDisproportionRule(TrueAnimismus.ModdedAtoms.TrueMors, MagnusAnimismusAtoms.AbjectMors, TrueAnimismus.ModdedAtoms.GreyMors);

        // Add Left Hand
        TrueAnimismus.API.addLeftHandRule(MagnusAnimismusAtoms.SublimeVitae, MagnusAnimismusAtoms.AbjectMors);
        TrueAnimismus.API.addLeftHandRule(MagnusAnimismusAtoms.AbjectMors, MagnusAnimismusAtoms.SublimeVitae);

        // Add Ratings
        TrueAnimismus.API.AtomsForRating.Add(new(MagnusAnimismusAtoms.SublimeVitae, 4, "animismus"));
        TrueAnimismus.API.AtomsForRating.Add(new(MagnusAnimismusAtoms.AbjectMors, -4, "animismus"));
    }
}

