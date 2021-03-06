﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace FRGenerics.Helpers {
  public class ExteriorHider: BaseScript {
    public ExteriorHider() {
      //Tick += OnTick;
    }

    public async Task OnTick() {
      int interiorId = Interior.GetFromEntity(Game.PlayerPed);

      if (Interior.IsValid(interiorId)) {

      }

      await Task.FromResult(0);
    }
  }
}

/*
 * //apartment buildings:

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ss1_11_flats"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ss1_11_ss1_emissive_a"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ss1_11_detail01b"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ss1_11_Flats_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_02_Building01_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_LOD_01_02_08_09_10_11"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_02_SLOD1"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("hei_dt1_20_build2"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("dt1_20_dt1_emissive_dt1_20"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("sm_14_emissive"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("hei_sm_14_bld2"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("hei_bh1_09_bld_01"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("bh1_09_ema"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("prop_wall_light_12a"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("hei_dt1_03_build1x"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("DT1_Emissive_DT1_03_b1"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("dt1_03_dt1_Emissive_b1"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("hei_bh1_08_bld2"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("bh1_emissive_bh1_08"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("bh1_08_bld2_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("hei_bh1_08_bld2"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("bh1_08_em"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ss1_02_building01"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_Emissive_SS1_02a_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ss1_02_ss1_emissive_ss1_02"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ss1_02_building01"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_02_Building01_LOD"));

// houses:

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_05e_res5"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_05e_res5_LOD"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_04_house02"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_04_house02_d"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_04_M_a_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_04_house02_railings"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_04_emissive_04"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_04_emissive_04_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_04_house02_details"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_hs01a_details"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_hs01"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_hs01_balcony"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_Emissive_11_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_Emissive_11"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_CH2_09b_House08_LOD"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09c_hs11"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("CH2_09c_Emissive_11_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("CH2_09c_Emissive_11"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09c_hs11_details"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_05c_b4"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_05c_emissive_07"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_05c_decals_05"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_05c_B4_LOD"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09c_hs07"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_09c_build_11_07_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("CH2_09c_Emissive_07_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09c_build_11_07_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_09c_hs07_details"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("CH2_09c_Emissive_07"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09c_hs13"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09c_hs13_details"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_CH2_09c_House11_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_09c_Emissive_13_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_09c_Emissive_13"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_hs02"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_hs02b_details"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_Emissive_09_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_09b_botpoolHouse02_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_Emissive_09"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_09b_hs02_balcony"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_12b_house03mc"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_12b_emissive_02"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_12b_house03_MC_a_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_12b_emissive_02_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_12b_railing_06"));

INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_04_house01"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_04_house01_d"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_04_emissive_05_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ch2_04_M_b_LOD"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_04_emissive_05"));
INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ch2_04_house01_details"));
 **
 * 
 * while (true) {
   GRAPHICS::_0x4B5CFC83122DF602();
   INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("apa_ss1_11_flats"));
   INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ss1_11_ss1_emissive_a"));
   INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ss1_11_detail01b"));
   INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("ss1_11_Flats_LOD"));
   INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_02_Building01_LOD"));
   INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_LOD_01_02_08_09_10_11"));
   INTERIOR::_HIDE_MAP_OBJECT_THIS_FRAME(GAMEPLAY::GET_HASH_KEY("SS1_02_SLOD1"));
   GRAPHICS::_0x3669F1B198DCAA4F();
   WAIT(0);
}
 */
