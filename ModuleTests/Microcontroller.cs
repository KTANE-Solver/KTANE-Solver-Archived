using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
namespace ModuleTests
{
    [TestClass]
    public class Microcontroller
    {
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");
        [TestMethod]
        public void CorrectPinLayout()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            #region STRK 6
            KTANE_Solver.Microcontroller module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "STRK", 6, 0, 0);
            module.SetUpModule();

            List<KTANE_Solver.Microcontroller.Pin> pinList = module.pinList;

            Assert.AreEqual("AIN", pinList[0].name);
            Assert.AreEqual("VCC", pinList[1].name);
            Assert.AreEqual("RST", pinList[2].name);
            Assert.AreEqual("DIN", pinList[3].name);
            Assert.AreEqual("PWM", pinList[4].name);
            Assert.AreEqual("GND", pinList[5].name);
            #endregion

            #region STRK 8
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "STRK", 8, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("AIN", pinList[0].name);
            Assert.AreEqual("PWM", pinList[1].name);
            Assert.AreEqual("GND", pinList[2].name);
            Assert.AreEqual("DIN", pinList[3].name);
            Assert.AreEqual("VCC", pinList[4].name);
            Assert.AreEqual("GND", pinList[5].name);
            Assert.AreEqual("RST", pinList[6].name);
            Assert.AreEqual("GND", pinList[7].name);
            #endregion

            #region STRK 10
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "STRK", 10, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("GND", pinList[0].name);
            Assert.AreEqual("GND", pinList[1].name);
            Assert.AreEqual("GND", pinList[2].name);
            Assert.AreEqual("GND", pinList[3].name);
            Assert.AreEqual("AIN", pinList[4].name);
            Assert.AreEqual("DIN", pinList[5].name);
            Assert.AreEqual("GND", pinList[6].name);
            Assert.AreEqual("VCC", pinList[7].name);
            Assert.AreEqual("RST", pinList[8].name);
            Assert.AreEqual("PWM", pinList[9].name);
            #endregion

            #region LEDS 6
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "LEDS", 6, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("PWM", pinList[0].name);
            Assert.AreEqual("RST", pinList[1].name);
            Assert.AreEqual("VCC", pinList[2].name);
            Assert.AreEqual("DIN", pinList[3].name);
            Assert.AreEqual("AIN", pinList[4].name);
            Assert.AreEqual("GND", pinList[5].name);
            #endregion

            #region LEDS 8
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "LEDS", 8, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("PWM", pinList[0].name);
            Assert.AreEqual("DIN", pinList[1].name);
            Assert.AreEqual("VCC", pinList[2].name);
            Assert.AreEqual("GND", pinList[3].name);
            Assert.AreEqual("AIN", pinList[4].name);
            Assert.AreEqual("GND", pinList[5].name);
            Assert.AreEqual("RST", pinList[6].name);
            Assert.AreEqual("GND", pinList[7].name);
            #endregion

            #region LEDS 10
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "LEDS", 10, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("PWM", pinList[0].name);
            Assert.AreEqual("AIN", pinList[1].name);
            Assert.AreEqual("DIN", pinList[2].name);
            Assert.AreEqual("GND", pinList[3].name);
            Assert.AreEqual("GND", pinList[4].name);
            Assert.AreEqual("GND", pinList[5].name);
            Assert.AreEqual("GND", pinList[6].name);
            Assert.AreEqual("RST", pinList[7].name);
            Assert.AreEqual("VCC", pinList[8].name);
            Assert.AreEqual("GND", pinList[9].name);
            #endregion

            #region CNTD 6
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "CNTD", 6, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("GND", pinList[0].name);
            Assert.AreEqual("AIN", pinList[1].name);
            Assert.AreEqual("PWM", pinList[2].name);
            Assert.AreEqual("VCC", pinList[3].name);
            Assert.AreEqual("DIN", pinList[4].name);
            Assert.AreEqual("RST", pinList[5].name);
            #endregion

            #region CNTD 8
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "CNTD", 8, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("PWM", pinList[0].name);
            Assert.AreEqual("GND", pinList[1].name);
            Assert.AreEqual("GND", pinList[2].name);
            Assert.AreEqual("VCC", pinList[3].name);
            Assert.AreEqual("AIN", pinList[4].name);
            Assert.AreEqual("GND", pinList[5].name);
            Assert.AreEqual("DIN", pinList[6].name);
            Assert.AreEqual("RST", pinList[7].name);
            #endregion

            #region CNTD 10
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "CNTD", 10, 0, 0);
            module.SetUpModule();

            pinList = module.pinList;

            Assert.AreEqual("PWM", pinList[0].name);
            Assert.AreEqual("DIN", pinList[1].name);
            Assert.AreEqual("AIN", pinList[2].name);
            Assert.AreEqual("GND", pinList[3].name);
            Assert.AreEqual("GND", pinList[4].name);
            Assert.AreEqual("VCC", pinList[5].name);
            Assert.AreEqual("GND", pinList[6].name);
            Assert.AreEqual("GND", pinList[7].name);
            Assert.AreEqual("RST", pinList[8].name);
            Assert.AreEqual("GND", pinList[9].name);
            #endregion

            streamWriter.Close();
        }

        [TestMethod]
        public void CorrectPinColor()
        {
            #region last digit of controller is 1
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));
            KTANE_Solver.Microcontroller module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "", "STRK", 6, 0, 1);
            
            module.Solve();
            List<KTANE_Solver.Microcontroller.Pin> pinList = module.pinList;

            Assert.AreEqual(pinList[0].color, KTANE_Solver.Microcontroller.Pin.Color.Magenta);
            Assert.AreEqual(pinList[1].color, KTANE_Solver.Microcontroller.Pin.Color.Yellow);
            Assert.AreEqual(pinList[2].color, KTANE_Solver.Microcontroller.Pin.Color.Red);
            Assert.AreEqual(pinList[3].color, KTANE_Solver.Microcontroller.Pin.Color.Green);
            Assert.AreEqual(pinList[4].color, KTANE_Solver.Microcontroller.Pin.Color.Blue);
            Assert.AreEqual(pinList[5].color, KTANE_Solver.Microcontroller.Pin.Color.White);


            #endregion

            #region rj port
            bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 1), new Port("serial", 1), new Port("setero", 0));
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "0", "STRK", 6, 0, 0);
            module.Solve();
            pinList = module.pinList;

            Assert.AreEqual(pinList[0].color, KTANE_Solver.Microcontroller.Pin.Color.Red);
            Assert.AreEqual(pinList[1].color, KTANE_Solver.Microcontroller.Pin.Color.Yellow);
            Assert.AreEqual(pinList[2].color, KTANE_Solver.Microcontroller.Pin.Color.Blue);
            Assert.AreEqual(pinList[3].color, KTANE_Solver.Microcontroller.Pin.Color.Magenta);
            Assert.AreEqual(pinList[4].color, KTANE_Solver.Microcontroller.Pin.Color.Green);
            Assert.AreEqual(pinList[5].color, KTANE_Solver.Microcontroller.Pin.Color.White);
            #endregion

            #region Bomb serial num has C
            bomb = new Bomb(Day.Sunday, "C", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "0", "STRK", 6, 0, 0);
            module.Solve();
            pinList = module.pinList;

            Assert.AreEqual(pinList[0].color, KTANE_Solver.Microcontroller.Pin.Color.Magenta);
            Assert.AreEqual(pinList[1].color, KTANE_Solver.Microcontroller.Pin.Color.Red);
            Assert.AreEqual(pinList[2].color, KTANE_Solver.Microcontroller.Pin.Color.Yellow);
            Assert.AreEqual(pinList[3].color, KTANE_Solver.Microcontroller.Pin.Color.Green);
            Assert.AreEqual(pinList[4].color, KTANE_Solver.Microcontroller.Pin.Color.Blue);
            Assert.AreEqual(pinList[5].color, KTANE_Solver.Microcontroller.Pin.Color.White);
            #endregion

            #region second digit of controller matches number of batteries

            bomb = new Bomb(Day.Sunday, "F", 0, 0, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));
            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "0", "STRK", 6, 0, 0);
            module.Solve();
            pinList = module.pinList;

            Assert.AreEqual(pinList[0].color, KTANE_Solver.Microcontroller.Pin.Color.Blue);
            Assert.AreEqual(pinList[1].color, KTANE_Solver.Microcontroller.Pin.Color.Red);
            Assert.AreEqual(pinList[2].color, KTANE_Solver.Microcontroller.Pin.Color.Magenta);
            Assert.AreEqual(pinList[3].color, KTANE_Solver.Microcontroller.Pin.Color.Yellow);
            Assert.AreEqual(pinList[4].color, KTANE_Solver.Microcontroller.Pin.Color.Green);
            Assert.AreEqual(pinList[5].color, KTANE_Solver.Microcontroller.Pin.Color.White);
            #endregion

            #region else
            bomb = new Bomb(Day.Sunday, "F", 0, 0, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new KTANE_Solver.Microcontroller(bomb, streamWriter, "0", "STRK", 6, 7, 0);
            module.Solve();
            pinList = module.pinList;

            Assert.AreEqual(pinList[0].color, KTANE_Solver.Microcontroller.Pin.Color.Red);
            Assert.AreEqual(pinList[1].color, KTANE_Solver.Microcontroller.Pin.Color.Green);
            Assert.AreEqual(pinList[2].color, KTANE_Solver.Microcontroller.Pin.Color.Magenta);
            Assert.AreEqual(pinList[3].color, KTANE_Solver.Microcontroller.Pin.Color.Yellow);
            Assert.AreEqual(pinList[4].color, KTANE_Solver.Microcontroller.Pin.Color.Blue);
            Assert.AreEqual(pinList[5].color, KTANE_Solver.Microcontroller.Pin.Color.White);
            #endregion
            streamWriter.Close();
        }
    }
}
