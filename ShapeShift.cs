using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    public class ShapeShift : Module
    {
        Ticket currentTicket;
        public List<Ticket> ticketList;

        public enum TicketShape
        {
            Flat,
            Round,
            Diamond,
            Ticket
        }

        public ShapeShift(Bomb bomb, StreamWriter logFileWriter, TicketShape leftSideStartingPosition, TicketShape rightSideStartingPosition) : base(bomb, logFileWriter, "Shape Shift")
        {
            ticketList = new List<Ticket>();
            SetUpModule();
            currentTicket = FindStartingTicket(leftSideStartingPosition, rightSideStartingPosition);
            currentTicket.visitNum++;


        }

        public void Solve()
        {
            while (currentTicket.visitNum != 2)
            {
                PrintDebugLine($"Current Ticket {currentTicket.leftSide} {currentTicket.rightSide}\n");

                PrintDebugLine($"Current Ticket's # of visits: {currentTicket.visitNum}");

                PrintDebugLine($"Current Ticket's condition: {currentTicket.condition}");

                currentTicket = currentTicket.GetNextTicket(); ;

                PrintDebugLine($"Current Ticket's is now {currentTicket.leftSide} {currentTicket.rightSide}\n");

                currentTicket.visitNum++;
            }

            ShowAnswer($"{currentTicket.leftSide} {currentTicket.rightSide}", true);
        }

        private void SetUpModule()
        {
            Ticket flatRound = new Ticket(TicketShape.Flat, TicketShape.Round, Bomb.Dvid.Visible);
            Ticket roundDiamond = new Ticket(TicketShape.Round, TicketShape.Diamond, Bomb.Sig.Lit);
            Ticket diamondTicket = new Ticket(TicketShape.Diamond, TicketShape.Ticket, Bomb.Rj.Visible);
            Ticket roundRound = new Ticket(TicketShape.Round, TicketShape.Round, Bomb.HasVowel);
            Ticket ticketDiamond = new Ticket(TicketShape.Ticket, TicketShape.Diamond, Bomb.Ps.Visible);
            Ticket diamondDiamond = new Ticket(TicketShape.Diamond, TicketShape.Diamond, Bomb.Ind.Lit);
            Ticket ticketFlat = new Ticket(TicketShape.Ticket, TicketShape.Flat, !Bomb.Frq.Lit);
            Ticket diamondRound = new Ticket(TicketShape.Diamond, TicketShape.Round, Bomb.Parallel.Visible);
            Ticket ticketTicket = new Ticket(TicketShape.Ticket, TicketShape.Ticket, Bomb.Battery >= 3);
            Ticket roundTicket = new Ticket(TicketShape.Round, TicketShape.Ticket, Bomb.AABattery >= 2);
            Ticket flatFlat = new Ticket(TicketShape.Flat, TicketShape.Flat, Bomb.LastDigit % 2 == 1);
            Ticket flatTicket = new Ticket(TicketShape.Flat, TicketShape.Ticket, !Bomb.Bob.Lit);
            Ticket diamondFlat = new Ticket(TicketShape.Diamond, TicketShape.Flat, !Bomb.Car.Lit);
            Ticket ticketRound = new Ticket(TicketShape.Ticket, TicketShape.Round, Bomb.Stereo.Visible);
            Ticket roundFlat = new Ticket(TicketShape.Round, TicketShape.Flat, Bomb.Snd.Lit);
            Ticket flatDiamond = new Ticket(TicketShape.Flat, TicketShape.Diamond, Bomb.Msa.Lit);

            flatRound.SetTrueFalseTickets(roundDiamond, ticketDiamond);
            roundDiamond.SetTrueFalseTickets(ticketTicket, flatFlat);
            diamondTicket.SetTrueFalseTickets(roundDiamond, roundRound);
            roundRound.SetTrueFalseTickets(ticketTicket, flatTicket);
            ticketDiamond.SetTrueFalseTickets(diamondTicket, diamondRound);
            diamondDiamond.SetTrueFalseTickets(diamondTicket, flatFlat);
            ticketFlat.SetTrueFalseTickets(flatRound, diamondDiamond);
            diamondRound.SetTrueFalseTickets(flatDiamond, roundFlat);
            ticketTicket.SetTrueFalseTickets(ticketFlat, flatTicket);
            roundTicket.SetTrueFalseTickets(ticketFlat, flatTicket);
            flatFlat.SetTrueFalseTickets(diamondFlat, diamondRound);
            flatTicket.SetTrueFalseTickets(ticketRound, diamondDiamond);
            diamondFlat.SetTrueFalseTickets(ticketRound, roundTicket);
            ticketRound.SetTrueFalseTickets(flatDiamond, roundFlat);
            roundFlat.SetTrueFalseTickets(roundRound, roundTicket);
            flatDiamond.SetTrueFalseTickets(ticketDiamond, diamondFlat);

            ticketList.AddRange(new Ticket[] { flatRound, roundDiamond, diamondTicket, roundRound, ticketDiamond, diamondDiamond, ticketTicket, roundTicket, flatFlat, flatTicket, diamondFlat, ticketRound, roundFlat, flatDiamond });
        }

        private Ticket FindStartingTicket(TicketShape leftSide, TicketShape rightSide)
        {
            foreach (Ticket t in ticketList)
            {
                if (t.leftSide == leftSide && t.rightSide == rightSide)
                {
                    return t;
                }
            }

            return null;
        }



        public class Ticket
        {
            public int visitNum;
            Ticket trueTicket;
            Ticket falseTicket;
            public TicketShape leftSide { get; }
            public TicketShape rightSide { get; }
            public bool condition { get; }

            public Ticket(TicketShape leftSide, TicketShape rightSide, bool condition)
            {
                this.leftSide = leftSide;
                this.rightSide = rightSide;
                this.condition = condition;
                visitNum = 0;
            }

            public void SetTrueFalseTickets(Ticket trueTicket, Ticket falseTicket)
            {
                this.trueTicket = trueTicket;
                this.falseTicket = falseTicket;
            }

            public Ticket GetNextTicket()
            {
                return condition ? trueTicket : falseTicket;
            }
        }
    }
}
