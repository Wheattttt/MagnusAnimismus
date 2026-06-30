using Quintessential;
using Texture = class_256;

namespace MagnusAnimismus;

public static class MagnusAnimismusAtoms
{
    public static AtomType SublimeVitae, AbjectMors;
    public static void AddAtomTypes()
    {
        SublimeVitae = new AtomType()
        {
            /*ID, byte*/
            field_2283 = 140,
            /*Non-local Name*/
            field_2284 = class_134.method_254("Sublime Vitae"),
            /*Atomic Name*/
            field_2285 = class_134.method_253("Elemental Sublime Vitae", string.Empty),
            /*Local name*/
            field_2286 = class_134.method_253("Sublime Vitae", string.Empty),
            /*Symbol*/
            field_2287 = class_235.method_615("textures/atoms/magnusanim/sublimevitae_symbol"),
            /*Shadow*/
            field_2288 = class_238.field_1989.field_81.field_599,
            /*Default Graphics struct*/
            field_2290 = new class_106()
            {
                field_994 = class_235.method_615("textures/atoms/magnusanim/sublimevitae_diffuse"),
                field_995 = class_235.method_615("textures/atoms/magnusanim/sublimevitae_shade")
            },
            /*is Purifijectable?*/
            field_2294 = false,//do not use field_2291 for drawing -- checked by purifier (consumption) and projector (promotion)
            /*is Cardinal element?*/
            field_2293 = false,//use field_2289 for drawing -- also checked by duplicator (copy essence) and calcinator (calcify)
            /*is Projector fuel?*/
            field_2295 = false,//checked by projector (consumption)
            /*is drawn like Quintessence?*/
            field_2296 = false, //use field_2292 for drawing
            /*field_2298 is unused, it seems*/
            QuintAtomType = "Sublime Vitae:sublimevitae"
        };
        AbjectMors = new AtomType()
        {
            /*ID, byte*/
            field_2283 = 141,
            /*Non-local Name*/
            field_2284 = class_134.method_254("Abject Mors"),
            /*Atomic Name*/
            field_2285 = class_134.method_253("Elemental Abject Mors", string.Empty),
            /*Local name*/
            field_2286 = class_134.method_253("Abject Mors", string.Empty),
            /*Symbol*/
            field_2287 = class_235.method_615("textures/atoms/magnusanim/abjectmors_symbol"),
            /*Shadow*/
            field_2288 = class_238.field_1989.field_81.field_599,
            /*Default Graphics struct*/
            field_2290 = new class_106()
            {
                field_994 = class_235.method_615("textures/atoms/magnusanim/abjectmors_diffuse"),
                field_995 = class_235.method_615("textures/atoms/magnusanim/abjectmors_shade")
            },
            /*is Purifijectable?*/
            field_2294 = false,//do not use field_2291 for drawing -- checked by purifier (consumption) and projector (promotion)
            /*is Cardinal element?*/
            field_2293 = false,//use field_2289 for drawing -- also checked by duplicator (copy essence) and calcinator (calcify)
            /*is Projector fuel?*/
            field_2295 = false,//checked by projector (consumption)
            /*is drawn like Quintessence?*/
            field_2296 = false, //use field_2292 for drawing
            /*field_2298 is unused, it seems*/
            QuintAtomType = "Abject Mors:abjectmors"
        };
    }
}