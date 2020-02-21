﻿using VaultLib.Core.Types;

namespace VaultLib.Support.ProStreet.VLT
{
    [VLTTypeInfo(nameof(eMenuSoundTriggers))]
    public enum eMenuSoundTriggers
    {
        UISND_NONE = -1,
        UISND_COMMON_UP = 0x0,
        UISND_COMMON_DOWN = 0x1,
        UISND_COMMON_SELECT = 0x2,
        UISND_COMMON_BACK = 0x3,
        UISND_COMMON_LEFT_AND_RIGHT = 0x4,
        UISND_COMMON_WRONG = 0x5,
        UISND_COMMON_TRIGGER_LEFT = 0x6,
        UISND_COMMON_TRIGGER_RIGHT = 0x7,
        UISND_COMMON_DLGBOX_APPEAR = 0x8,
        UISND_COMMON_DLGBOX_DISAPPEAR = 0x9,
        UISND_COMMON_DLGBOX_DOWN = 0xA,
        UISND_COMMON_DLGBOX_LEFT = 0xB,
        UISND_COMMON_DLGBOX_RIGHT = 0xC,
        UISND_COMMON_DLGBOX_UP = 0xD,
        UISND_ENTER_TRIGGER = 0x18,
        UISND_COMMON_ExpandingTree_Left_BASIC = 0x1F,
        UISND_COMMON_ExpandingTree_Left_P0 = 0x20,
        UISND_COMMON_ExpandingTree_Left_P1 = 0x21,
        UISND_COMMON_ExpandingTree_Left_P2 = 0x22,
        UISND_COMMON_ExpandingTree_Left_P3 = 0x23,
        UISND_COMMON_ExpandingTree_Left_P4 = 0x24,
        UISND_COMMON_ExpandingTree_Left_P5 = 0x25,
        UISND_COMMON_ExpandingTree_Left_P6 = 0x26,
        UISND_COMMON_ExpandingTree_Left_P7 = 0x27,
        UISND_COMMON_ExpandingTree_Left_P8 = 0x28,
        UISND_COMMON_ExpandingTree_Left_P9 = 0x29,
        UISND_COMMON_ExpandingTree_Right_BASIC = 0x2A,
        UISND_COMMON_ExpandingTree_Right_P0 = 0x2B,
        UISND_COMMON_ExpandingTree_Right_P1 = 0x2C,
        UISND_COMMON_ExpandingTree_Right_P2 = 0x2D,
        UISND_COMMON_ExpandingTree_Right_P3 = 0x2E,
        UISND_COMMON_ExpandingTree_Right_P4 = 0x2F,
        UISND_COMMON_ExpandingTree_Right_P5 = 0x30,
        UISND_COMMON_ExpandingTree_Right_P6 = 0x31,
        UISND_COMMON_ExpandingTree_Right_P7 = 0x32,
        UISND_COMMON_ExpandingTree_Right_P8 = 0x33,
        UISND_COMMON_ExpandingTree_Right_P9 = 0x34,
        UISND_COMMON_e3_Transition = 0x49,
        UISND_COMMON_e3_Move_Left = 0x4A,
        UISND_COMMON_LIGHT_TREE_TICK = 0x4C,
        UISND_COMMON_LIGHT_TREE_GO = 0x4D,
        UISND_COMMON_OPTION_SLIDER_TICK = 0x4E,
        UISND_HUD_RACE_COMPLETE_IN = 0x4F,
        UISND_HUD_COUNTDOWN = 0x50,
        UISND_HUD_COUNTDOWN_GO = 0x53,
        UISND_HUD_MATCHUP_TEXT_IN = 0x54,
        UISND_HUD_MATCHUP_TEXT_OUT = 0x55,
        UISND_HUD_STUTTER_TEXT_OVERLAY_IN = 0x56,
        UISND_HUD_STUTTER_TEXT_OVERLAY_OUT = 0x57,
        UISND_HUD_BURNOUT_RATING_IN = 0x58,
        UISND_HUD_BURNOUT_RATING_OUT = 0x59,
        UISND_HUD_DRAG_COUNTDOWN = 0x5C,
        UISND_HUD_DRAG_COUNTDOWN_GO = 0x5D,
        UISND_COMMON_CHYRON_IN = 0x5E,
        UISND_COMMON_CHYRON_OUT = 0x5F,
        UISND_COMMON_CHYRON_NOTIFICATION = 0x60,
        UISND_HUD_COUNTDOWN_1 = 0x61,
        UISND_HUD_COUNTDOWN_2 = 0x62,
        UISND_HUD_COUNTDOWN_3 = 0x63,
        UISND_COMMON_MUSIC_CHYRON_IN = 0x64,
        UISND_COMMON_MUSIC_CHYRON_OUT = 0x65,
        UISND_COMMON_LARGE_MENU_IN = 0x66,
        UISND_COMMON_LARGE_MENU_OUT = 0x67,
        UISND_COMMON_PAUSE_MENU_IN = 0x68,
        UISND_COMMON_PAUSE_MENU_OUT = 0x69,
        UISND_COMMON_YOU_WON = 0x6A,
        UISND_COMMON_MAX_NUM = 0xC7,
        UISND_MAIN_UP_AND_DOWN = 0xC8,
        UISND_MAIN_LEFT_AND_RIGHT = 0xC9,
        UISND_MAIN_SCROLL_LEFT = 0xCA,
        UISND_MAIN_SCROLL_RIGHT = 0xCB,
        UISND_MAIN_SELECT = 0xCC,
        UISND_MAIN_BACK = 0xCD,
        UISND_MAIN_WRONG = 0xCF,
        UISND_MAIN_TRANSITION_IN = 0xD0,
        UISND_MAIN_TRANSITION_OUT = 0xD1,
        UISND_MAIN_DLGBOX_IN = 0xD2,
        UISND_MAIN_DLGBOX_OUT = 0xD3,
        UISND_UGNEW_KBTYPE = 0xE0,
        UISND_UGNEW_ENTER = 0xE1,
        UISND_UGNEW_DELETE = 0xE2,
        UISND_MAIN_END_OF_LIST = 0xE4,
        UISND_MAIN_KBCURSOR_UPDOWN = 0xE6,
        UISND_MAIN_KBCURSOR_LEFTRIGHT = 0xE7,
        UISND_MAIN_TRANSITION_ANIMATION_1 = 0xE8,
        UISND_MAIN_TRANSITION_ANIMATION_2 = 0xE9,
        UISND_MAIN_TRANSITION_ANIMATION_3 = 0xEA,
        UISND_MAIN_TRANSITION_ANIMATION_4 = 0xEB,
        UISND_MAIN_TRANSITION_ANIMATION_5 = 0xEC,
        UISND_MAIN_TRANSITION_ANIMATION_6 = 0xED,
        UISND_MAIN_TRANSITION_ANIMATION_7 = 0xEE,
        UISND_MAIN_TRANSITION_ANIMATION_8 = 0xEF,
        UISND_MAIN_TRANSITION_ANIMATION_9 = 0xF0,
        UISND_MAIN_CUST_INST_PAINT = 0x132,
        UISND_MAIN_CUST_PAINT_COLOUR_LEFT = 0x133,
        UISND_MAIN_CUST_PAINT_COLOUR_RIGHT = 0x134,
        UISND_MAIN_CUST_PAINT_COLOUR_UP = 0x135,
        UISND_MAIN_CUST_PAINT_COLOUR_DOWN = 0x136,
        UISND_MAIN_CUST_VINYL_INSTALL = 0x137,
        UISND_CUST_INST_EXHAUST = 0x13C,
        UISND_CUST_INST_GENERIC = 0x13D,
        UISND_CUST_INST_TURBO = 0x13E,
        UISND_CUST_INST_NOS = 0x13F,
        UISND_CUST_INST_TRANSMISSION = 0x140,
        UISND_CUST_INST_TIRES = 0x141,
        UISND_EA_MSGR_OPEN = 0x142,
        UISND_EA_MSGR_LOGOFF = 0x143,
        UISND_EA_MSGR_CHAT_REQ = 0x144,
        UISND_EA_MSGR_MAIL_RECEIVE = 0x145,
        UISND_EA_MSGR_CHALLENGE_REQ = 0x146,
        UISND_MAIN_MENU_ENTER = 0x15A,
        UISND_MAIN_MENU_EXIT = 0x15B,
        UISND_MAIN_SUB_ENTER = 0x15C,
        UISND_MAIN_SUB_EXIT = 0x15D,
        UISND_MAIN_MAP_AREA_SELECT = 0x15E,
        UISND_MAIN_MAP_MENU_APPEAR = 0x15F,
        UISND_MAIN_MAP_MENU_DISAPPEAR = 0x160,
        UISND_MAIN_MAP_MENU_NAV_UP = 0x161,
        UISND_MAIN_MAP_MENU_NAV_DOWN = 0x162,
        UISND_MAIN_MAP_MENU_NAV_LEFT = 0x163,
        UISND_MAIN_MAP_MENU_NAV_RIGHT = 0x164,
        UISND_MAIN_MAP_ZOOM_IN = 0x165,
        UISND_MAIN_MAP_ZOOM_OUT = 0x166,
        UISND_MAIN_KEYBOARD_ACCEPT = 0x167,
        UISND_MAIN_KEYBOARD_BACK = 0x168,
        UISND_MAIN_KEYBOARD_NAV = 0x169,
        UISND_MAIN_KEYBOARD_SELECT = 0x16A,
        UISND_MAIN_MAP_MENU_NAV_LEFTRIGHT = 0x16B,
        UISND_MAIN_MAP_MENU_NAV_UPDOWN = 0x16C,
        UISND_MAIN_FEICECAM_CAM1 = 0x170,
        UISND_MAIN_FEICECAM_CAM1BCK = 0x171,
        UISND_MAIN_FEICECAM_CAM2 = 0x172,
        UISND_MAIN_FEICECAM_CAM2BCK = 0x173,
        UISND_MAIN_FEICECAM_CAM3 = 0x174,
        UISND_MAIN_FEICECAM_CAM3BCK = 0x175,
        UISND_MAIN_FEICECAM_CAM4 = 0x176,
        UISND_MAIN_FEICECAM_CAM4BCK = 0x177,
        UISND_MAIN_FEICECAM_CAM5 = 0x178,
        UISND_MAIN_FEICECAM_CAM5BCK = 0x179,
        UISND_MAIN_FEICECAM_CAM6 = 0x17A,
        UISND_MAIN_FEICECAM_CAM6BCK = 0x17B,
        UISND_MAIN_FEICECAM_CAM7 = 0x17C,
        UISND_MAIN_FEICECAM_CAM7BCK = 0x17D,
        UISND_MAIN_FEICECAM_CAM8 = 0x17E,
        UISND_MAIN_FEICECAM_CAM8BCK = 0x17F,
        UISND_MAIN_FEICECAM_CAM9 = 0x180,
        UISND_MAIN_FEICECAM_CAM9BCK = 0x181,
        UISND_MAIN_FEICECAM_CAM10 = 0x182,
        UISND_MAIN_FEICECAM_CAM10BCK = 0x183,
        UISND_MAIN_SWIRLING_MENU_INTRO = 0x184,
        UISND_MAIN_UNLOCK = 0x185,
        UISND_FRONTEND_MAX_NUM = 0x18F,
        UISND_COMMON_DRIFT_NICE = 0x190,
        UISND_COMMON_DRIFT_GOOD = 0x190,
        UISND_COMMON_DRIFT_AWESOME = 0x191,
        UISND_COMMON_DRIFT_AMAZING = 0x191,
        UISND_COMMON_DRIFT_GREAT = 0x191,
        UISND_COMMON_DRIFT_OUTRAGEOUS = 0x192,
        UISND_COMMON_DRIFT_MULTIPLIER = 0x193,
        UISND_COMMON_DRIFT_DRIFT_ENDED = 0x194,
        UISND_COMMON_DRIFT_PERFECT_ENTRY = 0x195,
        UISND_DRIFT_MAX_NUM = 0x1A4,
    }
}