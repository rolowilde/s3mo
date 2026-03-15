using System;
using System.Collections.Generic;
using System.Text;

namespace s3molib
{
    public static class Helper
    {
        public static Dictionary<string, string> TagList = new Dictionary<string, string>()
        {
            ["0x00AE6C67"] = "BONE",
            ["0x00B2D882"] = "_IMG",
            ["0x00B552EA"] = "_SPT",
            ["0x015A1849"] = "GEOM",
            ["0x0166038C"] = "NMAP",
            ["0x01661233"] = "MODL",
            ["0x01A527DB"] = "_AUD",
            ["0x01D0E6FB"] = "VBUF",
            ["0x01D0E70F"] = "IBUF",
            ["0x01D0E723"] = "VRTG",
            ["0x01D0E75D"] = "MATD",
            ["0x01D0E76B"] = "SKIN",
            ["0x01D10F34"] = "MLOD",
            ["0x01EEF63A"] = "_AUD",
            ["0x02019972"] = "MTST",
            ["0x021D7E8C"] = "SPT2",
            ["0x0229684B"] = "VBUF",
            ["0x0229684F"] = "",
            ["0x022B756C"] = "",
            ["0x025C90A6"] = "_CSS",
            ["0x025C95B6"] = "LAYO",
            ["0x025ED6F4"] = "SIMO",
            ["0x029E333B"] = "VOCE",
            ["0x02C9EFF2"] = "MIXR",
            ["0x02D5DF13"] = "JAZZ",
            ["0x02DC343F"] = "OBJK",
            ["0x033260E3"] = "TKMK",
            ["0x0333406C"] = "_XML",
            ["0x033A1435"] = "TXTC",
            ["0x033B2B66"] = "",
            ["0x0341ACC9"] = "TXTF",
            ["0x034AEECB"] = "CASP",
            ["0x0354796A"] = "TONE",
            ["0x03555BA8"] = "TONE",
            ["0x0355E0A6"] = "BOND",
            ["0x0358B08A"] = "FACE",
            ["0x03B33DDF"] = "ITUN",
            ["0x03B4C61D"] = "LITE",
            ["0x03D843C2"] = "CCHE",
            ["0x03D86EA4"] = "DETL",
            ["0x03E80CDC"] = "",
            ["0x0418FE2A"] = "CFEN",
            ["0x044AE110"] = "COMP",
            ["0x046A7235"] = "",
            ["0x048A166D"] = "UNKN",
            ["0x0498DA7E"] = "",
            ["0x049CA4CD"] = "CSTR",
            ["0x04A09283"] = "UNKN",
            ["0x04A4D951"] = "WDET",
            ["0x04AC5D93"] = "CPRX",
            ["0x04B30669"] = "CTTL",
            ["0x04C58103"] = "CRAL",
            ["0x04D82D90"] = "CMRU",
            ["0x04ED4BB2"] = "CTPT",
            ["0x04EE6ABB"] = "UNKN",
            ["0x04F3CC01"] = "CFIR",
            ["0x04F51033"] = "SBNO",
            ["0x04F66BCC"] = "UNKN",
            ["0x04F88964"] = "SIME",
            ["0x051DF2DD"] = "CBLN",
            ["0x05512255"] = "UNKN",
            ["0x0553EAD4"] = "UNKN",
            ["0x0563919E"] = "UNKN",
            ["0x0580A2B4"] = "",
            ["0x0580A2B5"] = "",
            ["0x0580A2B6"] = "",
            ["0x0580A2CD"] = "SNAP",
            ["0x0580A2CE"] = "SNAP",
            ["0x0580A2CF"] = "SNAP",
            ["0x0580A2B4"] = "THUM",
            ["0x0580A2B5"] = "THUM",
            ["0x0580A2B6"] = "THUM",
            ["0x0589DC44"] = "THUM",
            ["0x0589DC45"] = "THUM",
            ["0x0589DC46"] = "THUM",
            ["0x0591B1AF"] = "UPST",
            ["0x05B17698"] = "THUM",
            ["0x05B17699"] = "THUM",
            ["0x05B1769A"] = "THUM",
            ["0x05B1B524"] = "THUM",
            ["0x05B1B525"] = "THUM",
            ["0x05B1B526"] = "THUM",
            ["0x05CD4BB3"] = "",
            ["0x05DA8AF6"] = "WBND",
            ["0x05E4FAF7"] = "UNKN",
            ["0x05ED1226"] = "REFS",
            ["0x05FF3549"] = "UNKN",
            ["0x05FF6BA4"] = "2ARY",
            ["0x0604ABDA"] = "DMTR",
            ["0x060B390C"] = "CWAT",
            ["0x060E1826"] = "UNKN",
            ["0x0611B0E7"] = "UNKN",
            ["0x062853A8"] = "FAMD",
            ["0x062C8204"] = "BBLN",
            ["0x062E9EE0"] = "",
            ["0x06302271"] = "CINF",
            ["0x063261DA"] = "HINF",
            ["0x06326213"] = "OBCI",
            ["0x06393F5D"] = "UNKN",
            ["0x06393F5D"] = "UNKN",
            ["0x065BFCAC"] = "",
            ["0x065BFCAD"] = "",
            ["0x065BFCAE"] = "",
            ["0x0668F628"] = "",
            ["0x0668F630"] = "",
            ["0x0668F635"] = "TWNI",
            ["0x0668F639"] = "TWNP",
            ["0x067CAA11"] = "BGEO",
            ["0x06B981ED"] = "OBJS",
            ["0x06CE4804"] = "META",
            ["0x06D6B112"] = "UNKN",
            ["0x06DC847E"] = "UNKN",
            ["0x073FAA07"] = "S3SA",
            ["0x07046B39"] = "",
            ["0x07CD07EC"] = "",
            ["0x0A36F07A"] = "CCFP",
            ["0x0C37A5B5"] = "LOOK",
            ["0x0C07456D"] = "COLL",
            ["0x11E32896"] = "",
            ["0x16B17A6C"] = "",
            ["0x1F886EAD"] = "_INI",
            ["0x220557DA"] = "STBL",
            ["0x2AD195F2"] = "",
            ["0x2653E3C8"] = "THUM",
            ["0x2653E3C9"] = "THUM",
            ["0x2653E3CA"] = "THUM",
            ["0x2D4284F0"] = "THUM",
            ["0x2D4284F1"] = "THUM",
            ["0x2D4284F2"] = "THUM",
            ["0x2E75C764"] = "ICON",
            ["0x2E75C765"] = "ICON",
            ["0x2E75C766"] = "ICON",
            ["0x2E75C767"] = "ICON",
            ["0x2F7D0002"] = "IMAG",
            ["0x2F7D0004"] = "IMAG",
            ["0x2F7D0008"] = "UITX",
            ["0x312E7545"] = "UNKN",
            ["0x316C78F2"] = "CFND",
            ["0x319E4F1D"] = "OBJD",
            ["0x32C83095"] = "",
            ["0x342778A7"] = "",
            ["0x342779A7"] = "",
            ["0x34E5247C"] = "UNKN",
            ["0x35A33E29"] = "",
            ["0x3A65AF29"] = "MINF",
            ["0x3D8632D0"] = "",
            ["0x4D1A5589"] = "OBJN",
            ["0x4F09F8E1"] = "UNKN",
            ["0x515CA4CD"] = "CWAL",
            ["0x54372472"] = "TSNP",
            ["0x5DE9DBA0"] = "THUM",
            ["0x5DE9DBA1"] = "THUM",
            ["0x5DE9DBA2"] = "THUM",
            ["0x626F60CC"] = "THUM",
            ["0x626F60CD"] = "THUM",
            ["0x626F60CE"] = "THUM",
            ["0x628A788F"] = "",
            ["0x63A33EA7"] = "ANIM",
            ["0x6ABFAD26"] = "UNKN",
            ["0x6B20C4F3"] = "CLIP",
            ["0x6B6D837D"] = "SNAP",
            ["0x6B6D837E"] = "SNAP",
            ["0x6B6D837F"] = "SNAP",
            ["0x72683C15"] = "STPR",
            ["0x736884F1"] = "VPXY",
            ["0x73E93EEB"] = "_XML",
            ["0x7672F0C5"] = "",
            ["0x8070223D"] = "AUDT",
            ["0x82B43584"] = "",
            ["0x8EAF13DE"] = "_RIG",
            ["0x8FFB80F6"] = "_ADS",
            ["0x90620000"] = "",
            ["0x90624C1B"] = "",
            ["0x9063660D"] = "WTXT",
            ["0x9063660E"] = "",
            ["0x913381F2"] = "UNKN",
            ["0x9151E6BC"] = "CWST",
            ["0x91EDBD3E"] = "CRST",
            ["0x94C5D14A"] = "SIGR",
            ["0x94EC4B54"] = "UNKN",
            ["0xA2377025"] = "",
            ["0xA5F9FE18"] = "UNKN",
            ["0xA8D58BE5"] = "SKIL",
            ["0xAE39399F"] = "",
            ["0xB074ACE6"] = "",
            ["0xB125533A"] = "UNKN",
            ["0xB1422971"] = "UNKN",
            ["0xB1CC1AF6"] = "_VID",
            ["0xB4DD716B"] = "_INV",
            ["0xB52F5055"] = "FBLN",
            ["0xCF84EC98"] = "",
            ["0xCF9A4ACE"] = "MDLR",
            ["0xD063545B"] = "LDES",
            ["0xD3044521"] = "RSLT",
            ["0xD382BF57"] = "FTPT",
            ["0xD4D9FBE5"] = "PTRN",
            ["0xD84E7FC5"] = "ICON",
            ["0xD84E7FC6"] = "ICON",
            ["0xD84E7FC7"] = "ICON",
            ["0xD9BD0909"] = "",
            ["0xDC37E964"] = "",
            ["0xDD3223A7"] = "BUFF",
            ["0xDEA2951C"] = "PETB",
            ["0xEA5118B0"] = "_SWB",
            ["0xF0633989"] = "",
            ["0xF0FF5598"] = "",
            ["0xF12E5E12"] = "UNKN",
            ["0xF1EDBD86"] = "CRMT",
            ["0xF3A38370"] = "NGMP",
            ["0xF609FD60"] = "",
            ["0xFCEAB65B"] = "THUM",
        };


        // From "s3pi Wrappers\ImageResource\ImageResources.txt"
        public static List<string> ImageTypes = new List<string>()
        {
            "0x0580A2B4", //  THUM   .png
            "0x0580A2B5", //  THUM   .png
            "0x0580A2B6", //  THUM   .png
            "0x0580A2CD", //  SNAP   .png
            "0x0580A2CE", //  SNAP   .png
            "0x0580A2CF", //  SNAP   .png
            "0x0589DC44", //  THUM   .png
            "0x0589DC45", //  THUM   .png
            "0x0589DC46", //  THUM   .png
            "0x0589DC47", //  THUM   .png
            "0x05B17698", //  THUM   .png
            "0x05B17699", //  THUM   .png
            "0x05B1769A", //  THUM   .png
            "0x05B1B524", //  THUM   .png
            "0x05B1B525", //  THUM   .png
            "0x05B1B526", //  THUM   .png
            "0x0668F635", //  TWNI   .png
            "0x2653E3C8", //  THUM   .png
            "0x2653E3C9", //  THUM   .png
            "0x2653E3CA", //  THUM   .png
            "0x2D4284F0", //  THUM   .png
            "0x2D4284F1", //  THUM   .png
            "0x2D4284F2", //  THUM   .png
            "0x2E75C764", //  ICON   .png
            "0x2E75C765", //  ICON   .png
            "0x2E75C766", //  ICON   .png
            "0x2E75C767", //  ICON   .png
            "0x2F7D0002", //  IMAG   .jpg
            "0x2F7D0004", //  IMAG   .png
            "0x5DE9DBA0", //  THUM   .png
            "0x5DE9DBA1", //  THUM   .png
            "0x5DE9DBA2", //  THUM   .png
            "0x626F60CC", //  THUM   .png
            "0x626F60CD", //  THUM   .png
            "0x626F60CE", //  THUM   .png
            "0x6B6D837D", //  SNAP   .png
            "0x6B6D837E", //  SNAP   .png
            "0x6B6D837F", //  SNAP   .png
            "0xAD366F95", //  THUM   .png
            "0xAD366F96", //  THUM   .png
            "0xD84E7FC5", //  ICON   .png
            "0xD84E7FC6", //  ICON   .png
            "0xD84E7FC7", //  ICON   .png
            "0xFCEAB65B"  //  THUM   .png
        };

        public static List<string> DDSTypes = new List<string>()
        {
            "0x8FFB80F6",
            "0x00B2D882"
        };

        // This method is here because of the goddamn antivirus giving false positive if placed in s3mo.dll
        public static bool CheckValidFolderName(string name)
        {
            char[] illegalChars = new char[] { '<', '>', ':', '"', '/', '\\', '|', '?', '*' }; // https://stackoverflow.com/questions/1976007/what-characters-are-forbidden-in-windows-and-linux-directory-names
            return !(string.IsNullOrEmpty(name) || name.IndexOfAny(illegalChars) > -1 || !name.Equals(name.Trim()));
        }

        public static string UInt32ToHexString(uint num)
        {
            string s = Convert.ToString(num, 16).ToUpper();
            s = s.PadLeft(8, '0');
            return "0x" + s;
        }

        public static string UInt64ToHexString(ulong num)
        {
            uint num1 = (uint)((num & 0xffffffff00000000) >> 32);
            uint num2 = (uint)(num & 0x00000000ffffffff);

            string s1 = Convert.ToString(num1, 16).ToUpper();
            s1 = s1.PadLeft(8, '0');

            string s2 = Convert.ToString(num2, 16).ToUpper();
            s2 = s2.PadLeft(8, '0');

            return "0x" + s1 + s2;
        }
    }

}
