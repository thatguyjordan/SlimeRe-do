using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using TAPI;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace jSlimes
{
    public sealed class MBase : ModBase
    {
        internal static MBase BaseInstance;
        public override void OnLoad()
        {
            BaseInstance = this;
            Main.NPCLoaded[1] = true;
            Main.npcTexture[1] = MBase.BaseInstance.textures["Images/NPC_1"];
            Main.NPCLoaded[16] = true;
            Main.npcTexture[16] = MBase.BaseInstance.textures["Images/NPC_16"];
            Main.NPCLoaded[50] = true;
            Main.npcTexture[50] = MBase.BaseInstance.textures["Images/NPC_50"];
            Main.NPCLoaded[59] = true;
            Main.npcTexture[59] = MBase.BaseInstance.textures["Images/NPC_59"];
            Main.NPCLoaded[71] = true;
            Main.npcTexture[71] = MBase.BaseInstance.textures["Images/NPC_71"];
            Main.NPCLoaded[81] = true;
            Main.npcTexture[81] = MBase.BaseInstance.textures["Images/NPC_81"];
            Main.NPCLoaded[121] = true;
            Main.npcTexture[121] = MBase.BaseInstance.textures["Images/NPC_121"];
            Main.NPCLoaded[138] = true;
            Main.npcTexture[138] = MBase.BaseInstance.textures["Images/NPC_138"];
            Main.NPCLoaded[141] = true;
            Main.npcTexture[141] = MBase.BaseInstance.textures["Images/NPC_141"];
            Main.NPCLoaded[147] = true;
            Main.npcTexture[147] = MBase.BaseInstance.textures["Images/NPC_147"];
            Main.NPCLoaded[183] = true;
            Main.npcTexture[183] = MBase.BaseInstance.textures["Images/NPC_183"];
            Main.NPCLoaded[184] = true;
            Main.npcTexture[184] = MBase.BaseInstance.textures["Images/NPC_184"];
            Main.NPCLoaded[204] = true;
            Main.npcTexture[204] = MBase.BaseInstance.textures["Images/NPC_204"];
            Main.NPCLoaded[225] = true;
            Main.npcTexture[225] = MBase.BaseInstance.textures["Images/NPC_225"];
            Main.NPCLoaded[244] = true;
            Main.npcTexture[244] = MBase.BaseInstance.textures["Images/NPC_244"];
        }
        public override void OnUnload() 
        {
            Main.NPCLoaded[1] = false;
            Main.NPCLoaded[16] = false;
            Main.NPCLoaded[50] = false;
            Main.NPCLoaded[59] = false;
            Main.NPCLoaded[71] = false;
            Main.NPCLoaded[81] = false;
            Main.NPCLoaded[121] = false;
            Main.NPCLoaded[138] = false;
            Main.NPCLoaded[141] = false;
            Main.NPCLoaded[147] = false;
            Main.NPCLoaded[183] = false;
            Main.NPCLoaded[184] = false;
            Main.NPCLoaded[204] = false;
            Main.NPCLoaded[225] = false;
            Main.NPCLoaded[244] = false;
        }
    }
}