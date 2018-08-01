// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble3
    {
        [Test]
        public void double3_constructor()
        {
            double3 a = new double3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void double3_scalar_constructor()
        {
            double3 a = new double3(17.0);
            Assert.AreEqual(a.x, 17.0);
            Assert.AreEqual(a.y, 17.0);
            Assert.AreEqual(a.z, 17.0);
        }

        [Test]
        public void double3_static_constructor()
        {
            double3 a = double3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void double3_static_scalar_constructor()
        {
            double3 a = double3(17.0);
            Assert.AreEqual(a.x, 17.0);
            Assert.AreEqual(a.y, 17.0);
            Assert.AreEqual(a.z, 17.0);
        }

        [Test]
        public void double3_operator_equal_wide_wide()
        {
            double3 a0 = double3(492.15758275061728, -495.20632027797694, 227.45765195947968);
            double3 b0 = double3(192.56880888369346, -235.61102472786376, -254.04311740307281);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double3 a1 = double3(-147.37405950733182, -222.68201909897942, 64.093720704360749);
            double3 b1 = double3(-412.62472052715009, 471.90480945627428, -6.4727852374654162);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double3 a2 = double3(-23.890404473939157, -16.8197190839889, 163.23210890741655);
            double3 b2 = double3(-339.10237447316865, 488.1875700839737, -379.5965842584132);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double3 a3 = double3(-165.27101071424363, 470.87767980568003, -423.94255967808078);
            double3 b3 = double3(-308.41700258311675, -82.333374300195544, -102.92108087563935);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double3_operator_equal_wide_scalar()
        {
            double3 a0 = double3(-303.2300766926399, 451.52631327674089, -253.65587413201848);
            double b0 = (123.5445759871717);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double3 a1 = double3(-105.20363502632995, -426.19248338518315, 159.87609656149334);
            double b1 = (-500.6910920090466);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double3 a2 = double3(-59.558379439431405, -182.0497396840014, 406.51375861024189);
            double b2 = (-57.477391031327386);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double3 a3 = double3(370.88599866017978, 455.40001198993991, -11.338988547836891);
            double b3 = (-172.03530629539642);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double3_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double3 b0 = double3(19.952187785856495, -185.79199346610903, 407.8136052600172);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (-87.2766969610363);
            double3 b1 = double3(-206.27469382354741, 160.503138855334, -274.77081478516141);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-2.6315281403397535);
            double3 b2 = double3(448.35453602688131, -410.03524251004461, 247.32901465489022);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (355.53915350303942);
            double3 b3 = double3(-298.06671180299793, 414.10151429385951, -481.30262707234482);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double3_operator_not_equal_wide_wide()
        {
            double3 a0 = double3(430.8425316432689, 104.69001798736394, 225.80243478799355);
            double3 b0 = double3(210.02470622305975, -55.203330304102678, -269.92533672504373);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double3 a1 = double3(-310.57017841496048, -418.61945815506363, 304.12820281839379);
            double3 b1 = double3(-234.54673372700194, 25.917412054686565, -63.726991444699024);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double3 a2 = double3(-509.32682561749908, -160.53807719076895, -203.30197606016975);
            double3 b2 = double3(-484.55371092471933, -425.333599050219, -53.274394775402925);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double3 a3 = double3(-505.76325368590807, 162.17220623892365, 1.1561973100324394);
            double3 b3 = double3(328.1944192984115, 15.963139303011417, 461.71412417931208);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double3_operator_not_equal_wide_scalar()
        {
            double3 a0 = double3(-16.914588697680529, 168.83411486858233, -462.71352145760949);
            double b0 = (-145.37277109239847);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double3 a1 = double3(130.30776959765137, -440.26328178879959, -197.12796053529155);
            double b1 = (214.50161443208424);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double3 a2 = double3(-169.09985860115842, -281.02101362916687, -270.26885593601912);
            double b2 = (-386.61117595555783);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double3 a3 = double3(-403.96372313236992, 299.65422763473089, -71.750904831919286);
            double b3 = (-269.80570877241234);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double3_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double3 b0 = double3(-57.196896341255353, -382.4325279586169, 97.820359990848374);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (-161.46364529499022);
            double3 b1 = double3(-458.39563367254829, -499.61786364932448, 327.92217818271467);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (367.57121699283425);
            double3 b2 = double3(59.7863667289663, -209.58068118318016, -62.580453186566217);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (-479.97497604786184);
            double3 b3 = double3(-49.494519495169868, -114.68521338081229, 109.93924599044919);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double3_operator_less_wide_wide()
        {
            double3 a0 = double3(196.84256825076534, 336.40979997087732, 251.96372115424072);
            double3 b0 = double3(-465.34502313348696, -256.15239751346053, -314.814018634527);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            double3 a1 = double3(257.65591466503963, 430.04588647840819, -62.419644146421774);
            double3 b1 = double3(364.56673662949663, 100.21050290959443, 182.56098636545289);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double3 a2 = double3(8.8392293494376872, -333.81671563434259, 164.67880662003472);
            double3 b2 = double3(3.116978885194726, -259.43047893207074, -437.33490749696966);
            bool3 r2 = bool3(false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double3 a3 = double3(-350.94487516532877, 3.84143662631584, 125.40972024081725);
            double3 b3 = double3(-456.0437321402336, -394.2559718537405, 401.91369099259077);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void double3_operator_less_wide_scalar()
        {
            double3 a0 = double3(-132.05731708000292, -192.46500477216438, -66.834607870706634);
            double b0 = (-156.01021845452965);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            double3 a1 = double3(-379.01750081545561, 20.927834282129879, -158.24074537970159);
            double b1 = (-360.28242199508588);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double3 a2 = double3(437.34587522845061, 225.29148517609178, 307.48418607725023);
            double b2 = (-20.452607402788772);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double3 a3 = double3(274.01523292903562, 398.52368301829495, 105.0301654827922);
            double b3 = (373.54965584983563);
            bool3 r3 = bool3(true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void double3_operator_less_scalar_wide()
        {
            double a0 = (-423.117411095238);
            double3 b0 = double3(385.09483617595151, -123.93348532725753, 86.376572887588509);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double a1 = (133.44217378154497);
            double3 b1 = double3(161.45794947513286, 229.75426660746064, 222.57159934871436);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double a2 = (315.53116360098647);
            double3 b2 = double3(-447.20351883731945, 271.83385790131695, -393.60531324595462);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            double a3 = (317.48689737798964);
            double3 b3 = double3(-164.6051085761772, -282.87605370342544, 296.97953071118309);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void double3_operator_greater_wide_wide()
        {
            double3 a0 = double3(483.50140141113729, 310.81563415695712, 106.9661896726891);
            double3 b0 = double3(-471.39802454011425, -371.98528617060992, 36.900723236101044);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double3 a1 = double3(295.73526038589671, 116.95757179938141, -478.29977653841479);
            double3 b1 = double3(-316.76360407320954, 19.683055648432628, 207.3091381561519);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double3 a2 = double3(-14.897393471979228, -33.817441717636484, -24.740548383789417);
            double3 b2 = double3(362.79748861994483, 324.95341816775192, 340.94807140014507);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double3 a3 = double3(319.78262701620474, -120.15856581561201, -289.00857962714906);
            double3 b3 = double3(25.986035120666998, -114.2111352021858, 240.80346428640348);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void double3_operator_greater_wide_scalar()
        {
            double3 a0 = double3(64.317918092160426, -397.70346445483318, 431.87690826499693);
            double b0 = (305.85991992888034);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double3 a1 = double3(85.702980796668157, 197.49155602114809, 286.1994608781298);
            double b1 = (246.26305233978803);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double3 a2 = double3(280.81334818564972, 171.56538661362856, -241.80727326209063);
            double b2 = (-405.78459210218148);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            double3 a3 = double3(333.57817498481745, -413.70138116073861, -356.5923551789449);
            double b3 = (370.27919524269146);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void double3_operator_greater_scalar_wide()
        {
            double a0 = (-282.67049635698572);
            double3 b0 = double3(358.09997360692353, -72.5964134077525, -232.16380106292843);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double a1 = (-60.706723956720282);
            double3 b1 = double3(75.156642710397364, 150.88350040786133, 339.53917924479538);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double a2 = (-498.19602965665797);
            double3 b2 = double3(459.74610326241054, -227.96872316485678, 335.86213485145106);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double a3 = (76.178844248959308);
            double3 b3 = double3(296.85993899817572, 177.49000390688423, -281.20120657663847);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void double3_operator_less_equal_wide_wide()
        {
            double3 a0 = double3(-438.52313753521219, 210.48942837980087, 4.8773329280677444);
            double3 b0 = double3(-474.8141498392514, 304.3710555063426, 234.8241737982371);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double3 a1 = double3(-137.29793817237857, 156.09410174009111, -363.92412035722475);
            double3 b1 = double3(-390.48543209139513, -297.17535295019638, -326.29239121372461);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double3 a2 = double3(-97.948485181642923, 437.29539009430232, 458.53029153241323);
            double3 b2 = double3(107.2538764976216, -413.13107342884462, 67.094432623635271);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            double3 a3 = double3(-294.06474675520542, 23.622613679441884, -34.284056441059363);
            double3 b3 = double3(470.07522724106684, -84.499104777583455, 392.78422683886447);
            bool3 r3 = bool3(true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void double3_operator_less_equal_wide_scalar()
        {
            double3 a0 = double3(193.4958237118534, 168.91555197952107, -313.9930695565385);
            double b0 = (443.85054299042122);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double3 a1 = double3(81.826965131716292, -0.35819602029312136, 241.36115776810846);
            double b1 = (18.503590830836288);
            bool3 r1 = bool3(false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double3 a2 = double3(-463.81641242644582, -268.89945591096739, 398.9919504593089);
            double b2 = (-1.3577692515020203);
            bool3 r2 = bool3(true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            double3 a3 = double3(-471.253072242836, 82.258299150624453, 11.246050124636895);
            double b3 = (-264.93778264938749);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void double3_operator_less_equal_scalar_wide()
        {
            double a0 = (393.60626644343427);
            double3 b0 = double3(-75.688363825757222, -44.2638714519627, 125.8649156679702);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            double a1 = (191.96488174794467);
            double3 b1 = double3(13.543054825413492, -197.0519259893577, -423.945100743298);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double a2 = (-330.04861680141119);
            double3 b2 = double3(420.16553779140372, 105.54730777887039, 174.82126363311954);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double a3 = (296.71757831085358);
            double3 b3 = double3(-469.70041845259277, 123.26718979853536, 112.9969695140594);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void double3_operator_greater_equal_wide_wide()
        {
            double3 a0 = double3(-507.92858409692, 504.49748181947393, -385.43449205226938);
            double3 b0 = double3(-81.346509732933043, 297.66615047010885, 171.06540616371922);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            double3 a1 = double3(-262.32340944107784, -37.550928848586466, -111.59527759980193);
            double3 b1 = double3(-431.03805538222105, -6.859075311040101, 319.72570362674332);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double3 a2 = double3(-463.70202157632542, 387.44885772627265, 456.96878573716094);
            double3 b2 = double3(254.079170106947, 396.5724000393285, 178.83927615864172);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double3 a3 = double3(-211.01015506079892, 182.41135391146474, -53.596053863687473);
            double3 b3 = double3(-447.06336304501787, 288.49268569075161, 474.88929460704765);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void double3_operator_greater_equal_wide_scalar()
        {
            double3 a0 = double3(465.15218732559686, -424.8860745024337, -209.22109685150025);
            double b0 = (-5.5998842742293391);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            double3 a1 = double3(58.779852656079356, 140.12558252183976, 16.353385694489475);
            double b1 = (-302.26910533675414);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double3 a2 = double3(-344.55997316192838, -315.70155086913218, 441.0115565923096);
            double b2 = (393.27804846003562);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double3 a3 = double3(-509.78156757251435, 494.82028865014217, -164.97393830352183);
            double b3 = (-36.994287269652943);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void double3_operator_greater_equal_scalar_wide()
        {
            double a0 = (374.82703393270594);
            double3 b0 = double3(-1.609757185731894, 338.61524049314448, -116.18140392945213);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double a1 = (-332.15732375353451);
            double3 b1 = double3(-355.9793509710484, -468.90144107719021, 38.579884785497484);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double a2 = (-332.34754697063357);
            double3 b2 = double3(2.8901150240051265, 467.77776477661814, 121.40638762405445);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double a3 = (-305.02337303060267);
            double3 b3 = double3(-58.428812292604164, -226.51955209789776, -47.020994446715804);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void double3_operator_add_wide_wide()
        {
            double3 a0 = double3(506.12905263627374, -501.77980803967444, 420.08479638587903);
            double3 b0 = double3(-28.757987751047096, -337.135153689019, -340.676816860529);
            double3 r0 = double3(477.37106488522664, -838.91496172869347, 79.407979525350015);
            TestUtils.AreEqual(a0 + b0, r0);

            double3 a1 = double3(-186.03206476291274, -9.3123953385801883, 328.51179686585056);
            double3 b1 = double3(152.31202633320913, 423.66745420157326, 90.374096674087468);
            double3 r1 = double3(-33.720038429703607, 414.35505886299308, 418.885893539938);
            TestUtils.AreEqual(a1 + b1, r1);

            double3 a2 = double3(424.34407659263536, 87.791079800478656, 462.41368148402012);
            double3 b2 = double3(376.18866246574964, 1.7671887882831925, -120.18586045139745);
            double3 r2 = double3(800.532739058385, 89.558268588761848, 342.22782103262267);
            TestUtils.AreEqual(a2 + b2, r2);

            double3 a3 = double3(-46.178705952213477, 401.17006296718966, -454.12414643453627);
            double3 b3 = double3(-279.62936628965167, -344.66710273580026, 242.8391956029642);
            double3 r3 = double3(-325.80807224186515, 56.502960231389409, -211.28495083157208);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void double3_operator_add_wide_scalar()
        {
            double3 a0 = double3(-194.51420387742769, 338.54838696985894, 246.97140252169754);
            double b0 = (124.121678171736);
            double3 r0 = double3(-70.3925257056917, 462.67006514159493, 371.09308069343354);
            TestUtils.AreEqual(a0 + b0, r0);

            double3 a1 = double3(100.51093797595752, -478.11131094308166, 30.916145577522116);
            double b1 = (-45.724677822424439);
            double3 r1 = double3(54.786260153533078, -523.835988765506, -14.808532244902324);
            TestUtils.AreEqual(a1 + b1, r1);

            double3 a2 = double3(60.37435224483454, 82.50134495762245, 6.7993848355483806);
            double b2 = (-242.1187475855084);
            double3 r2 = double3(-181.74439534067386, -159.61740262788595, -235.31936274996002);
            TestUtils.AreEqual(a2 + b2, r2);

            double3 a3 = double3(-484.69981287638649, -213.52673087526426, -267.78430688929944);
            double b3 = (-188.26501068298938);
            double3 r3 = double3(-672.96482355937587, -401.79174155825365, -456.04931757228883);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void double3_operator_add_scalar_wide()
        {
            double a0 = (-340.35468284243473);
            double3 b0 = double3(511.36225652665007, -146.21663791789518, -106.21042661844308);
            double3 r0 = double3(171.00757368421535, -486.57132076032991, -446.56510946087781);
            TestUtils.AreEqual(a0 + b0, r0);

            double a1 = (-363.45024960276214);
            double3 b1 = double3(199.08958325120136, -27.108407271610758, 419.84900041103788);
            double3 r1 = double3(-164.36066635156078, -390.5586568743729, 56.398750808275736);
            TestUtils.AreEqual(a1 + b1, r1);

            double a2 = (284.95503748811552);
            double3 b2 = double3(-164.92418129971446, -249.19032561461921, 150.92817718858282);
            double3 r2 = double3(120.03085618840106, 35.76471187349631, 435.88321467669834);
            TestUtils.AreEqual(a2 + b2, r2);

            double a3 = (298.17509784278229);
            double3 b3 = double3(-457.15341803857751, 424.71807094324288, -301.85750283946163);
            double3 r3 = double3(-158.97832019579522, 722.89316878602517, -3.6824049966793382);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void double3_operator_sub_wide_wide()
        {
            double3 a0 = double3(160.4922617229131, 11.223957305412682, 359.20010607279846);
            double3 b0 = double3(115.46876078260539, -130.98230630298252, 241.54083716196044);
            double3 r0 = double3(45.023500940307713, 142.2062636083952, 117.65926891083802);
            TestUtils.AreEqual(a0 - b0, r0);

            double3 a1 = double3(-498.22830485656311, -355.25362913462038, -94.534852787170053);
            double3 b1 = double3(9.9870860623135513, 419.89512582304656, 59.124466208333388);
            double3 r1 = double3(-508.21539091887666, -775.14875495766694, -153.65931899550344);
            TestUtils.AreEqual(a1 - b1, r1);

            double3 a2 = double3(-410.46404786150163, -401.38464398001537, 317.70681944382693);
            double3 b2 = double3(-402.38163847587145, -75.370143687059226, 320.97960796997859);
            double3 r2 = double3(-8.0824093856301715, -326.01450029295614, -3.2727885261516576);
            TestUtils.AreEqual(a2 - b2, r2);

            double3 a3 = double3(447.0604133303558, -489.07414482956477, -230.00838218909149);
            double3 b3 = double3(-73.908757482612884, -31.444742455819949, -389.25194734579509);
            double3 r3 = double3(520.96917081296874, -457.62940237374482, 159.2435651567036);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void double3_operator_sub_wide_scalar()
        {
            double3 a0 = double3(207.38960108877609, 248.45773684627272, -384.82393211164697);
            double b0 = (-36.112476604111691);
            double3 r0 = double3(243.50207769288778, 284.57021345038441, -348.71145550753528);
            TestUtils.AreEqual(a0 - b0, r0);

            double3 a1 = double3(-205.34476122881506, 191.64204820973896, 18.856238135535364);
            double b1 = (-374.81156152058929);
            double3 r1 = double3(169.46680029177423, 566.45360973032825, 393.66779965612466);
            TestUtils.AreEqual(a1 - b1, r1);

            double3 a2 = double3(-44.96160151667965, 16.338193185784917, -366.86545269883493);
            double b2 = (480.85798738936796);
            double3 r2 = double3(-525.81958890604756, -464.51979420358305, -847.72344008820289);
            TestUtils.AreEqual(a2 - b2, r2);

            double3 a3 = double3(-35.523088233323335, 439.07729336203886, 490.2222661870635);
            double b3 = (349.39776460705218);
            double3 r3 = double3(-384.92085284037552, 89.679528754986677, 140.82450158001132);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void double3_operator_sub_scalar_wide()
        {
            double a0 = (-86.008225719448262);
            double3 b0 = double3(466.42511413359318, 298.48694219183506, -300.95010652251085);
            double3 r0 = double3(-552.43333985304139, -384.49516791128332, 214.94188080306259);
            TestUtils.AreEqual(a0 - b0, r0);

            double a1 = (315.38003006362362);
            double3 b1 = double3(-381.09218543632522, -125.00837546447684, 58.466194418476107);
            double3 r1 = double3(696.47221549994879, 440.38840552810046, 256.91383564514751);
            TestUtils.AreEqual(a1 - b1, r1);

            double a2 = (214.74609361158036);
            double3 b2 = double3(-257.54942739082009, 480.22459505508868, -443.35507723472784);
            double3 r2 = double3(472.29552100240045, -265.47850144350832, 658.10117084630815);
            TestUtils.AreEqual(a2 - b2, r2);

            double a3 = (260.79503858312728);
            double3 b3 = double3(29.681931747906788, 139.85773164586055, -247.78996216868512);
            double3 r3 = double3(231.11310683522049, 120.93730693726673, 508.5850007518124);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void double3_operator_mul_wide_wide()
        {
            double3 a0 = double3(-482.71381710596097, -407.29348559272171, 137.70058995937029);
            double3 b0 = double3(-236.36788355389979, 260.72759139757954, -416.38629718142852);
            double3 r0 = double3(114098.04331156027, -106192.64949051509, -57336.638772880389);
            TestUtils.AreEqual(a0 * b0, r0);

            double3 a1 = double3(208.54113278563182, 194.296573967811, -484.24241684574747);
            double3 b1 = double3(-364.49561541364324, -253.14750897751537, -369.20287220981106);
            double3 r1 = double3(-76012.328533757158, -49185.69370281692, 178783.69114527057);
            TestUtils.AreEqual(a1 * b1, r1);

            double3 a2 = double3(183.98730739578014, -241.33547770294149, 45.868758938214114);
            double3 b2 = double3(193.54791531038836, 169.08491976982214, 201.96966442930034);
            double3 r2 = double3(35610.359790024842, -40806.189885013562, 9264.0978505395742);
            TestUtils.AreEqual(a2 * b2, r2);

            double3 a3 = double3(363.32610266438041, -328.11893692990714, -471.02307413100408);
            double3 b3 = double3(249.45608317547294, -308.19319810913555, -385.57964843585137);
            double3 r3 = double3(90633.9064860661, 101124.02453259782, 181616.91132860651);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void double3_operator_mul_wide_scalar()
        {
            double3 a0 = double3(-96.318821236639678, -277.14229239017811, -239.93690191951436);
            double b0 = (-301.20720424373042);
            double3 r0 = double3(29011.922860739887, 83477.255068544036, 72270.723422079071);
            TestUtils.AreEqual(a0 * b0, r0);

            double3 a1 = double3(509.53140544776409, 215.73149667295229, -455.50827500573746);
            double b1 = (255.85810172551226);
            double3 r1 = double3(130367.73816739726, 55196.651221145235, -116545.48256323059);
            TestUtils.AreEqual(a1 * b1, r1);

            double3 a2 = double3(-389.24327367788334, 53.796284939067618, 243.75734459783757);
            double b2 = (-338.29248658674419);
            double3 r2 = double3(131678.07493965575, -18198.879001166202, -82461.278227784351);
            TestUtils.AreEqual(a2 * b2, r2);

            double3 a3 = double3(135.35469991311186, -383.93960946795517, -31.425238862366086);
            double b3 = (-207.35010275959508);
            double3 r3 = double3(-28065.810935977897, 79609.9174766593, 6516.0265073564287);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void double3_operator_mul_scalar_wide()
        {
            double a0 = (37.432166355397612);
            double3 b0 = double3(96.747546479454058, 492.18539427788244, -274.05458534604617);
            double3 r0 = double3(3621.4702542954869, 18423.565556306661, -10258.456829132712);
            TestUtils.AreEqual(a0 * b0, r0);

            double a1 = (-452.87096926796761);
            double3 b1 = double3(420.85330434369541, 102.18292694081686, -114.94887762654054);
            double3 r1 = double3(-190592.24385775632, -46275.681166325652, 52057.009626996405);
            TestUtils.AreEqual(a1 * b1, r1);

            double a2 = (-351.12003843445336);
            double3 b2 = double3(-464.66496799172131, 444.08484646495663, 447.10525605040846);
            double3 r2 = double3(163153.18142039722, -155927.08835893389, -156987.61468866552);
            TestUtils.AreEqual(a2 * b2, r2);

            double a3 = (130.82935124767448);
            double3 b3 = double3(-321.41334191030512, 445.30131861441828, 478.24357317306271);
            double3 r3 = double3(-42050.2990044722, 58258.482624058335, 62568.296416601537);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void double3_operator_div_wide_wide()
        {
            double3 a0 = double3(-353.13144390337703, -102.79985456485292, 51.319128298814917);
            double3 b0 = double3(-178.73954805114283, -302.09628381491467, -199.40583739029518);
            double3 r0 = double3(1.97567604793504, 0.34028837848212429, -0.25736021056579439);
            TestUtils.AreEqual(a0 / b0, r0);

            double3 a1 = double3(-191.87167868012176, 8.0418245829836223, -128.73764210973758);
            double3 b1 = double3(278.85077561012042, 502.33758782890516, -361.48483078623417);
            double3 r1 = double3(-0.68808013268139567, 0.016008805189634039, 0.35613566917796119);
            TestUtils.AreEqual(a1 / b1, r1);

            double3 a2 = double3(-136.05959779399427, -370.4710053738537, -237.69456326109105);
            double3 b2 = double3(353.121059820578, -38.894930142394685, -75.764737402910725);
            double3 r2 = double3(-0.3853058151307277, 9.5249176182488586, 3.1372716570909582);
            TestUtils.AreEqual(a2 / b2, r2);

            double3 a3 = double3(-432.54687496300176, 200.26549181727012, 361.44157068871039);
            double3 b3 = double3(-195.21784719974636, -405.03399224068687, -394.2300085473014);
            double3 r3 = double3(2.2157137842034547, -0.49444119667433889, -0.9168291678773689);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void double3_operator_div_wide_scalar()
        {
            double3 a0 = double3(171.34242184988341, 0.10338377957384637, 57.888263967767443);
            double b0 = (171.79682191265601);
            double3 r0 = double3(0.99735501473360411, 0.00060177934855167557, 0.33695771157628673);
            TestUtils.AreEqual(a0 / b0, r0);

            double3 a1 = double3(-256.13074529177078, -290.38690461329509, -127.44869118903239);
            double b1 = (95.6696842162263);
            double3 r1 = double3(-2.6772404172766056, -3.0353074434423948, -1.332174264325795);
            TestUtils.AreEqual(a1 / b1, r1);

            double3 a2 = double3(-79.7448890580539, -499.84355687529012, 58.686315802245531);
            double b2 = (146.46688110496234);
            double3 r2 = double3(-0.54445679771733813, -3.4126729066968249, 0.400679767053886);
            TestUtils.AreEqual(a2 / b2, r2);

            double3 a3 = double3(-453.20579859856787, 481.73814247629514, 464.47907159499778);
            double b3 = (-205.03382143985192);
            double3 r3 = double3(2.2103953163235506, -2.3495545227284187, -2.2653778207575179);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void double3_operator_div_scalar_wide()
        {
            double a0 = (-264.44250095283729);
            double3 b0 = double3(105.58908157497137, -142.34910137129441, -288.94890679463231);
            double3 r0 = double3(-2.5044492954044237, 1.85770404172122, 0.915187753732487);
            TestUtils.AreEqual(a0 / b0, r0);

            double a1 = (39.644133824689334);
            double3 b1 = double3(-363.99138396046658, -149.71822006521666, -395.72912306139671);
            double3 r1 = double3(-0.10891503362891446, -0.26479164531491561, -0.10017997542864343);
            TestUtils.AreEqual(a1 / b1, r1);

            double a2 = (258.71868693955184);
            double3 b2 = double3(-9.6662514254759344, 117.72553282497711, -331.38655797177296);
            double3 r2 = double3(-26.765151820661792, 2.1976429473815986, -0.78071569505721816);
            TestUtils.AreEqual(a2 / b2, r2);

            double a3 = (-509.98602676297821);
            double3 b3 = double3(427.8964666928614, 467.61712882836218, -407.12461943511136);
            double3 r3 = double3(-1.1918444447662142, -1.0906059579998138, 1.2526533705345255);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void double3_operator_mod_wide_wide()
        {
            double3 a0 = double3(-388.81249422059045, 181.68118842955732, -167.07872470052854);
            double3 b0 = double3(436.94417187056695, 58.940049437312382, -201.11623368091705);
            double3 r0 = double3(-388.81249422059045, 4.8610401176201776, -167.07872470052854);
            TestUtils.AreEqual(a0 % b0, r0);

            double3 a1 = double3(432.82015319951813, -258.43895995730486, -170.11079629236406);
            double3 b1 = double3(279.2893537391393, -397.07975954426445, 377.89994758083481);
            double3 r1 = double3(153.53079946037883, -258.43895995730486, -170.11079629236406);
            TestUtils.AreEqual(a1 % b1, r1);

            double3 a2 = double3(283.318293464984, 122.71651297561664, 335.27101413126616);
            double3 b2 = double3(174.69386657266591, -228.17652736798698, -317.06019106370405);
            double3 r2 = double3(108.62442689231807, 122.71651297561664, 18.210823067562103);
            TestUtils.AreEqual(a2 % b2, r2);

            double3 a3 = double3(-503.60851668920765, 191.02251848532933, 289.74269379756538);
            double3 b3 = double3(-417.48011107811709, -249.9759434433542, -397.57157177364991);
            double3 r3 = double3(-86.128405611090557, 191.02251848532933, 289.74269379756538);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void double3_operator_mod_wide_scalar()
        {
            double3 a0 = double3(-244.49962889612635, -211.81931958525411, -145.92677576184588);
            double b0 = (39.634963769295723);
            double3 r0 = double3(-6.6898462803520147, -13.644500738775491, -27.021884453958705);
            TestUtils.AreEqual(a0 % b0, r0);

            double3 a1 = double3(-304.91822090042672, -133.90778428591221, 281.30965412841624);
            double b1 = (155.47946436492703);
            double3 r1 = double3(-149.43875653549969, -133.90778428591221, 125.83018976348922);
            TestUtils.AreEqual(a1 % b1, r1);

            double3 a2 = double3(-226.53575311719243, 101.70649032560482, 319.47152033423606);
            double b2 = (335.16613046041039);
            double3 r2 = double3(-226.53575311719243, 101.70649032560482, 319.47152033423606);
            TestUtils.AreEqual(a2 % b2, r2);

            double3 a3 = double3(-285.40231646476423, 259.37800061860025, -330.87193957477433);
            double b3 = (-355.84685985923136);
            double3 r3 = double3(-285.40231646476423, 259.37800061860025, -330.87193957477433);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void double3_operator_mod_scalar_wide()
        {
            double a0 = (-66.945025236785909);
            double3 b0 = double3(-249.77609479137516, -396.07375664081133, 386.49204582091977);
            double3 r0 = double3(-66.945025236785909, -66.945025236785909, -66.945025236785909);
            TestUtils.AreEqual(a0 % b0, r0);

            double a1 = (168.93948109864232);
            double3 b1 = double3(-199.4182442163202, 261.7517141130528, 16.127438791155555);
            double3 r1 = double3(168.93948109864232, 168.93948109864232, 7.665093187086768);
            TestUtils.AreEqual(a1 % b1, r1);

            double a2 = (257.66814744550186);
            double3 b2 = double3(-75.788451945310669, 170.95630439136005, -242.85828005655588);
            double3 r2 = double3(30.302791609569852, 86.711843054141809, 14.809867388945975);
            TestUtils.AreEqual(a2 % b2, r2);

            double a3 = (425.94531913564788);
            double3 b3 = double3(303.27240409668184, 3.033060790520608, -505.74352788633831);
            double3 r3 = double3(122.67291503896604, 1.316808462762765, 425.94531913564788);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void double3_operator_plus()
        {
            double3 a0 = double3(-418.82956357432045, -405.79894823851015, -34.041791216489742);
            double3 r0 = double3(-418.82956357432045, -405.79894823851015, -34.041791216489742);
            TestUtils.AreEqual(+a0, r0);

            double3 a1 = double3(236.99924456188421, 210.8614223985287, 293.74197902052754);
            double3 r1 = double3(236.99924456188421, 210.8614223985287, 293.74197902052754);
            TestUtils.AreEqual(+a1, r1);

            double3 a2 = double3(-373.015422279488, 4.9544198536101476, -418.64524932328857);
            double3 r2 = double3(-373.015422279488, 4.9544198536101476, -418.64524932328857);
            TestUtils.AreEqual(+a2, r2);

            double3 a3 = double3(504.47483062393724, 439.55937572920664, -478.74939916969714);
            double3 r3 = double3(504.47483062393724, 439.55937572920664, -478.74939916969714);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void double3_operator_neg()
        {
            double3 a0 = double3(148.46174890755754, -467.12267873581624, 132.04719954917539);
            double3 r0 = double3(-148.46174890755754, 467.12267873581624, -132.04719954917539);
            TestUtils.AreEqual(-a0, r0);

            double3 a1 = double3(183.52262290917463, -407.99109024926605, -54.958759571872065);
            double3 r1 = double3(-183.52262290917463, 407.99109024926605, 54.958759571872065);
            TestUtils.AreEqual(-a1, r1);

            double3 a2 = double3(-382.98981803608581, -383.01406377508027, 407.70980305583669);
            double3 r2 = double3(382.98981803608581, 383.01406377508027, -407.70980305583669);
            TestUtils.AreEqual(-a2, r2);

            double3 a3 = double3(168.73550351370852, 171.90249474900895, -280.55831564616335);
            double3 r3 = double3(-168.73550351370852, -171.90249474900895, 280.55831564616335);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void double3_operator_prefix_inc()
        {
            double3 a0 = double3(-139.84208137348389, -56.743654039103376, -381.955324589254);
            double3 r0 = double3(-138.84208137348389, -55.743654039103376, -380.955324589254);
            TestUtils.AreEqual(++a0, r0);

            double3 a1 = double3(509.79634380237962, 210.31986556310199, -392.73151058365193);
            double3 r1 = double3(510.79634380237962, 211.31986556310199, -391.73151058365193);
            TestUtils.AreEqual(++a1, r1);

            double3 a2 = double3(-300.19410218866267, 401.614830919362, 130.90919429199266);
            double3 r2 = double3(-299.19410218866267, 402.614830919362, 131.90919429199266);
            TestUtils.AreEqual(++a2, r2);

            double3 a3 = double3(-450.23016402229212, 46.19202735190845, -41.497298975241051);
            double3 r3 = double3(-449.23016402229212, 47.19202735190845, -40.497298975241051);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void double3_operator_postfix_inc()
        {
            double3 a0 = double3(-396.6697396695007, 511.20749378167443, 249.11127030528678);
            double3 r0 = double3(-396.6697396695007, 511.20749378167443, 249.11127030528678);
            TestUtils.AreEqual(a0++, r0);

            double3 a1 = double3(-128.81731301584154, 278.00817764830219, -81.393423356764686);
            double3 r1 = double3(-128.81731301584154, 278.00817764830219, -81.393423356764686);
            TestUtils.AreEqual(a1++, r1);

            double3 a2 = double3(66.719732554033271, 147.94395048354932, -326.10758486674524);
            double3 r2 = double3(66.719732554033271, 147.94395048354932, -326.10758486674524);
            TestUtils.AreEqual(a2++, r2);

            double3 a3 = double3(41.033564825092185, 73.155582223625629, -60.132380275117384);
            double3 r3 = double3(41.033564825092185, 73.155582223625629, -60.132380275117384);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void double3_operator_prefix_dec()
        {
            double3 a0 = double3(123.12869626056806, 256.8437465433235, 156.33078844674435);
            double3 r0 = double3(122.12869626056806, 255.84374654332351, 155.33078844674435);
            TestUtils.AreEqual(--a0, r0);

            double3 a1 = double3(461.73742530389563, 392.01561731473339, 187.87412580655609);
            double3 r1 = double3(460.73742530389563, 391.01561731473339, 186.87412580655609);
            TestUtils.AreEqual(--a1, r1);

            double3 a2 = double3(-236.2252043393558, 469.8447313112415, 45.536655685648611);
            double3 r2 = double3(-237.2252043393558, 468.8447313112415, 44.536655685648611);
            TestUtils.AreEqual(--a2, r2);

            double3 a3 = double3(376.04684680329956, -22.028951416736902, 248.79012667797042);
            double3 r3 = double3(375.04684680329956, -23.028951416736902, 247.79012667797042);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void double3_operator_postfix_dec()
        {
            double3 a0 = double3(379.68831723727669, 302.69287814884115, -176.07134040448409);
            double3 r0 = double3(379.68831723727669, 302.69287814884115, -176.07134040448409);
            TestUtils.AreEqual(a0--, r0);

            double3 a1 = double3(-291.25267066212962, -402.92594666170231, -63.655158787805192);
            double3 r1 = double3(-291.25267066212962, -402.92594666170231, -63.655158787805192);
            TestUtils.AreEqual(a1--, r1);

            double3 a2 = double3(355.26110069605568, -100.76183824462902, 156.14034969924967);
            double3 r2 = double3(355.26110069605568, -100.76183824462902, 156.14034969924967);
            TestUtils.AreEqual(a2--, r2);

            double3 a3 = double3(479.94519613680677, -445.0269393609031, 407.42034907239508);
            double3 r3 = double3(479.94519613680677, -445.0269393609031, 407.42034907239508);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
