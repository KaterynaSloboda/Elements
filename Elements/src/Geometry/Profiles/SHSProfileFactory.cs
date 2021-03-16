#pragma warning disable CS1591
using System;

namespace Elements.Geometry.Profiles
{
    public enum SHSProfileType
    {
        SHS50xs00x1_6,
        SHS50xs00x2,
        SHS50xs00x2_3,
        SHS50xs00x2_5,
        SHS50xs00x3,
        SHS50xs00x3_2,
        SHS50xs00x4,
        SHS50xs00x4_5,
        SHS50xs00x5,
        SHS50xs00x6,
        SHS60xs00x1_6,
        SHS60xs00x2,
        SHS60xs00x2_3,
        SHS60xs00x2_5,
        SHS60xs00x3,
        SHS60xs00x3_2,
        SHS60xs00x4,
        SHS60xs00x4_5,
        SHS60xs00x5,
        SHS60xs00x6,
        SHS75xs00x1_6,
        SHS75xs00x2,
        SHS75xs00x2_3,
        SHS75xs00x2_5,
        SHS75xs00x3,
        SHS75xs00x3_2,
        SHS75xs00x4,
        SHS75xs00x4_5,
        SHS75xs00x5,
        SHS75xs00x6,
        SHS75xs00x6_3,
        SHS75xs00x8,
        SHS80xs00x1_6,
        SHS80xs00x2,
        SHS80xs00x2_3,
        SHS80xs00x2_5,
        SHS80xs00x3,
        SHS80xs00x3_2,
        SHS80xs00x4,
        SHS80xs00x4_5,
        SHS80xs00x5,
        SHS80xs00x6,
        SHS80xs00x6_3,
        SHS80xs00x8,
        SHS90xs00x2_3,
        SHS90xs00x2_5,
        SHS90xs00x3,
        SHS90xs00x3_2,
        SHS90xs00x4,
        SHS90xs00x4_5,
        SHS90xs00x5,
        SHS90xs00x6,
        SHS90xs00x6_3,
        SHS100xs00x1_6,
        SHS100xs00x2,
        SHS100xs00x2_3,
        SHS100xs00x2_5,
        SHS100xs00x3,
        SHS100xs00x3_2,
        SHS100xs00x4,
        SHS100xs00x4_5,
        SHS100xs00x5,
        SHS100xs00x6,
        SHS100xs00x6_3,
        SHS100xs00x8,
        SHS100xs00x9,
        SHS100xs00x10,
        SHS100xs00x12,
        SHS120xs00x6,
        SHS120xs00x6_3,
        SHS120xs00x8,
        SHS120xs00x9,
        SHS120xs00x10,
        SHS120xs00x12,
        SHS125xs00x2_3,
        SHS125xs00x2_5,
        SHS125xs00x3,
        SHS125xs00x3_2,
        SHS125xs00x4,
        SHS125xs00x4_5,
        SHS125xs00x5,
        SHS125xs00x6,
        SHS125xs00x6_3,
        SHS125xs00x8,
        SHS125xs00x9,
        SHS125xs00x10,
        SHS125xs00x12,
        SHS125xs00x12_5,
        SHS150xs00x3_2,
        SHS150xs00x4,
        SHS150xs00x4_5,
        SHS150xs00x5,
        SHS150xs00x6,
        SHS150xs00x6_3,
        SHS150xs00x8,
        SHS150xs00x9,
        SHS150xs00x10,
        SHS150xs00x12,
        SHS150xs00x12_5,
        SHS175xs00x4_5,
        SHS175xs00x5,
        SHS175xs00x6,
        SHS175xs00x6_3,
        SHS175xs00x8,
        SHS175xs00x9,
        SHS175xs00x10,
        SHS175xs00x12,
        SHS175xs00x12_5,
        SHS200xs00x4_5,
        SHS200xs00x5,
        SHS200xs00x6,
        SHS200xs00x6_3,
        SHS200xs00x8,
        SHS200xs00x9,
        SHS200xs00x10,
        SHS200xs00x12,
        SHS200xs00x12_5,
        SHS200xs00x16,
        SHS250xs00x6,
        SHS250xs00x6_3,
        SHS250xs00x8,
        SHS250xs00x9,
        SHS250xs00x10,
        SHS250xs00x12,
        SHS250xs00x12_5,
        SHS250xs00x16,
        SHS250xs00x19,
        SHS300xs00x6,
        SHS300xs00x6_3,
        SHS300xs00x8,
        SHS300xs00x9,
        SHS300xs00x10,
        SHS300xs00x12,
        SHS300xs00x12_5,
        SHS300xs00x16,
        SHS300xs00x19,
        SHS350xs00x9,
        SHS350xs00x10,
        SHS350xs00x12,
        SHS350xs00x12_5,
        SHS350xs00x16,
        SHS350xs00x19,
        SHS350xs00x22,
        SHS400xs00x9,
        SHS400xs00x10,
        SHS400xs00x12,
        SHS400xs00x12_5,
        SHS400xs00x16,
        SHS400xs00x19,
        SHS400xs00x22,
        SHS450xs00x9,
        SHS450xs00x10,
        SHS450xs00x12,
        SHS450xs00x12_5,
        SHS450xs00x16,
        SHS450xs00x19,
        SHS450xs00x22,
        SHS500xs00x9,
        SHS500xs00x10,
        SHS500xs00x12,
        SHS500xs00x12_5,
        SHS500xs00x16,
        SHS500xs00x19,
        SHS500xs00x22,
        SHS550xs00x12,
        SHS550xs00x12_5,
        SHS550xs00x16,
        SHS550xs00x19,
        SHS550xs00x22
    }

    /// <summary>
    /// A singleton class which serves every HSS pipe section as defined by AISC.
    /// </summary>
    public sealed class SHSProfileFactory : ProfileFactory<SHSProfileType, SHSProfile>
    {
        /// Nominal Size,Nominal Size,Thickness,Mass,Area,Second Moment of Area,Second Moment of Area,Radius of Gyration,Radius of Gyration,Elastic Section Modulus,Elastic Section Modulus,Plastic Section modulus,Plastic Section modulus,Torsional Inertia,Torsional Modulus,superficial area per,Nominal Length
        private static string _data = @"A,B,t,M,A,Ix,Iy,ix,iy,Zx,Zy,Zpx,Zpy,ti,tm,sa,nl,J 
50,50,1.6,2.38,3.032,11.7,11.7,1.96,1.96,4.68,4.68,5.46,5.46,18.5,7.03,0.195,420
50,50,2,2.93,3.737,14.1,14.1,1.95,1.95,5.66,5.66,6.66,6.66,22.6,8.51,0.193,341
50,50,2.3,3.34,4.252,15.9,15.9,1.93,1.93,6.34,6.34,7.52,7.52,25.6,9.55,0.192,300
50,50,2.5,3.6,4.589,16.9,16.9,1.92,1.92,6.78,6.78,8.07,8.07,27.5,10.2,0.191,278
50,50,3,4.25,5.408,19.5,19.5,1.9,1.9,7.79,7.79,9.39,9.39,32.1,11.8,0.19,236
50,50,3.2,4.5,5.727,20.4,20.4,1.89,1.89,8.16,8.16,9.89,9.89,33.9,12.3,0.189,222
50,50,4,5.45,6.948,23.7,23.7,1.85,1.85,9.49,9.49,11.7,11.7,40.4,14.4,0.186,183
50,50,4.5,6.02,7.669,25.5,25.5,1.82,1.82,10.2,10.2,12.8,12.8,44.1,15.6,0.185,166
50,50,5,6.56,8.356,27,27,1.8,1.8,10.8,10.8,13.7,13.7,47.5,16.6,0.183,152
50,50,6,7.56,9.633,29.5,29.5,1.75,1.75,11.8,11.8,15.3,15.3,53.2,18.2,0.179,132
60,60,1.6,2.88,3.672,20.7,20.7,2.37,2.37,6.89,6.89,7.99,7.99,32.4,10.4,0.235,347
60,60,2,3.56,4.537,25.1,25.1,2.35,2.35,8.38,8.38,9.79,9.79,39.8,12.6,0.233,281
60,60,2.3,4.06,5.172,28.3,28.3,2.34,2.34,9.44,9.44,11.1,11.1,45.2,14.2,0.232,246
60,60,2.5,4.39,5.589,30.3,30.3,2.33,2.33,10.1,10.1,11.9,11.9,48.7,15.2,0.231,228
60,60,3,5.19,6.608,35.1,35.1,2.31,2.31,11.7,11.7,14,14,57.1,17.7,0.23,193
60,60,3.2,5.5,7.007,36.9,36.9,2.3,2.3,12.3,12.3,14.7,14.7,60.3,18.6,0.229,182
60,60,4,6.71,8.548,43.6,43.6,2.26,2.26,14.5,14.5,17.6,17.6,72.6,22,0.226,149
60,60,4.5,7.43,9.469,47.2,47.2,2.23,2.23,15.7,15.7,19.3,19.3,79.8,23.9,0.225,135
60,60,5,8.13,10.36,50.5,50.5,2.21,2.21,16.8,16.8,20.9,20.9,86.4,25.6,0.223,123
60,60,6,9.45,12.03,56.1,56.1,2.16,2.16,18.7,18.7,23.7,23.7,98.4,28.6,0.219,106
75,75,1.6,3.64,4.632,41.3,41.3,2.99,2.99,11,11,12.7,12.7,64.1,16.5,0.295,275
75,75,2,4.5,5.737,50.5,50.5,2.97,2.97,13.5,13.5,15.6,15.6,79,20.2,0.293,222
75,75,2.3,5.14,6.552,57.1,57.1,2.95,2.95,15.2,15.2,17.7,17.7,90,22.9,0.292,194
75,75,2.5,5.57,7.089,61.4,61.4,2.94,2.94,16.4,16.4,19.1,19.1,97.1,24.6,0.291,180
75,75,3,6.6,8.408,71.6,71.6,2.92,2.92,19.1,19.1,22.5,22.5,115,28.7,0.29,152
75,75,3.2,7.01,8.927,75.5,75.5,2.91,2.91,20.1,20.1,23.8,23.8,121,30.3,0.289,143
75,75,4,8.59,10.95,90.2,90.2,2.87,2.87,24.1,24.1,28.8,28.8,147,36.3,0.286,116
75,75,4.5,9.55,12.17,98.6,98.6,2.85,2.85,26.3,26.3,31.7,31.7,163,39.7,0.285,105
75,75,5,10.5,13.36,106,106,2.82,2.82,28.4,28.4,34.5,34.5,177,42.9,0.283,95.4
75,75,6,12.3,15.63,120,120,2.77,2.77,32,32,39.6,39.6,205,48.7,0.279,81.5
75,75,6.3,12.8,16.29,124,124,2.76,2.76,33,33,41,41,212,50.3,0.278,78.2
75,75,8,15.5,19.79,141,141,2.67,2.67,37.7,37.7,48.2,48.2,251,57.9,0.273,64.4
80,80,1.6,3.89,4.952,50.4,50.4,3.19,3.19,12.6,12.6,14.5,14.5,78,18.9,0.315,257
80,80,2,4.82,6.137,61.7,61.7,3.17,3.17,15.4,15.4,17.8,17.8,96.3,23.2,0.313,208
80,80,2.3,5.51,7.012,69.9,69.9,3.16,3.16,17.5,17.5,20.3,20.3,110,26.2,0.312,182
80,80,2.5,5.96,7.589,75.1,75.1,3.15,3.15,18.8,18.8,21.9,21.9,119,28.2,0.311,168
80,80,3,7.07,9.008,87.8,87.8,3.12,3.12,22,22,25.8,25.8,140,33,0.31,141
80,80,3.2,7.51,9.567,92.7,92.7,3.11,3.11,23.2,23.2,27.3,27.3,148,34.9,0.309,133
80,80,4,9.22,11.75,111,111,3.07,3.07,27.8,27.8,33.1,33.1,180,41.8,0.306,108
80,80,4.5,10.3,13.07,122,122,3.05,3.05,30.4,30.4,36.5,36.5,200,45.9,0.305,97.5
80,80,5,11.3,14.36,131,131,3.03,3.03,32.9,32.9,39.7,39.7,218,49.7,0.303,88.7
80,80,6,13.2,16.83,149,149,2.98,2.98,37.3,37.3,45.8,45.8,252,56.6,0.299,75.7
80,80,6.3,13.8,17.55,154,154,2.96,2.96,38.5,38.5,47.5,47.5,262,58.5,0.298,72.6
80,80,8,16.8,21.39,177,177,2.88,2.88,44.3,44.3,56.1,56.1,311,67.8,0.293,59.6
90,90,2.3,6.23,7.932,101,101,3.56,3.56,22.4,22.4,25.9,25.9,158,33.6,0.352,161
90,90,2.5,6.74,8.589,109,109,3.56,3.56,24.1,24.1,28,28,170,36.2,0.351,148
90,90,3,8.01,10.21,127,127,3.53,3.53,28.3,28.3,33,33,201,42.5,0.35,125
90,90,3.2,8.52,10.85,135,135,3.52,3.52,29.9,29.9,35,35,214,44.9,0.349,117
90,90,4,10.5,13.35,162,162,3.48,3.48,36,36,42.6,42.6,261,54.2,0.346,95.4
90,90,4.5,11.7,14.87,178,178,3.46,3.46,39.5,39.5,47.1,47.1,289,59.6,0.345,85.7
90,90,5,12.8,16.36,193,193,3.43,3.43,42.9,42.9,51.4,51.4,316,64.7,0.343,77.9
90,90,6,15.1,19.23,220,220,3.39,3.39,49,49,59.5,59.5,368,74.2,0.339,66.2
90,90,6.3,15.8,20.07,228,228,3.37,3.37,50.7,50.7,61.9,61.9,382,76.8,0.338,63.5
100,100,1.6,4.89,6.232,100,100,4.01,4.01,20,20,22.9,22.9,154,30,0.395,204
100,100,2,6.07,7.737,123,123,3.99,3.99,24.6,24.6,28.3,28.3,191,36.9,0.393,165
100,100,2.3,6.95,8.852,140,140,3.97,3.97,27.9,27.9,32.3,32.3,217,41.9,0.392,144
100,100,2.5,7.53,9.589,151,151,3.96,3.96,30.1,30.1,34.9,34.9,235,45.2,0.391,133
100,100,3,8.96,11.41,177,177,3.94,3.94,35.4,35.4,41.2,41.2,279,53.2,0.39,112
100,100,3.2,9.52,12.13,187,187,3.93,3.93,37.5,37.5,43.7,43.7,296,56.3,0.389,105
100,100,4,11.7,14.95,226,226,3.89,3.89,45.3,45.3,53.3,53.3,362,68.1,0.386,85.2
100,100,4.5,13.1,16.67,249,249,3.87,3.87,49.9,49.9,59,59,402,75.1,0.385,76.4
100,100,5,14.4,18.36,271,271,3.84,3.84,54.2,54.2,64.6,64.6,441,81.7,0.383,69.4
100,100,6,17,21.63,311,311,3.79,3.79,62.3,62.3,75.1,75.1,514,94.1,0.379,58.9
100,100,6.3,17.7,22.59,323,323,3.78,3.78,64.6,64.6,78.1,78.1,535,97.6,0.378,56.4
100,100,8,21.8,27.79,380,380,3.7,3.7,76,76,93.8,93.8,647,115,0.373,45.8
100,100,9,24.1,30.67,408,408,3.65,3.65,81.6,81.6,102,102,706,124,0.369,41.5
100,100,10,26.2,33.43,433,433,3.6,3.6,86.5,86.5,110,110,759,132,0.366,38.1
100,100,12,30.3,38.53,471,471,3.5,3.5,94.3,94.3,123,123,852,146,0.359,33.1
120,120,6,20.8,26.43,562,562,4.61,4.61,93.7,93.7,112,112,913,141,0.459,48.2
120,120,6.3,21.7,27.63,584,584,4.6,4.6,97.3,97.3,116,116,953,147,0.458,46.1
120,120,8,26.8,34.19,697,697,4.51,4.51,116,116,141,141,1160,176,0.453,37.3
120,120,9,29.7,37.87,755,755,4.47,4.47,126,126,155,155,1280,191,0.449,33.6
120,120,10,32.5,41.43,808,808,4.42,4.42,135,135,167,167,1380,205,0.446,30.8
120,120,12,37.8,48.13,897,897,4.32,4.32,150,150,189,189,1570,229,0.439,26.5
125,125,2.3,8.75,11.15,278,278,4.99,4.99,44.5,44.5,51.1,51.1,430,66.8,0.492,114
125,125,2.5,9.49,12.09,300,300,4.98,4.98,48.1,48.1,55.3,55.3,465,72.1,0.491,105
125,125,3,11.3,14.41,355,355,4.96,4.96,56.7,56.7,65.6,65.6,553,85.1,0.49,88.4
125,125,3.2,12,15.33,376,376,4.95,4.95,60.1,60.1,69.6,69.6,587,90.2,0.489,83.1
125,125,4,14.9,18.95,457,457,4.91,4.91,73.2,73.2,85.3,85.3,722,110,0.486,67.2
125,125,4.5,16.6,21.17,506,506,4.89,4.89,80.9,80.9,94.8,94.8,804,122,0.485,60.2
125,125,5,18.3,23.36,553,553,4.86,4.86,88.4,88.4,104,104,884,133,0.483,54.5
125,125,6,21.7,27.63,641,641,4.82,4.82,103,103,122,122,1040,154,0.479,46.1
125,125,6.3,22.7,28.89,666,666,4.8,4.8,107,107,127,127,1080,161,0.478,44.1
125,125,8,28.1,35.79,797,797,4.72,4.72,128,128,154,154,1320,193,0.473,35.6
125,125,9,31.1,39.67,865,865,4.67,4.67,138,138,169,169,1460,210,0.469,32.1
125,125,10,34.1,43.43,927,927,4.62,4.62,148,148,183,183,1580,225,0.466,29.3
125,125,12,39.7,50.53,1030,1030,4.52,4.52,165,165,208,208,1800,253,0.459,25.2
125,125,12.5,41,52.23,1060,1060,4.5,4.5,169,169,214,214,1850,259,0.457,24.4
150,150,3.2,14.5,18.53,661,661,5.97,5.97,88.1,88.1,101,101,1030,132,0.589,68.8
150,150,4,18,22.95,808,808,5.93,5.93,108,108,125,125,1260,162,0.586,55.5
150,150,4.5,20.2,25.67,896,896,5.91,5.91,120,120,139,139,1410,180,0.585,49.6
150,150,5,22.3,28.36,982,982,5.89,5.89,131,131,153,153,1550,197,0.583,44.9
150,150,6,26.4,33.63,1150,1150,5.84,5.84,153,153,180,180,1830,230,0.579,37.9
150,150,6.3,27.6,35.19,1190,1190,5.82,5.82,159,159,188,188,1910,239,0.578,36.2
150,150,8,34.4,43.79,1440,1440,5.74,5.74,192,192,230,230,2360,290,0.573,29.1
150,150,9,38.2,48.67,1580,1580,5.69,5.69,210,210,253,253,2600,318,0.569,26.2
150,150,10,41.9,53.43,1700,1700,5.64,5.64,227,227,276,276,2840,343,0.566,23.8
150,150,12,49.1,62.53,1920,1920,5.54,5.54,256,256,317,317,3270,390,0.559,20.4
150,150,12.5,50.8,64.73,1970,1970,5.52,5.52,263,263,326,326,3380,400,0.557,19.7
175,175,4.5,23.7,30.17,1450,1450,6.93,6.93,166,166,192,192,2260,249,0.685,42.2
175,175,5,26.2,33.36,1590,1590,6.91,6.91,182,182,211,211,2500,273,0.683,38.2
175,175,6,31.1,39.63,1860,1860,6.86,6.86,213,213,249,249,2950,320,0.679,32.1
175,175,6.3,32.6,41.49,1940,1940,6.84,6.84,222,222,260,260,3090,334,0.678,30.7
175,175,8,40.7,51.79,2370,2370,6.76,6.76,271,271,321,321,3820,408,0.673,24.6
175,175,9,45.3,57.67,2600,2600,6.71,6.71,297,297,354,354,4230,448,0.669,22.1
175,175,10,49.8,63.43,2820,2820,6.66,6.66,322,322,387,387,4630,486,0.666,20.1
175,175,12,58.5,74.53,3210,3210,6.57,6.57,367,367,447,447,5380,556,0.659,17.1
175,175,12.5,60.6,77.23,3310,3310,6.54,6.54,378,378,462,462,5560,573,0.657,16.5
200,200,4.5,27.2,34.67,2190,2190,7.95,7.95,219,219,253,253,3410,329,0.785,36.7
200,200,5,30.1,38.36,2410,2410,7.93,7.93,241,241,279,279,3760,362,0.783,33.2
200,200,6,35.8,45.63,2830,2830,7.88,7.88,283,283,330,330,4460,426,0.779,27.9
200,200,6.3,37.5,47.79,2960,2960,7.86,7.86,296,296,345,345,4660,444,0.778,26.7
200,200,8,46.9,59.79,3620,3620,7.78,7.78,362,362,426,426,5790,545,0.773,21.3
200,200,9,52.3,66.67,3990,3990,7.73,7.73,399,399,472,472,6430,601,0.769,19.1
200,200,10,57.6,73.43,4340,4340,7.69,7.69,434,434,517,517,7050,654,0.766,17.3
200,200,12,67.9,86.53,4980,4980,7.59,7.59,498,498,601,601,8230,753,0.759,14.7
200,200,12.5,70.4,89.73,5130,5130,7.56,7.56,513,513,621,621,8510,776,0.757,14.2
200,200,16,87.3,111.2,6080,6080,7.39,7.39,608,608,751,751,10300,924,0.745,11.5
250,250,6,45.2,57.63,5670,5670,9.92,9.92,454,454,524,524,8840,681,0.979,22.1
250,250,6.3,47.4,60.39,5930,5930,9.91,9.91,474,474,549,549,9260,712,0.978,21.1
250,250,8,59.5,75.79,7320,7320,9.82,9.82,585,585,683,683,11600,879,0.973,16.8
250,250,9,66.5,84.67,8090,8090,9.78,9.78,647,647,759,759,12900,973,0.969,15
250,250,10,73.3,93.43,8840,8840,9.73,9.73,707,707,833,833,14100,1060,0.966,13.6
250,250,12,86.8,110.5,10300,10300,9.63,9.63,820,820,975,975,16600,1240,0.959,11.5
250,250,12.5,90.1,114.7,10600,10600,9.61,9.61,847,847,1010,1010,17200,1280,0.957,11.1
250,250,16,112,143.2,12800,12800,9.44,9.44,1020,1020,1240,1240,21200,1540,0.945,8.9
250,250,19,131,166.3,14400,14400,9.29,9.29,1150,1150,1410,1410,24300,1740,0.935,7.66
300,300,6,54.7,69.63,9960,9960,12,12,664,664,764,764,15400,997,1.18,18.3
300,300,6.3,57.3,72.99,10400,10400,11.9,11.9,695,695,800,800,16200,1040,1.18,17.5
300,300,8,72.1,91.79,12900,12900,11.9,11.9,862,862,999,999,20200,1290,1.17,13.9
300,300,9,80.6,102.7,14300,14300,11.8,11.8,956,956,1110,1110,22600,1440,1.17,12.4
300,300,10,89,113.4,15700,15700,11.8,11.8,1050,1050,1220,1220,24900,1570,1.17,11.2
300,300,12,106,134.5,18300,18300,11.7,11.7,1220,1220,1440,1440,29300,1840,1.16,9.47
300,300,12.5,110,139.7,19000,19000,11.6,11.6,1260,1260,1490,1490,30400,1900,1.16,9.12
300,300,16,138,175.2,23100,23100,11.5,11.5,1540,1540,1840,1840,37700,2320,1.15,7.27
300,300,19,160,204.3,26200,26200,11.3,11.3,1750,1750,2120,2120,43500,2650,1.13,6.24
350,350,9,94.7,120.7,23200,23200,13.9,13.9,1320,1320,1530,1530,36200,1990,1.37,10.6
350,350,10,105,133.4,25500,25500,13.8,13.8,1450,1450,1690,1690,40000,2180,1.37,9.55
350,350,12,124,158.5,29800,29800,13.7,13.7,1700,1700,1990,1990,47300,2560,1.36,8.04
350,350,12.5,129,164.7,30900,30900,13.7,13.7,1760,1760,2070,2070,49100,2650,1.36,7.73
350,350,16,163,207.2,37900,37900,13.5,13.5,2160,2160,2570,2570,61100,3260,1.35,6.15
350,350,19,190,242.3,43400,43400,13.4,13.4,2480,2480,2970,2970,70900,3740,1.33,5.26
350,350,22,217,276.2,48400,48400,13.2,13.2,2760,2760,3340,3340,80200,4180,1.32,4.61
400,400,9,109,138.7,35100,35100,15.9,15.9,1750,1750,2020,2020,54500,2630,1.57,9.19
400,400,10,120,153.4,38600,38600,15.9,15.9,1930,1930,2230,2230,60200,2890,1.57,8.3
400,400,12,143,182.5,45300,45300,15.8,15.8,2270,2270,2640,2640,71300,3400,1.56,6.98
400,400,12.5,149,189.7,47000,47000,15.7,15.7,2350,2350,2740,2740,74100,3530,1.56,6.71
400,400,16,188,239.2,57900,57900,15.6,15.6,2900,2900,3410,3410,92700,4360,1.55,5.33
400,400,19,220,280.3,66600,66600,15.4,15.4,3330,3330,3960,3960,108000,5020,1.53,4.55
400,400,22,251,320.2,74700,74700,15.3,15.3,3740,3740,4480,4480,122000,5640,1.52,3.98
450,450,9,123,156.7,50400,50400,17.9,17.9,2240,2240,2580,2580,78100,3360,1.77,8.13
450,450,10,136,173.4,55500,55500,17.9,17.9,2470,2470,2850,2850,86300,3700,1.77,7.35
450,450,12,162,206.5,65400,65400,17.8,17.8,2910,2910,3370,3370,102000,4370,1.76,6.17
450,450,12.5,169,214.7,67800,67800,17.8,17.8,3020,3020,3500,3500,106000,4530,1.76,5.93
450,450,16,213,271.2,84100,84100,17.6,17.6,3740,3740,4380,4380,134000,5620,1.75,4.7
450,450,19,250,318.3,97100,97100,17.5,17.5,4310,4310,5090,5090,156000,6490,1.73,4
450,450,22,286,364.2,109000,109000,17.3,17.3,4850,4850,5780,5780,177000,7310,1.72,3.5
500,500,9,137,174.7,69800,69800,20,20,2790,2790,3200,3200,108000,4190,1.97,7.29
500,500,10,152,193.4,76900,76900,19.9,19.9,3080,3080,3540,3540,119000,4610,1.97,6.59
500,500,12,181,230.5,90800,90800,19.8,19.8,3630,3630,4200,4200,141000,5450,1.96,5.53
500,500,12.5,188,239.7,94100,94100,19.8,19.8,3770,3770,4360,4360,147000,5650,1.96,5.31
500,500,16,238,303.2,117000,117000,19.6,19.6,4680,4680,5460,5460,185000,7030,1.95,4.2
500,500,19,280,356.3,136000,136000,19.5,19.5,5420,5420,6370,6370,216000,8150,1.93,3.58
500,500,22,320,408.2,153000,153000,19.4,19.4,6120,6120,7240,7240,246000,9210,1.92,3.12
550,550,12,200,254.5,122000,122000,21.9,21.9,4430,4430,5110,5110,189000,6650,2.16,5
550,550,12.5,208,264.7,126000,126000,21.9,21.9,4600,4600,5310,5310,197000,6900,2.16,4.81
550,550,16,263,335.2,158000,158000,21.7,21.7,5730,5730,6670,6670,248000,8610,2.15,3.8
550,550,19,310,394.3,183000,183000,21.5,21.5,6660,6660,7790,7790,290000,10000,2.13,3.23
550,550,22,355,452.2,207000,207000,21.4,21.4,7530,7530,8870,8870,331000,11300,2.12,2.82";

        public SHSProfileFactory() : base(_data) { }

        /// <summary>
        /// Get a profile by name.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <returns>A rectangular hollow section profile.</returns>
        public override SHSProfile GetProfileByName(string name)
        {
            var profileType = (SHSProfileType)Enum.Parse(typeof(SHSProfileType), name, true);
            return CreateProfile((int)profileType);
        }

        /// <summary>
        /// Get a profile by type.
        /// </summary>
        /// <param name="type">The type of the profile.</param>
        /// <returns>A rectangular hollow section profile.</returns>
        public override SHSProfile GetProfileByType(SHSProfileType type)
        {
            return CreateProfile((int)type);
        }

        protected override SHSProfile CreateProfile(int typeIndex)
        {
            var profileType = (SHSProfileType)Enum.ToObject(typeof(SHSProfileType), typeIndex);

            var values = _profileData[typeIndex];

            var profile = new SHSProfile(profileType.ToString(),
                                         Guid.NewGuid(),
                                         double.Parse(values[0]) / 1000,
                                         double.Parse(values[1]) / 1000,
                                         double.Parse(values[2]) / 1000)
            {
                // M,A,Ix,Iy,ix,iy,Zx,Zy,Zpx,Zpy,ti,tm,sa,nl,J
                M = double.Parse(values[3]),
                Ix = double.Parse(values[4]),
                Iy = double.Parse(values[5]),
                ix = double.Parse(values[6]),
                iy = double.Parse(values[7]),
                Zx = double.Parse(values[8]),
                Zy = double.Parse(values[9]),
                Zpx = double.Parse(values[10]),
                Zpy = double.Parse(values[11]),
                ti = double.Parse(values[12]),
                tm = double.Parse(values[13]),
                sa = double.Parse(values[14]),
                nl = double.Parse(values[15]),
                J = double.Parse(values[16])
            };

            return profile;
        }
    }
}