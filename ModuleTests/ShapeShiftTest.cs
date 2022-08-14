using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;

namespace ModuleTests
{
    [TestClass]
    public class ShapeShiftTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "IIIII1", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

        [TestMethod]
        public void TicketsInitialized()
        {
            ShapeShift module = new ShapeShift(bomb, streamWriter, ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket);

            Assert.AreEqual(module.ticketList.Count, 16);

            Assert.IsTrue(module.ticketList[0].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[0].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[0].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Diamond));

            Assert.IsTrue(module.ticketList[1].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[1].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[1].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[2].SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[2].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[2].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[3].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[3].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[3].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[4].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[4].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[4].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[5].SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[5].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[5].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[6].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[6].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[6].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Diamond));

            Assert.IsTrue(module.ticketList[7].SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[7].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[7].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[8].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[8].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[8].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Ticket));

            Assert.IsTrue(module.ticketList[9].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[9].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[9].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Ticket));

            Assert.IsTrue(module.ticketList[10].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[10].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[10].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Round));

            Assert.IsTrue(module.ticketList[11].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Ticket));
            Assert.IsTrue(module.ticketList[11].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[11].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Diamond));

            Assert.IsTrue(module.ticketList[12].SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[12].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[12].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Ticket));

            Assert.IsTrue(module.ticketList[13].SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[13].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[13].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Flat));

            Assert.IsTrue(module.ticketList[14].SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Flat));
            Assert.IsTrue(module.ticketList[14].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Round));
            Assert.IsTrue(module.ticketList[14].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Round, ShapeShift.TicketShape.Ticket));


            Assert.IsTrue(module.ticketList[15].SameTicketShapes(ShapeShift.TicketShape.Flat, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[15].trueTicket.SameTicketShapes(ShapeShift.TicketShape.Ticket, ShapeShift.TicketShape.Diamond));
            Assert.IsTrue(module.ticketList[15].falseTicket.SameTicketShapes(ShapeShift.TicketShape.Diamond, ShapeShift.TicketShape.Flat));


        }
    }
}
