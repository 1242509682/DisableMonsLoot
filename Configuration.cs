﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using TShockAPI;

namespace DisableMonsLoot
{
    internal class Configuration
    {
        #region 实例变量
        [JsonProperty("使用说明", Order = -9)]
        public string Text { get; set; } = "你只管改‘ID’就行，‘清理’和‘怪物名’不用动，击杀其中1个怪物ID自动关闭清理功能。指令：/kdm (权限killitem.admin)";
        [JsonProperty("插件开关", Order = -8)]
        public bool Enabled { get; set; } = true;
        [JsonProperty("是否全杀", Order = -7)]
        public bool KillAll { get; set; } = false;
        [JsonProperty("清理范围", Order = -6)]
        public int radius = 35;

        [JsonProperty("清理列表", Order = 0)]
        public List<ItemData> BossList { get; set; } = new List<ItemData>();
        #endregion

        #region 读取与创建配置文件方法
        public static readonly string FilePath = Path.Combine(TShock.SavePath, "禁怪物掉落.json");

        public void Write()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static Configuration Read()
        {
            if (!File.Exists(FilePath))
            {
                var NewConfig = new Configuration();
                NewConfig.Ints();
                new Configuration().Write();
                return NewConfig;
            }
            else
            {
                string jsonContent = File.ReadAllText(FilePath);
                Configuration config = JsonConvert.DeserializeObject<Configuration>(jsonContent)!;
                return config;
            }
        }
        #endregion

        #region 预设参数方法

        public void Ints()
        {
            BossList = new List<ItemData>
             {
                new ItemData("",true,new int []{ 50 }, new int[]{
                    3318,2430,256,257,258,3090}),

                new ItemData("",true,new int []{ 4 }, new int[]{
                    3319, 3262, 3097}),

                new ItemData("",true,new int []{ 668 }, new int[]{
                    3320, 5098, 5095, 5117, 5118, 5119}),

                new ItemData("",true,new int []{ 13,14,15,266 }, new int[]{
                    56, 86, 880, 1329, 3320, 3321, 174, 175, 122, 120, 119, 231, 232, 233, 2365, 4821, 121,
                    3223, 3224, 3266, 3267, 3268, 102, 101, 100, 103, 792, 793, 794, 798,
                    3817, 3813, 3809, 3810, 197, 123, 124, 125, 127, 116, 117, 4076, 4131, 5325}),

                new ItemData("",true,new int []{ 222 }, new int[]{
                    3322,1123,2888,1121,1132,1130,2431,2502,1249,4007,5294,1158,1430 }),

                new ItemData("",true,new int []{ 35,36 }, new int[]{
                    154,327,3323,346,273,329,113,683,157,3019,219,218,220,3317,3282,155,156,397,
                    163,164,151,152,153,5074,1313,2999,3000,890,891,904,2623,327}),

                new ItemData("",true,new int []{ 113,114 }, new int[]{
                    3324,2673,3991,3366,400,401,402,403,404,391,778,481,524,376,377,378,379,380,382,777,
                    436,525,371,372,373,374,375,381,776,435,1205,1206,1207,1208,1209,
                    1184,1187,1188,1189,1210,1211,1212,1213,1214,
                    1191,1194,1195,1196,1220,1215,1216,1217,1218,1219,1198,1201,1202,1203,1221,
                    1328,2161,684,685,686,726,1264,676,4911,1306,3783,3776,3777,3778,
                    2607,2370,2371,2372,2551,2366,
                    1308,389,426,3051,422,2998,489,490,491,492,493,785,
                    1165,761,822,485,900,497,861,
                    3013,3014,3015,3016,3992,
                    536,897,527,528,520,521,575,535,860,554,
                    862,1613,1612,892,886,901,893,889,903,888,
                    3781,5354,1253,3290,3289,3316,3315,3283,3054,532,
                    1247,1244,1326,522,519,3010,545,546,1332,1334,1335,3011,
                    1356,1336,1346,1350,1357,1347,1351,
                    526,501,516,502,518,515,3009,534,3211,723,514,1265,3788,
                    3210,2270,434,496,3006,3007,3008,3029,3052,5065,4269,4270,4272,3787,1321,
                    4006,4002,3103,3104,2750,905,2584,854,855,3034,3035,1324,3012,4912,544,556,557,3779}),

                new ItemData("",true,new int []{ 657 }, new int[]{
                    4957,4987,4980,4981,4982,4983,4984,4758 }),

                new ItemData("",true,new int []{ 134,135,136,125,126,127,128,129,130,131 }, new int[]
                {3325,3326,3327,1291,5338,533,4060,561,494,495,4760,
                    506,3284,3287,3288,3286,1515,821,748,
                    4896,4897,4898,4899,4900,4901,558,559,553,4873,
                    551,552,1225,578,4678,550,2535,3353,547,548,549,
                    3856,3835,3836,3854,3823,3852,
                    3797,3798,3799,3800,3801,3802,3803,3804,3805,3811,3806,3807,3808,3812,
                    935,2220,936,1343,674,675,990,579,947,1006,1001,1002,1003,1004,1005,
                    1229,1230,1231,1235,1179,1316,1317,1318,5382}),

                new ItemData("",true,new int []{ 262,263,264 }, new int[]{
                    3328,1958,1844,4961,3336,963,984,977,3292,3291,
                    1178,3105,3106,2770,1871,1183,4679,4680,1444,1445,1446,
                    3249,1305,757,1569,1571,1572,1156,1260,4607,1508,1946,1947,1931,
                    1928,1929,1930,3997,1552,1546,1547,1548,1549,1550,
                    1866,1570,823,1503,1504,1505,1506,3261,1729,1830,1832,1833,1834,1802,1801,
                    4444,1157,1159,1160,1161,1162,1845,1864,
                    1339,1342,1341,1340,1255,3107,3108,1782,1783,1910,1300,1254,760,759,758,
                    1784,1785,1835,1836,4457,4458,771,772,773,774,
                    4445,4446,4447,4448,4449,4459,1259,3018,1826,1513,938,3998,1327,4812,1301,4005}),

                new ItemData("",true,new int []{ 370 }, new int[]
                { 3330,2609,2622,2624,2621,2611,3367 }),

                new ItemData("",true,new int []{ 636 }, new int[]
                { 4782,4823,4715,4914,5005,4989,4923,4952,4953,4811}),

                new ItemData("",true,new int []{ 245, 246, 247, 248, 249 }, new int[]{
                    3329,3860,4807,1248,3337,1294,1122,1295,1296,1297,3110,
                    1865,899,2218,2199,2200,2201,2202,2280,948,
                    3871,3872,3873,3874,3875,3876,3877,3878,3879,3880,3882,
                    1258,2797,2882,2769,2880,2795,2749,2796,3883,
                    3870,3859,3858,3827,1261}),

                new ItemData("",true,new int []{ 439,440 }, new int[]{
                    3456,3457,3458,3459,3473,3543,3474,3531,3475,3540,3542,3476,3549,3544}),

                new ItemData("",true,new int []{ 396, 397, 398 }, new int[]{
                 3332,3601,3460,3467,3567,3568,2757,2758,2759,3469,3381,3382,3383,3470,2760,2761,2762,
                    3471,2763,2764,2765,3468,3466,2776,2781,2786,2774,2779,2784,3464,2768,3384,1131,4954,
                    4956,3065,3063,1553,3930,3570,3389,3541,3569,3571,5335,5364}),

            };
            this.BossList = BossList;
        }
        #endregion

        #region 数据结构
        public class ItemData
        {
            [JsonProperty("怪物名", Order = -8)]
            public string Name { get; set; } = "";
            [JsonProperty("清理", Order = -6)]
            public bool Enabled { get; set; } = true;
            [JsonProperty("怪物ID", Order = -4)]
            public int[] ID { get; set; } = new int[] { 1 };
            [JsonProperty("物品ID", Order = -2)]
            public int[] ItemID { get; set; }

            public ItemData(string name, bool enabled, int[] id, int[] itemId)
            {
                Name = name ?? ""; //避免Reload空引用
                Enabled = enabled;
                ID = id ?? new int[] { 1 };
                ItemID = itemId ?? new int[0];
            }

        }


        #endregion

    }
}